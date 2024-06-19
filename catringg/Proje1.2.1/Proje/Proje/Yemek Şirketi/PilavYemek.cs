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

namespace Proje_1
{
    public partial class PilavYemek : Form
    {
        public PilavYemek()
        {
            InitializeComponent();
            this.Load += PilavYemek_Load; // Form yüklendiğinde StokBilgi_Load metodunu çağırır

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int porsiyonSayisi;
            if (!int.TryParse(txtPorsiyonSayisi.Text, out porsiyonSayisi) || porsiyonSayisi <= 0)
            {
                MessageBox.Show("Lütfen geçerli ve sıfırdan büyük bir porsiyon sayısı giriniz.");
                return;
            }

            var malzemeler = new (string Adi, decimal Miktar, decimal BirimFiyat)[]
            {
        ("Pirinç", 0.2m * porsiyonSayisi, GetBirimFiyat("Pirinç")),
        ("Su", 0.3m * porsiyonSayisi, GetBirimFiyat("Su")),
        ("Tereyağı", 0.015m * porsiyonSayisi, GetBirimFiyat("Tereyağı")),
        ("Tuz", 0.005m * porsiyonSayisi, GetBirimFiyat("Tuz"))
            };

            decimal GetBirimFiyat(string malzemeAdi)
            {
                decimal birimFiyat = 0m;
                using (var connection = new SqlConnection("Data Source=HALIL;Initial Catalog=Catring;Integrated Security=True"))
                {
                    connection.Open();
                    var command = new SqlCommand("SELECT BirimFiyat FROM Malzemeler WHERE MalzemeAdi = @MalzemeAdi", connection);
                    command.Parameters.AddWithValue("@MalzemeAdi", malzemeAdi);
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        if (reader[0] != DBNull.Value)
                        {
                            birimFiyat = Convert.ToDecimal(reader[0]);
                        }
                    }
                    reader.Close();
                }
                return birimFiyat;
            }

            decimal toplamTutar = 0;

            using (var connection = new SqlConnection("Data Source=HALIL;Initial Catalog=Catring;Integrated Security=True"))
            {
                connection.Open();

                foreach (var malzeme in malzemeler)
                {
                    var command = new SqlCommand("SELECT Adet, MinimumStok FROM Malzemeler WHERE MalzemeAdi = @MalzemeAdi", connection);
                    command.Parameters.AddWithValue("@MalzemeAdi", malzeme.Adi);
                    var reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        decimal mevcutMiktar = reader.GetDecimal(0);
                        decimal minimumStok = reader.GetDecimal(1);
                        reader.Close();

                        if (mevcutMiktar < malzeme.Miktar)
                        {
                            MessageBox.Show($"{malzeme.Adi} malzemesinden {malzeme.Miktar - mevcutMiktar} kadar eksik.");
                            return;
                        }

                        if (mevcutMiktar - malzeme.Miktar < minimumStok)
                        {
                            var result = MessageBox.Show($"{malzeme.Adi} malzemesi minimum stok seviyesinin altına iniyor. Devam etmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo);
                            if (result == DialogResult.No)
                            {
                                return;
                            }
                        }

                        toplamTutar += malzeme.Miktar * malzeme.BirimFiyat;

                        var updateCommand = new SqlCommand("UPDATE Malzemeler SET Adet = Adet - @Miktar WHERE MalzemeAdi = @MalzemeAdi", connection);
                        updateCommand.Parameters.AddWithValue("@Miktar", malzeme.Miktar);
                        updateCommand.Parameters.AddWithValue("@MalzemeAdi", malzeme.Adi);
                        updateCommand.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show($"{malzeme.Adi} malzemesi bulunamadı.");
                        return;
                    }
                }

                // GelirGider tablosuna tutarı kaydet
                var insertCommand = new SqlCommand("INSERT INTO GelirGider (IslemTipi, Tarih, GelirGiderTipi, Tutar, Aciklama) VALUES (@IslemTipi, @Tarih, @GelirGiderTipi, @Tutar, @Aciklama)", connection);
                insertCommand.Parameters.AddWithValue("@IslemTipi", "Gider");
                insertCommand.Parameters.AddWithValue("@Tarih", DateTime.Now);
                insertCommand.Parameters.AddWithValue("@GelirGiderTipi", "Yemek Yapım");
                insertCommand.Parameters.AddWithValue("@Tutar", toplamTutar);
                insertCommand.Parameters.AddWithValue("@Aciklama", "Pilav yapımı için malzeme gideri");
                insertCommand.ExecuteNonQuery();

                MessageBox.Show($"Toplam Tutar: {toplamTutar} ₺\nMalzemeler başarıyla güncellendi.");
            }
            VerileriGetir();
        }


        private void PilavYemek_Load(object sender, EventArgs e)
        {
            
            VerileriGetir();
           

        }
        private void VerileriGetir()
        {
            string query = "SELECT * FROM Malzemeler WHERE MalzemeAdi IN ('Pirinç', 'Tereyağı', 'Su', 'Tuz')";
            using (SqlConnection connection = new SqlConnection("Data Source=HALIL;Initial Catalog=Catring;Integrated Security=True"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Malzemeler");
                    dataGridView1.DataSource = ds.Tables["Malzemeler"];
                }
            }
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TarifForm TarifForm = new TarifForm();
            TarifForm.Show();
            this.Hide();
        }
    }
}


