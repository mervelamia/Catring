using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proje_1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void ShowFormInPanel(Form form)
        {
            menüpanel.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            menüpanel.Controls.Add(form);
            form.Show();
        }
        private void btnPilav_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new PilavForm());
        }

        private void btnMakarna_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new SosluMakarnaForm());
        }

        private void btnKofte_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new RostoKofte());
        }

        private void btnTantuni_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new TavukTantuniForm());
        }

        private void btnKebap_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new OrmanKebabıForm());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new PilavYemek());
           
        }
    }
}
