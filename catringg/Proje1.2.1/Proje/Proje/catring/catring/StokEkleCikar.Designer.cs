
namespace catring
{
    partial class StokEkleCikar
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
            this.cmbMalzemeAdi = new System.Windows.Forms.TextBox();
            this.numericUpDownStokEkle = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStokCikar = new System.Windows.Forms.NumericUpDown();
            this.btnStokEkle = new System.Windows.Forms.Button();
            this.btnStokCikar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStokEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStokCikar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Malzeme Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stok Ekle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stok Çıkar";
            // 
            // cmbMalzemeAdi
            // 
            this.cmbMalzemeAdi.Location = new System.Drawing.Point(138, 139);
            this.cmbMalzemeAdi.Name = "cmbMalzemeAdi";
            this.cmbMalzemeAdi.Size = new System.Drawing.Size(120, 22);
            this.cmbMalzemeAdi.TabIndex = 3;
            // 
            // numericUpDownStokEkle
            // 
            this.numericUpDownStokEkle.Location = new System.Drawing.Point(138, 180);
            this.numericUpDownStokEkle.Name = "numericUpDownStokEkle";
            this.numericUpDownStokEkle.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownStokEkle.TabIndex = 4;
            // 
            // numericUpDownStokCikar
            // 
            this.numericUpDownStokCikar.Location = new System.Drawing.Point(138, 217);
            this.numericUpDownStokCikar.Name = "numericUpDownStokCikar";
            this.numericUpDownStokCikar.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownStokCikar.TabIndex = 5;
            // 
            // btnStokEkle
            // 
            this.btnStokEkle.Location = new System.Drawing.Point(282, 175);
            this.btnStokEkle.Name = "btnStokEkle";
            this.btnStokEkle.Size = new System.Drawing.Size(135, 31);
            this.btnStokEkle.TabIndex = 6;
            this.btnStokEkle.Text = "Stok Ekle";
            this.btnStokEkle.UseVisualStyleBackColor = true;
            this.btnStokEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStokCikar
            // 
            this.btnStokCikar.Location = new System.Drawing.Point(282, 217);
            this.btnStokCikar.Name = "btnStokCikar";
            this.btnStokCikar.Size = new System.Drawing.Size(135, 31);
            this.btnStokCikar.TabIndex = 7;
            this.btnStokCikar.Text = "Stok Çıkar";
            this.btnStokCikar.UseVisualStyleBackColor = true;
            this.btnStokCikar.Click += new System.EventHandler(this.btnStokCikar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(423, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(370, 426);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // StokEkleCikar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 457);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnStokCikar);
            this.Controls.Add(this.btnStokEkle);
            this.Controls.Add(this.numericUpDownStokCikar);
            this.Controls.Add(this.numericUpDownStokEkle);
            this.Controls.Add(this.cmbMalzemeAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StokEkleCikar";
            this.Text = "StokEkleCikar";
            this.Load += new System.EventHandler(this.StokEkleCikar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStokEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStokCikar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cmbMalzemeAdi;
        private System.Windows.Forms.NumericUpDown numericUpDownStokEkle;
        private System.Windows.Forms.NumericUpDown numericUpDownStokCikar;
        private System.Windows.Forms.Button btnStokEkle;
        private System.Windows.Forms.Button btnStokCikar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}