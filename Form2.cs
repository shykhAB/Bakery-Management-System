using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project
{
    public partial class forgot_password : Form
    {
        public forgot_password()
        {
            InitializeComponent();
        }

        private void forgot_securityqu_SelectedIndexChanged(object sender, EventArgs e)
        {
            forgot_securityans.Focus();
        }

        private void forgot_show_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4170OPL;Initial Catalog=bakery;Integrated Security=True");
            string query = "Select count(security_question), security_question, security_answer FROM users WHERE username = '" + forgot_username.Text + "'";
            query += "Group By security_question, security_answer";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            try
            {
                if (dt.Rows[0][0].ToString() == "1")
                {
                    if (forgot_securityqu.Text == dt.Rows[0]["security_question"].ToString() && forgot_securityans.Text == dt.Rows[0]["security_answer"].ToString())
                    {
                        SqlCommand scom = new SqlCommand("Select passwordd from users Where username = @uname", con);
                        scom.Parameters.AddWithValue("@uname", forgot_username.Text);
                        con.Open();
                        string temp;
                        temp = scom.ExecuteScalar().ToString();
                        con.Close();
                        MessageBox.Show("Your Password is: " + temp, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Your Values Not Matched with Database Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Username is Invalid Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void forgot_back_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Close();
        }
    }
}
