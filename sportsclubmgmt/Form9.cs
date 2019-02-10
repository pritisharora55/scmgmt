using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sportsclubmgmt
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            f6.Activate();
            f6.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f6 = new Form7();
            f6.Activate();
            f6.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f6 = new Form1();
            f6.Activate();
            f6.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
