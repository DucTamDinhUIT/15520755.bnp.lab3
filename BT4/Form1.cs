using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            server f1 = new server();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            client f2 = new client();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // BT3 f3 = new BT3();
            //f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //BT4 f4 = new BT4();
            //f4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //BT5 f5 = new BT5();
            //f5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

