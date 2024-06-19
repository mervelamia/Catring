﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using yemek.İşlemler;

namespace yemek.Arayüz
{
    public partial class Teslimat : Form
    {
        string connectionString = "Server=HALIL;Database=Catring;Integrated Security=True;";
        Veritabanı dbOperations;

        public Teslimat()
        {
            InitializeComponent();
            dbOperations = new Veritabanı(connectionString);
            this.Load += new EventHandler(Teslimat_Load);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Teslimat_Load(object sender, EventArgs e)
        {
            tsmtbitiş.Format = DateTimePickerFormat.Custom;
            tsmtbitiş.CustomFormat = "dd MMMM yyyy";

            try
            {
          
                DataTable dtTeslimatlar = dbOperations.TeslimatlariGetir();
                dataGridView1.DataSource = dtTeslimatlar;

  
                DataGridViewButtonColumn updateButtonColumn = (DataGridViewButtonColumn)dataGridView1.Columns["Güncelle"];
                if (updateButtonColumn == null)
                {
                    updateButtonColumn = new DataGridViewButtonColumn();
                    updateButtonColumn.Name = "Güncelle";
                    updateButtonColumn.HeaderText = "";
                    updateButtonColumn.Text = "Güncelle";
                    updateButtonColumn.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(updateButtonColumn);
                }

                DataGridViewButtonColumn deleteButtonColumn = (DataGridViewButtonColumn)dataGridView1.Columns["Sil"];
                if (deleteButtonColumn == null)
                {
                    deleteButtonColumn = new DataGridViewButtonColumn();
                    deleteButtonColumn.Name = "Sil";
                    deleteButtonColumn.HeaderText = "";
                    deleteButtonColumn.Text = "Sil";
                    deleteButtonColumn.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(deleteButtonColumn);
                }

              
                dataGridView1.Columns["TeslimatID"].Visible = false; 
                dataGridView1.Columns["TeslimatAdi"].HeaderText = "Teslimat Adı";
                dataGridView1.Columns["TeslimatSorumlusu"].HeaderText = "Teslimat Sorumlusu";
                dataGridView1.Columns["TelefonNo"].HeaderText = "Telefon Numarası";
                dataGridView1.Columns["TeslimatTutari"].HeaderText = "Teslimat Tutarı";
                dataGridView1.Columns["BaslangicTarihi"].HeaderText = "Başlangıç Tarihi";
                dataGridView1.Columns["TeslimatGunleri"].HeaderText = "Teslimat Günleri";
                dataGridView1.Columns["BitisTarihi"].HeaderText = "Bitiş Tarihi";
                dataGridView1.Columns["TeslimatSaati"].HeaderText = "Teslimat Saati";
                dataGridView1.Columns["Sehir"].HeaderText = "Şehir";
                dataGridView1.Columns["Ilce"].HeaderText = "İlçe";
                dataGridView1.Columns["Adres"].HeaderText = "Adres";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }

            DataTable sehirler = Veritabanı.GetSehirler();
            comboBox1.DataSource = sehirler;
            comboBox1.DisplayMember = "SehirAdi";
            comboBox1.ValueMember = "SehirID";

          
            if (comboBox1.Items.Count > 0)
            {
                int sehirID = Convert.ToInt32(comboBox1.SelectedValue);
                DataTable ilceler = Veritabanı.GetIlcelerBySehir(sehirID);
                comboBox2.DataSource = ilceler;
                comboBox2.DisplayMember = "IlceAdi";
                comboBox2.ValueMember = "IlceID";

            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void günler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=HALIL;Database=Catring;Integrated Security=True;";

            string teslimatAdi = tsmtadı.Text;
            string teslimatSorumlusu = tsmtsor.Text;
            string telefonNo = telno.Text;

            if (telefonNo.Length != 11)
            {
                MessageBox.Show("Telefon numarası 11 haneli olmalıdır.");
                return;
            }
            decimal teslimatTutari;
            DateTime baslangicTarihi = tsmtbaşlangıç.Value;
            string teslimatGunleri = string.Join(", ", günler.CheckedItems.OfType<string>());
            DateTime bitisTarihi = tsmtbitiş.Value;
            string teslimatSaati = tsmtsaat.SelectedItem?.ToString();
            string sehir = comboBox1.SelectedItem?.ToString();
            string ilce = comboBox2.SelectedItem?.ToString();
            string adres = tsmtadres.Text;


            if (!decimal.TryParse(tsmttutarı.Text, out teslimatTutari))
            {
                MessageBox.Show("Teslimat tutarı geçerli bir sayı olmalıdır.");
                return;
            }
            if (string.IsNullOrWhiteSpace(teslimatAdi) ||
                string.IsNullOrWhiteSpace(teslimatSorumlusu) ||
                string.IsNullOrWhiteSpace(telefonNo) ||
                string.IsNullOrWhiteSpace(teslimatSaati) ||
                string.IsNullOrWhiteSpace(sehir) ||
                string.IsNullOrWhiteSpace(ilce) ||
                string.IsNullOrWhiteSpace(adres))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }
         

            Veritabanı veritabaniIslemleri = new Veritabanı(connectionString);
            veritabaniIslemleri.TeslimatEkle(teslimatAdi, teslimatSorumlusu, telefonNo, teslimatTutari, baslangicTarihi, teslimatGunleri, bitisTarihi, teslimatSaati, sehir, ilce, adres);

            DataTable dtTeslimatlar = veritabaniIslemleri.TeslimatlariGetir();
            dataGridView1.DataSource = dtTeslimatlar;

            MessageBox.Show("Teslimat başarıyla kaydedildi.");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                row.ReadOnly = true;
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) 
            {
       
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Güncelle")
                {
           
                    UpdateForm updateForm = new UpdateForm();
                    updateForm.TeslimatAdi = dataGridView1.Rows[e.RowIndex].Cells["TeslimatAdi"].Value?.ToString();
                    updateForm.TeslimatSorumlusu = dataGridView1.Rows[e.RowIndex].Cells["TeslimatSorumlusu"].Value?.ToString();
                    updateForm.TelefonNo = dataGridView1.Rows[e.RowIndex].Cells["TelefonNo"].Value?.ToString();
                    updateForm.TeslimatTutari = (decimal)dataGridView1.Rows[e.RowIndex].Cells["TeslimatTutari"].Value;
                    updateForm.BaslangicTarihi = (DateTime)dataGridView1.Rows[e.RowIndex].Cells["BaslangicTarihi"].Value;
                    updateForm.TeslimatGunleri = dataGridView1.Rows[e.RowIndex].Cells["TeslimatGunleri"].Value?.ToString();
                    updateForm.BitisTarihi = (DateTime)dataGridView1.Rows[e.RowIndex].Cells["BitisTarihi"].Value;
                    updateForm.TeslimatSaati = dataGridView1.Rows[e.RowIndex].Cells["TeslimatSaati"].Value?.ToString();
                    updateForm.Sehir = dataGridView1.Rows[e.RowIndex].Cells["Sehir"].Value?.ToString();
                    updateForm.Ilce = dataGridView1.Rows[e.RowIndex].Cells["Ilce"].Value?.ToString();
                    updateForm.Adres = dataGridView1.Rows[e.RowIndex].Cells["Adres"].Value?.ToString();

                    updateForm.ShowDialog();

                  
                    DataTable dtTeslimatlar = dbOperations.TeslimatlariGetir();
                    dataGridView1.DataSource = dtTeslimatlar;
                }
           
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Sil")
                {
                    int teslimatID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["TeslimatID"].Value);
                    var teslimatAdi = dataGridView1.Rows[e.RowIndex].Cells["TeslimatAdi"].Value?.ToString();
                    var result = MessageBox.Show($"{teslimatAdi} adlı teslimatı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                  
                        dbOperations.TeslimatSil(teslimatID);

                   
                        DataTable dtTeslimatlar = dbOperations.TeslimatlariGetir();
                        dataGridView1.DataSource = dtTeslimatlar;
                    }
                }
            }
                }
            
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_Load(object sender, EventArgs e)
        {
 
            DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn();
            updateButtonColumn.Name = "Güncelle";
            updateButtonColumn.HeaderText = "";
            updateButtonColumn.Text = "Güncelle";
            updateButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(updateButtonColumn);

      
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "Sil";
            deleteButtonColumn.HeaderText = "";
            deleteButtonColumn.Text = "Sil";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(deleteButtonColumn);
        }
        private void FillCitiesComboBox()
        {
            DataTable sehirler = Veritabanı.GetSehirler(); 
            comboBox1.DisplayMember = "SehirAdi"; 
            comboBox1.ValueMember = "SehirID"; 
            comboBox1.DataSource = sehirler; 
        }

        private void FillDistrictsComboBox(int sehirID)
        {
            DataTable ilceler = Veritabanı.GetIlcelerBySehir(sehirID); 
            comboBox2.DisplayMember = "IlceAdi"; 
            comboBox2.ValueMember = "IlceID"; 
            comboBox2.DataSource = ilceler; 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                if (comboBox1.SelectedItem != null)
                {
                    DataRowView selectedRow = (DataRowView)comboBox1.SelectedItem;
                    int sehirID = Convert.ToInt32(selectedRow.Row["SehirID"]);
                    FillDistrictsComboBox(sehirID); 
                }
            }
        }
        }
    }

