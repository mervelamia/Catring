
namespace catring
{
    partial class StokBilgi
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownAdet = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinimumStok = new System.Windows.Forms.NumericUpDown();
            this.txtMalzemeAdi = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBirimFiyatGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinimumStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Malzeme Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Malzeme Adedi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Minimum Stok Belirle";
            // 
            // numericUpDownAdet
            // 
            this.numericUpDownAdet.Location = new System.Drawing.Point(196, 167);
            this.numericUpDownAdet.Name = "numericUpDownAdet";
            this.numericUpDownAdet.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownAdet.TabIndex = 3;
            // 
            // numericUpDownMinimumStok
            // 
            this.numericUpDownMinimumStok.Location = new System.Drawing.Point(196, 206);
            this.numericUpDownMinimumStok.Name = "numericUpDownMinimumStok";
            this.numericUpDownMinimumStok.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownMinimumStok.TabIndex = 4;
            // 
            // txtMalzemeAdi
            // 
            this.txtMalzemeAdi.Location = new System.Drawing.Point(196, 125);
            this.txtMalzemeAdi.Name = "txtMalzemeAdi";
            this.txtMalzemeAdi.Size = new System.Drawing.Size(120, 22);
            this.txtMalzemeAdi.TabIndex = 5;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(196, 299);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(96, 32);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "MALZEME GİRİŞ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(418, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(370, 426);
            this.dataGridView1.TabIndex = 9;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.Location = new System.Drawing.Point(318, 194);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(94, 47);
            this.btnGüncelle.TabIndex = 11;
            this.btnGüncelle.Text = "MİN STOK GÜNCELLE";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Location = new System.Drawing.Point(196, 258);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(120, 22);
            this.txtBirimFiyat.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Birim Fiyat";
            // 
            // btnBirimFiyatGuncelle
            // 
            this.btnBirimFiyatGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBirimFiyatGuncelle.Location = new System.Drawing.Point(322, 247);
            this.btnBirimFiyatGuncelle.Name = "btnBirimFiyatGuncelle";
            this.btnBirimFiyatGuncelle.Size = new System.Drawing.Size(94, 44);
            this.btnBirimFiyatGuncelle.TabIndex = 14;
            this.btnBirimFiyatGuncelle.Text = "Birim Fiyat Güncelle";
            this.btnBirimFiyatGuncelle.UseVisualStyleBackColor = true;
            this.btnBirimFiyatGuncelle.Click += new System.EventHandler(this.btnBirimFiyatGuncelle_Click);
            // 
            // StokBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBirimFiyatGuncelle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBirimFiyat);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtMalzemeAdi);
            this.Controls.Add(this.numericUpDownMinimumStok);
            this.Controls.Add(this.numericUpDownAdet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StokBilgi";
            this.Text = "StokBilgi";
            this.Load += new System.EventHandler(this.StokBilgi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinimumStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownAdet;
        private System.Windows.Forms.NumericUpDown numericUpDownMinimumStok;
        private System.Windows.Forms.TextBox txtMalzemeAdi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBirimFiyatGuncelle;
    }
}