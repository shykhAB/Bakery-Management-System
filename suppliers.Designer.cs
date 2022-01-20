namespace project
{
    partial class suppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(suppliers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.user_display = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.supplier_searchchoice = new System.Windows.Forms.ComboBox();
            this.supplier_contactno = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.supplier_email = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.supplier_address = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.supplier_city = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.supplier_suppliername = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.supplier_supplierid = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.supplier_displaylabel = new System.Windows.Forms.Label();
            this.supplier_searchentry = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.supplier_datagrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.supplieridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addresssDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bakeryDataSet4 = new project.bakeryDataSet4();
            this.supplierTableAdapter = new project.bakeryDataSet4TableAdapters.supplierTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.supplier_addbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.supplier_showallbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.supplier_updatebutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.supplier_searchbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.supplier_deletebutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.supplier_clearbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplier_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet4)).BeginInit();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // user_display
            // 
            this.user_display.AutoSize = true;
            this.user_display.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_display.Location = new System.Drawing.Point(545, -12);
            this.user_display.Name = "user_display";
            this.user_display.Size = new System.Drawing.Size(0, 15);
            this.user_display.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 394);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(258, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Contact No (03XXXXXXXXX)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 324);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(58, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 254);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Supplier Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Supplier ID";
            // 
            // supplier_searchchoice
            // 
            this.supplier_searchchoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplier_searchchoice.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_searchchoice.FormattingEnabled = true;
            this.supplier_searchchoice.Items.AddRange(new object[] {
            "By Supplier ID",
            "By Supplier Name",
            "By City"});
            this.supplier_searchchoice.Location = new System.Drawing.Point(79, 9);
            this.supplier_searchchoice.Name = "supplier_searchchoice";
            this.supplier_searchchoice.Size = new System.Drawing.Size(150, 23);
            this.supplier_searchchoice.TabIndex = 29;
            this.supplier_searchchoice.SelectedIndexChanged += new System.EventHandler(this.supplier_searchchoice_SelectedIndexChanged);
            // 
            // supplier_contactno
            // 
            this.supplier_contactno.BackColor = System.Drawing.Color.White;
            this.supplier_contactno.BorderColorFocused = System.Drawing.Color.Blue;
            this.supplier_contactno.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.supplier_contactno.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.supplier_contactno.BorderThickness = 3;
            this.supplier_contactno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.supplier_contactno.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_contactno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.supplier_contactno.isPassword = false;
            this.supplier_contactno.Location = new System.Drawing.Point(11, 420);
            this.supplier_contactno.Margin = new System.Windows.Forms.Padding(4);
            this.supplier_contactno.Name = "supplier_contactno";
            this.supplier_contactno.Size = new System.Drawing.Size(250, 35);
            this.supplier_contactno.TabIndex = 5;
            this.supplier_contactno.Text = "Enter Contact Number";
            this.supplier_contactno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // supplier_email
            // 
            this.supplier_email.BackColor = System.Drawing.Color.White;
            this.supplier_email.BorderColorFocused = System.Drawing.Color.Blue;
            this.supplier_email.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.supplier_email.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.supplier_email.BorderThickness = 3;
            this.supplier_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.supplier_email.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.supplier_email.isPassword = false;
            this.supplier_email.Location = new System.Drawing.Point(10, 350);
            this.supplier_email.Margin = new System.Windows.Forms.Padding(4);
            this.supplier_email.Name = "supplier_email";
            this.supplier_email.Size = new System.Drawing.Size(250, 35);
            this.supplier_email.TabIndex = 4;
            this.supplier_email.Text = "Enter Email Address";
            this.supplier_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // supplier_address
            // 
            this.supplier_address.BackColor = System.Drawing.Color.White;
            this.supplier_address.BorderColorFocused = System.Drawing.Color.Blue;
            this.supplier_address.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.supplier_address.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.supplier_address.BorderThickness = 3;
            this.supplier_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.supplier_address.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.supplier_address.isPassword = false;
            this.supplier_address.Location = new System.Drawing.Point(11, 280);
            this.supplier_address.Margin = new System.Windows.Forms.Padding(4);
            this.supplier_address.Name = "supplier_address";
            this.supplier_address.Size = new System.Drawing.Size(250, 35);
            this.supplier_address.TabIndex = 3;
            this.supplier_address.Text = "Enter Address";
            this.supplier_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.supplier_contactno);
            this.panel1.Controls.Add(this.supplier_email);
            this.panel1.Controls.Add(this.supplier_address);
            this.panel1.Controls.Add(this.supplier_city);
            this.panel1.Controls.Add(this.supplier_suppliername);
            this.panel1.Controls.Add(this.supplier_supplierid);
            this.panel1.Location = new System.Drawing.Point(2, -10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 572);
            this.panel1.TabIndex = 27;
            // 
            // supplier_city
            // 
            this.supplier_city.BackColor = System.Drawing.Color.White;
            this.supplier_city.BorderColorFocused = System.Drawing.Color.Blue;
            this.supplier_city.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.supplier_city.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.supplier_city.BorderThickness = 3;
            this.supplier_city.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.supplier_city.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_city.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.supplier_city.isPassword = false;
            this.supplier_city.Location = new System.Drawing.Point(10, 210);
            this.supplier_city.Margin = new System.Windows.Forms.Padding(4);
            this.supplier_city.Name = "supplier_city";
            this.supplier_city.Size = new System.Drawing.Size(250, 35);
            this.supplier_city.TabIndex = 2;
            this.supplier_city.Text = "Enter City Name";
            this.supplier_city.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // supplier_suppliername
            // 
            this.supplier_suppliername.BackColor = System.Drawing.Color.White;
            this.supplier_suppliername.BorderColorFocused = System.Drawing.Color.Blue;
            this.supplier_suppliername.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.supplier_suppliername.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.supplier_suppliername.BorderThickness = 3;
            this.supplier_suppliername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.supplier_suppliername.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_suppliername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.supplier_suppliername.isPassword = false;
            this.supplier_suppliername.Location = new System.Drawing.Point(10, 140);
            this.supplier_suppliername.Margin = new System.Windows.Forms.Padding(4);
            this.supplier_suppliername.Name = "supplier_suppliername";
            this.supplier_suppliername.Size = new System.Drawing.Size(250, 35);
            this.supplier_suppliername.TabIndex = 1;
            this.supplier_suppliername.Text = "Enter Supplier Name";
            this.supplier_suppliername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // supplier_supplierid
            // 
            this.supplier_supplierid.BackColor = System.Drawing.Color.White;
            this.supplier_supplierid.BorderColorFocused = System.Drawing.Color.Blue;
            this.supplier_supplierid.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.supplier_supplierid.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.supplier_supplierid.BorderThickness = 3;
            this.supplier_supplierid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.supplier_supplierid.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_supplierid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.supplier_supplierid.isPassword = false;
            this.supplier_supplierid.Location = new System.Drawing.Point(10, 70);
            this.supplier_supplierid.Margin = new System.Windows.Forms.Padding(4);
            this.supplier_supplierid.Name = "supplier_supplierid";
            this.supplier_supplierid.Size = new System.Drawing.Size(250, 35);
            this.supplier_supplierid.TabIndex = 0;
            this.supplier_supplierid.Text = "Enter Supplier ID";
            this.supplier_supplierid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // supplier_displaylabel
            // 
            this.supplier_displaylabel.AutoSize = true;
            this.supplier_displaylabel.BackColor = System.Drawing.Color.Transparent;
            this.supplier_displaylabel.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_displaylabel.ForeColor = System.Drawing.Color.White;
            this.supplier_displaylabel.Location = new System.Drawing.Point(233, 12);
            this.supplier_displaylabel.Name = "supplier_displaylabel";
            this.supplier_displaylabel.Size = new System.Drawing.Size(0, 19);
            this.supplier_displaylabel.TabIndex = 32;
            // 
            // supplier_searchentry
            // 
            this.supplier_searchentry.BorderColorFocused = System.Drawing.Color.Blue;
            this.supplier_searchentry.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.supplier_searchentry.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.supplier_searchentry.BorderThickness = 3;
            this.supplier_searchentry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.supplier_searchentry.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_searchentry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.supplier_searchentry.isPassword = false;
            this.supplier_searchentry.Location = new System.Drawing.Point(401, 6);
            this.supplier_searchentry.Margin = new System.Windows.Forms.Padding(4);
            this.supplier_searchentry.Name = "supplier_searchentry";
            this.supplier_searchentry.Size = new System.Drawing.Size(220, 25);
            this.supplier_searchentry.TabIndex = 33;
            this.supplier_searchentry.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // supplier_datagrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.supplier_datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.supplier_datagrid.AutoGenerateColumns = false;
            this.supplier_datagrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.supplier_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.supplier_datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.supplier_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.supplier_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplier_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplieridDataGridViewTextBoxColumn,
            this.suppliernameDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.addresssDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn});
            this.supplier_datagrid.DataSource = this.supplierBindingSource;
            this.supplier_datagrid.DoubleBuffered = true;
            this.supplier_datagrid.EnableHeadersVisualStyles = false;
            this.supplier_datagrid.HeaderBgColor = System.Drawing.Color.DimGray;
            this.supplier_datagrid.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.supplier_datagrid.Location = new System.Drawing.Point(275, 200);
            this.supplier_datagrid.Name = "supplier_datagrid";
            this.supplier_datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.supplier_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.supplier_datagrid.Size = new System.Drawing.Size(625, 350);
            this.supplier_datagrid.TabIndex = 40;
            this.supplier_datagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supplier_datagrid_CellClick_1);
            // 
            // supplieridDataGridViewTextBoxColumn
            // 
            this.supplieridDataGridViewTextBoxColumn.DataPropertyName = "supplier_id";
            this.supplieridDataGridViewTextBoxColumn.HeaderText = "Supplier ID";
            this.supplieridDataGridViewTextBoxColumn.Name = "supplieridDataGridViewTextBoxColumn";
            this.supplieridDataGridViewTextBoxColumn.Width = 80;
            // 
            // suppliernameDataGridViewTextBoxColumn
            // 
            this.suppliernameDataGridViewTextBoxColumn.DataPropertyName = "supplier_name";
            this.suppliernameDataGridViewTextBoxColumn.HeaderText = "Supplier Name";
            this.suppliernameDataGridViewTextBoxColumn.Name = "suppliernameDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // addresssDataGridViewTextBoxColumn
            // 
            this.addresssDataGridViewTextBoxColumn.DataPropertyName = "addresss";
            this.addresssDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addresssDataGridViewTextBoxColumn.Name = "addresssDataGridViewTextBoxColumn";
            this.addresssDataGridViewTextBoxColumn.Width = 110;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact Number";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "supplier";
            this.supplierBindingSource.DataSource = this.bakeryDataSet4;
            // 
            // bakeryDataSet4
            // 
            this.bakeryDataSet4.DataSetName = "bakeryDataSet4";
            this.bakeryDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.supplier_searchentry);
            this.panel3.Controls.Add(this.supplier_displaylabel);
            this.panel3.Controls.Add(this.supplier_searchchoice);
            this.panel3.Location = new System.Drawing.Point(275, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(625, 41);
            this.panel3.TabIndex = 64;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(3, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 19);
            this.label10.TabIndex = 48;
            this.label10.Text = "Search By";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.Controls.Add(this.supplier_addbutton);
            this.flowLayoutPanel1.Controls.Add(this.supplier_showallbutton);
            this.flowLayoutPanel1.Controls.Add(this.supplier_updatebutton);
            this.flowLayoutPanel1.Controls.Add(this.supplier_searchbutton);
            this.flowLayoutPanel1.Controls.Add(this.supplier_deletebutton);
            this.flowLayoutPanel1.Controls.Add(this.supplier_clearbutton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(275, 70);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(625, 128);
            this.flowLayoutPanel1.TabIndex = 63;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // supplier_addbutton
            // 
            this.supplier_addbutton.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.supplier_addbutton.BackColor = System.Drawing.Color.White;
            this.supplier_addbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("supplier_addbutton.BackgroundImage")));
            this.supplier_addbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.supplier_addbutton.BorderRadius = 0;
            this.supplier_addbutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.supplier_addbutton.ButtonText = "Add Supplier";
            this.supplier_addbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.supplier_addbutton.DisabledColor = System.Drawing.Color.Gray;
            this.supplier_addbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.supplier_addbutton.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_addbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.supplier_addbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("supplier_addbutton.Iconimage")));
            this.supplier_addbutton.Iconimage_right = null;
            this.supplier_addbutton.Iconimage_right_Selected = null;
            this.supplier_addbutton.Iconimage_Selected = null;
            this.supplier_addbutton.IconMarginLeft = 1;
            this.supplier_addbutton.IconMarginRight = 0;
            this.supplier_addbutton.IconRightVisible = true;
            this.supplier_addbutton.IconRightZoom = 0D;
            this.supplier_addbutton.IconVisible = true;
            this.supplier_addbutton.IconZoom = 80D;
            this.supplier_addbutton.IsTab = false;
            this.supplier_addbutton.Location = new System.Drawing.Point(3, 3);
            this.supplier_addbutton.Name = "supplier_addbutton";
            this.supplier_addbutton.Normalcolor = System.Drawing.Color.White;
            this.supplier_addbutton.OnHovercolor = System.Drawing.Color.Cyan;
            this.supplier_addbutton.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.supplier_addbutton.selected = false;
            this.supplier_addbutton.Size = new System.Drawing.Size(200, 55);
            this.supplier_addbutton.TabIndex = 2;
            this.supplier_addbutton.Text = "Add Supplier";
            this.supplier_addbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.supplier_addbutton.Textcolor = System.Drawing.Color.White;
            this.supplier_addbutton.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_addbutton.Click += new System.EventHandler(this.supplier_addbutton_Click_1);
            // 
            // supplier_showallbutton
            // 
            this.supplier_showallbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.supplier_showallbutton.BackColor = System.Drawing.Color.White;
            this.supplier_showallbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("supplier_showallbutton.BackgroundImage")));
            this.supplier_showallbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.supplier_showallbutton.BorderRadius = 0;
            this.supplier_showallbutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.supplier_showallbutton.ButtonText = "Show All";
            this.supplier_showallbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.supplier_showallbutton.DisabledColor = System.Drawing.Color.Gray;
            this.supplier_showallbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.supplier_showallbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.supplier_showallbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("supplier_showallbutton.Iconimage")));
            this.supplier_showallbutton.Iconimage_right = null;
            this.supplier_showallbutton.Iconimage_right_Selected = null;
            this.supplier_showallbutton.Iconimage_Selected = null;
            this.supplier_showallbutton.IconMarginLeft = 0;
            this.supplier_showallbutton.IconMarginRight = 0;
            this.supplier_showallbutton.IconRightVisible = true;
            this.supplier_showallbutton.IconRightZoom = 0D;
            this.supplier_showallbutton.IconVisible = true;
            this.supplier_showallbutton.IconZoom = 90D;
            this.supplier_showallbutton.IsTab = false;
            this.supplier_showallbutton.Location = new System.Drawing.Point(209, 3);
            this.supplier_showallbutton.Name = "supplier_showallbutton";
            this.supplier_showallbutton.Normalcolor = System.Drawing.Color.White;
            this.supplier_showallbutton.OnHovercolor = System.Drawing.Color.Cyan;
            this.supplier_showallbutton.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.supplier_showallbutton.selected = false;
            this.supplier_showallbutton.Size = new System.Drawing.Size(200, 55);
            this.supplier_showallbutton.TabIndex = 4;
            this.supplier_showallbutton.Text = "Show All";
            this.supplier_showallbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.supplier_showallbutton.Textcolor = System.Drawing.Color.White;
            this.supplier_showallbutton.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_showallbutton.Click += new System.EventHandler(this.supplier_showallbutton_Click_1);
            // 
            // supplier_updatebutton
            // 
            this.supplier_updatebutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.supplier_updatebutton.BackColor = System.Drawing.Color.White;
            this.supplier_updatebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("supplier_updatebutton.BackgroundImage")));
            this.supplier_updatebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.supplier_updatebutton.BorderRadius = 0;
            this.supplier_updatebutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.supplier_updatebutton.ButtonText = "Update Supplier";
            this.supplier_updatebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.supplier_updatebutton.DisabledColor = System.Drawing.Color.Gray;
            this.supplier_updatebutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.supplier_updatebutton.Iconcolor = System.Drawing.Color.Transparent;
            this.supplier_updatebutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("supplier_updatebutton.Iconimage")));
            this.supplier_updatebutton.Iconimage_right = null;
            this.supplier_updatebutton.Iconimage_right_Selected = null;
            this.supplier_updatebutton.Iconimage_Selected = null;
            this.supplier_updatebutton.IconMarginLeft = 0;
            this.supplier_updatebutton.IconMarginRight = 0;
            this.supplier_updatebutton.IconRightVisible = true;
            this.supplier_updatebutton.IconRightZoom = 0D;
            this.supplier_updatebutton.IconVisible = true;
            this.supplier_updatebutton.IconZoom = 90D;
            this.supplier_updatebutton.IsTab = false;
            this.supplier_updatebutton.Location = new System.Drawing.Point(415, 3);
            this.supplier_updatebutton.Name = "supplier_updatebutton";
            this.supplier_updatebutton.Normalcolor = System.Drawing.Color.White;
            this.supplier_updatebutton.OnHovercolor = System.Drawing.Color.Cyan;
            this.supplier_updatebutton.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.supplier_updatebutton.selected = false;
            this.supplier_updatebutton.Size = new System.Drawing.Size(200, 55);
            this.supplier_updatebutton.TabIndex = 5;
            this.supplier_updatebutton.Text = "Update Supplier";
            this.supplier_updatebutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.supplier_updatebutton.Textcolor = System.Drawing.Color.White;
            this.supplier_updatebutton.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_updatebutton.Click += new System.EventHandler(this.supplier_updatebutton_Click_1);
            // 
            // supplier_searchbutton
            // 
            this.supplier_searchbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.supplier_searchbutton.BackColor = System.Drawing.Color.White;
            this.supplier_searchbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("supplier_searchbutton.BackgroundImage")));
            this.supplier_searchbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.supplier_searchbutton.BorderRadius = 0;
            this.supplier_searchbutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.supplier_searchbutton.ButtonText = "Search Supplier";
            this.supplier_searchbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.supplier_searchbutton.DisabledColor = System.Drawing.Color.Gray;
            this.supplier_searchbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.supplier_searchbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.supplier_searchbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("supplier_searchbutton.Iconimage")));
            this.supplier_searchbutton.Iconimage_right = null;
            this.supplier_searchbutton.Iconimage_right_Selected = null;
            this.supplier_searchbutton.Iconimage_Selected = null;
            this.supplier_searchbutton.IconMarginLeft = 0;
            this.supplier_searchbutton.IconMarginRight = 0;
            this.supplier_searchbutton.IconRightVisible = true;
            this.supplier_searchbutton.IconRightZoom = 0D;
            this.supplier_searchbutton.IconVisible = true;
            this.supplier_searchbutton.IconZoom = 90D;
            this.supplier_searchbutton.IsTab = false;
            this.supplier_searchbutton.Location = new System.Drawing.Point(3, 64);
            this.supplier_searchbutton.Name = "supplier_searchbutton";
            this.supplier_searchbutton.Normalcolor = System.Drawing.Color.White;
            this.supplier_searchbutton.OnHovercolor = System.Drawing.Color.Cyan;
            this.supplier_searchbutton.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.supplier_searchbutton.selected = false;
            this.supplier_searchbutton.Size = new System.Drawing.Size(200, 55);
            this.supplier_searchbutton.TabIndex = 6;
            this.supplier_searchbutton.Text = "Search Supplier";
            this.supplier_searchbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.supplier_searchbutton.Textcolor = System.Drawing.Color.White;
            this.supplier_searchbutton.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_searchbutton.Click += new System.EventHandler(this.supplier_searchbutton_Click_1);
            // 
            // supplier_deletebutton
            // 
            this.supplier_deletebutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.supplier_deletebutton.BackColor = System.Drawing.Color.White;
            this.supplier_deletebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("supplier_deletebutton.BackgroundImage")));
            this.supplier_deletebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.supplier_deletebutton.BorderRadius = 0;
            this.supplier_deletebutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.supplier_deletebutton.ButtonText = "Delete Supplier";
            this.supplier_deletebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.supplier_deletebutton.DisabledColor = System.Drawing.Color.Gray;
            this.supplier_deletebutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.supplier_deletebutton.Iconcolor = System.Drawing.Color.Transparent;
            this.supplier_deletebutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("supplier_deletebutton.Iconimage")));
            this.supplier_deletebutton.Iconimage_right = null;
            this.supplier_deletebutton.Iconimage_right_Selected = null;
            this.supplier_deletebutton.Iconimage_Selected = null;
            this.supplier_deletebutton.IconMarginLeft = 0;
            this.supplier_deletebutton.IconMarginRight = 0;
            this.supplier_deletebutton.IconRightVisible = true;
            this.supplier_deletebutton.IconRightZoom = 0D;
            this.supplier_deletebutton.IconVisible = true;
            this.supplier_deletebutton.IconZoom = 90D;
            this.supplier_deletebutton.IsTab = false;
            this.supplier_deletebutton.Location = new System.Drawing.Point(209, 64);
            this.supplier_deletebutton.Name = "supplier_deletebutton";
            this.supplier_deletebutton.Normalcolor = System.Drawing.Color.White;
            this.supplier_deletebutton.OnHovercolor = System.Drawing.Color.Cyan;
            this.supplier_deletebutton.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.supplier_deletebutton.selected = false;
            this.supplier_deletebutton.Size = new System.Drawing.Size(200, 55);
            this.supplier_deletebutton.TabIndex = 7;
            this.supplier_deletebutton.Text = "Delete Supplier";
            this.supplier_deletebutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.supplier_deletebutton.Textcolor = System.Drawing.Color.White;
            this.supplier_deletebutton.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_deletebutton.Click += new System.EventHandler(this.supplier_deletebutton_Click_1);
            // 
            // supplier_clearbutton
            // 
            this.supplier_clearbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.supplier_clearbutton.BackColor = System.Drawing.Color.White;
            this.supplier_clearbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("supplier_clearbutton.BackgroundImage")));
            this.supplier_clearbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.supplier_clearbutton.BorderRadius = 0;
            this.supplier_clearbutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.supplier_clearbutton.ButtonText = "Clear All";
            this.supplier_clearbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.supplier_clearbutton.DisabledColor = System.Drawing.Color.Gray;
            this.supplier_clearbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.supplier_clearbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.supplier_clearbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("supplier_clearbutton.Iconimage")));
            this.supplier_clearbutton.Iconimage_right = null;
            this.supplier_clearbutton.Iconimage_right_Selected = null;
            this.supplier_clearbutton.Iconimage_Selected = null;
            this.supplier_clearbutton.IconMarginLeft = 0;
            this.supplier_clearbutton.IconMarginRight = 0;
            this.supplier_clearbutton.IconRightVisible = true;
            this.supplier_clearbutton.IconRightZoom = 0D;
            this.supplier_clearbutton.IconVisible = true;
            this.supplier_clearbutton.IconZoom = 90D;
            this.supplier_clearbutton.IsTab = false;
            this.supplier_clearbutton.Location = new System.Drawing.Point(415, 64);
            this.supplier_clearbutton.Name = "supplier_clearbutton";
            this.supplier_clearbutton.Normalcolor = System.Drawing.Color.White;
            this.supplier_clearbutton.OnHovercolor = System.Drawing.Color.Cyan;
            this.supplier_clearbutton.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.supplier_clearbutton.selected = false;
            this.supplier_clearbutton.Size = new System.Drawing.Size(200, 55);
            this.supplier_clearbutton.TabIndex = 8;
            this.supplier_clearbutton.Text = "Clear All";
            this.supplier_clearbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.supplier_clearbutton.Textcolor = System.Drawing.Color.White;
            this.supplier_clearbutton.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_clearbutton.Click += new System.EventHandler(this.supplier_clearbutton_Click_1);
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
            this.panel2.TabIndex = 62;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(238, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 24);
            this.label9.TabIndex = 10;
            this.label9.Text = "Suppliers";
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
            // suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.supplier_datagrid);
            this.Controls.Add(this.user_display);
            this.Controls.Add(this.panel1);
            this.Name = "suppliers";
            this.Size = new System.Drawing.Size(900, 550);
            this.Load += new System.EventHandler(this.suppliers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplier_datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label user_display;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox supplier_searchchoice;
        private Bunifu.Framework.UI.BunifuMetroTextbox supplier_contactno;
        private Bunifu.Framework.UI.BunifuMetroTextbox supplier_email;
        private Bunifu.Framework.UI.BunifuMetroTextbox supplier_address;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox supplier_city;
        private Bunifu.Framework.UI.BunifuMetroTextbox supplier_suppliername;
        private Bunifu.Framework.UI.BunifuMetroTextbox supplier_supplierid;
        private System.Windows.Forms.Label supplier_displaylabel;
        private Bunifu.Framework.UI.BunifuMetroTextbox supplier_searchentry;
        private Bunifu.Framework.UI.BunifuCustomDataGrid supplier_datagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplieridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addresssDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private bakeryDataSet4 bakeryDataSet4;
        private bakeryDataSet4TableAdapters.supplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton supplier_addbutton;
        private Bunifu.Framework.UI.BunifuFlatButton supplier_showallbutton;
        private Bunifu.Framework.UI.BunifuFlatButton supplier_updatebutton;
        private Bunifu.Framework.UI.BunifuFlatButton supplier_searchbutton;
        private Bunifu.Framework.UI.BunifuFlatButton supplier_deletebutton;
        private Bunifu.Framework.UI.BunifuFlatButton supplier_clearbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label9;
    }
}
