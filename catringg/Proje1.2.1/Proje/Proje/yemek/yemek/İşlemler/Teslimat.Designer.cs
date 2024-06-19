
namespace yemek.Arayüz
{
    partial class Teslimat
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
            this.label1 = new System.Windows.Forms.Label();
            this.tsmtadı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tsmtadres = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tsmtsor = new System.Windows.Forms.TextBox();
            this.tsmtbasla = new System.Windows.Forms.Label();
            this.günler = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tsmtbitiş = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tsmtsaat = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tsmtbaşlangıç = new System.Windows.Forms.DateTimePicker();
            this.telno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tsmttutarı = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(867, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TESLİMAT EKLE";
            // 
            // tsmtadı
            // 
            this.tsmtadı.Location = new System.Drawing.Point(913, 80);
            this.tsmtadı.Multiline = true;
            this.tsmtadı.Name = "tsmtadı";
            this.tsmtadı.Size = new System.Drawing.Size(147, 23);
            this.tsmtadı.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(830, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Teslimat Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(779, 460);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(820, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Teslimat Saati:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tsmtadres
            // 
            this.tsmtadres.Location = new System.Drawing.Point(881, 449);
            this.tsmtadres.Margin = new System.Windows.Forms.Padding(2);
            this.tsmtadres.Name = "tsmtadres";
            this.tsmtadres.Size = new System.Drawing.Size(192, 93);
            this.tsmtadres.TabIndex = 6;
            this.tsmtadres.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(792, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Teslimat Sorumlusu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(816, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Teslimat Tutarı:";
            // 
            // tsmtsor
            // 
            this.tsmtsor.Location = new System.Drawing.Point(913, 108);
            this.tsmtsor.Multiline = true;
            this.tsmtsor.Name = "tsmtsor";
            this.tsmtsor.Size = new System.Drawing.Size(147, 23);
            this.tsmtsor.TabIndex = 11;
            // 
            // tsmtbasla
            // 
            this.tsmtbasla.AutoSize = true;
            this.tsmtbasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tsmtbasla.Location = new System.Drawing.Point(816, 210);
            this.tsmtbasla.Name = "tsmtbasla";
            this.tsmtbasla.Size = new System.Drawing.Size(98, 15);
            this.tsmtbasla.TabIndex = 12;
            this.tsmtbasla.Text = "Başlangıç Tarihi:";
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
            this.günler.Location = new System.Drawing.Point(913, 236);
            this.günler.Margin = new System.Windows.Forms.Padding(2);
            this.günler.Name = "günler";
            this.günler.Size = new System.Drawing.Size(147, 64);
            this.günler.TabIndex = 14;
            this.günler.SelectedIndexChanged += new System.EventHandler(this.günler_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(808, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Teslimat Günleri:";
            // 
            // tsmtbitiş
            // 
            this.tsmtbitiş.Location = new System.Drawing.Point(913, 314);
            this.tsmtbitiş.Margin = new System.Windows.Forms.Padding(2);
            this.tsmtbitiş.Name = "tsmtbitiş";
            this.tsmtbitiş.Size = new System.Drawing.Size(147, 20);
            this.tsmtbitiş.TabIndex = 17;
            this.tsmtbitiş.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(841, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Bitiş Tarihi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(868, 384);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Şehir:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(878, 411);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "İlçe:";
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
            this.comboBox1.Location = new System.Drawing.Point(913, 378);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.comboBox2.Location = new System.Drawing.Point(913, 411);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(147, 21);
            this.comboBox2.TabIndex = 22;
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
            this.tsmtsaat.Location = new System.Drawing.Point(913, 342);
            this.tsmtsaat.Margin = new System.Windows.Forms.Padding(2);
            this.tsmtsaat.Name = "tsmtsaat";
            this.tsmtsaat.Size = new System.Drawing.Size(147, 21);
            this.tsmtsaat.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(871, 432);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "Adres:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1000, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Kayıt Et";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto Bk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(274, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(236, 23);
            this.label12.TabIndex = 26;
            this.label12.Text = "TESLİMAT ANLAŞMALARI";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // tsmtbaşlangıç
            // 
            this.tsmtbaşlangıç.Location = new System.Drawing.Point(913, 206);
            this.tsmtbaşlangıç.Margin = new System.Windows.Forms.Padding(2);
            this.tsmtbaşlangıç.Name = "tsmtbaşlangıç";
            this.tsmtbaşlangıç.Size = new System.Drawing.Size(147, 20);
            this.tsmtbaşlangıç.TabIndex = 27;
            // 
            // telno
            // 
            this.telno.Location = new System.Drawing.Point(913, 137);
            this.telno.Multiline = true;
            this.telno.Name = "telno";
            this.telno.Size = new System.Drawing.Size(147, 23);
            this.telno.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(804, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "Telefon Numarası:";
            // 
            // tsmttutarı
            // 
            this.tsmttutarı.Location = new System.Drawing.Point(913, 167);
            this.tsmttutarı.Multiline = true;
            this.tsmttutarı.Name = "tsmttutarı";
            this.tsmttutarı.Size = new System.Drawing.Size(147, 23);
            this.tsmttutarı.TabIndex = 30;
            // 
            // Teslimat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 611);
            this.Controls.Add(this.tsmttutarı);
            this.Controls.Add(this.telno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tsmtbaşlangıç);
            this.Controls.Add(this.label12);
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tsmtadı);
            this.Controls.Add(this.label1);
            this.Name = "Teslimat";
            this.Text = "Teslimat";
            this.Load += new System.EventHandler(this.Teslimat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tsmtadı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox tsmtadres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tsmtsor;
        private System.Windows.Forms.Label tsmtbasla;
        private System.Windows.Forms.CheckedListBox günler;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker tsmtbitiş;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox tsmtsaat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker tsmtbaşlangıç;
        private System.Windows.Forms.TextBox telno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tsmttutarı;
    }
}