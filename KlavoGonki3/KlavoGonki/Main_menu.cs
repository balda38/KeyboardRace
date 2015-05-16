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
    public partial class Main_menu : Form
    {
        public Main_menu()
        {
            InitializeComponent();
        }
        public System.Media.SoundPlayer sndplr;
        private void Form1_Load(object sender, EventArgs e)
        {
            //while (true)
            //{
                sndplr = new System.Media.SoundPlayer(KlavoGonki.Properties.Resources.The_ARTISANS___True_Moment);
                sndplr.Play();
            //}
            //Size sz = new Size();
            //sz = SystemInformation.PrimaryMonitorSize;
            //formwidth = SystemInformation.PrimaryMonitorSize.Width;
            //formheight = SystemInformation.PrimaryMonitorSize.Height;

            //label3.Text = Global.resulttimetoyouropponent;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main_menu.ActiveForm.Hide();
            Game MyForm2 = new Game();
            MyForm2.ShowDialog();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main_menu.ActiveForm.Hide();
            Garage MyForm4 = new Garage();
            MyForm4.ShowDialog();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private static int clickeditem = 0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (clickeditem > 2)
            {
                clickeditem = 0;
            }
            clickeditem++;
            switch (clickeditem)
            {
                case 1:
                    pictureBox1.Image = global::KlavoGonki.Properties.Resources.soundoff1;
                    sndplr.Stop();
                    break;
                case 2:
                    pictureBox1.Image = global::KlavoGonki.Properties.Resources.soundon1;
                    sndplr.Play();
                    break;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Main_menu.ActiveForm.Hide();
            Helpform MyForm4 = new Helpform();
            MyForm4.ShowDialog();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Registrationform MyForm4 = new Registrationform();
            MyForm4.ShowDialog();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
