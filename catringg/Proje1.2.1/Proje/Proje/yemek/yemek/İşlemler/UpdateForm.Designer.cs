
namespace yemek.İşlemler
{
    partial class UpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tsmttutarı = new System.Windows.Forms.TextBox();
            this.telno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tsmtbaşlangıç = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tsmtsaat = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tsmtbitiş = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.günler = new System.Windows.Forms.CheckedListBox();
            this.tsmtbasla = new System.Windows.Forms.Label();
            this.tsmtsor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tsmtadres = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tsmtadı = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tsmttutarı
            // 
            this.tsmttutarı.Location = new System.Drawing.Point(214, 102);
            this.tsmttutarı.Multiline = true;
            this.tsmttutarı.Name = "tsmttutarı";
            this.tsmttutarı.Size = new System.Drawing.Size(147, 23);
            this.tsmttutarı.TabIndex = 53;
            // 
            // telno
            // 
            this.telno.Location = new System.Drawing.Point(214, 72);
            this.telno.Multiline = true;
            this.telno.Name = "telno";
            this.telno.Size = new System.Drawing.Size(147, 23);
            this.telno.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(105, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 15);
            this.label6.TabIndex = 51;
            this.label6.Text = "Telefon Numarası:";
            // 
            // tsmtbaşlangıç
            // 
            this.tsmtbaşlangıç.Location = new System.Drawing.Point(214, 141);
            this.tsmtbaşlangıç.Margin = new System.Windows.Forms.Padding(2);
            this.tsmtbaşlangıç.Name = "tsmtbaşlangıç";
            this.tsmtbaşlangıç.Size = new System.Drawing.Size(147, 20);
            this.tsmtbaşlangıç.TabIndex = 50;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 49;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(172, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 15);
            this.label11.TabIndex = 48;
            this.label11.Text = "Adres:";
            // 
            // tsmtsaat
            // 
            this.tsmtsaat.FormattingEnabled = true;
            this.tsmtsaat.Items.AddRange(new object[] {
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00"});
            this.tsmtsaat.Location = new System.Drawing.Point(214, 277);
            this.tsmtsaat.Margin = new System.Windows.Forms.Padding(2);
            this.tsmtsaat.Name = "tsmtsaat";
            this.tsmtsaat.Size = new System.Drawing.Size(147, 21);
            this.tsmtsaat.TabIndex = 47;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ADANA",
            "ADIYAMAN",
            "AFYONKARAHİSAR",
            "AĞRI",
            "AKSARAY",
            "AMASYA",
            "ANKARA",
            "ANTALYA",
            "ARDAHAN",
            "ARTVİN",
            "AYDIN",
            "BALIKESİR",
            "BARTIN",
            "BATMAN",
            "BAYBURT",
            "BİLECİK",
            "BİNGÖL",
            "BİTLİS",
            "BOLU",
            "BURDUR",
            "BURSA",
            "ÇANAKKALE",
            "ÇANKIRI",
            "ÇORUM",
            "DENİZLİ",
            "DİYARBAKIR",
            "DÜZCE",
            "EDİRNE",
            "ELAZIĞ",
            "ERZİNCAN",
            "ERZURUM",
            "ESKİŞEHİR",
            "GAZİANTEP",
            "GİRESUN",
            "GÜMÜŞHANE",
            "HAKKARİ",
            "HATAY",
            "IĞDIR",
            "ISPARTA",
            "İSTANBUL",
            "İZMİR",
            "KAHRAMANMARAŞ",
            "KARABÜK",
            "KARAMAN",
            "KARS",
            "KASTAMONU",
            "KAYSERİ",
            "KIRIKKALE",
            "KIRKLARELİ",
            "KIRŞEHİR",
            "KİLİS",
            "KOCAELİ",
            "KONYA",
            "KÜTAHYA",
            "MALATYA",
            "MANİSA",
            "MARDİN",
            "MERSİN",
            "MUĞLA",
            "MUŞ",
            "NEVŞEHİR",
            "NİĞDE",
            "ORDU",
            "OSMANİYE",
            "RİZE",
            "SAKARYA",
            "SAMSUN",
            "SİİRT",
            "SİNOP",
            "SİVAS",
            "ŞANLIURFA",
            "ŞIRNAK",
            "TEKİRDAĞ",
            "TOKAT",
            "TRABZON",
            "TUNCELİ",
            "UŞAK",
            "VAN",
            "YALOVA",
            "YOZGAT",
            "ZONGULDAK"});
            this.comboBox2.Location = new System.Drawing.Point(214, 346);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(147, 21);
            this.comboBox2.TabIndex = 46;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ADANA",
            "ADIYAMAN",
            "AFYONKARAHİSAR",
            "AĞRI",
            "AKSARAY",
            "AMASYA",
            "ANKARA",
            "ANTALYA",
            "ARDAHAN",
            "ARTVİN",
            "AYDIN",
            "BALIKESİR",
            "BARTIN",
            "BATMAN",
            "BAYBURT",
            "BİLECİK",
            "BİNGÖL",
            "BİTLİS",
            "BOLU",
            "BURDUR",
            "BURSA",
            "ÇANAKKALE",
            "ÇANKIRI",
            "ÇORUM",
            "DENİZLİ",
            "DİYARBAKIR",
            "DÜZCE",
            "EDİRNE",
            "ELAZIĞ",
            "ERZİNCAN",
            "ERZURUM",
            "ESKİŞEHİR",
            "GAZİANTEP",
            "GİRESUN",
            "GÜMÜŞHANE",
            "HAKKARİ",
            "HATAY",
            "IĞDIR",
            "ISPARTA",
            "İSTANBUL",
            "İZMİR",
            "KAHRAMANMARAŞ",
            "KARABÜK",
            "KARAMAN",
            "KARS",
            "KASTAMONU",
            "KAYSERİ",
            "KIRIKKALE",
            "KIRKLARELİ",
            "KIRŞEHİR",
            "KİLİS",
            "KOCAELİ",
            "KONYA",
            "KÜTAHYA",
            "MALATYA",
            "MANİSA",
            "MARDİN",
            "MERSİN",
            "MUĞLA",
            "MUŞ",
            "NEVŞEHİR",
            "NİĞDE",
            "ORDU",
            "OSMANİYE",
            "RİZE",
            "SAKARYA",
            "SAMSUN",
            "SİİRT",
            "SİNOP",
            "SİVAS",
            "ŞANLIURFA",
            "ŞIRNAK",
            "TEKİRDAĞ",
            "TOKAT",
            "TRABZON",
            "TUNCELİ",
            "UŞAK",
            "VAN",
            "YALOVA",
            "YOZGAT",
            "ZONGULDAK"});
            this.comboBox1.Location = new System.Drawing.Point(214, 313);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 21);
            this.comboBox1.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(179, 346);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 15);
            this.label10.TabIndex = 44;
            this.label10.Text = "İlçe:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(169, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 43;
            this.label9.Text = "Şehir:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(142, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 42;
            this.label8.Text = "Bitiş Tarihi:";
            // 
            // tsmtbitiş
            // 
            this.tsmtbitiş.Location = new System.Drawing.Point(214, 249);
            this.tsmtbitiş.Margin = new System.Windows.Forms.Padding(2);
            this.tsmtbitiş.Name = "tsmtbitiş";
            this.tsmtbitiş.Size = new System.Drawing.Size(147, 20);
            this.tsmtbitiş.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(109, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 15);
            this.label7.TabIndex = 40;
            this.label7.Text = "Teslimat Günleri:";
            // 
            // günler
            // 
            this.günler.FormattingEnabled = true;
            this.günler.Items.AddRange(new object[] {
            "PAZARTESİ",
            "SALI",
            "ÇARŞAMBA",
            "PERŞEMBE",
            "CUMA ",
            "CUMARTESİ",
            "PAZAR"});
            this.günler.Location = new System.Drawing.Point(214, 171);
            this.günler.Margin = new System.Windows.Forms.Padding(2);
            this.günler.Name = "günler";
            this.günler.Size = new System.Drawing.Size(147, 64);
            this.günler.TabIndex = 39;
            // 
            // tsmtbasla
            // 
            this.tsmtbasla.AutoSize = true;
            this.tsmtbasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tsmtbasla.Location = new System.Drawing.Point(117, 145);
            this.tsmtbasla.Name = "tsmtbasla";
            this.tsmtbasla.Size = new System.Drawing.Size(98, 15);
            this.tsmtbasla.TabIndex = 38;
            this.tsmtbasla.Text = "Başlangıç Tarihi:";
            // 
            // tsmtsor
            // 
            this.tsmtsor.Location = new System.Drawing.Point(214, 43);
            this.tsmtsor.Multiline = true;
            this.tsmtsor.Name = "tsmtsor";
            this.tsmtsor.Size = new System.Drawing.Size(147, 23);
            this.tsmtsor.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(117, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 36;
            this.label5.Text = "Teslimat Tutarı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(93, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "Teslimat Sorumlusu:";
            // 
            // tsmtadres
            // 
            this.tsmtadres.Location = new System.Drawing.Point(182, 384);
            this.tsmtadres.Margin = new System.Windows.Forms.Padding(2);
            this.tsmtadres.Name = "tsmtadres";
            this.tsmtadres.Size = new System.Drawing.Size(192, 93);
            this.tsmtadres.TabIndex = 34;
            this.tsmtadres.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(121, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Teslimat Saati:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(131, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Teslimat Adı:";
            // 
            // tsmtadı
            // 
            this.tsmtadı.Location = new System.Drawing.Point(214, 15);
            this.tsmtadı.Multiline = true;
            this.tsmtadı.Name = "tsmtadı";
            this.tsmtadı.Size = new System.Drawing.Size(147, 23);
            this.tsmtadı.TabIndex = 31;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 521);
            this.Controls.Add(this.tsmttutarı);
            this.Controls.Add(this.telno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tsmtbaşlangıç);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tsmtsaat);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tsmtbitiş);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.günler);
            this.Controls.Add(this.tsmtbasla);
            this.Controls.Add(this.tsmtsor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tsmtadres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tsmtadı);
            this.Name = "UpdateForm";
            this.Text = "Teslimat Güncelle";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tsmttutarı;
        private System.Windows.Forms.TextBox telno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker tsmtbaşlangıç;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox tsmtsaat;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker tsmtbitiş;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox günler;
        private System.Windows.Forms.Label tsmtbasla;
        private System.Windows.Forms.TextBox tsmtsor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox tsmtadres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tsmtadı;
    }
}