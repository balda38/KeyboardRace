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
    public class Dataconstructor
    {
        private UdpClient udpclient;
        private IPAddress multicastaddress;
        private IPEndPoint remoteep;
        public Dataconstructor()
        {
            multicastaddress = IPAddress.Parse("192.168.1.46");
            udpclient = new UdpClient();
            //udpclient.JoinMulticastGroup(multicastaddress);
            remoteep = new IPEndPoint(multicastaddress, 2222);
        }
        public static void Messsend()
        {
            Dataconstructor result = new Dataconstructor();
            Thread ListenThread = new Thread(new ThreadStart(result.Listen));
            ListenThread.Start();
            string data = "Привет, чувак!";
            result.SendMessage(data);
        }
        public void SendMessage(string data)
        {
            Byte[] buffer = Encoding.UTF8.GetBytes(data);

            udpclient.Send(buffer, buffer.Length, remoteep);
        }
        public void Listen()
        {
            UdpClient client = new UdpClient();

            client.ExclusiveAddressUse = false;
            IPEndPoint localEp = new IPEndPoint(IPAddress.Any, 2222);

            client.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            client.ExclusiveAddressUse = false;

            client.Client.Bind(localEp);

            //client.JoinMulticastGroup(multicastaddress);

            Global.resulttimetoyouropponent = "\tListening started";

            string formatted_data;

            while (true)
            {
                Byte[] data = client.Receive(ref localEp);
                formatted_data = Encoding.UTF8.GetString(data);
                Global.resulttimetoyouropponentforuser = formatted_data;
            }
        }
    }
}
