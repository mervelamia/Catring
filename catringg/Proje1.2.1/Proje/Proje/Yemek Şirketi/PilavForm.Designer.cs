namespace Proje_1
{
    partial class PilavForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PilavForm));
            this.cmbBirim = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstMalzemeler = new System.Windows.Forms.ListBox();
            this.txtMalzemeAdi = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.TarifeGit = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblKaydetDurum = new System.Windows.Forms.Label();
            this.btnGeriGit = new System.Windows.Forms.Button();
            this.lblUcret = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblKalori = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.Cornsilk;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(128, 80);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(137, 28);
            label1.TabIndex = 0;
            label1.Text = "Malzeme Adı :";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.Cornsilk;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(128, 130);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(137, 29);
            label2.TabIndex = 1;
            label2.Text = "Miktar :";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.Cornsilk;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(128, 185);
            label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(137, 27);
            label3.TabIndex = 2;
            label3.Text = "Birim :";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.Color.Cornsilk;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(545, 65);
            label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(267, 62);
            label4.TabIndex = 6;
            label4.Text = "Malzeme Listesi";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbBirim
            // 
            this.cmbBirim.FormattingEnabled = true;
            this.cmbBirim.Items.AddRange(new object[] {
            "Kilogram",
            "Gram",
            "Litre",
            "Mililitre"});
            this.cmbBirim.Location = new System.Drawing.Point(298, 185);
            this.cmbBirim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(121, 24);
            this.cmbBirim.TabIndex = 4;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Silver;
            this.btnEkle.Location = new System.Drawing.Point(294, 300);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(125, 34);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstMalzemeler
            // 
            this.lstMalzemeler.FormattingEnabled = true;
            this.lstMalzemeler.ItemHeight = 16;
            this.lstMalzemeler.Location = new System.Drawing.Point(549, 158);
            this.lstMalzemeler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstMalzemeler.Name = "lstMalzemeler";
            this.lstMalzemeler.Size = new System.Drawing.Size(263, 148);
            this.lstMalzemeler.TabIndex = 8;
            // 
            // txtMalzemeAdi
            // 
            this.txtMalzemeAdi.Location = new System.Drawing.Point(298, 86);
            this.txtMalzemeAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMalzemeAdi.Name = "txtMalzemeAdi";
            this.txtMalzemeAdi.Size = new System.Drawing.Size(121, 22);
            this.txtMalzemeAdi.TabIndex = 9;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(298, 134);
            this.txtMiktar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(121, 22);
            this.txtMiktar.TabIndex = 10;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Silver;
            this.btnKaydet.Location = new System.Drawing.Point(549, 445);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(145, 34);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // TarifeGit
            // 
            this.TarifeGit.BackColor = System.Drawing.Color.Silver;
            this.TarifeGit.Location = new System.Drawing.Point(549, 500);
            this.TarifeGit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TarifeGit.Name = "TarifeGit";
            this.TarifeGit.Size = new System.Drawing.Size(145, 39);
            this.TarifeGit.TabIndex = 12;
            this.TarifeGit.Text = "Tarif Sitesi";
            this.TarifeGit.UseVisualStyleBackColor = false;
            this.TarifeGit.Click += new System.EventHandler(this.TarifeGit_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Silver;
            this.btnSil.Location = new System.Drawing.Point(294, 352);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(125, 36);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "Çıkart";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblKaydetDurum
            // 
            this.lblKaydetDurum.BackColor = System.Drawing.Color.White;
            this.lblKaydetDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKaydetDurum.ForeColor = System.Drawing.Color.Lime;
            this.lblKaydetDurum.Location = new System.Drawing.Point(713, 445);
            this.lblKaydetDurum.Name = "lblKaydetDurum";
            this.lblKaydetDurum.Size = new System.Drawing.Size(272, 32);
            this.lblKaydetDurum.TabIndex = 14;
            this.lblKaydetDurum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKaydetDurum.UseWaitCursor = true;
            this.lblKaydetDurum.Visible = false;
            // 
            // btnGeriGit
            // 
            this.btnGeriGit.BackColor = System.Drawing.Color.DarkGray;
            this.btnGeriGit.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriGit.Location = new System.Drawing.Point(12, 29);
            this.btnGeriGit.Name = "btnGeriGit";
            this.btnGeriGit.Size = new System.Drawing.Size(111, 37);
            this.btnGeriGit.TabIndex = 15;
            this.btnGeriGit.Text = "Geri Git";
            this.btnGeriGit.UseVisualStyleBackColor = false;
            this.btnGeriGit.Click += new System.EventHandler(this.btnGeriGit_Click);
            // 
            // lblUcret
            // 
            this.lblUcret.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUcret.BackColor = System.Drawing.Color.White;
            this.lblUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUcret.ForeColor = System.Drawing.Color.Black;
            this.lblUcret.Location = new System.Drawing.Point(712, 330);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(286, 0);
            this.lblUcret.TabIndex = 17;
            this.lblUcret.UseWaitCursor = true;
            this.lblUcret.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(549, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "Tutar :";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblKalori
            // 
            this.lblKalori.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKalori.BackColor = System.Drawing.Color.White;
            this.lblKalori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalori.ForeColor = System.Drawing.Color.Black;
            this.lblKalori.Location = new System.Drawing.Point(712, 388);
            this.lblKalori.Name = "lblKalori";
            this.lblKalori.Size = new System.Drawing.Size(335, 0);
            this.lblKalori.TabIndex = 19;
            this.lblKalori.UseWaitCursor = true;
            this.lblKalori.Visible = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(546, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 32);
            this.label5.TabIndex = 20;
            this.label5.Text = "Kalori :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(295, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 42);
            this.label7.TabIndex = 30;
            this.label7.Text = "* gr/ml cinsinden\r\n giriniz.\r\n";
            // 
            // PilavForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1411, 674);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblKalori);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblUcret);
            this.Controls.Add(this.btnGeriGit);
            this.Controls.Add(this.lblKaydetDurum);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.TarifeGit);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtMalzemeAdi);
            this.Controls.Add(this.lstMalzemeler);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(label4);
            this.Controls.Add(this.cmbBirim);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PilavForm";
            this.Text = "PilavForm";
            this.Load += new System.EventHandler(this.PilavForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbBirim;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstMalzemeler;
        private System.Windows.Forms.TextBox txtMalzemeAdi;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button TarifeGit;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblKaydetDurum;
        private System.Windows.Forms.Button btnGeriGit;
        private System.Windows.Forms.Button UcretHesapla;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.Button ücretHesapla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblKalori;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}