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
    public partial class TavukTantuniForm : Form
    {
        private List<Malzeme> malzemeler;
        public TavukTantuniForm()
        {
            InitializeComponent();
        }

        private void TavukTantuniForm_Load(object sender, EventArgs e)
        {
            malzemeler = new List<Malzeme>();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void bEkle_Click(object sender, EventArgs e)
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

        private void bSil_Click(object sender, EventArgs e)
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

        private void bKaydet_Click(object sender, EventArgs e)
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

        private void bGit_Click(object sender, EventArgs e)
        {
            TarifForm3 tarifForm3 = new TarifForm3();
            tarifForm3.Show();
        }

        private void bGeri_Click(object sender, EventArgs e)
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
                case "tavuk göğsü":
                    if (standartMiktar > 1 && standartMiktar <= 100)
                        return 58;
                    else if (standartMiktar > 100 && standartMiktar <= 200)
                        return 116;
                    else if (standartMiktar > 200 && standartMiktar <= 300)
                        return 174;
                    else if (standartMiktar > 300 && standartMiktar <= 500)
                        return 290;
                    else if (standartMiktar > 500 && standartMiktar <= 1000)
                        return 580;
                    else
                        return 0;
                case "soğan":
                    if (standartMiktar >= 100 && standartMiktar <= 200)
                        return 1;
                    else if (standartMiktar > 200 && standartMiktar <= 300)
                        return 2;
                    else if (standartMiktar > 300 && standartMiktar <= 500)
                        return 3;
                    else if (standartMiktar > 500 && standartMiktar <= 1000)
                        return 5;
                    else if (standartMiktar > 1000 && standartMiktar <= 1000)
                        return 10;
                    else
                        return 0;
                case "domates":
                    if (standartMiktar > 1 && standartMiktar <= 100)
                        return 3.5;
                    else if (standartMiktar > 100 && standartMiktar <= 200)
                        return 7;
                    else if (standartMiktar > 200 && standartMiktar <= 400)
                        return 14;
                    else if (standartMiktar > 400 && standartMiktar <= 600)
                        return 21;
                    else if (standartMiktar > 600 && standartMiktar <= 800)
                        return 28;
                    else if (standartMiktar > 800 && standartMiktar <= 1000)
                        return 35;
                    else if (standartMiktar > 1000 && standartMiktar <= 1500)
                        return 52.5;
                    else
                        return 0;
                case "yeşil biber":
                    if (standartMiktar > 1 && standartMiktar <= 10)
                        return 0.3;
                    else if (standartMiktar > 10 && standartMiktar <= 30)
                        return 0.9;
                    else if (standartMiktar > 30 && standartMiktar <= 40)
                        return 1.2;
                    else if (standartMiktar > 40 && standartMiktar <= 50)
                        return 1.5;
                    else if (standartMiktar > 50 && standartMiktar <= 100)
                        return 3;
                    else
                        return 0;
                case "maydonoz":
                    if (standartMiktar >= 1 && standartMiktar < 10)
                        return 2.6;
                    else if (standartMiktar >= 10 && standartMiktar < 20)
                        return 5.2;
                    else if (standartMiktar >= 20 && standartMiktar < 50)
                        return 13;
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
                case "tuz":
                    if (standartMiktar > 1 && standartMiktar <= 5)
                        return 0.40;
                    else if (standartMiktar > 5 && standartMiktar <= 6)
                        return 0.48;
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
                case "pulbiber":
                    if (standartMiktar >= 1 && standartMiktar < 5)
                        return 0.19;
                    else if (standartMiktar >= 5 && standartMiktar < 10)
                        return 0.95;
                    else
                        return 0;
                case "kimyon":
                    if (standartMiktar >= 1 && standartMiktar < 5)
                        return 0.2;
                    else if (standartMiktar >= 5 && standartMiktar < 10)
                        return 1;
                    else
                        return 0;
                case "lavaş":
                    if (standartMiktar > 1 && standartMiktar <= 50)
                        return 15;
                    else if (standartMiktar > 50 && standartMiktar <= 70)
                        return 21;
                    else if (standartMiktar > 70 && standartMiktar <= 100)
                        return 30;
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
                case "tavuk göğsü":
                    return standartMiktar * 165 / 100;
                case "soğan":
                    return standartMiktar * 40 / 100;
                case "domates":
                    return standartMiktar * 18 / 100;
                case "yeşil biber":
                    return standartMiktar * 20 / 100;
                case "maydonoz":
                    return standartMiktar * 36 / 100;
                case "zeytinyağı":
                    return standartMiktar * 884 / 100;             
                case "tuz":
                    return 0;
                case "karabiber":
                    return standartMiktar * 251 / 100;
                case "kimyon":
                    return standartMiktar * 375 / 100;
                case "pul biber":
                    return standartMiktar * 282 / 100;
                case "lavaş":
                    return standartMiktar * 250 / 100; 
                case "su":
                    return 0;
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
