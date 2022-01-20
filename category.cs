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
    public partial class category : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-4170OPL;Initial Catalog=bakery;Integrated Security=True");
        public category()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void category_searchchoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            String s1 = "ENTER CATEGORY ID";
            String s2 = "ENTER CATEGORY NAME";
            if (category_searchchoice.Text == "By Category ID")
            {
                category_displaylabel.Text = s1;
            }
            else if (category_searchchoice.Text == "By Category Name")
            {
                category_displaylabel.Text = s2;
            }
        }

        
        public void show_data_on_grid()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4170OPL;Initial Catalog=bakery;Integrated Security=True");
            SqlCommand scom = new SqlCommand("SELECT * FROM category", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = scom.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            category_datagrid.DataSource = dt;
        }

        private void category_Load(object sender, EventArgs e)
        {
            
        }

        
        private void category_datagrid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            category_categoryid.Text = category_datagrid.SelectedRows[0].Cells[0].Value.ToString();
            category_categoryname.Text = category_datagrid.SelectedRows[0].Cells[1].Value.ToString();
            category_status.Text = category_datagrid.SelectedRows[0].Cells[2].Value.ToString();
        }

        
        public void clear_all_fields()
        {
            category_categoryid.Text = "";
            category_categoryname.Text = "";
            category_status.Text = "";
            category_categoryid.Focus();
        }

        private void category_addbutton_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand scom = new SqlCommand("INSERT INTO category VALUES (@c_id, @c_name, @status)", con);
                scom.Parameters.AddWithValue("@c_id", category_categoryid.Text);
                scom.Parameters.AddWithValue("@c_name", category_categoryname.Text);
                scom.Parameters.AddWithValue("@status", category_status.Text);

                con.Open();
                scom.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Category is Added Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                show_data_on_grid();
                clear_all_fields();
            }
            catch
            {
                MessageBox.Show("Something went Wrong/n Try Again..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void category_showallbutton_Click_1(object sender, EventArgs e)
        {
            show_data_on_grid();
        }

        private void category_searchbutton_Click_1(object sender, EventArgs e)
        {
            if (category_displaylabel.Text == "ENTER CATEGORY ID")
            {
                try
                {
                    SqlCommand scom = new SqlCommand("SELECT * FROM category WHERE category_id = @c_id", con);
                    scom.Parameters.AddWithValue("@c_id", category_searchentry.Text);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader sdr = scom.ExecuteReader();
                    dt.Load(sdr);
                    con.Close();
                    MessageBox.Show("Data Found Successfully", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    category_datagrid.DataSource = dt;
                    category_searchentry.Text = "";
                    category_searchentry.Focus();
                }
                catch
                {
                    MessageBox.Show("Not Found../nTry Again!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (category_displaylabel.Text == "ENTER CATEGORY NAME")
            {
                try
                {
                    SqlCommand scom = new SqlCommand("SELECT * FROM category WHERE LOWER(category_name) = @c_name", con);
                    scom.Parameters.AddWithValue("@c_name", category_searchentry.Text);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader sdr = scom.ExecuteReader();
                    dt.Load(sdr);
                    con.Close();
                    MessageBox.Show("Data Found Successfully", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    category_datagrid.DataSource = dt;
                    category_searchentry.Text = "";
                    category_searchentry.Focus();
                }
                catch
                {
                    MessageBox.Show("Not Found../nTry Again!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (category_displaylabel.Text == "")
            {
                MessageBox.Show("Please Select Your Choice First.....!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                category_searchentry.Text = "";
                category_searchentry.Focus();
            }
        }

        private void category_updatebutton_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-4170OPL;Initial Catalog=bakery;Integrated Security=True");
                SqlCommand scom = new SqlCommand("UPDATE category SET category_name = @c_name, statuss = @status WHERE category_id = @c_id ", con);
                scom.Parameters.AddWithValue("@c_name", category_categoryname.Text);
                scom.Parameters.AddWithValue("@status", category_status.Text);
                scom.Parameters.AddWithValue("@c_id", category_categoryid.Text);
                con.Open();
                scom.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Category Updated Successfully", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                show_data_on_grid();
                clear_all_fields();
            }
            catch
            {
                MessageBox.Show("Something went wrong/nTry Again...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void category_deletebutton_Click_1(object sender, EventArgs e)
        {
            try
            {
                string message = "Do you really want to Delete Category?";
                string title = "Delete Category";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-4170OPL;Initial Catalog=bakery;Integrated Security=True");
                    SqlCommand scom = new SqlCommand("DELETE FROM category WHERE category_id = @c_id ", con);
                    scom.Parameters.AddWithValue("@c_id", category_categoryid.Text);
                    con.Open();
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
                MessageBox.Show("Category Not Found./nTry Again..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void category_clearbutton_Click_1(object sender, EventArgs e)
        {
            clear_all_fields();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
