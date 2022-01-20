namespace project
{
    partial class category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(category));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.user_display = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.category_searchchoice = new System.Windows.Forms.ComboBox();
            this.category_categoryname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.category_displaylabel = new System.Windows.Forms.Label();
            this.category_searchentry = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.category_status = new System.Windows.Forms.ComboBox();
            this.category_categoryid = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bakeryDataSet = new project.bakeryDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new project.bakeryDataSetTableAdapters.usersTableAdapter();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bakeryDataSet1 = new project.bakeryDataSet1();
            this.categoryTableAdapter = new project.bakeryDataSet1TableAdapters.categoryTableAdapter();
            this.category_datagrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.categoryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statussDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bakeryDataSet5 = new project.bakeryDataSet5();
            this.categoryTableAdapter1 = new project.bakeryDataSet5TableAdapters.categoryTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.category_addbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.category_showallbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.category_updatebutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.category_searchbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.category_deletebutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.category_clearbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.category_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet5)).BeginInit();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // user_display
            // 
            this.user_display.AutoSize = true;
            this.user_display.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_display.Location = new System.Drawing.Point(546, -11);
            this.user_display.Name = "user_display";
            this.user_display.Size = new System.Drawing.Size(0, 15);
            this.user_display.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Status";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Category Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Category ID";
            // 
            // category_searchchoice
            // 
            this.category_searchchoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category_searchchoice.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_searchchoice.FormattingEnabled = true;
            this.category_searchchoice.Items.AddRange(new object[] {
            "By Category ID",
            "By Category Name"});
            this.category_searchchoice.Location = new System.Drawing.Point(85, 12);
            this.category_searchchoice.Name = "category_searchchoice";
            this.category_searchchoice.Size = new System.Drawing.Size(150, 23);
            this.category_searchchoice.TabIndex = 55;
            this.category_searchchoice.SelectedIndexChanged += new System.EventHandler(this.category_searchchoice_SelectedIndexChanged);
            // 
            // category_categoryname
            // 
            this.category_categoryname.BackColor = System.Drawing.Color.White;
            this.category_categoryname.BorderColorFocused = System.Drawing.Color.Blue;
            this.category_categoryname.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.category_categoryname.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.category_categoryname.BorderThickness = 3;
            this.category_categoryname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.category_categoryname.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_categoryname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.category_categoryname.isPassword = false;
            this.category_categoryname.Location = new System.Drawing.Point(10, 260);
            this.category_categoryname.Margin = new System.Windows.Forms.Padding(4);
            this.category_categoryname.Name = "category_categoryname";
            this.category_categoryname.Size = new System.Drawing.Size(250, 35);
            this.category_categoryname.TabIndex = 1;
            this.category_categoryname.Text = "Enter Category Name";
            this.category_categoryname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // category_displaylabel
            // 
            this.category_displaylabel.AutoSize = true;
            this.category_displaylabel.BackColor = System.Drawing.Color.Transparent;
            this.category_displaylabel.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_displaylabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.category_displaylabel.Location = new System.Drawing.Point(238, 15);
            this.category_displaylabel.Name = "category_displaylabel";
            this.category_displaylabel.Size = new System.Drawing.Size(0, 19);
            this.category_displaylabel.TabIndex = 58;
            // 
            // category_searchentry
            // 
            this.category_searchentry.BorderColorFocused = System.Drawing.Color.Blue;
            this.category_searchentry.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.category_searchentry.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.category_searchentry.BorderThickness = 3;
            this.category_searchentry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.category_searchentry.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_searchentry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.category_searchentry.isPassword = false;
            this.category_searchentry.Location = new System.Drawing.Point(405, 10);
            this.category_searchentry.Margin = new System.Windows.Forms.Padding(4);
            this.category_searchentry.Name = "category_searchentry";
            this.category_searchentry.Size = new System.Drawing.Size(220, 25);
            this.category_searchentry.TabIndex = 59;
            this.category_searchentry.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.category_status);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.category_categoryname);
            this.panel1.Controls.Add(this.category_categoryid);
            this.panel1.Location = new System.Drawing.Point(2, -10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 572);
            this.panel1.TabIndex = 53;
            // 
            // category_status
            // 
            this.category_status.BackColor = System.Drawing.Color.White;
            this.category_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category_status.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_status.FormattingEnabled = true;
            this.category_status.Items.AddRange(new object[] {
            "Active",
            "In-Active"});
            this.category_status.Location = new System.Drawing.Point(10, 360);
            this.category_status.Name = "category_status";
            this.category_status.Size = new System.Drawing.Size(250, 24);
            this.category_status.TabIndex = 11;
            // 
            // category_categoryid
            // 
            this.category_categoryid.BackColor = System.Drawing.Color.White;
            this.category_categoryid.BorderColorFocused = System.Drawing.Color.Blue;
            this.category_categoryid.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.category_categoryid.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.category_categoryid.BorderThickness = 3;
            this.category_categoryid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.category_categoryid.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_categoryid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.category_categoryid.isPassword = false;
            this.category_categoryid.Location = new System.Drawing.Point(10, 160);
            this.category_categoryid.Margin = new System.Windows.Forms.Padding(4);
            this.category_categoryid.Name = "category_categoryid";
            this.category_categoryid.Size = new System.Drawing.Size(250, 35);
            this.category_categoryid.TabIndex = 0;
            this.category_categoryid.Text = "Enter Category ID";
            this.category_categoryid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bakeryDataSet
            // 
            this.bakeryDataSet.DataSetName = "bakeryDataSet";
            this.bakeryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.bakeryDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "category";
            this.categoryBindingSource.DataSource = this.bakeryDataSet1;
            // 
            // bakeryDataSet1
            // 
            this.bakeryDataSet1.DataSetName = "bakeryDataSet1";
            this.bakeryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // category_datagrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.category_datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.category_datagrid.AutoGenerateColumns = false;
            this.category_datagrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.category_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.category_datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.category_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.category_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.category_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryidDataGridViewTextBoxColumn,
            this.categorynameDataGridViewTextBoxColumn,
            this.statussDataGridViewTextBoxColumn});
            this.category_datagrid.DataSource = this.categoryBindingSource1;
            this.category_datagrid.DoubleBuffered = true;
            this.category_datagrid.EnableHeadersVisualStyles = false;
            this.category_datagrid.HeaderBgColor = System.Drawing.Color.DimGray;
            this.category_datagrid.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.category_datagrid.Location = new System.Drawing.Point(275, 200);
            this.category_datagrid.Name = "category_datagrid";
            this.category_datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.category_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.category_datagrid.Size = new System.Drawing.Size(625, 350);
            this.category_datagrid.TabIndex = 66;
            this.category_datagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.category_datagrid_CellClick_1);
            // 
            // categoryidDataGridViewTextBoxColumn
            // 
            this.categoryidDataGridViewTextBoxColumn.DataPropertyName = "category_id";
            this.categoryidDataGridViewTextBoxColumn.HeaderText = "Category ID";
            this.categoryidDataGridViewTextBoxColumn.Name = "categoryidDataGridViewTextBoxColumn";
            this.categoryidDataGridViewTextBoxColumn.Width = 150;
            // 
            // categorynameDataGridViewTextBoxColumn
            // 
            this.categorynameDataGridViewTextBoxColumn.DataPropertyName = "category_name";
            this.categorynameDataGridViewTextBoxColumn.HeaderText = "Category Name";
            this.categorynameDataGridViewTextBoxColumn.Name = "categorynameDataGridViewTextBoxColumn";
            this.categorynameDataGridViewTextBoxColumn.Width = 250;
            // 
            // statussDataGridViewTextBoxColumn
            // 
            this.statussDataGridViewTextBoxColumn.DataPropertyName = "statuss";
            this.statussDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statussDataGridViewTextBoxColumn.Name = "statussDataGridViewTextBoxColumn";
            this.statussDataGridViewTextBoxColumn.Width = 190;
            // 
            // categoryBindingSource1
            // 
            this.categoryBindingSource1.DataMember = "category";
            this.categoryBindingSource1.DataSource = this.bakeryDataSet5;
            // 
            // bakeryDataSet5
            // 
            this.bakeryDataSet5.DataSetName = "bakeryDataSet5";
            this.bakeryDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryTableAdapter1
            // 
            this.categoryTableAdapter1.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.category_searchentry);
            this.panel3.Controls.Add(this.category_displaylabel);
            this.panel3.Controls.Add(this.category_searchchoice);
            this.panel3.Location = new System.Drawing.Point(275, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(625, 41);
            this.panel3.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(2, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 48;
            this.label4.Text = "Search By";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.Controls.Add(this.category_addbutton);
            this.flowLayoutPanel1.Controls.Add(this.category_showallbutton);
            this.flowLayoutPanel1.Controls.Add(this.category_updatebutton);
            this.flowLayoutPanel1.Controls.Add(this.category_searchbutton);
            this.flowLayoutPanel1.Controls.Add(this.category_deletebutton);
            this.flowLayoutPanel1.Controls.Add(this.category_clearbutton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(275, 70);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(625, 128);
            this.flowLayoutPanel1.TabIndex = 68;
            // 
            // category_addbutton
            // 
            this.category_addbutton.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.category_addbutton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.category_addbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("category_addbutton.BackgroundImage")));
            this.category_addbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.category_addbutton.BorderRadius = 0;
            this.category_addbutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.category_addbutton.ButtonText = "Add Category";
            this.category_addbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.category_addbutton.DisabledColor = System.Drawing.Color.Gray;
            this.category_addbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.category_addbutton.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_addbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.category_addbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("category_addbutton.Iconimage")));
            this.category_addbutton.Iconimage_right = null;
            this.category_addbutton.Iconimage_right_Selected = null;
            this.category_addbutton.Iconimage_Selected = null;
            this.category_addbutton.IconMarginLeft = 1;
            this.category_addbutton.IconMarginRight = 0;
            this.category_addbutton.IconRightVisible = true;
            this.category_addbutton.IconRightZoom = 0D;
            this.category_addbutton.IconVisible = true;
            this.category_addbutton.IconZoom = 80D;
            this.category_addbutton.IsTab = false;
            this.category_addbutton.Location = new System.Drawing.Point(3, 3);
            this.category_addbutton.Name = "category_addbutton";
            this.category_addbutton.Normalcolor = System.Drawing.Color.White;
            this.category_addbutton.OnHovercolor = System.Drawing.Color.Cyan;
            this.category_addbutton.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.category_addbutton.selected = false;
            this.category_addbutton.Size = new System.Drawing.Size(200, 55);
            this.category_addbutton.TabIndex = 2;
            this.category_addbutton.Text = "Add Category";
            this.category_addbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.category_addbutton.Textcolor = System.Drawing.Color.White;
            this.category_addbutton.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_addbutton.Click += new System.EventHandler(this.category_addbutton_Click_1);
            // 
            // category_showallbutton
            // 
            this.category_showallbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.category_showallbutton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.category_showallbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("category_showallbutton.BackgroundImage")));
            this.category_showallbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.category_showallbutton.BorderRadius = 0;
            this.category_showallbutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.category_showallbutton.ButtonText = "Show All";
            this.category_showallbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.category_showallbutton.DisabledColor = System.Drawing.Color.Gray;
            this.category_showallbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.category_showallbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.category_showallbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("category_showallbutton.Iconimage")));
            this.category_showallbutton.Iconimage_right = null;
            this.category_showallbutton.Iconimage_right_Selected = null;
            this.category_showallbutton.Iconimage_Selected = null;
            this.category_showallbutton.IconMarginLeft = 0;
            this.category_showallbutton.IconMarginRight = 0;
            this.category_showallbutton.IconRightVisible = true;
            this.category_showallbutton.IconRightZoom = 0D;
            this.category_showallbutton.IconVisible = true;
            this.category_showallbutton.IconZoom = 90D;
            this.category_showallbutton.IsTab = false;
            this.category_showallbutton.Location = new System.Drawing.Point(209, 3);
            this.category_showallbutton.Name = "category_showallbutton";
            this.category_showallbutton.Normalcolor = System.Drawing.Color.White;
            this.category_showallbutton.OnHovercolor = System.Drawing.Color.Cyan;
            this.category_showallbutton.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.category_showallbutton.selected = false;
            this.category_showallbutton.Size = new System.Drawing.Size(200, 55);
            this.category_showallbutton.TabIndex = 4;
            this.category_showallbutton.Text = "Show All";
            this.category_showallbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.category_showallbutton.Textcolor = System.Drawing.Color.White;
            this.category_showallbutton.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_showallbutton.Click += new System.EventHandler(this.category_showallbutton_Click_1);
            // 
            // category_updatebutton
            // 
            this.category_updatebutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.category_updatebutton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.category_updatebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("category_updatebutton.BackgroundImage")));
            this.category_updatebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.category_updatebutton.BorderRadius = 0;
            this.category_updatebutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.category_updatebutton.ButtonText = "Update Category";
            this.category_updatebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.category_updatebutton.DisabledColor = System.Drawing.Color.Gray;
            this.category_updatebutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.category_updatebutton.Iconcolor = System.Drawing.Color.Transparent;
            this.category_updatebutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("category_updatebutton.Iconimage")));
            this.category_updatebutton.Iconimage_right = null;
            this.category_updatebutton.Iconimage_right_Selected = null;
            this.category_updatebutton.Iconimage_Selected = null;
            this.category_updatebutton.IconMarginLeft = 0;
            this.category_updatebutton.IconMarginRight = 0;
            this.category_updatebutton.IconRightVisible = true;
            this.category_updatebutton.IconRightZoom = 0D;
            this.category_updatebutton.IconVisible = true;
            this.category_updatebutton.IconZoom = 90D;
            this.category_updatebutton.IsTab = false;
            this.category_updatebutton.Location = new System.Drawing.Point(415, 3);
            this.category_updatebutton.Name = "category_updatebutton";
            this.category_updatebutton.Normalcolor = System.Drawing.Color.White;
            this.category_updatebutton.OnHovercolor = System.Drawing.Color.Cyan;
            this.category_updatebutton.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.category_updatebutton.selected = false;
            this.category_updatebutton.Size = new System.Drawing.Size(200, 55);
            this.category_updatebutton.TabIndex = 5;
            this.category_updatebutton.Text = "Update Category";
            this.category_updatebutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.category_updatebutton.Textcolor = System.Drawing.Color.White;
            this.category_updatebutton.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_updatebutton.Click += new System.EventHandler(this.category_updatebutton_Click_1);
            // 
            // category_searchbutton
            // 
            this.category_searchbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.category_searchbutton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.category_searchbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("category_searchbutton.BackgroundImage")));
            this.category_searchbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.category_searchbutton.BorderRadius = 0;
            this.category_searchbutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.category_searchbutton.ButtonText = "Search Category";
            this.category_searchbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.category_searchbutton.DisabledColor = System.Drawing.Color.Gray;
            this.category_searchbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.category_searchbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.category_searchbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("category_searchbutton.Iconimage")));
            this.category_searchbutton.Iconimage_right = null;
            this.category_searchbutton.Iconimage_right_Selected = null;
            this.category_searchbutton.Iconimage_Selected = null;
            this.category_searchbutton.IconMarginLeft = 0;
            this.category_searchbutton.IconMarginRight = 0;
            this.category_searchbutton.IconRightVisible = true;
            this.category_searchbutton.IconRightZoom = 0D;
            this.category_searchbutton.IconVisible = true;
            this.category_searchbutton.IconZoom = 90D;
            this.category_searchbutton.IsTab = false;
            this.category_searchbutton.Location = new System.Drawing.Point(3, 64);
            this.category_searchbutton.Name = "category_searchbutton";
            this.category_searchbutton.Normalcolor = System.Drawing.Color.White;
            this.category_searchbutton.OnHovercolor = System.Drawing.Color.Cyan;
            this.category_searchbutton.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.category_searchbutton.selected = false;
            this.category_searchbutton.Size = new System.Drawing.Size(200, 55);
            this.category_searchbutton.TabIndex = 6;
            this.category_searchbutton.Text = "Search Category";
            this.category_searchbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.category_searchbutton.Textcolor = System.Drawing.Color.White;
            this.category_searchbutton.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_searchbutton.Click += new System.EventHandler(this.category_searchbutton_Click_1);
            // 
            // category_deletebutton
            // 
            this.category_deletebutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.category_deletebutton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.category_deletebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("category_deletebutton.BackgroundImage")));
            this.category_deletebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.category_deletebutton.BorderRadius = 0;
            this.category_deletebutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.category_deletebutton.ButtonText = "Delete Category";
            this.category_deletebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.category_deletebutton.DisabledColor = System.Drawing.Color.Gray;
            this.category_deletebutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.category_deletebutton.Iconcolor = System.Drawing.Color.Transparent;
            this.category_deletebutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("category_deletebutton.Iconimage")));
            this.category_deletebutton.Iconimage_right = null;
            this.category_deletebutton.Iconimage_right_Selected = null;
            this.category_deletebutton.Iconimage_Selected = null;
            this.category_deletebutton.IconMarginLeft = 0;
            this.category_deletebutton.IconMarginRight = 0;
            this.category_deletebutton.IconRightVisible = true;
            this.category_deletebutton.IconRightZoom = 0D;
            this.category_deletebutton.IconVisible = true;
            this.category_deletebutton.IconZoom = 90D;
            this.category_deletebutton.IsTab = false;
            this.category_deletebutton.Location = new System.Drawing.Point(209, 64);
            this.category_deletebutton.Name = "category_deletebutton";
            this.category_deletebutton.Normalcolor = System.Drawing.Color.White;
            this.category_deletebutton.OnHovercolor = System.Drawing.Color.Cyan;
            this.category_deletebutton.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.category_deletebutton.selected = false;
            this.category_deletebutton.Size = new System.Drawing.Size(200, 55);
            this.category_deletebutton.TabIndex = 7;
            this.category_deletebutton.Text = "Delete Category";
            this.category_deletebutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.category_deletebutton.Textcolor = System.Drawing.Color.White;
            this.category_deletebutton.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_deletebutton.Click += new System.EventHandler(this.category_deletebutton_Click_1);
            // 
            // category_clearbutton
            // 
            this.category_clearbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.category_clearbutton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.category_clearbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("category_clearbutton.BackgroundImage")));
            this.category_clearbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.category_clearbutton.BorderRadius = 0;
            this.category_clearbutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.category_clearbutton.ButtonText = "Clear All";
            this.category_clearbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.category_clearbutton.DisabledColor = System.Drawing.Color.Gray;
            this.category_clearbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.category_clearbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.category_clearbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("category_clearbutton.Iconimage")));
            this.category_clearbutton.Iconimage_right = null;
            this.category_clearbutton.Iconimage_right_Selected = null;
            this.category_clearbutton.Iconimage_Selected = null;
            this.category_clearbutton.IconMarginLeft = 0;
            this.category_clearbutton.IconMarginRight = 0;
            this.category_clearbutton.IconRightVisible = true;
            this.category_clearbutton.IconRightZoom = 0D;
            this.category_clearbutton.IconVisible = true;
            this.category_clearbutton.IconZoom = 90D;
            this.category_clearbutton.IsTab = false;
            this.category_clearbutton.Location = new System.Drawing.Point(415, 64);
            this.category_clearbutton.Name = "category_clearbutton";
            this.category_clearbutton.Normalcolor = System.Drawing.Color.White;
            this.category_clearbutton.OnHovercolor = System.Drawing.Color.Cyan;
            this.category_clearbutton.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.category_clearbutton.selected = false;
            this.category_clearbutton.Size = new System.Drawing.Size(200, 55);
            this.category_clearbutton.TabIndex = 8;
            this.category_clearbutton.Text = "Clear All";
            this.category_clearbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.category_clearbutton.Textcolor = System.Drawing.Color.White;
            this.category_clearbutton.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_clearbutton.Click += new System.EventHandler(this.category_clearbutton_Click_1);
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
            this.panel2.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(238, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 24);
            this.label9.TabIndex = 10;
            this.label9.Text = "Categories";
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
            // category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.category_datagrid);
            this.Controls.Add(this.user_display);
            this.Controls.Add(this.panel1);
            this.Name = "category";
            this.Size = new System.Drawing.Size(900, 550);
            this.Load += new System.EventHandler(this.category_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.category_datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet5)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox category_searchchoice;
        private Bunifu.Framework.UI.BunifuMetroTextbox category_categoryname;
        private System.Windows.Forms.Label category_displaylabel;
        private Bunifu.Framework.UI.BunifuMetroTextbox category_searchentry;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox category_categoryid;
        private System.Windows.Forms.ComboBox category_status;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private bakeryDataSet bakeryDataSet;
        private bakeryDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private bakeryDataSet1 bakeryDataSet1;
        private bakeryDataSet1TableAdapters.categoryTableAdapter categoryTableAdapter;
        private Bunifu.Framework.UI.BunifuCustomDataGrid category_datagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statussDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource categoryBindingSource1;
        private bakeryDataSet5 bakeryDataSet5;
        private bakeryDataSet5TableAdapters.categoryTableAdapter categoryTableAdapter1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton category_addbutton;
        private Bunifu.Framework.UI.BunifuFlatButton category_showallbutton;
        private Bunifu.Framework.UI.BunifuFlatButton category_updatebutton;
        private Bunifu.Framework.UI.BunifuFlatButton category_searchbutton;
        private Bunifu.Framework.UI.BunifuFlatButton category_deletebutton;
        private Bunifu.Framework.UI.BunifuFlatButton category_clearbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label9;
    }
}
