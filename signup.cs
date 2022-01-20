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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            user_id.Text = "";
            full_name.Text = "";
            user_name.Text = "";
            pass_word.Text = "";
            contact_no.Text = "";
            status.Text = "";
            security_qu.Text = "";
            security_ans.Text = "";
            user_id.Focus();
        }

        private void back_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }

        private void sign_up_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-4170OPL;Initial Catalog=bakery;Integrated Security=True");
                SqlCommand scom = new SqlCommand("INSERT INTO users VALUES (@id, @fname, @uname, @p_word, @contact, @status, @s_qu, @s_ans)", con);
                scom.Parameters.AddWithValue("@id", user_id.Text);
                scom.Parameters.AddWithValue("@fname", full_name.Text);
                scom.Parameters.AddWithValue("@uname", user_name.Text);
                scom.Parameters.AddWithValue("@p_word", pass_word.Text);
                scom.Parameters.AddWithValue("@contact", contact_no.Text);
                scom.Parameters.AddWithValue("@status", status.Text);
                scom.Parameters.AddWithValue("@s_qu", security_qu.Text);
                scom.Parameters.AddWithValue("@s_ans", security_ans.Text);

                con.Open();
                scom.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Your Account is created Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Something went wrong \nTry Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void security_qu_SelectedIndexChanged(object sender, EventArgs e)
        {
            security_ans.Focus();
        }

        private void signup_showpass_OnChange(object sender, EventArgs e)
        {
            if(signup_showpass.Checked)
            {
                pass_word.isPassword = false;
            }
            else
            {
                pass_word.isPassword = true;
            }
        }
    }
}
