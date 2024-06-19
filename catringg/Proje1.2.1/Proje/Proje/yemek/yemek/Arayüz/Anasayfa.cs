using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yemek.Arayüz
{
    public partial class Anasayfa : Form
    {
        string connectionString = "Server=HALIL;Database=Catring;Integrated Security=True;";
        Veritabanı dbOperations;

        public Anasayfa()
        {
            InitializeComponent();
            dbOperations = new Veritabanı(connectionString);
            UpdateStokDataGridView();
        }

        private void yaklasanteslimat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            Veritabanı veritabaniIslemleri = new Veritabanı(connectionString);
            DataTable dtYaklasanTeslimatlar = veritabaniIslemleri.YaklasanTeslimatlariGetir();
            yaklasanteslimat.DataSource = dtYaklasanTeslimatlar;
            try
            {
                DataTable dtSonBesGelirGider = dbOperations.SonBesGelirGiderleriGetir();
                gelirgider.DataSource = dtSonBesGelirGider;

                // Sütun başlıklarını Türkçeleştirme
                gelirgider.Columns["Tarih"].HeaderText = "Tarih";
                gelirgider.Columns["GelirGiderTipi"].HeaderText = "Gelir/Gider Tipi";
                gelirgider.Columns["Tutar"].HeaderText = "Tutar";
                gelirgider.Columns["Aciklama"].HeaderText = "Açıklama";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
        }

        private void gelirgider_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gelirgider_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && gelirgider.Columns[e.ColumnIndex].Name == "IslemTipi")
            {
                string islemTipi = e.Value?.ToString();

                if (!string.IsNullOrEmpty(islemTipi))
                {
                    if (islemTipi.Equals("Gelir", StringComparison.OrdinalIgnoreCase))
                    {
                        e.CellStyle.BackColor = Color.LightGreen;
                    }
                    else if (islemTipi.Equals("Gider", StringComparison.OrdinalIgnoreCase))
                    {
                        e.CellStyle.BackColor = Color.LightCoral;
                    }
                }
            }
        }

        private void stok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void UpdateStokDataGridView()
        {
            DataTable dtMalzemeler = dbOperations.GetAzalanStokMalzemeler();
            stok.DataSource = dtMalzemeler;

          
            foreach (DataGridViewRow row in stok.Rows)
            {
                if (row.Cells["Adet"].Value != DBNull.Value)
                {
                    float adet = Convert.ToSingle(row.Cells["Adet"].Value);
                    float minStok = Convert.ToSingle(row.Cells["MinimumStok"].Value);

                    if (adet < minStok)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.Empty; 
                    }
                }
            }
        }

        private void yaklasanteslimat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = yaklasanteslimat.Rows[e.RowIndex];
                row.ReadOnly = true;
            }
        }

        private void stok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = stok.Rows[e.RowIndex];
                row.ReadOnly = true;
            }
        }

        private void gelirgider_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gelirgider.Rows[e.RowIndex];
                row.ReadOnly = true;
            }
        }
    }

}

