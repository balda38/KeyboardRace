using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace KlavoGonki
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
        
        //public void searchfiles(object text)
        //{
        //    string[] textfiles = Directory.GetFiles(@"C:\\games\\*.txt");
        //    Random txt = new Random(textfiles.Length);
        //}

        public string g = @"Морозы че то там. Дети играют и радуются. За окном очень холодно. Угрюмые взрослые идут на работу. Ля-ля-ля.asfasfasffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff";
 
        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = g;
            if (label1.Text.Length > 41)
            {
                label1.Text = label1.Text.Remove(41);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Text.
            if (textBox1.Text != null)
            {
                timer1.Enabled = true;
            }
            if (textBox1.Text == g)
            {
                timer1.Enabled = false;
            }
                if (label1.Text.Substring(1, 0) == textBox1.Text.Substring(1, 0))
                {
                    label1.Text = g.Remove(1, 1);
                    if (label1.Text.Length > 41)
                    {
                        label1.Text = label1.Text.Remove(41);
                    }
                }
                if (label1.Text.Substring(1, 0) != textBox1.Text.Substring(1, 0))
                {
                    label1.ForeColor = Color.Red;
                }
        }

        private int time = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            label2.Text = time.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }





    }
}