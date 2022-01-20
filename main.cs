using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            suppliers1.Hide();
            stock1.Hide();
            user1.Hide();
            changepassword1.Hide();
            category1.Hide();
            prroduct1.Hide();
            purchase1.Hide();
            sale1.Hide();
        }

       
        

        private void panelmenu_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void main_salebutton_Click_1(object sender, EventArgs e)
        {
            sale1.Show();
            suppliers1.Hide();
            user1.Hide();
            changepassword1.Hide();
            category1.Hide();
            prroduct1.Hide();
            purchase1.Hide();
            stock1.Hide();
        }

        private void main_purchasebutton_Click_1(object sender, EventArgs e)
        {
            purchase1.Show();
            changepassword1.Hide();
            suppliers1.Hide();
            stock1.Hide();
            user1.Hide();
            category1.Hide();
            prroduct1.Hide();
            sale1.Hide();
        }

        private void main_stockbutton_Click_1(object sender, EventArgs e)
        {
            stock1.Show();
            suppliers1.Hide();
            user1.Hide();
            changepassword1.Hide();
            category1.Hide();
            prroduct1.Hide();
            purchase1.Hide();
            sale1.Hide();
        }

        private void main_categorybutton_Click_1(object sender, EventArgs e)
        {
            category1.Show();
            suppliers1.Hide();
            stock1.Hide();
            user1.Hide();
            changepassword1.Hide();
            prroduct1.Hide();
            purchase1.Hide();
            sale1.Hide();
        }

        private void main_productbutton_Click_1(object sender, EventArgs e)
        {
            prroduct1.Show();
            suppliers1.Hide();
            stock1.Hide();
            user1.Hide();
            changepassword1.Hide();
            category1.Hide();
            purchase1.Hide();
            sale1.Hide();
        }

        private void main_supplierbutton_Click_1(object sender, EventArgs e)
        {
            suppliers1.Show();
            stock1.Hide();
            user1.Hide();
            changepassword1.Hide();
            category1.Hide();
            prroduct1.Hide();
            purchase1.Hide();
            sale1.Hide();
        }

        private void main_userbutton_Click_1(object sender, EventArgs e)
        {
            user1.Show();
            suppliers1.Hide();
            stock1.Hide();
            changepassword1.Hide();
            category1.Hide();
            prroduct1.Hide();
            purchase1.Hide();
            sale1.Hide();
        }

        private void main_changepassbutton_Click_1(object sender, EventArgs e)
        {
            changepassword1.Show();
            suppliers1.Hide();
            stock1.Hide();
            user1.Hide();
            category1.Hide();
            prroduct1.Hide();
            purchase1.Hide();
            sale1.Hide();
        }

        private void main_exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
