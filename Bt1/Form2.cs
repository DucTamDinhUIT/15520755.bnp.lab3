using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Bt1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            IPAddress ipadd = IPAddress.Parse(textBox1.Text);
            udpClient.Connect(ipadd, 8080);
            Byte[] sendBytes = Encoding.ASCII.GetBytes(richTextBox1.Text);
            udpClient.Send(sendBytes, sendBytes.Length);
        }
    }
}
