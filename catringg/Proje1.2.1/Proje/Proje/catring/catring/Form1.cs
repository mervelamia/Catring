using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace catring
{
    public partial class Form1 : Form
    {
        private Personel personel;
        private VeritabaniIslemleri veritabaniIslemleri;

        public Form1()
        {
            InitializeComponent();
            // Yeni bir Personel ve VeritabaniIslemleri nesnesi oluştur
            personel = new Personel();
            veritabaniIslemleri = new VeritabaniIslemleri("Data Source=localhost;Initial Catalog=Catring;Integrated Security=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TextBox'lardan girişleri al
            try
            {
                if (string.IsNullOrEmpty(txtAd.Text))
                    throw new Exception("Ad alanı boş olamaz.");
                personel.ad = txtAd.Text;

                if (string.IsNullOrEmpty(txtSoyad.Text))
                    throw new Exception("Soyad alanı boş olamaz.");
                personel.soyad = txtSoyad.Text;

                if (string.IsNullOrEmpty(txtAdres.Text))
                    throw new Exception("Adres alanı boş olamaz.");
                personel.adres = txtAdres.Text;

                personel.dogumTarihi = dateTimePicker1.Value;

                if (string.IsNullOrEmpty(txtTCNO.Text))
                {
                    throw new Exception("TC Kimlik Numarası alanı boş olamaz.");
                }

                if (txtTCNO.Text.Length != 11 || !double.TryParse(txtTCNO.Text, out double tcNo))
                {
                    throw new Exception("TC Kimlik Numarası 11 haneli bir sayı olmalıdır.");
                }
                personel.tcNo = tcNo;

                if (string.IsNullOrEmpty(txtTelNo.Text))
                {
                    throw new Exception("Telefon numarası alanı boş olamaz.");
                }

                if (txtTelNo.Text.Length != 11 || !double.TryParse(txtTelNo.Text, out double telNo))
                {
                    throw new Exception("Telefon numarası 11 haneli bir sayı olmalıdır.");
                }

                personel.telNo = telNo;

                if (string.IsNullOrEmpty(txtCalismaSaati.Text))
                    throw new Exception("Çalışma Saati alanı boş olamaz.");
                personel.calismaSaati = Convert.ToInt32(txtCalismaSaati.Text);

                if (string.IsNullOrEmpty(txtSaatBasiMaas.Text))
                    throw new Exception("Saat Başı Maaş alanı boş olamaz.");
                personel.SaatBaşıMaaş = Convert.ToDecimal(txtSaatBasiMaas.Text);

                // Hatalar yoksa veritabanına personeli ekle
                veritabaniIslemleri.PersonelEkle(personel);

                // TextBox'ları temizle
                txtAd.Clear();
                txtSoyad.Clear();
                txtAdres.Clear();
                txtCalismaSaati.Clear();
                txtTCNO.Clear();
                txtTelNo.Clear();
                txtSaatBasiMaas.Clear();
                dateTimePicker1.Value = DateTime.Now;

                // DataGridView'i güncelle
                VerileriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde verileri getir ve ID sütununu gizle
            VerileriGetir();
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.CellClick += dataGridView1_CellClick;

        }

        private void VerileriGetir()
        {
            // Veritabanından verileri çek ve DataGridView'e yükle
            using (SqlConnection connection = new SqlConnection("Data Source=HALIL;Initial Catalog=Catring;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT * FROM Calisanlar";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Calisanlar");
                dataGridView1.DataSource = ds.Tables["Calisanlar"];
            }
            // DataGridView sütunlarını otomatik boyutlandır
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

       private void Sil()
{
    // Seçili satırı sil
    if (dataGridView1.SelectedRows.Count > 0)
    {
        // Uyarı mesajı göster ve kullanıcı yanıtını kontrol et
        DialogResult dialogResult = MessageBox.Show("Veri silinecek. Devam etmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        
        if (dialogResult == DialogResult.Yes)
        {
            int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
            int selectedPersonelID = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["ID"].Value);

            dataGridView1.Rows.RemoveAt(selectedRowIndex);

            using (SqlConnection connection = new SqlConnection("Data Source=HALIL;Initial Catalog=Catring;Integrated Security=True"))
            {
                connection.Open();
                string query = "DELETE FROM Calisanlar WHERE ID = @PersonelID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PersonelID", selectedPersonelID);
                command.ExecuteNonQuery();
            }

            MessageBox.Show("Kayıt başarıyla silindi.");
        }
        else
        {
            MessageBox.Show("Silme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    else
    {
        MessageBox.Show("Lütfen silmek istediğiniz satırı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}


        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
            txtAd.Clear();
            txtSoyad.Clear();
            txtAdres.Clear();
            txtCalismaSaati.Clear();
            txtSaatBasiMaas.Clear();
            txtTCNO.Clear();
            dateTimePicker1.Value = DateTime.Now;


        }

        private void Guncelle()
        {
            try
            {
                // Seçili satırı güncelle
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                    int selectedPersonelID = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["ID"].Value);

                    string yeniAd = txtAd.Text;
                    string yeniSoyad = txtSoyad.Text;
                    string yeniAdres = txtAdres.Text;
                    DateTime yeniDogumTarihi = dateTimePicker1.Value;
                    double yeniTcNo = Convert.ToDouble(txtTCNO.Text);
                    double yeniTelNo = Convert.ToDouble(txtTelNo.Text);
                    int yeniCalismaSaati = Convert.ToInt32(txtCalismaSaati.Text);
                    decimal yeniSaatBasiMaas = Convert.ToDecimal(txtSaatBasiMaas.Text);

                    dataGridView1.Rows[selectedRowIndex].Cells["Ad"].Value = yeniAd;
                    dataGridView1.Rows[selectedRowIndex].Cells["Soyad"].Value = yeniSoyad;
                    dataGridView1.Rows[selectedRowIndex].Cells["Adres"].Value = yeniAdres;
                    dataGridView1.Rows[selectedRowIndex].Cells["DogumTarihi"].Value = yeniDogumTarihi;
                    dataGridView1.Rows[selectedRowIndex].Cells["TcNo"].Value = yeniTcNo;
                    dataGridView1.Rows[selectedRowIndex].Cells["CalismaSaati"].Value = yeniCalismaSaati;
                    dataGridView1.Rows[selectedRowIndex].Cells["TelNo"].Value = yeniTelNo;
                    dataGridView1.Rows[selectedRowIndex].Cells["SaatBasiMaas"].Value = yeniSaatBasiMaas;

                    // Toplam maaşı hesapla ve parametreye ekle
                    decimal toplamMaas = 30 * (yeniSaatBasiMaas * yeniCalismaSaati);

                    dataGridView1.Rows[selectedRowIndex].Cells["ToplamMaas"].Value = toplamMaas;

                    using (SqlConnection connection = new SqlConnection("Data Source=HALIL;Initial Catalog=Catring;Integrated Security=True"))
                    {
                        connection.Open();
                        string query = "UPDATE Calisanlar SET Ad = @Ad, Soyad = @Soyad, Adres = @Adres, DogumTarihi = @DogumTarihi, CalismaSaati = @CalismaSaati, SaatBasiMaas = @SaatBasiMaas, TcNo=@TcNo, ToplamMaas=@ToplamMaas WHERE ID = @PersonelID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Ad", yeniAd);
                        command.Parameters.AddWithValue("@Soyad", yeniSoyad);
                        command.Parameters.AddWithValue("@Adres", yeniAdres);
                        command.Parameters.AddWithValue("@DogumTarihi", yeniDogumTarihi);
                        command.Parameters.AddWithValue("@TcNo", yeniTcNo);
                        command.Parameters.AddWithValue("@TelNo", yeniTelNo);
                        command.Parameters.AddWithValue("@CalismaSaati", yeniCalismaSaati);
                        command.Parameters.AddWithValue("@SaatBasiMaas", yeniSaatBasiMaas);
                        command.Parameters.AddWithValue("@ToplamMaas", toplamMaas);
                        command.Parameters.AddWithValue("@PersonelID", selectedPersonelID);
                        command.ExecuteNonQuery();
                    }
                    // TextBox'ları temizle
                    txtAd.Clear();
                    txtSoyad.Clear();
                    txtAdres.Clear();
                    txtCalismaSaati.Clear();
                    txtSaatBasiMaas.Clear();
                    txtTCNO.Clear();
                    txtTelNo.Clear();
                    dateTimePicker1.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Lütfen güncellemek istediğiniz satırı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            VerileriGetir();
        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
            VerileriGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                // Satırın verilerini al ve gerekli kontrol alanlarına ata
                txtAd.Text = row.Cells["Ad"].Value.ToString();
                txtSoyad.Text = row.Cells["Soyad"].Value.ToString();
                txtAdres.Text = row.Cells["Adres"].Value.ToString();                
                // Integer değeri TextBox'a aktarmak
                if (int.TryParse(row.Cells["CalismaSaati"].Value.ToString(), out int CalismaSaati))
                {
                    txtCalismaSaati.Text = CalismaSaati.ToString();
                }
                else
                {
                    txtCalismaSaati.Text = ""; // Hata durumunda boş string atanabilir veya mevcut değer korunabilir
                }
                if (double.TryParse(row.Cells["TcNo"].Value.ToString(), out double TcNo))
                {
                    txtTCNO.Text = TcNo.ToString();
                }
                else
                {
                    txtTCNO.Text = ""; // Hata durumunda boş string atanabilir veya mevcut değer korunabilir
                }

                if (decimal.TryParse(row.Cells["saatBasiMaas"].Value.ToString(), out decimal SaatBaşıMaaş))
                {
                    txtSaatBasiMaas.Text = SaatBaşıMaaş.ToString();
                }
                else
                {
                    txtSaatBasiMaas.Text = "hata"; // Hata durumunda boş string atanabilir veya mevcut değer korunabilir
                }
                if (DateTime.TryParse(row.Cells["DogumTarihi"].Value.ToString(), out DateTime DogumTarihi))
                {
                    dateTimePicker1.Value = DogumTarihi;
                }
                if (double.TryParse(row.Cells["TelNo"].Value.ToString(), out double TelNo))
                {
                    txtTelNo.Text = TelNo.ToString();
                }
                else
                {
                    txtTelNo.Text = ""; // Hata durumunda boş string atanabilir veya mevcut değer korunabilir
                }

            }
        }


        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
