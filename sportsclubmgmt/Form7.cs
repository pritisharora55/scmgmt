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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

            private void button1_Click(object sender, EventArgs e)
{
searchbyid(searchbox.Text.Trim());
        }
        protected void searchbyid(string searchText)
        {
            if (searchbox.Text == "")
            {
                MessageBox.Show("No Id to search!");

            }
            else
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-O9CK3CHT\SQLEXPRESS;Initial Catalog=master;Integrated Security=True"))
                {
                    string sql = "SELECT * FROM player WHERE player_ID = '" + searchbox.Text + "'";
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {

                        cmd.Parameters.AddWithValue("id", searchbox.Text);

                        DataTable dt = new DataTable();
                        SqlDataAdapter ad = new SqlDataAdapter(cmd);
                        ad.Fill(dt);

                        if (dt.Rows.Count > 0)
                        { 
                            dataGridView1.DataSource = dt;
                            
                        }
                        else
                        {
                            MessageBox.Show("Record not found!");
                        }
                    }
                }

            }

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
            Close();
        }
}
        }
