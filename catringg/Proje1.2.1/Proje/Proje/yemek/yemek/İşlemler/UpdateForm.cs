﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yemek.İşlemler
{
    public partial class UpdateForm : Form
    {
        private string connectionString = "Server=HALIL;Database=Catring;Integrated Security=True;";
        public int TeslimatID { get; set; }
        public string TeslimatAdi { get; set; }
        public string TeslimatSorumlusu { get; set; }
        public string TelefonNo { get; set; }
        public decimal TeslimatTutari { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public string TeslimatGunleri { get; set; }
        public DateTime BitisTarihi { get; set; }
        public string TeslimatSaati { get; set; }
        public string Sehir { get; set; }
        public string Ilce { get; set; }
        public string Adres { get; set; }

        public UpdateForm()
        {
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            tsmtadı.Text = TeslimatAdi;
            tsmtsor.Text = TeslimatSorumlusu;
            telno.Text = TelefonNo;
            tsmttutarı.Text = TeslimatTutari.ToString();
            tsmtbaşlangıç.Value = BaslangicTarihi;
            günler.Text = TeslimatGunleri;
            tsmtbitiş.Value = BitisTarihi;
            tsmtsaat.Text = TeslimatSaati;
            comboBox1.Text = Sehir;
            comboBox2.Text = Ilce;
            tsmtadres.Text = Adres;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Veritabanı veritabaniIslemleri = new Veritabanı(connectionString);
            veritabaniIslemleri.TeslimatGuncelle(TeslimatID, tsmtadı.Text, tsmtsor.Text, telno.Text, decimal.Parse(tsmttutarı.Text), tsmtbaşlangıç.Value, günler.Text, tsmtbitiş.Value, tsmtsaat.Text, comboBox1.Text, comboBox2.Text, tsmtadres.Text);
            this.Close();
        }
    }
}
