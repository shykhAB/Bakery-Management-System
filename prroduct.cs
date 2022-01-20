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
    public partial class prroduct : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-4170OPL;Initial Catalog=bakery;Integrated Security=True");
        public prroduct()
        {
            InitializeComponent();
        }

        

        public void combobox_populate()
        { 
            SqlDataAdapter sda = new SqlDataAdapter("SELECT category_id, category_name FROM category", con);
            con.Open();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            product_category_id.DataSource = dt;
            product_category_id.DisplayMember = "category_name";
            product_category_id.ValueMember = "category_id";

        }

        private void prroduct_Load(object sender, EventArgs e)
        {
            combobox_populate();
        }

        private void product_category_id_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public void show_data_on_grid()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4170OPL;Initial Catalog=bakery;Integrated Security=True");
            SqlCommand scom = new SqlCommand("SELECT * FROM product", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = scom.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            product_datagrid.DataSource = dt;
        }

       
        private void product_datagrid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            product_productid.Text = product_datagrid.SelectedRows[0].Cells[0].Value.ToString();
            product_productname.Text = product_datagrid.SelectedRows[0].Cells[1].Value.ToString();
            product_category_id.SelectedValue = product_datagrid.SelectedRows[0].Cells[2].Value.ToString();


        }

        public void clear_all_fields()
        {
            product_productid.Text = "";
            product_productname.Text = "";
            product_category_id.Text = "";
            product_productid.Focus();
        }

       
        private void product_searchchoice_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            String s1 = "ENTER PRODUCT ID";
            String s2 = "ENTER PRODUCT NAME";
            if (product_searchchoice.Text == "By Product ID")
            {
                product_displaylabel.Text = s1;
            }
            else if (product_searchchoice.Text == "By Product Name")
            {
                product_displaylabel.Text = s2;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void product_addbutton_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand scom = new SqlCommand("INSERT INTO product VALUES (@p_id, @p_name, @c_id)", con);
                scom.Parameters.AddWithValue("@p_id", product_productid.Text);
                scom.Parameters.AddWithValue("@p_name", product_productname.Text);
                scom.Parameters.AddWithValue("@c_id", product_category_id.SelectedValue);

                con.Open();
                scom.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Product is Added Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                show_data_on_grid();
                clear_all_fields();
            }
            catch
            {
                MessageBox.Show("Something went wrong.\nTry Again!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void product_showallbutton_Click_1(object sender, EventArgs e)
        {
            show_data_on_grid();
        }

        private void product_searchbutton_Click_1(object sender, EventArgs e)
        {
            if (product_displaylabel.Text == "ENTER PRODUCT ID")
            {
                try
                {
                    SqlCommand scom = new SqlCommand("SELECT * FROM product WHERE product_id = @p_id", con);
                    scom.Parameters.AddWithValue("@p_id", product_searchentry.Text);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader sdr = scom.ExecuteReader();
                    dt.Load(sdr);
                    con.Close();
                    MessageBox.Show("Data Found Successfully", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    product_datagrid.DataSource = dt;
                    product_searchentry.Text = "";
                    product_searchentry.Focus();
                }
                catch
                {
                    MessageBox.Show("Data Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (product_displaylabel.Text == "ENTER PRODUCT NAME")
            {
                try
                {
                    SqlCommand scom = new SqlCommand("SELECT * FROM product WHERE product_name = @p_name", con);
                    scom.Parameters.AddWithValue("@p_name", product_searchentry.Text);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader sdr = scom.ExecuteReader();
                    dt.Load(sdr);
                    con.Close();
                    MessageBox.Show("Data Found Successfully", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    product_datagrid.DataSource = dt;
                    product_searchentry.Text = "";
                    product_searchentry.Focus();
                }
                catch
                {
                    MessageBox.Show("Data Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (product_displaylabel.Text == "")
            {
                MessageBox.Show("Please Select Your Choice First.....!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                product_searchentry.Text = "";
                product_searchentry.Focus();
            }
        }

        private void product_updatebutton_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-4170OPL;Initial Catalog=bakery;Integrated Security=True");
                SqlCommand scom = new SqlCommand("UPDATE product SET product_name = @p_name, category_id = @c_id WHERE product_id = @p_id ", con);
                scom.Parameters.AddWithValue("@p_name", product_productname.Text);
                scom.Parameters.AddWithValue("@c_id", product_category_id.Text);
                scom.Parameters.AddWithValue("@p_id", product_productid.Text);
                con.Open();
                scom.ExecuteNonQuery();
                con.Close();

                show_data_on_grid();
                clear_all_fields();
            }
            catch
            {
                MessageBox.Show("Something went wrong.\nTry Again!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void product_deletebutton_Click_1(object sender, EventArgs e)
        {
            try
            {

                string message = "Do you really want to Delete Product?";
                string title = "Delete Product";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    SqlCommand scom = new SqlCommand("DELETE FROM product WHERE product_id = @p_id ", con);
                    scom.Parameters.AddWithValue("@p_id", product_productid.Text);
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
                MessageBox.Show("Something went wrong.\nTry Again!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void product_clearbutton_Click_1(object sender, EventArgs e)
        {
            clear_all_fields();
        }
        private void product_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}