namespace Proje_1
{
    partial class TavukTantuniForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TavukTantuniForm));
            this.txtMalzemeAdi = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.cmbBirim = new System.Windows.Forms.ComboBox();
            this.lstMalzemeler = new System.Windows.Forms.ListBox();
            this.bEkle = new System.Windows.Forms.Button();
            this.bSil = new System.Windows.Forms.Button();
            this.bKaydet = new System.Windows.Forms.Button();
            this.bGit = new System.Windows.Forms.Button();
            this.lblKaydetDurum = new System.Windows.Forms.Label();
            this.bGeri = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUcret = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblKalori = new System.Windows.Forms.Label();
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
            label1.Location = new System.Drawing.Point(92, 61);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(146, 31);
            label1.TabIndex = 3;
            label1.Text = "Malzeme Adı";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.Cornsilk;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(92, 110);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(142, 31);
            label2.TabIndex = 4;
            label2.Text = "Miktar ";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.Cornsilk;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(91, 163);
            label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(147, 31);
            label3.TabIndex = 5;
            label3.Text = "Birim ";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.Color.Cornsilk;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(481, 44);
            label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(267, 55);
            label4.TabIndex = 28;
            label4.Text = "Malzeme Listesi";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMalzemeAdi
            // 
            this.txtMalzemeAdi.Location = new System.Drawing.Point(284, 61);
            this.txtMalzemeAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMalzemeAdi.Name = "txtMalzemeAdi";
            this.txtMalzemeAdi.Size = new System.Drawing.Size(121, 22);
            this.txtMalzemeAdi.TabIndex = 23;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(284, 115);
            this.txtMiktar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(121, 22);
            this.txtMiktar.TabIndex = 24;
            // 
            // cmbBirim
            // 
            this.cmbBirim.FormattingEnabled = true;
            this.cmbBirim.Items.AddRange(new object[] {
            "Kilogram",
            "Gram",
            "Litre",
            "Mililitre"});
            this.cmbBirim.Location = new System.Drawing.Point(284, 168);
            this.cmbBirim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(121, 24);
            this.cmbBirim.TabIndex = 25;
            // 
            // lstMalzemeler
            // 
            this.lstMalzemeler.FormattingEnabled = true;
            this.lstMalzemeler.ItemHeight = 16;
            this.lstMalzemeler.Location = new System.Drawing.Point(476, 121);
            this.lstMalzemeler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstMalzemeler.Name = "lstMalzemeler";
            this.lstMalzemeler.Size = new System.Drawing.Size(272, 148);
            this.lstMalzemeler.TabIndex = 29;
            // 
            // bEkle
            // 
            this.bEkle.BackColor = System.Drawing.Color.Silver;
            this.bEkle.Location = new System.Drawing.Point(275, 293);
            this.bEkle.Name = "bEkle";
            this.bEkle.Size = new System.Drawing.Size(130, 37);
            this.bEkle.TabIndex = 30;
            this.bEkle.Text = "Ekle";
            this.bEkle.UseVisualStyleBackColor = false;
            this.bEkle.Click += new System.EventHandler(this.bEkle_Click);
            // 
            // bSil
            // 
            this.bSil.BackColor = System.Drawing.Color.Silver;
            this.bSil.Location = new System.Drawing.Point(275, 352);
            this.bSil.Name = "bSil";
            this.bSil.Size = new System.Drawing.Size(131, 33);
            this.bSil.TabIndex = 31;
            this.bSil.Text = "Sil";
            this.bSil.UseVisualStyleBackColor = false;
            this.bSil.Click += new System.EventHandler(this.bSil_Click);
            // 
            // bKaydet
            // 
            this.bKaydet.BackColor = System.Drawing.Color.Silver;
            this.bKaydet.Location = new System.Drawing.Point(539, 409);
            this.bKaydet.Name = "bKaydet";
            this.bKaydet.Size = new System.Drawing.Size(111, 33);
            this.bKaydet.TabIndex = 32;
            this.bKaydet.Text = "Kaydet";
            this.bKaydet.UseVisualStyleBackColor = false;
            this.bKaydet.Click += new System.EventHandler(this.bKaydet_Click);
            // 
            // bGit
            // 
            this.bGit.BackColor = System.Drawing.Color.Silver;
            this.bGit.Location = new System.Drawing.Point(539, 463);
            this.bGit.Name = "bGit";
            this.bGit.Size = new System.Drawing.Size(111, 33);
            this.bGit.TabIndex = 33;
            this.bGit.Text = "Tarife Git";
            this.bGit.UseVisualStyleBackColor = false;
            this.bGit.Click += new System.EventHandler(this.bGit_Click);
            // 
            // lblKaydetDurum
            // 
            this.lblKaydetDurum.BackColor = System.Drawing.Color.White;
            this.lblKaydetDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKaydetDurum.ForeColor = System.Drawing.Color.Lime;
            this.lblKaydetDurum.Location = new System.Drawing.Point(677, 409);
            this.lblKaydetDurum.Name = "lblKaydetDurum";
            this.lblKaydetDurum.Size = new System.Drawing.Size(235, 33);
            this.lblKaydetDurum.TabIndex = 34;
            this.lblKaydetDurum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKaydetDurum.UseWaitCursor = true;
            this.lblKaydetDurum.Visible = false;
            // 
            // bGeri
            // 
            this.bGeri.BackColor = System.Drawing.Color.DarkGray;
            this.bGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bGeri.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bGeri.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bGeri.Location = new System.Drawing.Point(3, 12);
            this.bGeri.Name = "bGeri";
            this.bGeri.Size = new System.Drawing.Size(95, 37);
            this.bGeri.TabIndex = 35;
            this.bGeri.Text = "Geri Git";
            this.bGeri.UseVisualStyleBackColor = false;
            this.bGeri.Click += new System.EventHandler(this.bGeri_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(536, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 33);
            this.label5.TabIndex = 36;
            this.label5.Text = "Tutar :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUcret
            // 
            this.lblUcret.BackColor = System.Drawing.Color.White;
            this.lblUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUcret.ForeColor = System.Drawing.Color.Black;
            this.lblUcret.Location = new System.Drawing.Point(677, 293);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(71, 33);
            this.lblUcret.TabIndex = 37;
            this.lblUcret.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUcret.UseWaitCursor = true;
            this.lblUcret.Visible = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(539, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 33);
            this.label6.TabIndex = 38;
            this.label6.Text = "Kalori :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKalori
            // 
            this.lblKalori.BackColor = System.Drawing.Color.White;
            this.lblKalori.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalori.ForeColor = System.Drawing.Color.Black;
            this.lblKalori.Location = new System.Drawing.Point(677, 352);
            this.lblKalori.Name = "lblKalori";
            this.lblKalori.Size = new System.Drawing.Size(120, 33);
            this.lblKalori.TabIndex = 39;
            this.lblKalori.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKalori.UseWaitCursor = true;
            this.lblKalori.Visible = false;
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(281, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 42);
            this.label7.TabIndex = 40;
            this.label7.Text = "* gr/ml cinsinden\r\n giriniz.\r\n";
            // 
            // TavukTantuniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1411, 674);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblKalori);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblUcret);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bGeri);
            this.Controls.Add(this.lblKaydetDurum);
            this.Controls.Add(this.bGit);
            this.Controls.Add(this.bKaydet);
            this.Controls.Add(this.bSil);
            this.Controls.Add(this.bEkle);
            this.Controls.Add(this.lstMalzemeler);
            this.Controls.Add(label4);
            this.Controls.Add(this.cmbBirim);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtMalzemeAdi);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "TavukTantuniForm";
            this.Text = "TavukTantuniForm";
            this.Load += new System.EventHandler(this.TavukTantuniForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMalzemeAdi;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.ComboBox cmbBirim;
        private System.Windows.Forms.ListBox lstMalzemeler;
        private System.Windows.Forms.Button bEkle;
        private System.Windows.Forms.Button bSil;
        private System.Windows.Forms.Button bKaydet;
        private System.Windows.Forms.Button bGit;
        private System.Windows.Forms.Label lblKaydetDurum;
        private System.Windows.Forms.Button bGeri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblKalori;
        private System.Windows.Forms.Label label7;
    }
}