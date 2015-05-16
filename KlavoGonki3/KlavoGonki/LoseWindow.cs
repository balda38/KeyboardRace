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
    public partial class LoseWindow : Form
    {
        public LoseWindow()
        {
            InitializeComponent();
            if (Global.resulttimeseconds < 10)
            {
                label5.Text = "0" + Global.resulttimeminutes.ToString() + ":" + "0" + Global.resulttimeseconds.ToString();
            }
            else
            {
                label5.Text = "0" + Global.resulttimeminutes.ToString() + ":" + Global.resulttimeseconds.ToString();
            }
            label6.Text = Global.resultmistakes.ToString();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Main_menu.ActiveForm.Hide();
            Main_menu MyForm2 = new Main_menu();
            MyForm2.ShowDialog();
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
