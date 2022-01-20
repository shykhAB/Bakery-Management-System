using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project
{
    public partial class changepassword : UserControl
    {
        public changepassword()
        {
            InitializeComponent();
        }
        private void changepassword_Load(object sender, EventArgs e)
        {

        }

        private void changepass_showpass_OnChange(object sender, EventArgs e)
        {
            

        }

        public void clear_all_fields()
        {
            changepassword_confirmpass.Text = "";
            changepassword_newpass.Text = "";
            changepassword_oldpass.Text = "";
            changepassword_username.Text = "";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void show_password_OnChange(object sender, EventArgs e)
        {
            if (changepass_showpass.Checked)
            {
                changepassword_oldpass.isPassword = false;
                changepassword_newpass.isPassword = false;
                changepassword_confirmpass.isPassword = false;
            }
            else
            {
                changepassword_oldpass.isPassword = true;
                changepassword_newpass.isPassword = true;
                changepassword_confirmpass.isPassword = true;
            }
        }

        private void change_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4170OPL;Initial Catalog=bakery;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select passwordd FROM users WHERE username ='" + changepassword_username.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            try
            {
                if (changepassword_oldpass.Text == dt.Rows[0][0].ToString())
                {
                    if (changepassword_newpass.Text == changepassword_confirmpass.Text)
                    {
                        SqlCommand scom = new SqlCommand("UPDATE users SET passwordd = @password WHERE username = @uname", con);
                        scom.Parameters.AddWithValue("@password", changepassword_confirmpass.Text);
                        scom.Parameters.AddWithValue("@uname", changepassword_username.Text);
                        con.Open();
                        scom.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Password Changed Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear_all_fields();
                    }
                    else
                    {
                        MessageBox.Show("Password Not Matched", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (changepassword_oldpass.Text != dt.Rows[0][0].ToString())
                {
                    MessageBox.Show("Incorrect Current/Old Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Something Went Wrong Try Again....", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Username Not Matched.../nTry Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
