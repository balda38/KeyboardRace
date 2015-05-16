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
    public partial class Choose_mode : Form
    {
        public Choose_mode()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Choose_mode.ActiveForm.Hide();
            Game MyForm2 = new Game();
            MyForm2.ShowDialog();
            //Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Choose_mode.ActiveForm.Hide();
            //Game MyForm2 = new Game();
            //MyForm2.ShowDialog();
            //Close();
        }

        private void Choose_mode_Load(object sender, EventArgs e)
        {

        }
    }
}
