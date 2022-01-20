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
    public partial class sale_displaylabe : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-4170OPL;Initial Catalog=bakery;Integrated Security=True");
        public sale_displaylabe()
        {
            InitializeComponent();
        }
        public void product_combobox_populate()
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT product_id, product_name FROM product", con);
                con.Open();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sale_product_id.DataSource = dt;
                sale_product_id.DisplayMember = "product_name";
                sale_product_id.ValueMember = "product_id";
            }
            catch
            {
                MessageBox.Show("Something went wrong\n Check And Try Agin!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        
        private void sale_product_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4170OPL;Initial Catalog=bakery;Integrated Security=True");
            SqlCommand scom = new SqlCommand("SELECT purchase.purchase_rate FROM purchase, product WHERE purchase.product_id = product.product_id", con);
            con.Open();
            sale_rate.Text = scom.ExecuteScalar().ToString();
            con.Close();
            
            */
        }
        
        private void sale_Load(object sender, EventArgs e)
        {
            product_combobox_populate();
            sale_searchdate.Visible = false;
            add_to_list_hide();
            
        }

        public void add_to_list_hide()
        {
            sale_addtolistgrid.Visible = false;
            sale_save.Visible = false;
            sale_print.Visible = false;
            sale_discounttext.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            sale_grandtotaltext.Visible = false;
            label12.Visible = false;
            sale_subtotaltext.Visible = false;
            sale_balance.Visible = false;
            sale_paid.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            panel4.Visible = false;
        }
        public void add_to_list_show()
        {
            sale_addtolistgrid.Visible = true;
            sale_save.Visible = true;
            sale_print.Visible = true;
            sale_discounttext.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            sale_grandtotaltext.Visible = true;
            label12.Visible = true;
            sale_subtotaltext.Visible = true;
            sale_balance.Visible = true;
            sale_paid.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            panel4.Visible = true;
            sale_datagrid.Visible = false;
        }
        private void sale_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void show_data_on_grid()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4170OPL;Initial Catalog=bakery;Integrated Security=True");
            SqlCommand scom = new SqlCommand("SELECT * FROM sale", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = scom.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            sale_datagrid.DataSource = dt;
        }

        
        public void clear_all_fields()
        {
            sale_invoiceno.Text = "";
            sale_invoice_date.Text = "";
            sale_product_id.Text = "";
            sale_rate.Text = "";
            sale_quantity.Text = "";
            sale_discount.Text = "";
            sale_subtotal.Text = "";
            sale_grandtotal.Text = "";
        }

        
        private void sale_searchchoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            String s1 = "ENTER INVOICE NO";
            String s2 = "ENTER INVOICE DATE";
            String s3 = "ENTER PRODUCT ID";
            if (sale_searchchoice.Text == "By Invoice No")
            {
                sale_displaylabel.Text = s1;
                sale_searchentry.Visible = true;
                sale_searchdate.Visible = false;
                sale_searchentry.Focus();
            }
            else if (sale_searchchoice.Text == "By Invoice Date")
            {
                sale_displaylabel.Text = s2;
                sale_searchentry.Visible = false;
                sale_searchdate.Visible = true;
                sale_searchdate.Focus();
            }
            else if (sale_searchchoice.Text == "By Product ID")
            {
                sale_displaylabel.Text = s3;
                sale_searchentry.Visible = true;
                sale_searchdate.Visible = false;
                sale_searchentry.Focus();
            }
        }

        
        private void sale_datagrid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            sale_invoiceno.Text = sale_datagrid.SelectedRows[0].Cells[0].Value.ToString();
            sale_invoice_date.Text = sale_datagrid.SelectedRows[0].Cells[1].Value.ToString();
            sale_product_id.SelectedValue = sale_datagrid.SelectedRows[0].Cells[2].Value.ToString();
            sale_rate.Text = sale_datagrid.SelectedRows[0].Cells[3].Value.ToString();
            sale_quantity.Text = sale_datagrid.SelectedRows[0].Cells[4].Value.ToString();
            sale_discount.Text = sale_datagrid.SelectedRows[0].Cells[5].Value.ToString();
            sale_subtotal.Text = sale_datagrid.SelectedRows[0].Cells[6].Value.ToString();
            sale_grandtotal.Text = sale_datagrid.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void sale_subtotal_Click(object sender, EventArgs e)
        {
            
        }
        
        private void sale_subtotal_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void sale_quantity_Leave(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(sale_rate.Text) * Convert.ToInt32(sale_quantity.Text);
            sale_subtotal.Text = s.ToString();
        }

        private void sale_addtolistgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sale_paid_Leave(object sender, EventArgs e)
        {
            int a = int.Parse(sale_paid.Text) - int.Parse(sale_grandtotaltext.Text);
            sale_balance.Text = a.ToString();
        }

        private void sale_addtolist_Click_1(object sender, EventArgs e)
        {
            try
            {
                add_to_list_show();
                int n = sale_addtolistgrid.Rows.Add();
                sale_addtolistgrid.Rows[n].Cells[0].Value = sale_invoiceno.Text;
                sale_addtolistgrid.Rows[n].Cells[1].Value = sale_invoice_date.Text;
                sale_addtolistgrid.Rows[n].Cells[2].Value = sale_product_id.SelectedValue;
                sale_addtolistgrid.Rows[n].Cells[4].Value = sale_quantity.Text;
                sale_addtolistgrid.Rows[n].Cells[5].Value = sale_discount.Text;
                sale_addtolistgrid.Rows[n].Cells[3].Value = sale_rate.Text;
                sale_addtolistgrid.Rows[n].Cells[6].Value = sale_product_id.Text;
                sale_addtolistgrid.Rows[n].Cells[7].Value = sale_subtotal.Text;
                sale_addtolistgrid.Rows[n].Cells[8].Value = sale_grandtotal.Text;
                int sum_sub = 0;
                int sum_grand = 0;
                int sum_discount = 0;
                for (int i = 0; i < sale_addtolistgrid.Rows.Count; i++)
                {
                    sum_sub += Convert.ToInt32(sale_addtolistgrid.Rows[i].Cells[7].Value);
                    sum_grand += Convert.ToInt32(sale_addtolistgrid.Rows[i].Cells[8].Value);
                    sum_discount += (Convert.ToInt32(sale_addtolistgrid.Rows[i].Cells[7].Value) / 100) * Convert.ToInt32(sale_addtolistgrid.Rows[i].Cells[5].Value);
                }
                sale_subtotaltext.Text = sum_sub.ToString();
                sale_grandtotaltext.Text = sum_grand.ToString();
                sale_discounttext.Text = sum_discount.ToString();

            }
            catch
            {
                MessageBox.Show("Something went wrong\n Check And Try Agin!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sale_Addbutton_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-4170OPL;Initial Catalog=bakery;Integrated Security=True");
                SqlCommand s = new SqlCommand("Select quantity from stock WHERE product_id = '" + sale_product_id.SelectedValue + "'", con);
                con.Open();
                int temp = 0;
                temp = Convert.ToInt32(s.ExecuteScalar());
                con.Close();
                if (temp == 0)
                {
                    MessageBox.Show("No Stock Available", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int q = temp - Convert.ToInt32(sale_quantity.Text);
                    if (temp > Convert.ToInt32(sale_quantity.Text))
                    {
                        SqlCommand scom = new SqlCommand("INSERT INTO sale VALUES (@inv_no, @inv_date, @p_id, @sale_rate, @sale_quantity, @sale_discount, @s_total, @g_total)", con);
                        scom.Parameters.AddWithValue("@inv_no", sale_invoiceno.Text);
                        scom.Parameters.AddWithValue("@inv_date", sale_invoice_date.Text);
                        scom.Parameters.AddWithValue("@p_id", sale_product_id.SelectedValue);
                        scom.Parameters.AddWithValue("@sale_rate", sale_rate.Text);
                        scom.Parameters.AddWithValue("@sale_quantity", sale_quantity.Text);
                        scom.Parameters.AddWithValue("@sale_discount", sale_discount.Text);
                        scom.Parameters.AddWithValue("@s_total", sale_subtotal.Text);
                        scom.Parameters.AddWithValue("@g_total", sale_grandtotal.Text);
                        MessageBox.Show("Stock Sold Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        SqlCommand sc = new SqlCommand("UPDATE stock SET quantity = @p_quantity WHERE product_id = @p_id", con);
                        sc.Parameters.AddWithValue("@p_quantity", q);
                        sc.Parameters.AddWithValue("@p_id", sale_product_id.SelectedValue);
                        con.Open();
                        sc.ExecuteNonQuery();
                        scom.ExecuteNonQuery();
                        con.Close();

                        show_data_on_grid();
                        clear_all_fields();
                    }
                    else
                    {
                        MessageBox.Show("Sale Exceeds the Current Stock!!\nCurrent Available Stock is : " + temp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Someting went wrong..\nTry Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sale_updatebutton_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-4170OPL;Initial Catalog=bakery;Integrated Security=True");
                SqlCommand scom = new SqlCommand("UPDATE sale SET invoice_date = @inv_date, product_id = @p_id, sale_rate = @sale_rate, sale_quantity = @sale_quantity, sale_discount = @sale_discount, sub_total = @s_total, grand_total = @g_total WHERE invoice_no = @inv_no ", con);
                scom.Parameters.AddWithValue("@inv_date", sale_invoice_date.Text);
                scom.Parameters.AddWithValue("@p_id", sale_product_id.SelectedValue);
                scom.Parameters.AddWithValue("@sale_rate", sale_rate.Text);
                scom.Parameters.AddWithValue("@sale_quantity", sale_quantity.Text);
                scom.Parameters.AddWithValue("@sale_discount", sale_discount.Text);
                scom.Parameters.AddWithValue("@s_total", sale_subtotal.Text);
                scom.Parameters.AddWithValue("@g_total", sale_grandtotal.Text);
                scom.Parameters.AddWithValue("@inv_no", sale_invoiceno.Text);
                con.Open();
                scom.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Entry Updated Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                show_data_on_grid();
                clear_all_fields();
            }
            catch
            {
                MessageBox.Show("Something went wrong\nTry Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sale_searchbutton_Click_1(object sender, EventArgs e)
        {
            if (sale_displaylabel.Text == "ENTER INVOICE NO")
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-4170OPL;Initial Catalog=bakery;Integrated Security=True");
                    SqlCommand scom = new SqlCommand("SELECT * FROM sale WHERE invoice_no = @inv_no", con);
                    scom.Parameters.AddWithValue("@inv_no", sale_searchentry.Text);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader sdr = scom.ExecuteReader();
                    dt.Load(sdr);
                    con.Close();
                    MessageBox.Show("Data Found Successfully", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sale_datagrid.DataSource = dt;
                    sale_searchentry.Text = "";
                    sale_searchentry.Focus();
                }
                catch
                {
                    MessageBox.Show("Data Not Found./nTry Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (sale_displaylabel.Text == "ENTER INVOICE DATE")
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-4170OPL;Initial Catalog=bakery;Integrated Security=True");
                    SqlCommand scom = new SqlCommand("SELECT * FROM sale WHERE invoice_date = @inv_date", con);
                    scom.Parameters.AddWithValue("@inv_date", sale_searchdate.Text);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader sdr = scom.ExecuteReader();
                    dt.Load(sdr);
                    con.Close();
                    MessageBox.Show("Data Found Successfully", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sale_datagrid.DataSource = dt;
                    sale_searchentry.Text = "";
                    sale_searchentry.Focus();
                }
                catch
                {
                    MessageBox.Show("Data Not Found./nTry Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (sale_displaylabel.Text == "ENTER PRODUCT ID")
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-4170OPL;Initial Catalog=bakery;Integrated Security=True");
                    SqlCommand scom = new SqlCommand("SELECT * FROM sale WHERE product_id = @p_id", con);
                    scom.Parameters.AddWithValue("@p_id", sale_searchentry.Text);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader sdr = scom.ExecuteReader();
                    dt.Load(sdr);
                    con.Close();
                    MessageBox.Show("Data Found Successfully", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sale_datagrid.DataSource = dt;
                    sale_searchentry.Text = "";
                    sale_searchentry.Focus();
                }
                catch
                {
                    MessageBox.Show("Data Not Found./nTry Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Please Select Your Choice First.....!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                sale_searchentry.Text = "";
                sale_searchentry.Focus();
            }
        }

        private void sale_deletebutton_Click_1(object sender, EventArgs e)
        {
            try
            {
                string message = "Do you really want to Delete Entry?";
                string title = "Delete Entry";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-4170OPL;Initial Catalog=bakery;Integrated Security=True");
                    SqlCommand scom = new SqlCommand("DELETE FROM sale WHERE invoice_no = @inv_no ", con);
                    scom.Parameters.AddWithValue("@inv_no", sale_invoiceno.Text);
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
                MessageBox.Show("Something went wrong\nTry Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sale_clearbutton_Click_1(object sender, EventArgs e)
        {
            clear_all_fields();
        }

        private void sale_showallbutton_Click_1(object sender, EventArgs e)
        {
            show_data_on_grid();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void sale_save_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-4170OPL;Initial Catalog=bakery;Integrated Security=True");
                for (int i = 0; i < sale_addtolistgrid.Rows.Count - 1; i++)
                {
                    SqlCommand s = new SqlCommand("Select quantity from stock WHERE product_id = '" + sale_addtolistgrid.Rows[i].Cells["pr_id"].Value + "'", con);
                    con.Open();
                    int temp = 0;
                    temp = Convert.ToInt32(s.ExecuteScalar());
                    con.Close();
                    if (temp == 0)
                    {
                        MessageBox.Show("No Stock Available", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int q = temp - Convert.ToInt32(sale_quantity.Text);
                        if (temp > Convert.ToInt32(sale_quantity.Text))
                        {
                            SqlCommand scom = new SqlCommand("INSERT INTO sale(invoice_no, invoice_date, product_id, sale_rate, sale_quantity, sale_discount, sub_total, grand_total) VALUES ('" + sale_addtolistgrid.Rows[i].Cells["inv_number"].Value + "','" + sale_addtolistgrid.Rows[i].Cells["inv_date"].Value + "', '" + sale_addtolistgrid.Rows[i].Cells["pr_id"].Value + "', '" + sale_addtolistgrid.Rows[i].Cells["price"].Value + "', '" + sale_addtolistgrid.Rows[i].Cells["quantity"].Value + "', '" + sale_addtolistgrid.Rows[i].Cells["discount"].Value + "',  '" + sale_addtolistgrid.Rows[i].Cells["s_total"].Value + "',  '" + sale_addtolistgrid.Rows[i].Cells["g_total"].Value + "')", con);
                            MessageBox.Show("Stock Sold Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            SqlCommand sc = new SqlCommand("UPDATE stock SET quantity = @p_quantity WHERE product_id = @p_id", con);
                            sc.Parameters.AddWithValue("@p_quantity", q);
                            sc.Parameters.AddWithValue("@p_id", sale_addtolistgrid.Rows[i].Cells["pr_id"].Value);
                            con.Open();
                            sc.ExecuteNonQuery();
                            scom.ExecuteNonQuery();
                            con.Close();

                            show_data_on_grid();
                        }
                        else
                        {
                            MessageBox.Show("Sale Exceeds the Current Stock!!\nCurrent Available Stock is : " + temp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }

            }
            catch
            {
                MessageBox.Show("Something went wrong\nTry Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sale_discount_Leave_1(object sender, EventArgs e)
        {
            int s = (Convert.ToInt32(sale_subtotal.Text) / 100) * Convert.ToInt32(sale_discount.Text);
            int s1 = Convert.ToInt32(sale_subtotal.Text) - s;
            sale_grandtotal.Text = s1.ToString();
        }

        private void sale_addtolistback_Click(object sender, EventArgs e)
        {
            add_to_list_hide();
            sale_datagrid.Visible = true;
        }
    }
}
