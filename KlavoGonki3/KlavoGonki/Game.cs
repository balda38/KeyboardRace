using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace KlavoGonki
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        private static int random()
        {
            Random textrandom = new Random();
            return textrandom.Next(1, 5);
        }
        string textfilename = "";
        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Global.carimage;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            textBox1.ContextMenu = new ContextMenu();
            int randomnumber = random();
            textfilename = "TextFilewithoutEntering" + randomnumber;
            label1.Text = KlavoGonki.Properties.Resources.ResourceManager.GetString(textfilename);
        }


        private int mistakes = 0;

        private int seconds = 0;
        private int minutes = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds == 60)
            {
                seconds = 0;
            }
            if (minutes == 60)
            {
                minutes = 0;
            }
            if (seconds < 10)
            {
                label2.Text = "0" + minutes.ToString() + ":" + "0" + seconds.ToString();
            }
            else
            {
                label2.Text = "0" + minutes.ToString() + ":" + seconds.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Game.ActiveForm.Hide();
            Main_menu MyForm2 = new Main_menu();
            MyForm2.ShowDialog();
            Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            minutes++;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int waitchar = 0;
        bool start = false;
        string repl_text = "";
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!start)
            {
                timer1.Enabled = true;
                timer2.Enabled = true;
                waitchar = 0;
                start = true;
                repl_text = KlavoGonki.Properties.Resources.ResourceManager.GetString(textfilename);
            }

            int movecountpxl = 1800 / repl_text.Length;

            if (repl_text[waitchar] == e.KeyChar)
            {
                pictureBox1.Left += movecountpxl;
                waitchar++;
            }
            else
            {
                mistakes++;
                label5.Text = mistakes.ToString();
                e.Handled = true;
            }


            //if (repl_text == e.KeyChar)
            //{
            //    timer1.Enabled = false;
            //    timer2.Enabled = false;
            //    start = false;
            //    Global.resulttimeminutes = minutes;
            //    Global.resulttimeseconds = seconds;
            //    Global.resultmistakes = mistakes;
            //    WinWindow MyForm2 = new WinWindow();
            //    MyForm2.ShowDialog();
            //}          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (repl_text == textBox1.Text)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                start = false;
                //Dataconstructor.Messsend();

                Global.resulttimeminutes = minutes;
                Global.resulttimeseconds = seconds;
                Global.resultmistakes = mistakes;
                WinWindow MyForm2 = new WinWindow();
                MyForm2.ShowDialog();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (textBox2.Text != null)
            //{
                textBox2.Text = Global.resulttimetoyouropponent;
                Dataconstructor.Messsend();
                label6.Text = Global.resulttimetoyouropponentforuser;
            //}
        }


        //public void SendMessage(string data)
        //{
        //    Byte[] buffer = Encoding.UTF8.GetBytes(data);

        //    udpclient.Send(buffer, buffer.Length, remoteep);
        //}
        //public void Listen()
        //{
        //    UdpClient client = new UdpClient();

        //    client.ExclusiveAddressUse = false;
        //    IPEndPoint localEp = new IPEndPoint(IPAddress.Any, 2222);

        //    client.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
        //    client.ExclusiveAddressUse = false;

        //    client.Client.Bind(localEp);

        //    client.JoinMulticastGroup(multicastaddress);

        //    Global.resulttimetoyouropponent = "\tListening started";

        //    string formatted_data;

        //    while (true)
        //    {
        //        Byte[] data = client.Receive(ref localEp);
        //        formatted_data = Encoding.UTF8.GetString(data);
        //        Global.resulttimetoyouropponent = formatted_data;
        //    }
        //}

    }
}