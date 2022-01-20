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
    public partial class purchase : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-4170OPL;Initial Catalog=bakery;Integrated Security=True");
        public purchase()
        {
            InitializeComponent();
        }
        public void product_combobox_populate()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4170OPL;Initial Catalog=bakery;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT product_id, product_name FROM product", con);
            con.Open();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            purchase_product_id.DataSource = dt;
            purchase_product_id.DisplayMember = "product_name";
            purchase_product_id.ValueMember = "product_id";

        }
        public void supplier_combobox_populate()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4170OPL;Initial Catalog=bakery;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT supplier_id, supplier_name FROM supplier", con);
            con.Open();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            purchase_supplierid.DataSource = dt;
            purchase_supplierid.DisplayMember = "supplier_name";
            purchase_supplierid.ValueMember = "supplier_id";

        }

        private void purchase_Load(object sender, EventArgs e)
        {
            product_combobox_populate();
            supplier_combobox_populate();
        }

        public void show_data_on_grid()
        {
            SqlCommand scom = new SqlCommand("SELECT * FROM purchase", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = scom.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            purchase_datagrid.DataSource = dt;
        }

        private void purchase_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            purchase_purchaseid.Text = purchase_datagrid.SelectedRows[0].Cells[0].Value.ToString();
            purchase_date.Text = purchase_datagrid.SelectedRows[0].Cells[1].Value.ToString();
            purchase_method.Text = purchase_datagrid.SelectedRows[0].Cells[2].Value.ToString();
            purchase_rate.Text = purchase_datagrid.SelectedRows[0].Cells[3].Value.ToString();
            purchase_quantity.Text = purchase_datagrid.SelectedRows[0].Cells[4].Value.ToString();
            purchase_discount.Text = purchase_datagrid.SelectedRows[0].Cells[5].Value.ToString();
            purchase_product_id.SelectedValue = purchase_datagrid.SelectedRows[0].Cells[6].Value.ToString();
            purchase_supplierid.SelectedValue = purchase_datagrid.SelectedRows[0].Cells[7].Value.ToString();
            purchase_subtotal.Text = purchase_datagrid.SelectedRows[0].Cells[8].Value.ToString();
            purchase_grandtotal.Text = purchase_datagrid.SelectedRows[0].Cells[9].Value.ToString();
        }

        public void clear_all_fields()
        {
            purchase_purchaseid.Text = "";
            purchase_date.Text = "";
            purchase_method.Text = "";
            purchase_rate.Text = "";
            purchase_quantity.Text = "";
            purchase_discount.Text = "";
            purchase_product_id.Text = "";
            purchase_supplierid.Text = "";
            purchase_subtotal.Text = "";
            purchase_grandtotal.Text = "";
            purchase_purchaseid.Focus();

        }

        private void purchase_searchchoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            String s1 = "ENTER PURCHASE ID";
            String s2 = "ENTER PURCHASE DATE";
            String s3 = "ENTER PRODUCT ID";
            String s4 = "ENTER SUPPLIER ID";
            if (purchase_searchchoice.Text == "By Purchase ID")
            {
                purchase_displaylabel.Text = s1;
                purchase_searchentry.Visible = true;
                purchase_searchdate.Visible = false;
                purchase_searchentry.Focus();
            }
            else if (purchase_searchchoice.Text == "By Purchase Date")
            {
                purchase_displaylabel.Text = s2;
                purchase_searchentry.Visible = false;
                purchase_searchdate.Visible = true;
                purchase_searchdate.Focus();
            }
            else if (purchase_searchchoice.Text == "By Product ID")
            {
                purchase_displaylabel.Text = s3;
                purchase_searchentry.Visible = true;
                purchase_searchdate.Visible = false;
                purchase_searchentry.Focus();
            }
            else if (purchase_searchchoice.Text == "By Supplier ID")
            {
                purchase_displaylabel.Text = s4;
                purchase_searchentry.Visible = true;
                purchase_searchdate.Visible = false;
                purchase_searchentry.Focus();
            }
        }

        private void purchase_quantity_Leave(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(purchase_rate.Text) * Convert.ToInt32(purchase_quantity.Text);
            purchase_subtotal.Text = s.ToString();
        }

        private void purchase_discount_Leave(object sender, EventArgs e)
        {
            int s = (Convert.ToInt32(purchase_subtotal.Text) / 100) * Convert.ToInt32(purchase_discount.Text);
            int s1 = Convert.ToInt32(purchase_subtotal.Text) - s;
            purchase_grandtotal.Text = s1.ToString();
        }

        private void purchase_addbutton_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-4170OPL;Initial Catalog=bakery;Integrated Security=True");
                SqlCommand scom = new SqlCommand("INSERT INTO purchase VALUES (@id, @p_date, @p_method, @p_rate, @p_quantity, @p_discount, @p_id, @s_id, @s_total, @g_total)", con);
                scom.Parameters.AddWithValue("@id", purchase_purchaseid.Text);
                scom.Parameters.AddWithValue("@p_date", purchase_date.Text);
                scom.Parameters.AddWithValue("@p_method", purchase_method.Text);
                scom.Parameters.AddWithValue("@p_rate", purchase_rate.Text);
                scom.Parameters.AddWithValue("@p_quantity", purchase_quantity.Text);
                scom.Parameters.AddWithValue("@p_discount", purchase_discount.Text);
                scom.Parameters.AddWithValue("@p_id", purchase_product_id.SelectedValue);
                scom.Parameters.AddWithValue("@s_id", purchase_supplierid.SelectedValue);
                scom.Parameters.AddWithValue("@s_total", purchase_subtotal.Text);
                scom.Parameters.AddWithValue("@g_total", purchase_grandtotal.Text);
                SqlCommand s = new SqlCommand("Select quantity from stock WHERE product_id = '" + purchase_product_id.SelectedValue + "'", con);
                con.Open();
                int temp = 0;
                temp = Convert.ToInt32(s.ExecuteScalar());
                con.Close();
                if (temp == 0)
                {
                    SqlCommand scc = new SqlCommand("INSERT INTO stock VALUES (@p_quantity, @p_id)", con);
                    scc.Parameters.AddWithValue("@p_quantity", purchase_quantity.Text);
                    scc.Parameters.AddWithValue("@p_id", purchase_product_id.SelectedValue);
                    con.Open();
                    scc.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    int q = temp + Convert.ToInt32(purchase_quantity.Text);
                    SqlCommand sc = new SqlCommand("UPDATE stock SET quantity = @p_quantity WHERE product_id = @p_id", con);
                    sc.Parameters.AddWithValue("@p_quantity", q);
                    sc.Parameters.AddWithValue("@p_id", purchase_product_id.SelectedValue);
                    con.Open();
                    sc.ExecuteNonQuery();
                    con.Close();
                }

                con.Open();
                scom.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Stock Purchased Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                show_data_on_grid();
                clear_all_fields();
            }
            catch
            {
                MessageBox.Show("Something went wrong!!/nTry Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void purchase_showallbutton_Click_1(object sender, EventArgs e)
        {
            show_data_on_grid();
        }

        private void purchase_updatebutton_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand scom = new SqlCommand("UPDATE purchase SET purchase_date = @p_date, payment_method = @p_method, purchase_rate = @p_rate, purchase_quantity = @p_quantity, purchase_discount = @p_discount, product_id = @p_id, supplier_id = @s_id, sub_total = @s_total, grand_total = @g_total WHERE purchase_id = @id ", con);
                scom.Parameters.AddWithValue("@p_date", purchase_date.Text);
                scom.Parameters.AddWithValue("@p_method", purchase_method.Text);
                scom.Parameters.AddWithValue("@p_rate", purchase_rate.Text);
                scom.Parameters.AddWithValue("@p_quantity", purchase_quantity.Text);
                scom.Parameters.AddWithValue("@p_discount", purchase_discount.Text);
                scom.Parameters.AddWithValue("@p_id", purchase_product_id.SelectedValue);
                scom.Parameters.AddWithValue("@s_id", purchase_supplierid.SelectedValue);
                scom.Parameters.AddWithValue("@s_total", purchase_subtotal.Text);
                scom.Parameters.AddWithValue("@g_total", purchase_grandtotal.Text);
                scom.Parameters.AddWithValue("@id", purchase_purchaseid.Text);
                con.Open();
                scom.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Entry Updated Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                show_data_on_grid();
                clear_all_fields();
            }
            catch
            {
                MessageBox.Show("Something went wrong..\nTry Again!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void purchase_searchbutton_Click_1(object sender, EventArgs e)
        {
            if (purchase_displaylabel.Text == "ENTER PURCHASE ID")
            {
                try
                {
                    SqlCommand scom = new SqlCommand("SELECT * FROM purchase WHERE purchase_id = @id", con);
                    scom.Parameters.AddWithValue("@id", purchase_searchentry.Text);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader sdr = scom.ExecuteReader();
                    dt.Load(sdr);
                    con.Close();
                    MessageBox.Show("Data Found Successfully", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    purchase_datagrid.DataSource = dt;
                    purchase_searchentry.Text = "";
                    purchase_searchentry.Focus();
                }
                catch
                {
                    MessageBox.Show("Not Found../nTry Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (purchase_displaylabel.Text == "ENTER PURCHASE DATE")
            {
                try
                {
                    SqlCommand scom = new SqlCommand("SELECT * FROM purchase WHERE purchase_date = @p_date", con);
                    scom.Parameters.AddWithValue("@p_date", purchase_searchdate.Text);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader sdr = scom.ExecuteReader();
                    dt.Load(sdr);
                    con.Close();
                    MessageBox.Show("Data Found Successfully", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    purchase_datagrid.DataSource = dt;
                    purchase_searchentry.Text = "";
                    purchase_searchentry.Focus();
                }
                catch
                {
                    MessageBox.Show("Not Found../nTry Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (purchase_displaylabel.Text == "ENTER PRODUCT ID")
            {
                try
                {
                    SqlCommand scom = new SqlCommand("SELECT * FROM purchase WHERE product_id = @p_id", con);
                    scom.Parameters.AddWithValue("@p_id", purchase_searchentry.Text);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader sdr = scom.ExecuteReader();
                    dt.Load(sdr);
                    con.Close();
                    MessageBox.Show("Data Found Successfully", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    purchase_datagrid.DataSource = dt;
                    purchase_searchentry.Text = "";
                    purchase_searchentry.Focus();
                }
                catch
                {
                    MessageBox.Show("Not Found../nTry Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (purchase_displaylabel.Text == "ENTER SUPPLIER ID")
            {
                try
                {
                    SqlCommand scom = new SqlCommand("SELECT * FROM purchase WHERE supplier_id = @s_id", con);
                    scom.Parameters.AddWithValue("@s_id", purchase_searchentry.Text);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader sdr = scom.ExecuteReader();
                    dt.Load(sdr);
                    con.Close();
                    MessageBox.Show("Data Found Successfully", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    purchase_datagrid.DataSource = dt;
                    purchase_searchentry.Text = "";
                    purchase_searchentry.Focus();
                }
                catch
                {
                    MessageBox.Show("Not Found../nTry Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please Select Your Choice First.....!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                purchase_searchentry.Text = "";
                purchase_searchentry.Focus();
            }
        }

        private void purchase_deletebutton_Click_1(object sender, EventArgs e)
        {
            try
            {
                string message = "Do you really want to Delete Entry?";
                string title = "Delete Entry";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    SqlCommand scom = new SqlCommand("DELETE FROM purchase WHERE purchase_id = @id ", con);
                    scom.Parameters.AddWithValue("@id", purchase_purchaseid.Text); con.Open();
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
                MessageBox.Show("Something went wrong../nTry Again!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void purchase_clearbutton_Click_1(object sender, EventArgs e)
        {
            clear_all_fields();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
