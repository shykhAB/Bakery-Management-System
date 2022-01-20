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
    public partial class user : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-4170OPL;Initial Catalog=bakery;Integrated Security=True");
        public user()
        {
            InitializeComponent();
        }

        private void user_searchchoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            String s1 = "ENTER YOUR USER ID";
            String s2 = "ENTER YOUR FULLNAME";
            String s3 = "ENTER YOUR USERNAME";
            if (user_searchchoice.Text == "By User ID")
            {
                user_displaylabel.Text = s1;
            }
            else if (user_searchchoice.Text == "By Full Name")
            {
                user_displaylabel.Text = s2;
            }
            else if (user_searchchoice.Text == "By Username")
            {
                user_displaylabel.Text = s3;
            }


        }

        
        private void user_Load(object sender, EventArgs e)
        {
           
        }

        public void show_data_on_grid()
        { 
            SqlCommand scom = new SqlCommand("SELECT * FROM users", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = scom.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            user_datagrid.DataSource = dt;
        }

        private void user_datagrid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            user_userid.Text = user_datagrid.SelectedRows[0].Cells[0].Value.ToString();
            user_fullname.Text = user_datagrid.SelectedRows[0].Cells[1].Value.ToString();
            user_username.Text = user_datagrid.SelectedRows[0].Cells[2].Value.ToString();
            user_password.Text = user_datagrid.SelectedRows[0].Cells[3].Value.ToString();
            user_contactno.Text = user_datagrid.SelectedRows[0].Cells[4].Value.ToString();
            user_status.Text = user_datagrid.SelectedRows[0].Cells[5].Value.ToString();
            user_securityqu.Text = user_datagrid.SelectedRows[0].Cells[6].Value.ToString();
            user_securityans.Text = user_datagrid.SelectedRows[0].Cells[7].Value.ToString();

        }

        public void clear_all_fields()
        {
            user_userid.Text = "";
            user_username.Text = "";
            user_fullname.Text = "";
            user_password.Text = "";
            user_contactno.Text = "";
            user_status.Text = "";
            user_securityqu.Text = "";
            user_securityans.Text = "";
            user_userid.Focus();
        }

        private void user_userid_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void user_fullname_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void user_username_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void user_password_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void user_contactno_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void user_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void user_addbutton_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand scom = new SqlCommand("INSERT INTO users VALUES (@id, @fname, @uname, @p_word, @contact, @status, @s_qu, @s_ans)", con);
                scom.Parameters.AddWithValue("@id", user_userid.Text);
                scom.Parameters.AddWithValue("@fname", user_fullname.Text);
                scom.Parameters.AddWithValue("@uname", user_username.Text);
                scom.Parameters.AddWithValue("@p_word", user_password.Text);
                scom.Parameters.AddWithValue("@contact", user_contactno.Text);
                scom.Parameters.AddWithValue("@status", user_status.Text);
                scom.Parameters.AddWithValue("@s_qu", user_securityqu.Text);
                scom.Parameters.AddWithValue("@s_ans", user_securityans.Text);

                con.Open();
                scom.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Your Account is created Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                show_data_on_grid();
                clear_all_fields();
            }
            catch
            {
                MessageBox.Show("Something went wrong\nTry Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void user_showallbutton_Click_1(object sender, EventArgs e)
        {
            show_data_on_grid();
        }

        private void user_updatebutton_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand scom = new SqlCommand("UPDATE users SET full_name = @fname, username = @uname, passwordd = @p_word, contact_no = @contact, statuss = @status, security_question = @s_qu, security_answer = @s_ans WHERE user_idd = @id ", con);
                scom.Parameters.AddWithValue("@fname", user_fullname.Text);
                scom.Parameters.AddWithValue("@uname", user_username.Text);
                scom.Parameters.AddWithValue("@p_word", user_password.Text);
                scom.Parameters.AddWithValue("@contact", user_contactno.Text);
                scom.Parameters.AddWithValue("@status", user_status.Text);
                scom.Parameters.AddWithValue("@s_qu", user_securityqu.Text);
                scom.Parameters.AddWithValue("@s_ans", user_securityans.Text);
                scom.Parameters.AddWithValue("@id", user_userid.Text);
                con.Open();
                scom.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("User Updated Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                show_data_on_grid();
                clear_all_fields();
            }
            catch
            {
                MessageBox.Show("Something went wrong\nTry Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void user_searchbutton_Click_1(object sender, EventArgs e)
        {
            if (user_displaylabel.Text == "ENTER YOUR USER ID")
            {
                try
                {
                    SqlCommand scom = new SqlCommand("SELECT * FROM users WHERE user_idd = @id", con);
                    scom.Parameters.AddWithValue("@id", user_searchentry.Text);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader sdr = scom.ExecuteReader();
                    dt.Load(sdr);
                    con.Close();
                    MessageBox.Show("Data Found Successfully", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    user_datagrid.DataSource = dt;
                    user_searchentry.Text = "";
                    user_searchentry.Focus();
                }
                catch
                {
                    MessageBox.Show("Data Not Found..\nTry Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (user_displaylabel.Text == "ENTER YOUR FULLNAME")
            {
                try
                {
                    SqlCommand scom = new SqlCommand("SELECT * FROM users WHERE full_name = @fullname", con);
                    scom.Parameters.AddWithValue("@fullname", user_searchentry.Text);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader sdr = scom.ExecuteReader();
                    dt.Load(sdr);
                    con.Close();
                    MessageBox.Show("Data Found Successfully", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    user_datagrid.DataSource = dt;
                    user_searchentry.Text = "";
                    user_searchentry.Focus();
                }
                catch
                {
                    MessageBox.Show("Data Not Found..\nTry Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (user_displaylabel.Text == "ENTER YOUR USERNAME")
            {
                try
                {
                    SqlCommand scom = new SqlCommand("SELECT * FROM users WHERE username = @username", con);
                    scom.Parameters.AddWithValue("@username", user_searchentry.Text);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader sdr = scom.ExecuteReader();
                    dt.Load(sdr);
                    con.Close();
                    MessageBox.Show("Data Found Successfully", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    user_datagrid.DataSource = dt;
                    user_searchentry.Text = "";
                    user_searchentry.Focus();
                }
                catch
                {
                    MessageBox.Show("Data Not Found..\nTry Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Select Your Choice First.....!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                user_searchentry.Text = "";
                user_searchentry.Focus();
            }
        }

        private void user_deletebutton_Click_1(object sender, EventArgs e)
        {
            try
            {
                string message = "Do you really want to Delete User?";
                string title = "Delete User";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    SqlCommand scom = new SqlCommand("DELETE FROM users WHERE user_idd = @id ", con);
                    scom.Parameters.AddWithValue("@id", user_userid.Text); con.Open();
                    scom.ExecuteNonQuery();
                    con.Close();

                    show_data_on_grid();
                    clear_all_fields();
                }
                else
                {
                    clear_all_fields();
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong\nTry Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void user_clearbutton_Click_1(object sender, EventArgs e)
        {
            clear_all_fields();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
