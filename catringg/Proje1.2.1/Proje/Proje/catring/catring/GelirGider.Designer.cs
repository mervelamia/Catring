
namespace catring
{
    partial class GelirGider
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
            this.rbtnGelir = new System.Windows.Forms.RadioButton();
            this.rbtnGider = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.cbGelirGiderTipi = new System.Windows.Forms.ComboBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataRdbtnGider = new System.Windows.Forms.RadioButton();
            this.dataRdbtnGelir = new System.Windows.Forms.RadioButton();
            this.dataRdbtnHepsi = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnKarZararHesapla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "İşlem Tipi";
            // 
            // rbtnGelir
            // 
            this.rbtnGelir.AutoSize = true;
            this.rbtnGelir.Location = new System.Drawing.Point(132, 52);
            this.rbtnGelir.Name = "rbtnGelir";
            this.rbtnGelir.Size = new System.Drawing.Size(59, 21);
            this.rbtnGelir.TabIndex = 1;
            this.rbtnGelir.TabStop = true;
            this.rbtnGelir.Text = "Gelir";
            this.rbtnGelir.UseVisualStyleBackColor = true;
            // 
            // rbtnGider
            // 
            this.rbtnGider.AutoSize = true;
            this.rbtnGider.Location = new System.Drawing.Point(248, 52);
            this.rbtnGider.Name = "rbtnGider";
            this.rbtnGider.Size = new System.Drawing.Size(64, 21);
            this.rbtnGider.TabIndex = 2;
            this.rbtnGider.TabStop = true;
            this.rbtnGider.Text = "Gider";
            this.rbtnGider.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tarih";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(132, 101);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 22);
            this.dtpTarih.TabIndex = 4;
            // 
            // cbGelirGiderTipi
            // 
            this.cbGelirGiderTipi.FormattingEnabled = true;
            this.cbGelirGiderTipi.Items.AddRange(new object[] {
            "muhasebe"});
            this.cbGelirGiderTipi.Location = new System.Drawing.Point(132, 148);
            this.cbGelirGiderTipi.Name = "cbGelirGiderTipi";
            this.cbGelirGiderTipi.Size = new System.Drawing.Size(200, 24);
            this.cbGelirGiderTipi.TabIndex = 6;
            this.cbGelirGiderTipi.SelectedIndexChanged += new System.EventHandler(this.cbGelirGiderTipi_SelectedIndexChanged);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(132, 193);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(110, 22);
            this.txtTutar.TabIndex = 7;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(132, 239);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(200, 95);
            this.txtAciklama.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gelir/Gider tipi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tutar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Açıklama";
            // 
            // dataRdbtnGider
            // 
            this.dataRdbtnGider.AutoSize = true;
            this.dataRdbtnGider.Location = new System.Drawing.Point(570, 54);
            this.dataRdbtnGider.Name = "dataRdbtnGider";
            this.dataRdbtnGider.Size = new System.Drawing.Size(64, 21);
            this.dataRdbtnGider.TabIndex = 13;
            this.dataRdbtnGider.TabStop = true;
            this.dataRdbtnGider.Text = "Gider";
            this.dataRdbtnGider.UseVisualStyleBackColor = true;
            // 
            // dataRdbtnGelir
            // 
            this.dataRdbtnGelir.AutoSize = true;
            this.dataRdbtnGelir.Location = new System.Drawing.Point(470, 54);
            this.dataRdbtnGelir.Name = "dataRdbtnGelir";
            this.dataRdbtnGelir.Size = new System.Drawing.Size(59, 21);
            this.dataRdbtnGelir.TabIndex = 12;
            this.dataRdbtnGelir.TabStop = true;
            this.dataRdbtnGelir.Text = "Gelir";
            this.dataRdbtnGelir.UseVisualStyleBackColor = true;
            this.dataRdbtnGelir.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // dataRdbtnHepsi
            // 
            this.dataRdbtnHepsi.AutoSize = true;
            this.dataRdbtnHepsi.Location = new System.Drawing.Point(681, 54);
            this.dataRdbtnHepsi.Name = "dataRdbtnHepsi";
            this.dataRdbtnHepsi.Size = new System.Drawing.Size(65, 21);
            this.dataRdbtnHepsi.TabIndex = 14;
            this.dataRdbtnHepsi.TabStop = true;
            this.dataRdbtnHepsi.Text = "Hepsi";
            this.dataRdbtnHepsi.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(470, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(572, 357);
            this.dataGridView1.TabIndex = 15;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(229, 353);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(83, 28);
            this.btnSil.TabIndex = 16;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(117, 353);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(86, 28);
            this.btnKaydet.TabIndex = 17;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(338, 149);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 18;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnKarZararHesapla
            // 
            this.btnKarZararHesapla.Location = new System.Drawing.Point(151, 396);
            this.btnKarZararHesapla.Name = "btnKarZararHesapla";
            this.btnKarZararHesapla.Size = new System.Drawing.Size(135, 42);
            this.btnKarZararHesapla.TabIndex = 19;
            this.btnKarZararHesapla.Text = "KÂR-ZARAR HESAPLA";
            this.btnKarZararHesapla.UseVisualStyleBackColor = true;
            this.btnKarZararHesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // GelirGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 450);
            this.Controls.Add(this.btnKarZararHesapla);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataRdbtnHepsi);
            this.Controls.Add(this.dataRdbtnGider);
            this.Controls.Add(this.dataRdbtnGelir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.cbGelirGiderTipi);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtnGider);
            this.Controls.Add(this.rbtnGelir);
            this.Controls.Add(this.label1);
            this.Name = "GelirGider";
            this.Text = "GelirGider";
            this.Load += new System.EventHandler(this.GelirGider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnGelir;
        private System.Windows.Forms.RadioButton rbtnGider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.ComboBox cbGelirGiderTipi;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton dataRdbtnGider;
        private System.Windows.Forms.RadioButton dataRdbtnGelir;
        private System.Windows.Forms.RadioButton dataRdbtnHepsi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnKarZararHesapla;
    }
}