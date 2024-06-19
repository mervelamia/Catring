using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Proje_1
{
    public partial class PilavForm : Form
    {
        private List<Malzeme> malzemeler;


        public PilavForm()
        {
            InitializeComponent();
            malzemeler = new List<Malzeme>();

        }
        private void PilavForm_Load(object sender, EventArgs e)
        {
            malzemeler = new List<Malzeme>();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtMalzemeAdi.Text) ||
                string.IsNullOrWhiteSpace(txtMiktar.Text) ||
                cmbBirim.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtMiktar.Text, out double miktar))
            {
                MessageBox.Show("Miktar sadece sayı olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string birim = cmbBirim.SelectedItem.ToString();


            Malzeme malzeme = new Malzeme
            {
                Ad = txtMalzemeAdi.Text,
                Miktar = miktar,
                Birim = birim
            };

            malzemeler.Add(malzeme);
            lstMalzemeler.Items.Add($"{malzeme.Ad} - {malzeme.Miktar} {malzeme.Birim}");

            double toplamUcret = malzemeler.Sum(m =>
            {
                return CalculateCost(m.Ad, m.Miktar, m.Birim);
            });

            double toplamKalori = malzemeler.Sum(m =>
            {
                return CalculateCalories(m.Ad, m.Miktar, m.Birim);
            });

            lblUcret.Text = $" {toplamUcret} TL";
            lblKalori.Text = $" {Math.Floor(toplamKalori)} kcal";
            lblUcret.Visible = true;
            lblKalori.Visible = true;

            txtMalzemeAdi.Clear();
            txtMiktar.Clear();
            cmbBirim.SelectedIndex = -1;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (var malzeme in malzemeler)
                        {
                            writer.WriteLine($"{malzeme.Ad},{malzeme.Miktar},{malzeme.Birim}");
                        }
                    }

                    lblKaydetDurum.Text = "Malzeme listesi başarıyla kaydedildi.";
                    lblKaydetDurum.ForeColor = System.Drawing.Color.Green;
                    lblKaydetDurum.Visible = true;

                }
                else
                {
                    lblKaydetDurum.Text = "Kaydetme işlemi iptal edildi.";
                    lblKaydetDurum.ForeColor = System.Drawing.Color.Red;
                    lblKaydetDurum.Visible = true;
                }
            }
        }


        private void TarifeGit_Click(object sender, EventArgs e)
        {

            TarifForm tarifForm = new TarifForm();
            tarifForm.Show();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstMalzemeler.SelectedIndex != -1)
            {
                int selectedIndex = lstMalzemeler.SelectedIndex;
                malzemeler.RemoveAt(selectedIndex);
                lstMalzemeler.Items.RemoveAt(selectedIndex);

                double toplamUcret = malzemeler.Sum(m =>
                {
                    return CalculateCost(m.Ad, m.Miktar, m.Birim);
                });

                double toplamKalori = malzemeler.Sum(m =>
                {
                    return CalculateCalories(m.Ad, m.Miktar, m.Birim);
                });

                lblUcret.Text = $" {toplamUcret} TL";
                lblKalori.Text = $" {Math.Floor(toplamKalori)} kcal";
                lblUcret.Visible = true;
                lblKalori.Visible = true;

            }

            else
            {
                MessageBox.Show("Lütfen silmek için bir malzeme seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGeriGit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();

        }
        private double CalculateCost(string malzemeAdi, double miktar, string birim)
        {

            double standartMiktar = ConvertToStandardUnit(miktar, birim);
            switch (malzemeAdi)
            {
                case "pirinç":
                    if (standartMiktar >= 1 && standartMiktar < 200)
                        return 15;
                    else if (standartMiktar >= 200 && standartMiktar < 400)
                        return 30;
                    else if (standartMiktar >= 400 && standartMiktar < 600)
                        return 45;
                    else if (standartMiktar >= 600 && standartMiktar < 800)
                        return 60;
                    else if (standartMiktar >= 800 && standartMiktar <= 1000)
                        return 75;
                    else
                        return 0;
                case "su":
                    if (standartMiktar >= 1 && standartMiktar < 300)
                        return 4;
                    else if (standartMiktar >= 300 && standartMiktar < 600)
                        return 8;
                    else if (standartMiktar >= 600 && standartMiktar < 900)
                        return 12;
                    else
                        return 0;
                case "tuz":
                    if (standartMiktar > 1 && standartMiktar <= 5)
                        return 0.40;
                    else if (standartMiktar > 5 && standartMiktar <= 6)
                        return 0.48;
                    else
                        return 0;
                case "tereyağı":
                    if (standartMiktar > 1 && standartMiktar <= 15)
                        return 6;
                    else if (standartMiktar > 16 && standartMiktar <= 30)
                        return 12;
                    else
                        return 0;
                default: return 0;
            }
        }
        private double CalculateCalories(string malzemeAdi, double miktar, string birim)
        {
            double standartMiktar = ConvertToStandardUnit(miktar, birim);
            switch (malzemeAdi)
            {
                case "pirinç":
                    return standartMiktar * 130 / 100; 
                case "su":
                    return 0;
                case "tuz":
                    return 0;
                case "tereyağı":
                    return standartMiktar * 717 / 100; 
                default: return 0;
            }
        }
        private double ConvertToStandardUnit(double miktar, string birim)
        {
            switch (birim)
            {
                case "kg":
                    return miktar * 1000; 
                case "g":
                    return miktar;
                case "ml":
                    return miktar;
                case "L":
                    return miktar * 1000; 
                default:
                    return miktar;
            }
        }

        private void PilavForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}