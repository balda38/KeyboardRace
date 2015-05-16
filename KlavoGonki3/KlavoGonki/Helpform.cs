using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlavoGonki
{
    public partial class Helpform : Form
    {
        public Helpform()
        {
            InitializeComponent();
        }

        private void Helpform_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            label1.Text = "ОЫАлроДЛРЫОРАоыалоывмлоывпрываиыв";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main_menu.ActiveForm.Hide();
            Main_menu MyForm2 = new Main_menu();
            MyForm2.ShowDialog();
            Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
