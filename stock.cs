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
    public partial class stock : UserControl
    {
        public stock()
        {
            InitializeComponent();
        }

        private void stock_searchchoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            String s1 = "ENTER PRODUCT ID";
            String s2 = "ENTER PRODUCT NAME";
            if (stock_searchchoice.Text == "By Product ID")
            {
                stock_displaylabel.Text = s1;
            }
            else if (stock_searchchoice.Text == "By Product Name")
            {
                stock_displaylabel.Text = s2;
            }
        }

        private void stock_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productTableAdapter.FillBy(this.bakeryDataSet20.product);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void stock_Load(object sender, EventArgs e)
        {
            show_data_on_grid();
        }
        public void show_data_on_grid()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4170OPL;Initial Catalog=bakery;Integrated Security=True");
            SqlCommand scom = new SqlCommand("SELECT product.product_name, product.product_id, stock.quantity FROM stock, product WHERE stock.product_id = product.product_id", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = scom.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            stock_datagrid.DataSource = dt;
            stock_datagrid.Columns[0].Width = 290;
            stock_datagrid.Columns[1].Width = 270;
            stock_datagrid.Columns[2].Width = 290;
            stock_datagrid.Columns[0].HeaderText = "Product NAME";
            stock_datagrid.Columns[1].HeaderText = "Product ID";
            stock_datagrid.Columns[2].HeaderText = "Quantity";

        }

        private void stock_showallbutton_Click(object sender, EventArgs e)
        {
            show_data_on_grid();
        }

        private void stock_searchbutton_Click(object sender, EventArgs e)
        {
            if (stock_displaylabel.Text == "ENTER PRODUCT ID")
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-4170OPL;Initial Catalog=bakery;Integrated Security=True");
                    SqlCommand scom = new SqlCommand("SELECT product.product_name, product.product_id, stock.quantity FROM stock, product WHERE stock.product_id = product.product_id AND product.product_id = @id", con);
                    scom.Parameters.AddWithValue("@p_id", stock_searchentry.Text);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader sdr = scom.ExecuteReader();
                    dt.Load(sdr);
                    con.Close();
                    MessageBox.Show("Data Found Successfully", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    stock_datagrid.DataSource = dt;
                    stock_datagrid.Columns[0].Width = 290;
                    stock_datagrid.Columns[1].Width = 270;
                    stock_datagrid.Columns[2].Width = 290;
                    stock_datagrid.Columns[0].HeaderText = "Product NAME";
                    stock_datagrid.Columns[1].HeaderText = "Product ID";
                    stock_datagrid.Columns[2].HeaderText = "Quantity";
                    stock_searchentry.Text = "";
                    stock_searchentry.Focus();
                }
                catch
                {
                    MessageBox.Show("Data Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (stock_displaylabel.Text == "ENTER PRODUCT NAME")
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-4170OPL;Initial Catalog=bakery;Integrated Security=True");
                    SqlCommand scom = new SqlCommand("SELECT product.product_name, product.product_id, stock.quantity FROM stock, product WHERE stock.product_id = product.product_id AND product.product_name = @p_name", con);
                    scom.Parameters.AddWithValue("@p_name", stock_searchentry.Text);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader sdr = scom.ExecuteReader();
                    dt.Load(sdr);
                    con.Close();
                    MessageBox.Show("Data Found Successfully", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    stock_datagrid.DataSource = dt;
                    stock_datagrid.Columns[0].Width = 290;
                    stock_datagrid.Columns[1].Width = 270;
                    stock_datagrid.Columns[2].Width = 290;
                    stock_datagrid.Columns[0].HeaderText = "Product NAME";
                    stock_datagrid.Columns[1].HeaderText = "Product ID";
                    stock_datagrid.Columns[2].HeaderText = "Quantity";
                    stock_searchentry.Text = "";
                    stock_searchentry.Focus();
                }
                catch
                {
                    MessageBox.Show("Data Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (stock_displaylabel.Text == "")
            {
                MessageBox.Show("Please Select Your Choice First.....!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                stock_searchentry.Text = "";
                stock_searchentry.Focus();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
