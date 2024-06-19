using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_1
{
    public partial class SosluMakarnaForm : Form
    {
        private List<Malzeme> malzemeler;
        public SosluMakarnaForm()
        {
            InitializeComponent();
            malzemeler = new List<Malzeme>();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnGeriCik_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TarifForm1 tarifForm = new TarifForm1();
            tarifForm.Show();
        }

        private void btnEkle2_Click(object sender, EventArgs e)
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

            Malzeme malzeme = new Malzeme
            {
                Ad = txtMalzemeAdi.Text,
                Miktar = miktar,
                Birim = cmbBirim.SelectedItem.ToString()
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

        private void btnCikart_Click(object sender, EventArgs e)
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

                lblUcret.Text = $"{toplamUcret} TL";
                lblKalori.Text = $" {Math.Floor(toplamKalori)} kcal";
                lblUcret.Visible = true;
                lblKalori.Visible = true;
            }

            else
            {
                MessageBox.Show("Lütfen silmek için bir malzeme seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttnKaydet_Click(object sender, EventArgs e)
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
        private double CalculateCost(string malzemeAdi, double miktar, string birim)
        {

            double standartMiktar = ConvertToStandardUnit(miktar, birim);
            switch (malzemeAdi)
            {
                case "makarna":
                    if (standartMiktar > 1 && standartMiktar <= 100)
                        return 28;
                    else if (standartMiktar > 100 && standartMiktar < 200)
                        return 56;
                    else if (standartMiktar > 200 && standartMiktar <= 300)
                        return 84;
                    else if (standartMiktar > 300 && standartMiktar <= 400)
                        return 112;
                    else if (standartMiktar > 400 && standartMiktar <= 500)
                        return 140;
                    else if (standartMiktar > 500 && standartMiktar <= 800)
                        return 224;
                    else if (standartMiktar > 800 && standartMiktar <= 1000)
                        return 280;
                    else if (standartMiktar > 1000 && standartMiktar <= 1500)
                        return 420;
                    else
                        return 0;
                case "su":
                    if (standartMiktar > 1 && standartMiktar <= 250)
                        return 2;
                    else if (standartMiktar > 250 && standartMiktar <= 500)
                        return 4;
                    else if (standartMiktar > 500 && standartMiktar <= 750)
                        return 6;
                    else if (standartMiktar > 750 && standartMiktar <= 1000)
                        return 8;
                    else if (standartMiktar > 1000 && standartMiktar <= 1500)
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
                case "domates":
                    if (standartMiktar > 1 && standartMiktar <= 100)
                        return 3.5;
                    else if (standartMiktar > 100 && standartMiktar <= 200)
                        return 7;
                    else if (standartMiktar > 200 && standartMiktar <= 400)
                        return 14;
                    else if (standartMiktar > 400 && standartMiktar <=600)
                        return 21;
                    else if (standartMiktar > 600 && standartMiktar <= 800)
                        return 28;
                    else if (standartMiktar > 800 && standartMiktar <= 1000)
                        return 35;
                    else if (standartMiktar > 1000 && standartMiktar <= 1500)
                        return 52.5;
                    else
                        return 0;
                case "zeytinyağı":
                    if (standartMiktar > 1 && standartMiktar <= 150)
                        return 24;
                    else if (standartMiktar > 150 && standartMiktar < 300)
                        return 48;
                    else if (standartMiktar > 300 && standartMiktar <= 500)
                        return 80;
                    else if (standartMiktar > 500 && standartMiktar <= 750)
                        return 120;
                    else if (standartMiktar > 750 && standartMiktar <= 1000)
                        return 160;
                    else
                        return 0;
                case "sarımsak":
                    if (standartMiktar > 1 && standartMiktar <= 10)
                        return 0.65;
                    else if (standartMiktar > 10 && standartMiktar <= 50)
                        return 3.25;
                    else if (standartMiktar > 50 && standartMiktar <= 100)
                        return 6.5;
                    else
                        return 0;
                case "karabiber":
                    if (standartMiktar >= 1 && standartMiktar < 5)
                        return 0.44;
                    else if (standartMiktar >= 5 && standartMiktar < 6)
                        return 2.23;
                    else if (standartMiktar >= 6 && standartMiktar < 10)
                        return 4.46;
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
                case "makarna":
                    return standartMiktar * 131 / 100;
                case "su":
                    return 0;
                case "tuz":
                    return 0;
                case "domates":
                    return standartMiktar * 18 / 100;
                case "zeytinyağı":
                    return standartMiktar * 884 / 100;
                case "sarımsak":
                    return standartMiktar * 149 / 100;
                case "karabiber":
                    return standartMiktar * 251 / 100;
                  
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
    }
}
