namespace project
{
    partial class purchase
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(purchase));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.purchase_grandtotal = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.purchase_subtotal = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.purchase_discount = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.purchase_date = new System.Windows.Forms.DateTimePicker();
            this.purchase_method = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.purchase_supplierid = new System.Windows.Forms.ComboBox();
            this.purchase_product_id = new System.Windows.Forms.ComboBox();
            this.purchase_quantity = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.purchase_rate = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.purchase_purchaseid = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.user_securityans = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bakeryDataSet2 = new project.bakeryDataSet2();
            this.usersTableAdapter = new project.bakeryDataSet2TableAdapters.usersTableAdapter();
            this.purchase_searchchoice = new System.Windows.Forms.ComboBox();
            this.user_displaylabel = new System.Windows.Forms.Label();
            this.purchase_searchentry = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.user_display = new System.Windows.Forms.Label();
            this.purchase_displaylabel = new System.Windows.Forms.Label();
            this.purchase_datagrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.purchaseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentmethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaserateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasequantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasediscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplieridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grand_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bakeryDataSet10 = new project.bakeryDataSet10();
            this.purchaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bakeryDataSet6 = new project.bakeryDataSet6();
            this.purchaseTableAdapter = new project.bakeryDataSet6TableAdapters.purchaseTableAdapter();
            this.purchase_searchdate = new System.Windows.Forms.DateTimePicker();
            this.purchaseTableAdapter1 = new project.bakeryDataSet10TableAdapters.purchaseTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.purchase_addbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.purchase_showallbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.purchase_updatebutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.purchase_searchbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.purchase_deletebutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.purchase_clearbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet6)).BeginInit();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.purchase_grandtotal);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.purchase_subtotal);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.purchase_discount);
            this.panel1.Controls.Add(this.purchase_date);
            this.panel1.Controls.Add(this.purchase_method);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.purchase_supplierid);
            this.panel1.Controls.Add(this.purchase_product_id);
            this.panel1.Controls.Add(this.purchase_quantity);
            this.panel1.Controls.Add(this.purchase_rate);
            this.panel1.Controls.Add(this.purchase_purchaseid);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 554);
            this.panel1.TabIndex = 27;
            // 
            // purchase_grandtotal
            // 
            this.purchase_grandtotal.BackColor = System.Drawing.Color.White;
            this.purchase_grandtotal.BorderColorFocused = System.Drawing.Color.Blue;
            this.purchase_grandtotal.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.purchase_grandtotal.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.purchase_grandtotal.BorderThickness = 3;
            this.purchase_grandtotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.purchase_grandtotal.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_grandtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.purchase_grandtotal.isPassword = false;
            this.purchase_grandtotal.Location = new System.Drawing.Point(9, 520);
            this.purchase_grandtotal.Margin = new System.Windows.Forms.Padding(4);
            this.purchase_grandtotal.Name = "purchase_grandtotal";
            this.purchase_grandtotal.Size = new System.Drawing.Size(250, 30);
            this.purchase_grandtotal.TabIndex = 22;
            this.purchase_grandtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(9, 500);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(110, 22);
            this.label11.TabIndex = 21;
            this.label11.Text = "Grand Total";
            // 
            // purchase_subtotal
            // 
            this.purchase_subtotal.BackColor = System.Drawing.Color.White;
            this.purchase_subtotal.BorderColorFocused = System.Drawing.Color.Blue;
            this.purchase_subtotal.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.purchase_subtotal.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.purchase_subtotal.BorderThickness = 3;
            this.purchase_subtotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.purchase_subtotal.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_subtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.purchase_subtotal.isPassword = false;
            this.purchase_subtotal.Location = new System.Drawing.Point(9, 470);
            this.purchase_subtotal.Margin = new System.Windows.Forms.Padding(4);
            this.purchase_subtotal.Name = "purchase_subtotal";
            this.purchase_subtotal.Size = new System.Drawing.Size(250, 30);
            this.purchase_subtotal.TabIndex = 20;
            this.purchase_subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(9, 450);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(88, 22);
            this.label10.TabIndex = 19;
            this.label10.Text = "Sub Total";
            // 
            // purchase_discount
            // 
            this.purchase_discount.BackColor = System.Drawing.Color.White;
            this.purchase_discount.BorderColorFocused = System.Drawing.Color.Blue;
            this.purchase_discount.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.purchase_discount.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.purchase_discount.BorderThickness = 3;
            this.purchase_discount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.purchase_discount.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_discount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.purchase_discount.isPassword = false;
            this.purchase_discount.Location = new System.Drawing.Point(10, 310);
            this.purchase_discount.Margin = new System.Windows.Forms.Padding(4);
            this.purchase_discount.Name = "purchase_discount";
            this.purchase_discount.Size = new System.Drawing.Size(250, 30);
            this.purchase_discount.TabIndex = 18;
            this.purchase_discount.Text = "Enter Discount";
            this.purchase_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.purchase_discount.Leave += new System.EventHandler(this.purchase_discount_Leave);
            // 
            // purchase_date
            // 
            this.purchase_date.CustomFormat = "yyyy-MM-dd";
            this.purchase_date.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.purchase_date.Location = new System.Drawing.Point(10, 80);
            this.purchase_date.Name = "purchase_date";
            this.purchase_date.Size = new System.Drawing.Size(250, 25);
            this.purchase_date.TabIndex = 17;
            // 
            // purchase_method
            // 
            this.purchase_method.BackColor = System.Drawing.Color.White;
            this.purchase_method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.purchase_method.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_method.FormattingEnabled = true;
            this.purchase_method.Items.AddRange(new object[] {
            "Cash",
            "Deposit"});
            this.purchase_method.Location = new System.Drawing.Point(10, 135);
            this.purchase_method.Name = "purchase_method";
            this.purchase_method.Size = new System.Drawing.Size(250, 24);
            this.purchase_method.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(10, 395);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(78, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Supplier";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(10, 344);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(75, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Product";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 290);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(82, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Discount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 224);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 164);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(130, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Purchase Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Purchase Method";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Purchase Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Purchase ID";
            // 
            // purchase_supplierid
            // 
            this.purchase_supplierid.BackColor = System.Drawing.Color.White;
            this.purchase_supplierid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.purchase_supplierid.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_supplierid.FormattingEnabled = true;
            this.purchase_supplierid.Location = new System.Drawing.Point(10, 420);
            this.purchase_supplierid.Name = "purchase_supplierid";
            this.purchase_supplierid.Size = new System.Drawing.Size(250, 24);
            this.purchase_supplierid.TabIndex = 7;
            // 
            // purchase_product_id
            // 
            this.purchase_product_id.BackColor = System.Drawing.Color.White;
            this.purchase_product_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.purchase_product_id.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_product_id.FormattingEnabled = true;
            this.purchase_product_id.Items.AddRange(new object[] {
            "Active",
            "In-Active"});
            this.purchase_product_id.Location = new System.Drawing.Point(10, 370);
            this.purchase_product_id.Name = "purchase_product_id";
            this.purchase_product_id.Size = new System.Drawing.Size(250, 24);
            this.purchase_product_id.TabIndex = 6;
            // 
            // purchase_quantity
            // 
            this.purchase_quantity.BackColor = System.Drawing.Color.White;
            this.purchase_quantity.BorderColorFocused = System.Drawing.Color.Blue;
            this.purchase_quantity.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.purchase_quantity.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.purchase_quantity.BorderThickness = 3;
            this.purchase_quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.purchase_quantity.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.purchase_quantity.isPassword = false;
            this.purchase_quantity.Location = new System.Drawing.Point(10, 250);
            this.purchase_quantity.Margin = new System.Windows.Forms.Padding(4);
            this.purchase_quantity.Name = "purchase_quantity";
            this.purchase_quantity.Size = new System.Drawing.Size(250, 30);
            this.purchase_quantity.TabIndex = 4;
            this.purchase_quantity.Text = "Enter Quantity";
            this.purchase_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.purchase_quantity.Leave += new System.EventHandler(this.purchase_quantity_Leave);
            // 
            // purchase_rate
            // 
            this.purchase_rate.BackColor = System.Drawing.Color.White;
            this.purchase_rate.BorderColorFocused = System.Drawing.Color.Blue;
            this.purchase_rate.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.purchase_rate.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.purchase_rate.BorderThickness = 3;
            this.purchase_rate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.purchase_rate.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_rate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.purchase_rate.isPassword = false;
            this.purchase_rate.Location = new System.Drawing.Point(10, 190);
            this.purchase_rate.Margin = new System.Windows.Forms.Padding(4);
            this.purchase_rate.Name = "purchase_rate";
            this.purchase_rate.Size = new System.Drawing.Size(250, 30);
            this.purchase_rate.TabIndex = 3;
            this.purchase_rate.Text = "Enter Purchase Rate";
            this.purchase_rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // purchase_purchaseid
            // 
            this.purchase_purchaseid.BackColor = System.Drawing.Color.White;
            this.purchase_purchaseid.BorderColorFocused = System.Drawing.Color.Blue;
            this.purchase_purchaseid.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.purchase_purchaseid.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.purchase_purchaseid.BorderThickness = 3;
            this.purchase_purchaseid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.purchase_purchaseid.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_purchaseid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.purchase_purchaseid.isPassword = false;
            this.purchase_purchaseid.Location = new System.Drawing.Point(10, 25);
            this.purchase_purchaseid.Margin = new System.Windows.Forms.Padding(4);
            this.purchase_purchaseid.Name = "purchase_purchaseid";
            this.purchase_purchaseid.Size = new System.Drawing.Size(250, 30);
            this.purchase_purchaseid.TabIndex = 0;
            this.purchase_purchaseid.Text = "Enter Purchase ID";
            this.purchase_purchaseid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // user_securityans
            // 
            this.user_securityans.BorderColorFocused = System.Drawing.Color.Blue;
            this.user_securityans.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.user_securityans.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.user_securityans.BorderThickness = 3;
            this.user_securityans.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user_securityans.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_securityans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.user_securityans.isPassword = false;
            this.user_securityans.Location = new System.Drawing.Point(10, 380);
            this.user_securityans.Margin = new System.Windows.Forms.Padding(4);
            this.user_securityans.Name = "user_securityans";
            this.user_securityans.Size = new System.Drawing.Size(250, 35);
            this.user_securityans.TabIndex = 5;
            this.user_securityans.Text = "Enter Above Question\'s Answer";
            this.user_securityans.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.bakeryDataSet2;
            // 
            // bakeryDataSet2
            // 
            this.bakeryDataSet2.DataSetName = "bakeryDataSet2";
            this.bakeryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // purchase_searchchoice
            // 
            this.purchase_searchchoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.purchase_searchchoice.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_searchchoice.FormattingEnabled = true;
            this.purchase_searchchoice.Items.AddRange(new object[] {
            "By Purchase ID",
            "By Purchase Date",
            "By Product ID",
            "By Supplier ID"});
            this.purchase_searchchoice.Location = new System.Drawing.Point(85, 10);
            this.purchase_searchchoice.Name = "purchase_searchchoice";
            this.purchase_searchchoice.Size = new System.Drawing.Size(150, 23);
            this.purchase_searchchoice.TabIndex = 28;
            this.purchase_searchchoice.SelectedIndexChanged += new System.EventHandler(this.purchase_searchchoice_SelectedIndexChanged);
            // 
            // user_displaylabel
            // 
            this.user_displaylabel.AutoSize = true;
            this.user_displaylabel.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_displaylabel.Location = new System.Drawing.Point(519, 15);
            this.user_displaylabel.Name = "user_displaylabel";
            this.user_displaylabel.Size = new System.Drawing.Size(0, 15);
            this.user_displaylabel.TabIndex = 31;
            // 
            // purchase_searchentry
            // 
            this.purchase_searchentry.BorderColorFocused = System.Drawing.Color.Blue;
            this.purchase_searchentry.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.purchase_searchentry.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.purchase_searchentry.BorderThickness = 3;
            this.purchase_searchentry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.purchase_searchentry.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_searchentry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.purchase_searchentry.isPassword = false;
            this.purchase_searchentry.Location = new System.Drawing.Point(402, 8);
            this.purchase_searchentry.Margin = new System.Windows.Forms.Padding(4);
            this.purchase_searchentry.Name = "purchase_searchentry";
            this.purchase_searchentry.Size = new System.Drawing.Size(220, 25);
            this.purchase_searchentry.TabIndex = 32;
            this.purchase_searchentry.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // user_display
            // 
            this.user_display.AutoSize = true;
            this.user_display.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_display.Location = new System.Drawing.Point(552, 19);
            this.user_display.Name = "user_display";
            this.user_display.Size = new System.Drawing.Size(0, 15);
            this.user_display.TabIndex = 30;
            // 
            // purchase_displaylabel
            // 
            this.purchase_displaylabel.AutoSize = true;
            this.purchase_displaylabel.BackColor = System.Drawing.Color.Transparent;
            this.purchase_displaylabel.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_displaylabel.ForeColor = System.Drawing.Color.White;
            this.purchase_displaylabel.Location = new System.Drawing.Point(236, 12);
            this.purchase_displaylabel.Name = "purchase_displaylabel";
            this.purchase_displaylabel.Size = new System.Drawing.Size(0, 19);
            this.purchase_displaylabel.TabIndex = 39;
            // 
            // purchase_datagrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.purchase_datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.purchase_datagrid.AutoGenerateColumns = false;
            this.purchase_datagrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.purchase_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.purchase_datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purchase_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.purchase_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchase_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.purchaseidDataGridViewTextBoxColumn,
            this.purchasedateDataGridViewTextBoxColumn,
            this.paymentmethodDataGridViewTextBoxColumn,
            this.purchaserateDataGridViewTextBoxColumn,
            this.purchasequantityDataGridViewTextBoxColumn,
            this.purchasediscountDataGridViewTextBoxColumn,
            this.productidDataGridViewTextBoxColumn,
            this.supplieridDataGridViewTextBoxColumn,
            this.sub_total,
            this.grand_total});
            this.purchase_datagrid.DataSource = this.purchaseBindingSource1;
            this.purchase_datagrid.DoubleBuffered = true;
            this.purchase_datagrid.EnableHeadersVisualStyles = false;
            this.purchase_datagrid.HeaderBgColor = System.Drawing.Color.DimGray;
            this.purchase_datagrid.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.purchase_datagrid.Location = new System.Drawing.Point(275, 200);
            this.purchase_datagrid.Name = "purchase_datagrid";
            this.purchase_datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.purchase_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.purchase_datagrid.Size = new System.Drawing.Size(625, 350);
            this.purchase_datagrid.TabIndex = 40;
            this.purchase_datagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchase_datagrid_CellClick);
            // 
            // purchaseidDataGridViewTextBoxColumn
            // 
            this.purchaseidDataGridViewTextBoxColumn.DataPropertyName = "purchase_id";
            this.purchaseidDataGridViewTextBoxColumn.HeaderText = "Purchase ID";
            this.purchaseidDataGridViewTextBoxColumn.Name = "purchaseidDataGridViewTextBoxColumn";
            this.purchaseidDataGridViewTextBoxColumn.Width = 80;
            // 
            // purchasedateDataGridViewTextBoxColumn
            // 
            this.purchasedateDataGridViewTextBoxColumn.DataPropertyName = "purchase_date";
            this.purchasedateDataGridViewTextBoxColumn.HeaderText = "Purchase Date";
            this.purchasedateDataGridViewTextBoxColumn.Name = "purchasedateDataGridViewTextBoxColumn";
            // 
            // paymentmethodDataGridViewTextBoxColumn
            // 
            this.paymentmethodDataGridViewTextBoxColumn.DataPropertyName = "payment_method";
            this.paymentmethodDataGridViewTextBoxColumn.HeaderText = "Payment Method";
            this.paymentmethodDataGridViewTextBoxColumn.Name = "paymentmethodDataGridViewTextBoxColumn";
            // 
            // purchaserateDataGridViewTextBoxColumn
            // 
            this.purchaserateDataGridViewTextBoxColumn.DataPropertyName = "purchase_rate";
            this.purchaserateDataGridViewTextBoxColumn.HeaderText = "Purchase Rate";
            this.purchaserateDataGridViewTextBoxColumn.Name = "purchaserateDataGridViewTextBoxColumn";
            // 
            // purchasequantityDataGridViewTextBoxColumn
            // 
            this.purchasequantityDataGridViewTextBoxColumn.DataPropertyName = "purchase_quantity";
            this.purchasequantityDataGridViewTextBoxColumn.HeaderText = "Purchase Quantity";
            this.purchasequantityDataGridViewTextBoxColumn.Name = "purchasequantityDataGridViewTextBoxColumn";
            // 
            // purchasediscountDataGridViewTextBoxColumn
            // 
            this.purchasediscountDataGridViewTextBoxColumn.DataPropertyName = "purchase_discount";
            this.purchasediscountDataGridViewTextBoxColumn.HeaderText = "Purchase Discount";
            this.purchasediscountDataGridViewTextBoxColumn.Name = "purchasediscountDataGridViewTextBoxColumn";
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.Width = 80;
            // 
            // supplieridDataGridViewTextBoxColumn
            // 
            this.supplieridDataGridViewTextBoxColumn.DataPropertyName = "supplier_id";
            this.supplieridDataGridViewTextBoxColumn.HeaderText = "Supplier ID";
            this.supplieridDataGridViewTextBoxColumn.Name = "supplieridDataGridViewTextBoxColumn";
            this.supplieridDataGridViewTextBoxColumn.Width = 80;
            // 
            // sub_total
            // 
            this.sub_total.DataPropertyName = "sub_total";
            this.sub_total.HeaderText = "Total Amount";
            this.sub_total.Name = "sub_total";
            // 
            // grand_total
            // 
            this.grand_total.DataPropertyName = "grand_total";
            this.grand_total.HeaderText = "Grand Total";
            this.grand_total.Name = "grand_total";
            // 
            // purchaseBindingSource1
            // 
            this.purchaseBindingSource1.DataMember = "purchase";
            this.purchaseBindingSource1.DataSource = this.bakeryDataSet10;
            // 
            // bakeryDataSet10
            // 
            this.bakeryDataSet10.DataSetName = "bakeryDataSet10";
            this.bakeryDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchaseBindingSource
            // 
            this.purchaseBindingSource.DataMember = "purchase";
            this.purchaseBindingSource.DataSource = this.bakeryDataSet6;
            // 
            // bakeryDataSet6
            // 
            this.bakeryDataSet6.DataSetName = "bakeryDataSet6";
            this.bakeryDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchaseTableAdapter
            // 
            this.purchaseTableAdapter.ClearBeforeFill = true;
            // 
            // purchase_searchdate
            // 
            this.purchase_searchdate.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_searchdate.CustomFormat = "yyyy-MM-dd";
            this.purchase_searchdate.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_searchdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.purchase_searchdate.Location = new System.Drawing.Point(402, 8);
            this.purchase_searchdate.Name = "purchase_searchdate";
            this.purchase_searchdate.Size = new System.Drawing.Size(220, 25);
            this.purchase_searchdate.TabIndex = 41;
            this.purchase_searchdate.Visible = false;
            // 
            // purchaseTableAdapter1
            // 
            this.purchaseTableAdapter1.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.purchase_searchdate);
            this.panel3.Controls.Add(this.purchase_searchentry);
            this.panel3.Controls.Add(this.purchase_searchchoice);
            this.panel3.Controls.Add(this.purchase_displaylabel);
            this.panel3.Location = new System.Drawing.Point(275, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(625, 41);
            this.panel3.TabIndex = 67;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(3, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 19);
            this.label12.TabIndex = 48;
            this.label12.Text = "Search By";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.Controls.Add(this.purchase_addbutton);
            this.flowLayoutPanel1.Controls.Add(this.purchase_showallbutton);
            this.flowLayoutPanel1.Controls.Add(this.purchase_updatebutton);
            this.flowLayoutPanel1.Controls.Add(this.purchase_searchbutton);
            this.flowLayoutPanel1.Controls.Add(this.purchase_deletebutton);
            this.flowLayoutPanel1.Controls.Add(this.purchase_clearbutton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(275, 70);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(625, 128);
            this.flowLayoutPanel1.TabIndex = 66;
            // 
            // purchase_addbutton
            // 
            this.purchase_addbutton.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.purchase_addbutton.BackColor = System.Drawing.Color.White;
            this.purchase_addbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("purchase_addbutton.BackgroundImage")));
            this.purchase_addbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.purchase_addbutton.BorderRadius = 0;
            this.purchase_addbutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.purchase_addbutton.ButtonText = "Purchase";
            this.purchase_addbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purchase_addbutton.DisabledColor = System.Drawing.Color.Gray;
            this.purchase_addbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.purchase_addbutton.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_addbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.purchase_addbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("purchase_addbutton.Iconimage")));
            this.purchase_addbutton.Iconimage_right = null;
            this.purchase_addbutton.Iconimage_right_Selected = null;
            this.purchase_addbutton.Iconimage_Selected = null;
            this.purchase_addbutton.IconMarginLeft = 1;
            this.purchase_addbutton.IconMarginRight = 0;
            this.purchase_addbutton.IconRightVisible = true;
            this.purchase_addbutton.IconRightZoom = 0D;
            this.purchase_addbutton.IconVisible = true;
            this.purchase_addbutton.IconZoom = 80D;
            this.purchase_addbutton.IsTab = false;
            this.purchase_addbutton.Location = new System.Drawing.Point(3, 3);
            this.purchase_addbutton.Name = "purchase_addbutton";
            this.purchase_addbutton.Normalcolor = System.Drawing.Color.White;
            this.purchase_addbutton.OnHovercolor = System.Drawing.Color.Aqua;
            this.purchase_addbutton.OnHoverTextColor = System.Drawing.Color.Aqua;
            this.purchase_addbutton.selected = false;
            this.purchase_addbutton.Size = new System.Drawing.Size(200, 55);
            this.purchase_addbutton.TabIndex = 2;
            this.purchase_addbutton.Text = "Purchase";
            this.purchase_addbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.purchase_addbutton.Textcolor = System.Drawing.Color.White;
            this.purchase_addbutton.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_addbutton.Click += new System.EventHandler(this.purchase_addbutton_Click_1);
            // 
            // purchase_showallbutton
            // 
            this.purchase_showallbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.purchase_showallbutton.BackColor = System.Drawing.Color.White;
            this.purchase_showallbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("purchase_showallbutton.BackgroundImage")));
            this.purchase_showallbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.purchase_showallbutton.BorderRadius = 0;
            this.purchase_showallbutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.purchase_showallbutton.ButtonText = "Show All";
            this.purchase_showallbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purchase_showallbutton.DisabledColor = System.Drawing.Color.Gray;
            this.purchase_showallbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.purchase_showallbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.purchase_showallbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("purchase_showallbutton.Iconimage")));
            this.purchase_showallbutton.Iconimage_right = null;
            this.purchase_showallbutton.Iconimage_right_Selected = null;
            this.purchase_showallbutton.Iconimage_Selected = null;
            this.purchase_showallbutton.IconMarginLeft = 0;
            this.purchase_showallbutton.IconMarginRight = 0;
            this.purchase_showallbutton.IconRightVisible = true;
            this.purchase_showallbutton.IconRightZoom = 0D;
            this.purchase_showallbutton.IconVisible = true;
            this.purchase_showallbutton.IconZoom = 90D;
            this.purchase_showallbutton.IsTab = false;
            this.purchase_showallbutton.Location = new System.Drawing.Point(209, 3);
            this.purchase_showallbutton.Name = "purchase_showallbutton";
            this.purchase_showallbutton.Normalcolor = System.Drawing.Color.White;
            this.purchase_showallbutton.OnHovercolor = System.Drawing.Color.Aqua;
            this.purchase_showallbutton.OnHoverTextColor = System.Drawing.Color.Aqua;
            this.purchase_showallbutton.selected = false;
            this.purchase_showallbutton.Size = new System.Drawing.Size(200, 55);
            this.purchase_showallbutton.TabIndex = 4;
            this.purchase_showallbutton.Text = "Show All";
            this.purchase_showallbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.purchase_showallbutton.Textcolor = System.Drawing.Color.White;
            this.purchase_showallbutton.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_showallbutton.Click += new System.EventHandler(this.purchase_showallbutton_Click_1);
            // 
            // purchase_updatebutton
            // 
            this.purchase_updatebutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.purchase_updatebutton.BackColor = System.Drawing.Color.White;
            this.purchase_updatebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("purchase_updatebutton.BackgroundImage")));
            this.purchase_updatebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.purchase_updatebutton.BorderRadius = 0;
            this.purchase_updatebutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.purchase_updatebutton.ButtonText = "Update entry";
            this.purchase_updatebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purchase_updatebutton.DisabledColor = System.Drawing.Color.Gray;
            this.purchase_updatebutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.purchase_updatebutton.Iconcolor = System.Drawing.Color.Transparent;
            this.purchase_updatebutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("purchase_updatebutton.Iconimage")));
            this.purchase_updatebutton.Iconimage_right = null;
            this.purchase_updatebutton.Iconimage_right_Selected = null;
            this.purchase_updatebutton.Iconimage_Selected = null;
            this.purchase_updatebutton.IconMarginLeft = 0;
            this.purchase_updatebutton.IconMarginRight = 0;
            this.purchase_updatebutton.IconRightVisible = true;
            this.purchase_updatebutton.IconRightZoom = 0D;
            this.purchase_updatebutton.IconVisible = true;
            this.purchase_updatebutton.IconZoom = 90D;
            this.purchase_updatebutton.IsTab = false;
            this.purchase_updatebutton.Location = new System.Drawing.Point(415, 3);
            this.purchase_updatebutton.Name = "purchase_updatebutton";
            this.purchase_updatebutton.Normalcolor = System.Drawing.Color.White;
            this.purchase_updatebutton.OnHovercolor = System.Drawing.Color.Aqua;
            this.purchase_updatebutton.OnHoverTextColor = System.Drawing.Color.Aqua;
            this.purchase_updatebutton.selected = false;
            this.purchase_updatebutton.Size = new System.Drawing.Size(200, 55);
            this.purchase_updatebutton.TabIndex = 5;
            this.purchase_updatebutton.Text = "Update entry";
            this.purchase_updatebutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.purchase_updatebutton.Textcolor = System.Drawing.Color.White;
            this.purchase_updatebutton.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_updatebutton.Click += new System.EventHandler(this.purchase_updatebutton_Click_1);
            // 
            // purchase_searchbutton
            // 
            this.purchase_searchbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.purchase_searchbutton.BackColor = System.Drawing.Color.White;
            this.purchase_searchbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("purchase_searchbutton.BackgroundImage")));
            this.purchase_searchbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.purchase_searchbutton.BorderRadius = 0;
            this.purchase_searchbutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.purchase_searchbutton.ButtonText = "Search Entry";
            this.purchase_searchbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purchase_searchbutton.DisabledColor = System.Drawing.Color.Gray;
            this.purchase_searchbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.purchase_searchbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.purchase_searchbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("purchase_searchbutton.Iconimage")));
            this.purchase_searchbutton.Iconimage_right = null;
            this.purchase_searchbutton.Iconimage_right_Selected = null;
            this.purchase_searchbutton.Iconimage_Selected = null;
            this.purchase_searchbutton.IconMarginLeft = 0;
            this.purchase_searchbutton.IconMarginRight = 0;
            this.purchase_searchbutton.IconRightVisible = true;
            this.purchase_searchbutton.IconRightZoom = 0D;
            this.purchase_searchbutton.IconVisible = true;
            this.purchase_searchbutton.IconZoom = 90D;
            this.purchase_searchbutton.IsTab = false;
            this.purchase_searchbutton.Location = new System.Drawing.Point(3, 64);
            this.purchase_searchbutton.Name = "purchase_searchbutton";
            this.purchase_searchbutton.Normalcolor = System.Drawing.Color.White;
            this.purchase_searchbutton.OnHovercolor = System.Drawing.Color.Aqua;
            this.purchase_searchbutton.OnHoverTextColor = System.Drawing.Color.Aqua;
            this.purchase_searchbutton.selected = false;
            this.purchase_searchbutton.Size = new System.Drawing.Size(200, 55);
            this.purchase_searchbutton.TabIndex = 6;
            this.purchase_searchbutton.Text = "Search Entry";
            this.purchase_searchbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.purchase_searchbutton.Textcolor = System.Drawing.Color.White;
            this.purchase_searchbutton.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_searchbutton.Click += new System.EventHandler(this.purchase_searchbutton_Click_1);
            // 
            // purchase_deletebutton
            // 
            this.purchase_deletebutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.purchase_deletebutton.BackColor = System.Drawing.Color.White;
            this.purchase_deletebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("purchase_deletebutton.BackgroundImage")));
            this.purchase_deletebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.purchase_deletebutton.BorderRadius = 0;
            this.purchase_deletebutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.purchase_deletebutton.ButtonText = "Delete Entry";
            this.purchase_deletebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purchase_deletebutton.DisabledColor = System.Drawing.Color.Gray;
            this.purchase_deletebutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.purchase_deletebutton.Iconcolor = System.Drawing.Color.Transparent;
            this.purchase_deletebutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("purchase_deletebutton.Iconimage")));
            this.purchase_deletebutton.Iconimage_right = null;
            this.purchase_deletebutton.Iconimage_right_Selected = null;
            this.purchase_deletebutton.Iconimage_Selected = null;
            this.purchase_deletebutton.IconMarginLeft = 0;
            this.purchase_deletebutton.IconMarginRight = 0;
            this.purchase_deletebutton.IconRightVisible = true;
            this.purchase_deletebutton.IconRightZoom = 0D;
            this.purchase_deletebutton.IconVisible = true;
            this.purchase_deletebutton.IconZoom = 90D;
            this.purchase_deletebutton.IsTab = false;
            this.purchase_deletebutton.Location = new System.Drawing.Point(209, 64);
            this.purchase_deletebutton.Name = "purchase_deletebutton";
            this.purchase_deletebutton.Normalcolor = System.Drawing.Color.White;
            this.purchase_deletebutton.OnHovercolor = System.Drawing.Color.Aqua;
            this.purchase_deletebutton.OnHoverTextColor = System.Drawing.Color.Aqua;
            this.purchase_deletebutton.selected = false;
            this.purchase_deletebutton.Size = new System.Drawing.Size(200, 55);
            this.purchase_deletebutton.TabIndex = 7;
            this.purchase_deletebutton.Text = "Delete Entry";
            this.purchase_deletebutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.purchase_deletebutton.Textcolor = System.Drawing.Color.White;
            this.purchase_deletebutton.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_deletebutton.Click += new System.EventHandler(this.purchase_deletebutton_Click_1);
            // 
            // purchase_clearbutton
            // 
            this.purchase_clearbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.purchase_clearbutton.BackColor = System.Drawing.Color.White;
            this.purchase_clearbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("purchase_clearbutton.BackgroundImage")));
            this.purchase_clearbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.purchase_clearbutton.BorderRadius = 0;
            this.purchase_clearbutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.purchase_clearbutton.ButtonText = "Clear All";
            this.purchase_clearbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purchase_clearbutton.DisabledColor = System.Drawing.Color.Gray;
            this.purchase_clearbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.purchase_clearbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.purchase_clearbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("purchase_clearbutton.Iconimage")));
            this.purchase_clearbutton.Iconimage_right = null;
            this.purchase_clearbutton.Iconimage_right_Selected = null;
            this.purchase_clearbutton.Iconimage_Selected = null;
            this.purchase_clearbutton.IconMarginLeft = 0;
            this.purchase_clearbutton.IconMarginRight = 0;
            this.purchase_clearbutton.IconRightVisible = true;
            this.purchase_clearbutton.IconRightZoom = 0D;
            this.purchase_clearbutton.IconVisible = true;
            this.purchase_clearbutton.IconZoom = 90D;
            this.purchase_clearbutton.IsTab = false;
            this.purchase_clearbutton.Location = new System.Drawing.Point(415, 64);
            this.purchase_clearbutton.Name = "purchase_clearbutton";
            this.purchase_clearbutton.Normalcolor = System.Drawing.Color.White;
            this.purchase_clearbutton.OnHovercolor = System.Drawing.Color.Aqua;
            this.purchase_clearbutton.OnHoverTextColor = System.Drawing.Color.Aqua;
            this.purchase_clearbutton.selected = false;
            this.purchase_clearbutton.Size = new System.Drawing.Size(200, 55);
            this.purchase_clearbutton.TabIndex = 8;
            this.purchase_clearbutton.Text = "Clear All";
            this.purchase_clearbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.purchase_clearbutton.Textcolor = System.Drawing.Color.White;
            this.purchase_clearbutton.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_clearbutton.Click += new System.EventHandler(this.purchase_clearbutton_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.backButton);
            this.panel2.Location = new System.Drawing.Point(275, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 29);
            this.panel2.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(217, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "Purchase Stock";
            // 
            // backButton
            // 
            this.backButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(0, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(40, 29);
            this.backButton.TabIndex = 0;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.purchase_datagrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.user_displaylabel);
            this.Controls.Add(this.user_display);
            this.Controls.Add(this.user_securityans);
            this.Name = "purchase";
            this.Size = new System.Drawing.Size(900, 550);
            this.Load += new System.EventHandler(this.purchase_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet6)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox purchase_supplierid;
        private System.Windows.Forms.ComboBox purchase_product_id;
        private Bunifu.Framework.UI.BunifuMetroTextbox user_securityans;
        private Bunifu.Framework.UI.BunifuMetroTextbox purchase_quantity;
        private Bunifu.Framework.UI.BunifuMetroTextbox purchase_rate;
        private Bunifu.Framework.UI.BunifuMetroTextbox purchase_purchaseid;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private bakeryDataSet2 bakeryDataSet2;
        private bakeryDataSet2TableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.ComboBox purchase_searchchoice;
        private System.Windows.Forms.Label user_displaylabel;
        private Bunifu.Framework.UI.BunifuMetroTextbox purchase_searchentry;
        private System.Windows.Forms.Label user_display;
        private Bunifu.Framework.UI.BunifuMetroTextbox purchase_discount;
        private System.Windows.Forms.DateTimePicker purchase_date;
        private System.Windows.Forms.ComboBox purchase_method;
        private System.Windows.Forms.Label purchase_displaylabel;
        private Bunifu.Framework.UI.BunifuCustomDataGrid purchase_datagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentmethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaserateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasequantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasediscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplieridDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource purchaseBindingSource;
        private bakeryDataSet6 bakeryDataSet6;
        private bakeryDataSet6TableAdapters.purchaseTableAdapter purchaseTableAdapter;
        private System.Windows.Forms.DateTimePicker purchase_searchdate;
        private Bunifu.Framework.UI.BunifuMetroTextbox purchase_grandtotal;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuMetroTextbox purchase_subtotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn grand_total;
        private System.Windows.Forms.BindingSource purchaseBindingSource1;
        private bakeryDataSet10 bakeryDataSet10;
        private bakeryDataSet10TableAdapters.purchaseTableAdapter purchaseTableAdapter1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton purchase_addbutton;
        private Bunifu.Framework.UI.BunifuFlatButton purchase_showallbutton;
        private Bunifu.Framework.UI.BunifuFlatButton purchase_updatebutton;
        private Bunifu.Framework.UI.BunifuFlatButton purchase_searchbutton;
        private Bunifu.Framework.UI.BunifuFlatButton purchase_deletebutton;
        private Bunifu.Framework.UI.BunifuFlatButton purchase_clearbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
    }
}
