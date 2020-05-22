using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bt1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Shows Form2
            Form1 f1 = new Form1();
            f1.ShowDialog();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Shows Form2
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
