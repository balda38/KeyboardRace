using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KlavoGonki
{
    public partial class Garage : Form
    {
        //Game childrenForm = new Game();
        public Garage()
        {
            InitializeComponent();
            //childrenForm.Owner = this;
        }

        private void Garage_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Main_menu.ActiveForm.Hide();
            Main_menu MyForm2 = new Main_menu();
            MyForm2.ShowDialog();
            Close();
        }

        private int num = 0;
        private int num1 = 0;
        private int clickeditem = 0;
        private int clickeditem1 = 0;

        public void pictureBox3_Click(object sender, EventArgs e)
        {
            string[] NamesAutos = new string[6];
            NamesAutos[0] = "Maskarad";
            NamesAutos[1] = "Devyatina";
            NamesAutos[2] = "Jopel";
            NamesAutos[3] = "Bimer";
            NamesAutos[4] = "Merin";
            NamesAutos[5] = "Priora";

            label2.Text = NamesAutos[num++];
            if (num > 5)
            {
                num = 0;
            }
            label2.Update();

            clickeditem++;
            switch (clickeditem)
            {
                case 1:
                    pictureBox2.Image = global::KlavoGonki.Properties.Resources.Maskaradbig;
                    Global.carimage = Properties.Resources.Maskarad1;
                    break;
                case 2:
                    pictureBox2.Image = global::KlavoGonki.Properties.Resources.Bigdevuatka;
                    Global.carimage = Properties.Resources.devyatina;
                    break;
                case 3:
                    pictureBox2.Image = global::KlavoGonki.Properties.Resources.Jopelbig2;
                    Global.carimage = Properties.Resources.jopel;
                    break;
                case 4:
                    pictureBox2.Image = global::KlavoGonki.Properties.Resources.Bimerbig;
                    Global.carimage = Properties.Resources.bimer;
                    break;
                case 5:
                    pictureBox2.Image = global::KlavoGonki.Properties.Resources.Merinbig1;
                    Global.carimage = Properties.Resources.merin;
                    break;
                case 6:
                    pictureBox2.Image = global::KlavoGonki.Properties.Resources.tazikbig1;
                    Global.carimage = Properties.Resources.tazik;
                    break;
            }
            if (clickeditem > 5)
            {
                clickeditem = 0;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            string[] NamesAutos1 = new string[6];
            NamesAutos1[0] = "Priora";
            NamesAutos1[1] = "Merin";
            NamesAutos1[2] = "Bimer";
            NamesAutos1[3] = "Jopel";
            NamesAutos1[4] = "Devyatina";
            NamesAutos1[5] = "Maskarad";
            
            label2.Text = NamesAutos1[num1++];
            if (num1 > 5)
            {
                num1 = 0;
            }
            label2.Update();

            clickeditem1++;
            switch (clickeditem1)
            {
                case 1:
                    pictureBox2.Image = global::KlavoGonki.Properties.Resources.tazikbig1;
                    Global.carimage = Properties.Resources.tazik;              
                    break;
                case 2:
                    pictureBox2.Image = global::KlavoGonki.Properties.Resources.Merinbig1;
                    Global.carimage = Properties.Resources.merin;
                    break;
                case 3:
                    pictureBox2.Image = global::KlavoGonki.Properties.Resources.Bimerbig;
                    Global.carimage = Properties.Resources.bimer;
                    break;
                case 4:
                    pictureBox2.Image = global::KlavoGonki.Properties.Resources.Jopelbig2;
                    Global.carimage = Properties.Resources.jopel;
                    break;
                case 5:
                    pictureBox2.Image = global::KlavoGonki.Properties.Resources.Bigdevuatka;
                    Global.carimage = Properties.Resources.devyatina;
                    break;
                case 6:
                    pictureBox2.Image = global::KlavoGonki.Properties.Resources.Maskaradbig;
                    Global.carimage = Properties.Resources.Maskarad1;
                    break;
            }
            if (clickeditem1 > 5)
            {
                clickeditem1 = 0;
            }
        }
    }
}
