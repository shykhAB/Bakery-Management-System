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
using System.Threading;

namespace project
{
    public partial class login : Form
    {
        public login()
        {
            Thread mythread = new Thread(new ThreadStart(splashscreen));
            mythread.Start();
            Thread.Sleep(3000);
            InitializeComponent();
            mythread.Abort();

        }
        public void splashscreen()
        {
            Application.Run(new splashscreen());
        }

        private void log_in_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4170OPL;Initial Catalog=bakery;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) FROM users WHERE username ='" + uname.Text + "' AND passwordd ='" + pass.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            try
            {
                if (dt.Rows[0][0].ToString() == "1")
                {
                    new main().Show();
                    this.Hide();
                }
                else if (uname.Text == "" && pass.Text == "")
                {
                    MessageBox.Show("Please Enter Username/Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (uname.Text == "")
                {
                    MessageBox.Show("Please Enter Username!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (pass.Text == "")
                {
                    MessageBox.Show("Please Enter Password!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Invalid Username/Password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("User Not Found../nTry Again", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void showpass_OnChange(object sender, EventArgs e)
        {
            if(showpass.Checked == true)
            {
                pass.isPassword = false;
            }
            else
            {
                pass.isPassword = true;
            }

        }

        private void clear_Click(object sender, EventArgs e)
        {
            uname.Text = " ";
            pass.Text = "";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void create__LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new signup().Show();
            this.Hide();

        }

        private void forgot__LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new forgot_password().Show();
            this.Hide();
        }
    }
}
