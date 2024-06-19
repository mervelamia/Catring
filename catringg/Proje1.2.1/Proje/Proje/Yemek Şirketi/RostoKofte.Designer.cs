namespace Proje_1
{
    partial class RostoKofte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RostoKofte));
            this.txtMalzemeAdi = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.cmbBirim = new System.Windows.Forms.ComboBox();
            this.lstMalzemeler = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblKaydetDurum = new System.Windows.Forms.Label();
            this.bttnEkle = new System.Windows.Forms.Button();
            this.bttnKaydet = new System.Windows.Forms.Button();
            this.bttnSil = new System.Windows.Forms.Button();
            this.bttnGeriCik = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUcret = new System.Windows.Forms.Label();
            this.lblKalori = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            label1.Location = new System.Drawing.Point(123, 85);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(140, 31);
            label1.TabIndex = 2;
            label1.Text = "Malzeme Adı";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.Cornsilk;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(123, 148);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(140, 31);
            label2.TabIndex = 3;
            label2.Text = "Miktar ";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.Cornsilk;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(123, 214);
            label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(140, 31);
            label3.TabIndex = 4;
            label3.Text = "Birim ";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.Color.Cornsilk;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(551, 73);
            label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(267, 55);
            label4.TabIndex = 27;
            label4.Text = "Malzeme Listesi";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMalzemeAdi
            // 
            this.txtMalzemeAdi.Location = new System.Drawing.Point(300, 90);
            this.txtMalzemeAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMalzemeAdi.Name = "txtMalzemeAdi";
            this.txtMalzemeAdi.Size = new System.Drawing.Size(121, 22);
            this.txtMalzemeAdi.TabIndex = 22;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(300, 153);
            this.txtMiktar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(121, 22);
            this.txtMiktar.TabIndex = 23;
            // 
            // cmbBirim
            // 
            this.cmbBirim.FormattingEnabled = true;
            this.cmbBirim.Items.AddRange(new object[] {
            "Kilogram",
            "Gram",
            "Litre",
            "Mililitre"});
            this.cmbBirim.Location = new System.Drawing.Point(300, 214);
            this.cmbBirim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(121, 24);
            this.cmbBirim.TabIndex = 24;
            // 
            // lstMalzemeler
            // 
            this.lstMalzemeler.FormattingEnabled = true;
            this.lstMalzemeler.ItemHeight = 16;
            this.lstMalzemeler.Location = new System.Drawing.Point(546, 148);
            this.lstMalzemeler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstMalzemeler.Name = "lstMalzemeler";
            this.lstMalzemeler.Size = new System.Drawing.Size(272, 148);
            this.lstMalzemeler.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(632, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 32);
            this.button1.TabIndex = 30;
            this.button1.Text = "Tarife Git";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblKaydetDurum
            // 
            this.lblKaydetDurum.BackColor = System.Drawing.Color.White;
            this.lblKaydetDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKaydetDurum.ForeColor = System.Drawing.Color.Lime;
            this.lblKaydetDurum.Location = new System.Drawing.Point(770, 449);
            this.lblKaydetDurum.Name = "lblKaydetDurum";
            this.lblKaydetDurum.Size = new System.Drawing.Size(254, 32);
            this.lblKaydetDurum.TabIndex = 31;
            this.lblKaydetDurum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKaydetDurum.UseWaitCursor = true;
            this.lblKaydetDurum.Visible = false;
            // 
            // bttnEkle
            // 
            this.bttnEkle.BackColor = System.Drawing.Color.Silver;
            this.bttnEkle.Location = new System.Drawing.Point(300, 333);
            this.bttnEkle.Name = "bttnEkle";
            this.bttnEkle.Size = new System.Drawing.Size(121, 27);
            this.bttnEkle.TabIndex = 32;
            this.bttnEkle.Text = "Ekle";
            this.bttnEkle.UseVisualStyleBackColor = false;
            this.bttnEkle.Click += new System.EventHandler(this.bttnEkle_Click);
            // 
            // bttnKaydet
            // 
            this.bttnKaydet.BackColor = System.Drawing.Color.Silver;
            this.bttnKaydet.Location = new System.Drawing.Point(632, 449);
            this.bttnKaydet.Name = "bttnKaydet";
            this.bttnKaydet.Size = new System.Drawing.Size(121, 32);
            this.bttnKaydet.TabIndex = 33;
            this.bttnKaydet.Text = "Kaydet";
            this.bttnKaydet.UseVisualStyleBackColor = false;
            this.bttnKaydet.Click += new System.EventHandler(this.bttnKaydet_Click);
            // 
            // bttnSil
            // 
            this.bttnSil.BackColor = System.Drawing.Color.Silver;
            this.bttnSil.Location = new System.Drawing.Point(300, 390);
            this.bttnSil.Name = "bttnSil";
            this.bttnSil.Size = new System.Drawing.Size(121, 28);
            this.bttnSil.TabIndex = 34;
            this.bttnSil.Text = "Sil";
            this.bttnSil.UseVisualStyleBackColor = false;
            this.bttnSil.Click += new System.EventHandler(this.bttnSil_Click);
            // 
            // bttnGeriCik
            // 
            this.bttnGeriCik.BackColor = System.Drawing.Color.DarkGray;
            this.bttnGeriCik.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnGeriCik.Location = new System.Drawing.Point(21, 38);
            this.bttnGeriCik.Name = "bttnGeriCik";
            this.bttnGeriCik.Size = new System.Drawing.Size(97, 36);
            this.bttnGeriCik.TabIndex = 35;
            this.bttnGeriCik.Text = "Geri Git";
            this.bttnGeriCik.UseVisualStyleBackColor = false;
            this.bttnGeriCik.Click += new System.EventHandler(this.bttnGeriCik_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(629, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 32);
            this.label5.TabIndex = 36;
            this.label5.Text = "Tutar :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUcret
            // 
            this.lblUcret.BackColor = System.Drawing.Color.White;
            this.lblUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUcret.ForeColor = System.Drawing.Color.Black;
            this.lblUcret.Location = new System.Drawing.Point(770, 338);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(101, 32);
            this.lblUcret.TabIndex = 37;
            this.lblUcret.UseWaitCursor = true;
            this.lblUcret.Visible = false;
            // 
            // lblKalori
            // 
            this.lblKalori.BackColor = System.Drawing.Color.White;
            this.lblKalori.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalori.ForeColor = System.Drawing.Color.Black;
            this.lblKalori.Location = new System.Drawing.Point(770, 396);
            this.lblKalori.Name = "lblKalori";
            this.lblKalori.Size = new System.Drawing.Size(127, 32);
            this.lblKalori.TabIndex = 38;
            this.lblKalori.UseWaitCursor = true;
            this.lblKalori.Visible = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(632, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 32);
            this.label7.TabIndex = 39;
            this.label7.Text = "Kalori :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(297, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 42);
            this.label6.TabIndex = 40;
            this.label6.Text = "* gr/ml cinsinden\r\n giriniz.\r\n";
            // 
            // RostoKofte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1411, 674);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblKalori);
            this.Controls.Add(this.lblUcret);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bttnGeriCik);
            this.Controls.Add(this.bttnSil);
            this.Controls.Add(this.bttnKaydet);
            this.Controls.Add(this.bttnEkle);
            this.Controls.Add(this.lblKaydetDurum);
            this.Controls.Add(this.button1);
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
            this.Name = "RostoKofte";
            this.Text = "RostoKofte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMalzemeAdi;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.ComboBox cmbBirim;
        private System.Windows.Forms.ListBox lstMalzemeler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttnEkle;
        private System.Windows.Forms.Button bttnKaydet;
        private System.Windows.Forms.Button bttnSil;
        private System.Windows.Forms.Button bttnGeriCik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.Label lblKaydetDurum;
        private System.Windows.Forms.Label lblKalori;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}