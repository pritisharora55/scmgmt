using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sportsclubmgmt
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-O9CK3CHT\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            SqlCommand cmd;
            cnn.Open();
            string s = "insert into player values(@p1,@p2,@p3,@p4)";
            cmd = new SqlCommand(s, cnn);
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);
            cmd.Parameters.AddWithValue("@p2", textBox2.Text);
            cmd.Parameters.AddWithValue("@p3", textBox3.Text);
            cmd.Parameters.AddWithValue("@p4", textBox4.Text);
            cmd.CommandType = CommandType.Text;
            int i = cmd.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show(i + " Registeration complete ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 x = new Form9();
            x.Activate();
            x.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-O9CK3CHT\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            SqlCommand cmd;
            cnn.Open();
            string s = "insert into kit values(@p1,@p2,@p3,@p4,@p5)";
            cmd = new SqlCommand(s, cnn);
            cmd.Parameters.AddWithValue("@p1", textBox5.Text);
            cmd.Parameters.AddWithValue("@p2", textBox6.Text);
            cmd.Parameters.AddWithValue("@p3", textBox7.Text);
            cmd.Parameters.AddWithValue("@p4", textBox8.Text);
            cmd.Parameters.AddWithValue("@p5", textBox9.Text);
            cmd.CommandType = CommandType.Text;
            int i = cmd.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show(i + " Kit Registered ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-O9CK3CHT\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            SqlCommand cmd;
            cnn.Open();
            string s = "insert into health values(@p1,@p2,@p3,@p4,@p5)";
            cmd = new SqlCommand(s, cnn);
            cmd.Parameters.AddWithValue("@p1", textBox10.Text);
            cmd.Parameters.AddWithValue("@p2", textBox11.Text);
            cmd.Parameters.AddWithValue("@p3", textBox12.Text);
            cmd.Parameters.AddWithValue("@p4", textBox13.Text);
            cmd.Parameters.AddWithValue("@p5", textBox14.Text);
            cmd.CommandType = CommandType.Text;
            int i = cmd.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show(i + " Health Details Updated ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-O9CK3CHT\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            SqlCommand cmd;
            cnn.Open();
            string s = "insert into trainer values(@p1,@p2,@p3,@p4,@p5)";
            cmd = new SqlCommand(s, cnn);
            cmd.Parameters.AddWithValue("@p1", textBox15.Text);
            cmd.Parameters.AddWithValue("@p2", textBox16.Text);
            cmd.Parameters.AddWithValue("@p3", textBox17.Text);
            cmd.Parameters.AddWithValue("@p4", textBox18.Text);
            cmd.Parameters.AddWithValue("@p5", textBox19.Text);
            cmd.CommandType = CommandType.Text;
            int i = cmd.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show(i + " Trainer Details Updated ");
        }

       

     
    }
}
