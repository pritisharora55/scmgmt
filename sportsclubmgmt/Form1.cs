using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace sportsclubmgmt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exb_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            String us = tb1.Text;
            String pass = tb2.Text;
            if ((us.Equals("admin"))||(us.Equals("user")) && (pass.Equals("admin"))||(pass.Equals("password")))
            {
                string connetionString;
                SqlConnection con;
                connetionString = @"Data Source=LAPTOP-O9CK3CHT\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
                con = new SqlConnection(connetionString);
                con.Open();
                MessageBox.Show("Connection Created");
                this.Hide();
                Form2 f2 = new Form2();
                f2.Activate();
                f2.Show();
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f6 = new Form9();
            f6.Activate();
            f6.Show();
        }

        
    }
}
