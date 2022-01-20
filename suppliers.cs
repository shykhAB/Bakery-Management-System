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
    public partial class suppliers : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-4170OPL;Initial Catalog=bakery;Integrated Security=True");
        public suppliers()
        {
            InitializeComponent();
        }

        private void supplier_searchchoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            String s1 = "ENTER SUPPLIER ID";
            String s2 = "ENTER SUPPLIER NAME";
            String s3 = "ENTER CITY NAME";
            if (supplier_searchchoice.Text == "By Supplier ID")
            {
                supplier_displaylabel.Text = s1;
            }
            else if (supplier_searchchoice.Text == "By Supplier Name")
            {
                supplier_displaylabel.Text = s2;
            }
            else if (supplier_searchchoice.Text == "By City")
            {
                supplier_displaylabel.Text = s3;
            }
        }

        
        public void show_data_on_grid()
        {
            SqlCommand scom = new SqlCommand("SELECT * FROM supplier", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = scom.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            supplier_datagrid.DataSource = dt;
        }

        private void suppliers_Load(object sender, EventArgs e)
        {

        }

       

        private void supplier_datagrid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            supplier_supplierid.Text = supplier_datagrid.SelectedRows[0].Cells[0].Value.ToString();
            supplier_suppliername.Text = supplier_datagrid.SelectedRows[0].Cells[1].Value.ToString();
            supplier_city.Text = supplier_datagrid.SelectedRows[0].Cells[2].Value.ToString();
            supplier_address.Text = supplier_datagrid.SelectedRows[0].Cells[3].Value.ToString();
            supplier_email.Text = supplier_datagrid.SelectedRows[0].Cells[4].Value.ToString();
            supplier_contactno.Text = supplier_datagrid.SelectedRows[0].Cells[5].Value.ToString();
        }

        public void clear_all_fields()
        {
            supplier_supplierid.Text = "";
            supplier_suppliername.Text = "";
            supplier_city.Text = "";
            supplier_contactno.Text = "";
            supplier_email.Text = "";
            supplier_address.Text = "";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void supplier_addbutton_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand scom = new SqlCommand("INSERT INTO supplier VALUES (@s_id, @s_name, @city, @address, @email, @contactno)", con);
                scom.Parameters.AddWithValue("@s_id", supplier_supplierid.Text);
                scom.Parameters.AddWithValue("@s_name", supplier_suppliername.Text);
                scom.Parameters.AddWithValue("@city", supplier_city.Text);
                scom.Parameters.AddWithValue("@address", supplier_address.Text);
                scom.Parameters.AddWithValue("@email", supplier_email.Text);
                scom.Parameters.AddWithValue("@contactno", supplier_contactno.Text);

                con.Open();
                scom.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Supplier is Added Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                show_data_on_grid();
                clear_all_fields();
            }
            catch
            {
                MessageBox.Show("Something went wrong.\nTry Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void supplier_showallbutton_Click_1(object sender, EventArgs e)
        {
            show_data_on_grid();
        }

        private void supplier_updatebutton_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand scom = new SqlCommand("UPDATE supplier SET supplier_name = @s_name, city = @city, addresss = @address, email = @email, contact = @contactno WHERE supplier_id = @s_id ", con);
                scom.Parameters.AddWithValue("@s_name", supplier_suppliername.Text);
                scom.Parameters.AddWithValue("@city", supplier_city.Text);
                scom.Parameters.AddWithValue("@address", supplier_address.Text);
                scom.Parameters.AddWithValue("@email", supplier_email.Text);
                scom.Parameters.AddWithValue("@contactno", supplier_contactno.Text);
                scom.Parameters.AddWithValue("@s_id", supplier_supplierid.Text);
                con.Open();
                scom.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Supplier Updated Successfully", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                show_data_on_grid();
                clear_all_fields();
            }
            catch
            {
                MessageBox.Show("Something went wrong.\nTry Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void supplier_searchbutton_Click_1(object sender, EventArgs e)
        {
            if (supplier_displaylabel.Text == "ENTER SUPPLIER ID")
            {
                try
                {
                    SqlCommand scom = new SqlCommand("SELECT * FROM supplier WHERE supplier_id = @s_id", con);
                    scom.Parameters.AddWithValue("@s_id", supplier_searchentry.Text);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader sdr = scom.ExecuteReader();
                    dt.Load(sdr);
                    con.Close();
                    MessageBox.Show("Data Found Successfully", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    supplier_datagrid.DataSource = dt;
                    supplier_searchentry.Text = "";
                    supplier_searchentry.Focus();
                }
                catch
                {
                    MessageBox.Show("Data Not Found.\nTry Again..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (supplier_displaylabel.Text == "ENTER SUPPLIER NAME")
            {
                try
                {
                    SqlCommand scom = new SqlCommand("SELECT * FROM supplier WHERE supplier_name = @s_name", con);
                    scom.Parameters.AddWithValue("@s_name", supplier_searchentry.Text);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader sdr = scom.ExecuteReader();
                    dt.Load(sdr);
                    con.Close();
                    MessageBox.Show("Data Found Successfully", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    supplier_datagrid.DataSource = dt;
                    supplier_searchentry.Text = "";
                    supplier_searchentry.Focus();
                }
                catch
                {
                    MessageBox.Show("Data Not Found.\nTry Again..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (supplier_displaylabel.Text == "ENTER CITY NAME")
            {
                try
                {
                    SqlCommand scom = new SqlCommand("SELECT * FROM supplier WHERE city = @city", con);
                    scom.Parameters.AddWithValue("@city", supplier_searchentry.Text);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader sdr = scom.ExecuteReader();
                    dt.Load(sdr);
                    con.Close();
                    MessageBox.Show("Data Found Successfully", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    supplier_datagrid.DataSource = dt;
                    supplier_searchentry.Text = "";
                    supplier_searchentry.Focus();
                }
                catch
                {
                    MessageBox.Show("Data Not Found.\nTry Again..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else if (supplier_displaylabel.Text == "")
            {
                MessageBox.Show("Please Select Your Choice First.....!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                supplier_searchentry.Text = "";
                supplier_searchentry.Focus();
            }
        }

        private void supplier_deletebutton_Click_1(object sender, EventArgs e)
        {
            try
            {
                string message = "Do you really want to Delete Supplier?";
                string title = "Delete Supplier";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    SqlCommand scom = new SqlCommand("DELETE FROM supplier WHERE supplier_id = @s_id ", con);
                    scom.Parameters.AddWithValue("@s_id", supplier_supplierid.Text);
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
                MessageBox.Show("Something went wrong.\nTry Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void supplier_clearbutton_Click_1(object sender, EventArgs e)
        {
            clear_all_fields();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
