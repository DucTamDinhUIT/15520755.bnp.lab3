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
using System.IO;
using System.Net.Sockets;

namespace BT4
{
    public partial class server : Form
    {
        private delegate void UpdateStatusCallback(string strMessage);

        public server()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            IPAddress ipAddr = IPAddress.Any;
            
            ChatServer mainServer = new ChatServer(ipAddr);

            ChatServer.StatusChanged += new StatusChangedEventHandler(mainServer_StatusChanged);
           
            mainServer.StartListening();
            
            textBox2.AppendText("Monitoring for connections...\r\n");
        }

        public void mainServer_StatusChanged(object sender, StatusChangedEventArgs e)
        {
            // Call the method that updates the form
            this.Invoke(new UpdateStatusCallback(this.UpdateStatus), new object[] { e.EventMessage });
        }

        private void UpdateStatus(string strMessage)
        {
            // Updates the log with the message
            textBox2.AppendText(strMessage + "\r\n");
        }
    }
}
