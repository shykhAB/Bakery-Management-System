namespace project
{
    partial class prroduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prroduct));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.product_category_id = new System.Windows.Forms.ComboBox();
            this.product_productname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.product_productid = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.product_datagrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bakeryDataSet3 = new project.bakeryDataSet3();
            this.bakeryDataSet2 = new project.bakeryDataSet2();
            this.bakeryDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new project.bakeryDataSet2TableAdapters.usersTableAdapter();
            this.productTableAdapter = new project.bakeryDataSet3TableAdapters.productTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.product_addbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.product_showallbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.product_updatebutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.product_searchbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.product_deletebutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.product_clearbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.product_displaylabel = new System.Windows.Forms.Label();
            this.product_searchentry = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.product_searchchoice = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Category ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(10, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Product ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.product_category_id);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.product_productname);
            this.panel1.Controls.Add(this.product_productid);
            this.panel1.Location = new System.Drawing.Point(2, -10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 572);
            this.panel1.TabIndex = 40;
            // 
            // product_category_id
            // 
            this.product_category_id.BackColor = System.Drawing.Color.White;
            this.product_category_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.product_category_id.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_category_id.FormattingEnabled = true;
            this.product_category_id.Location = new System.Drawing.Point(10, 362);
            this.product_category_id.Name = "product_category_id";
            this.product_category_id.Size = new System.Drawing.Size(250, 24);
            this.product_category_id.TabIndex = 11;
            this.product_category_id.SelectedIndexChanged += new System.EventHandler(this.product_category_id_SelectedIndexChanged);
            // 
            // product_productname
            // 
            this.product_productname.BackColor = System.Drawing.Color.White;
            this.product_productname.BorderColorFocused = System.Drawing.Color.GhostWhite;
            this.product_productname.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.product_productname.BorderColorMouseHover = System.Drawing.Color.GhostWhite;
            this.product_productname.BorderThickness = 3;
            this.product_productname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.product_productname.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_productname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.product_productname.isPassword = false;
            this.product_productname.Location = new System.Drawing.Point(10, 260);
            this.product_productname.Margin = new System.Windows.Forms.Padding(4);
            this.product_productname.Name = "product_productname";
            this.product_productname.Size = new System.Drawing.Size(250, 35);
            this.product_productname.TabIndex = 1;
            this.product_productname.Text = "Enter Product Name";
            this.product_productname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // product_productid
            // 
            this.product_productid.BackColor = System.Drawing.Color.White;
            this.product_productid.BorderColorFocused = System.Drawing.Color.GhostWhite;
            this.product_productid.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.product_productid.BorderColorMouseHover = System.Drawing.Color.GhostWhite;
            this.product_productid.BorderThickness = 3;
            this.product_productid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.product_productid.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_productid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.product_productid.isPassword = false;
            this.product_productid.Location = new System.Drawing.Point(10, 160);
            this.product_productid.Margin = new System.Windows.Forms.Padding(4);
            this.product_productid.Name = "product_productid";
            this.product_productid.Size = new System.Drawing.Size(250, 35);
            this.product_productid.TabIndex = 0;
            this.product_productid.Text = "Enter Product ID";
            this.product_productid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // product_datagrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.product_datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.product_datagrid.AutoGenerateColumns = false;
            this.product_datagrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.product_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.product_datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.product_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.product_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.categoryidDataGridViewTextBoxColumn});
            this.product_datagrid.DataSource = this.productBindingSource;
            this.product_datagrid.DoubleBuffered = true;
            this.product_datagrid.EnableHeadersVisualStyles = false;
            this.product_datagrid.HeaderBgColor = System.Drawing.Color.DimGray;
            this.product_datagrid.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.product_datagrid.Location = new System.Drawing.Point(275, 200);
            this.product_datagrid.Name = "product_datagrid";
            this.product_datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.product_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.product_datagrid.Size = new System.Drawing.Size(625, 350);
            this.product_datagrid.TabIndex = 53;
            this.product_datagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_datagrid_CellClick_1);
            this.product_datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_datagrid_CellContentClick);
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.Width = 190;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.Width = 200;
            // 
            // categoryidDataGridViewTextBoxColumn
            // 
            this.categoryidDataGridViewTextBoxColumn.DataPropertyName = "category_id";
            this.categoryidDataGridViewTextBoxColumn.HeaderText = "Category ID";
            this.categoryidDataGridViewTextBoxColumn.Name = "categoryidDataGridViewTextBoxColumn";
            this.categoryidDataGridViewTextBoxColumn.Width = 200;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.bakeryDataSet3;
            // 
            // bakeryDataSet3
            // 
            this.bakeryDataSet3.DataSetName = "bakeryDataSet3";
            this.bakeryDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bakeryDataSet2
            // 
            this.bakeryDataSet2.DataSetName = "bakeryDataSet2";
            this.bakeryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bakeryDataSet2BindingSource
            // 
            this.bakeryDataSet2BindingSource.DataSource = this.bakeryDataSet2;
            this.bakeryDataSet2BindingSource.Position = 0;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.bakeryDataSet2BindingSource;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.backButton);
            this.panel2.Location = new System.Drawing.Point(275, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 29);
            this.panel2.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(238, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Products";
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.Controls.Add(this.product_addbutton);
            this.flowLayoutPanel1.Controls.Add(this.product_showallbutton);
            this.flowLayoutPanel1.Controls.Add(this.product_updatebutton);
            this.flowLayoutPanel1.Controls.Add(this.product_searchbutton);
            this.flowLayoutPanel1.Controls.Add(this.product_deletebutton);
            this.flowLayoutPanel1.Controls.Add(this.product_clearbutton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(275, 71);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(625, 128);
            this.flowLayoutPanel1.TabIndex = 56;
            // 
            // product_addbutton
            // 
            this.product_addbutton.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.product_addbutton.BackColor = System.Drawing.Color.White;
            this.product_addbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("product_addbutton.BackgroundImage")));
            this.product_addbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.product_addbutton.BorderRadius = 0;
            this.product_addbutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.product_addbutton.ButtonText = "Add Product";
            this.product_addbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product_addbutton.DisabledColor = System.Drawing.Color.Gray;
            this.product_addbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.product_addbutton.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_addbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.product_addbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("product_addbutton.Iconimage")));
            this.product_addbutton.Iconimage_right = null;
            this.product_addbutton.Iconimage_right_Selected = null;
            this.product_addbutton.Iconimage_Selected = null;
            this.product_addbutton.IconMarginLeft = 1;
            this.product_addbutton.IconMarginRight = 0;
            this.product_addbutton.IconRightVisible = true;
            this.product_addbutton.IconRightZoom = 0D;
            this.product_addbutton.IconVisible = true;
            this.product_addbutton.IconZoom = 80D;
            this.product_addbutton.IsTab = false;
            this.product_addbutton.Location = new System.Drawing.Point(3, 3);
            this.product_addbutton.Name = "product_addbutton";
            this.product_addbutton.Normalcolor = System.Drawing.Color.White;
            this.product_addbutton.OnHovercolor = System.Drawing.Color.Cyan;
            this.product_addbutton.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.product_addbutton.selected = false;
            this.product_addbutton.Size = new System.Drawing.Size(200, 55);
            this.product_addbutton.TabIndex = 2;
            this.product_addbutton.Text = "Add Product";
            this.product_addbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.product_addbutton.Textcolor = System.Drawing.Color.White;
            this.product_addbutton.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_addbutton.Click += new System.EventHandler(this.product_addbutton_Click_1);
            // 
            // product_showallbutton
            // 
            this.product_showallbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.product_showallbutton.BackColor = System.Drawing.Color.White;
            this.product_showallbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("product_showallbutton.BackgroundImage")));
            this.product_showallbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.product_showallbutton.BorderRadius = 0;
            this.product_showallbutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.product_showallbutton.ButtonText = "Show All";
            this.product_showallbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product_showallbutton.DisabledColor = System.Drawing.Color.Gray;
            this.product_showallbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.product_showallbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.product_showallbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("product_showallbutton.Iconimage")));
            this.product_showallbutton.Iconimage_right = null;
            this.product_showallbutton.Iconimage_right_Selected = null;
            this.product_showallbutton.Iconimage_Selected = null;
            this.product_showallbutton.IconMarginLeft = 0;
            this.product_showallbutton.IconMarginRight = 0;
            this.product_showallbutton.IconRightVisible = true;
            this.product_showallbutton.IconRightZoom = 0D;
            this.product_showallbutton.IconVisible = true;
            this.product_showallbutton.IconZoom = 90D;
            this.product_showallbutton.IsTab = false;
            this.product_showallbutton.Location = new System.Drawing.Point(209, 3);
            this.product_showallbutton.Name = "product_showallbutton";
            this.product_showallbutton.Normalcolor = System.Drawing.Color.White;
            this.product_showallbutton.OnHovercolor = System.Drawing.Color.Cyan;
            this.product_showallbutton.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.product_showallbutton.selected = false;
            this.product_showallbutton.Size = new System.Drawing.Size(200, 55);
            this.product_showallbutton.TabIndex = 4;
            this.product_showallbutton.Text = "Show All";
            this.product_showallbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.product_showallbutton.Textcolor = System.Drawing.Color.White;
            this.product_showallbutton.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_showallbutton.Click += new System.EventHandler(this.product_showallbutton_Click_1);
            // 
            // product_updatebutton
            // 
            this.product_updatebutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.product_updatebutton.BackColor = System.Drawing.Color.White;
            this.product_updatebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("product_updatebutton.BackgroundImage")));
            this.product_updatebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.product_updatebutton.BorderRadius = 0;
            this.product_updatebutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.product_updatebutton.ButtonText = "Update Product";
            this.product_updatebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product_updatebutton.DisabledColor = System.Drawing.Color.Gray;
            this.product_updatebutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.product_updatebutton.Iconcolor = System.Drawing.Color.Transparent;
            this.product_updatebutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("product_updatebutton.Iconimage")));
            this.product_updatebutton.Iconimage_right = null;
            this.product_updatebutton.Iconimage_right_Selected = null;
            this.product_updatebutton.Iconimage_Selected = null;
            this.product_updatebutton.IconMarginLeft = 0;
            this.product_updatebutton.IconMarginRight = 0;
            this.product_updatebutton.IconRightVisible = true;
            this.product_updatebutton.IconRightZoom = 0D;
            this.product_updatebutton.IconVisible = true;
            this.product_updatebutton.IconZoom = 90D;
            this.product_updatebutton.IsTab = false;
            this.product_updatebutton.Location = new System.Drawing.Point(415, 3);
            this.product_updatebutton.Name = "product_updatebutton";
            this.product_updatebutton.Normalcolor = System.Drawing.Color.White;
            this.product_updatebutton.OnHovercolor = System.Drawing.Color.Cyan;
            this.product_updatebutton.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.product_updatebutton.selected = false;
            this.product_updatebutton.Size = new System.Drawing.Size(200, 55);
            this.product_updatebutton.TabIndex = 5;
            this.product_updatebutton.Text = "Update Product";
            this.product_updatebutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.product_updatebutton.Textcolor = System.Drawing.Color.White;
            this.product_updatebutton.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_updatebutton.Click += new System.EventHandler(this.product_updatebutton_Click_1);
            // 
            // product_searchbutton
            // 
            this.product_searchbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.product_searchbutton.BackColor = System.Drawing.Color.White;
            this.product_searchbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("product_searchbutton.BackgroundImage")));
            this.product_searchbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.product_searchbutton.BorderRadius = 0;
            this.product_searchbutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.product_searchbutton.ButtonText = "Search Product";
            this.product_searchbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product_searchbutton.DisabledColor = System.Drawing.Color.Gray;
            this.product_searchbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.product_searchbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.product_searchbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("product_searchbutton.Iconimage")));
            this.product_searchbutton.Iconimage_right = null;
            this.product_searchbutton.Iconimage_right_Selected = null;
            this.product_searchbutton.Iconimage_Selected = null;
            this.product_searchbutton.IconMarginLeft = 0;
            this.product_searchbutton.IconMarginRight = 0;
            this.product_searchbutton.IconRightVisible = true;
            this.product_searchbutton.IconRightZoom = 0D;
            this.product_searchbutton.IconVisible = true;
            this.product_searchbutton.IconZoom = 90D;
            this.product_searchbutton.IsTab = false;
            this.product_searchbutton.Location = new System.Drawing.Point(3, 64);
            this.product_searchbutton.Name = "product_searchbutton";
            this.product_searchbutton.Normalcolor = System.Drawing.Color.White;
            this.product_searchbutton.OnHovercolor = System.Drawing.Color.Cyan;
            this.product_searchbutton.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.product_searchbutton.selected = false;
            this.product_searchbutton.Size = new System.Drawing.Size(200, 55);
            this.product_searchbutton.TabIndex = 6;
            this.product_searchbutton.Text = "Search Product";
            this.product_searchbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.product_searchbutton.Textcolor = System.Drawing.Color.White;
            this.product_searchbutton.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_searchbutton.Click += new System.EventHandler(this.product_searchbutton_Click_1);
            // 
            // product_deletebutton
            // 
            this.product_deletebutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.product_deletebutton.BackColor = System.Drawing.Color.White;
            this.product_deletebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("product_deletebutton.BackgroundImage")));
            this.product_deletebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.product_deletebutton.BorderRadius = 0;
            this.product_deletebutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.product_deletebutton.ButtonText = "Delete Product";
            this.product_deletebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product_deletebutton.DisabledColor = System.Drawing.Color.Gray;
            this.product_deletebutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.product_deletebutton.Iconcolor = System.Drawing.Color.Transparent;
            this.product_deletebutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("product_deletebutton.Iconimage")));
            this.product_deletebutton.Iconimage_right = null;
            this.product_deletebutton.Iconimage_right_Selected = null;
            this.product_deletebutton.Iconimage_Selected = null;
            this.product_deletebutton.IconMarginLeft = 0;
            this.product_deletebutton.IconMarginRight = 0;
            this.product_deletebutton.IconRightVisible = true;
            this.product_deletebutton.IconRightZoom = 0D;
            this.product_deletebutton.IconVisible = true;
            this.product_deletebutton.IconZoom = 90D;
            this.product_deletebutton.IsTab = false;
            this.product_deletebutton.Location = new System.Drawing.Point(209, 64);
            this.product_deletebutton.Name = "product_deletebutton";
            this.product_deletebutton.Normalcolor = System.Drawing.Color.White;
            this.product_deletebutton.OnHovercolor = System.Drawing.Color.Cyan;
            this.product_deletebutton.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.product_deletebutton.selected = false;
            this.product_deletebutton.Size = new System.Drawing.Size(200, 55);
            this.product_deletebutton.TabIndex = 7;
            this.product_deletebutton.Text = "Delete Product";
            this.product_deletebutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.product_deletebutton.Textcolor = System.Drawing.Color.White;
            this.product_deletebutton.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_deletebutton.Click += new System.EventHandler(this.product_deletebutton_Click_1);
            // 
            // product_clearbutton
            // 
            this.product_clearbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.product_clearbutton.BackColor = System.Drawing.Color.White;
            this.product_clearbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("product_clearbutton.BackgroundImage")));
            this.product_clearbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.product_clearbutton.BorderRadius = 0;
            this.product_clearbutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.product_clearbutton.ButtonText = "Clear All";
            this.product_clearbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product_clearbutton.DisabledColor = System.Drawing.Color.Gray;
            this.product_clearbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.product_clearbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.product_clearbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("product_clearbutton.Iconimage")));
            this.product_clearbutton.Iconimage_right = null;
            this.product_clearbutton.Iconimage_right_Selected = null;
            this.product_clearbutton.Iconimage_Selected = null;
            this.product_clearbutton.IconMarginLeft = 0;
            this.product_clearbutton.IconMarginRight = 0;
            this.product_clearbutton.IconRightVisible = true;
            this.product_clearbutton.IconRightZoom = 0D;
            this.product_clearbutton.IconVisible = true;
            this.product_clearbutton.IconZoom = 90D;
            this.product_clearbutton.IsTab = false;
            this.product_clearbutton.Location = new System.Drawing.Point(415, 64);
            this.product_clearbutton.Name = "product_clearbutton";
            this.product_clearbutton.Normalcolor = System.Drawing.Color.White;
            this.product_clearbutton.OnHovercolor = System.Drawing.Color.Cyan;
            this.product_clearbutton.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.product_clearbutton.selected = false;
            this.product_clearbutton.Size = new System.Drawing.Size(200, 55);
            this.product_clearbutton.TabIndex = 8;
            this.product_clearbutton.Text = "Clear All";
            this.product_clearbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.product_clearbutton.Textcolor = System.Drawing.Color.White;
            this.product_clearbutton.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_clearbutton.Click += new System.EventHandler(this.product_clearbutton_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.product_displaylabel);
            this.panel3.Controls.Add(this.product_searchentry);
            this.panel3.Controls.Add(this.product_searchchoice);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(275, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(625, 41);
            this.panel3.TabIndex = 57;
            // 
            // product_displaylabel
            // 
            this.product_displaylabel.AutoSize = true;
            this.product_displaylabel.BackColor = System.Drawing.Color.Transparent;
            this.product_displaylabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_displaylabel.ForeColor = System.Drawing.Color.Transparent;
            this.product_displaylabel.Location = new System.Drawing.Point(239, 16);
            this.product_displaylabel.Name = "product_displaylabel";
            this.product_displaylabel.Size = new System.Drawing.Size(0, 18);
            this.product_displaylabel.TabIndex = 50;
            // 
            // product_searchentry
            // 
            this.product_searchentry.BorderColorFocused = System.Drawing.Color.Blue;
            this.product_searchentry.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.product_searchentry.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.product_searchentry.BorderThickness = 3;
            this.product_searchentry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.product_searchentry.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_searchentry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.product_searchentry.isPassword = false;
            this.product_searchentry.Location = new System.Drawing.Point(402, 10);
            this.product_searchentry.Margin = new System.Windows.Forms.Padding(4);
            this.product_searchentry.Name = "product_searchentry";
            this.product_searchentry.Size = new System.Drawing.Size(220, 25);
            this.product_searchentry.TabIndex = 49;
            this.product_searchentry.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // product_searchchoice
            // 
            this.product_searchchoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.product_searchchoice.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_searchchoice.FormattingEnabled = true;
            this.product_searchchoice.Items.AddRange(new object[] {
            "By Product ID",
            "By Product Name"});
            this.product_searchchoice.Location = new System.Drawing.Point(83, 12);
            this.product_searchchoice.Name = "product_searchchoice";
            this.product_searchchoice.Size = new System.Drawing.Size(150, 23);
            this.product_searchchoice.TabIndex = 47;
            this.product_searchchoice.SelectedIndexChanged += new System.EventHandler(this.product_searchchoice_SelectedIndexChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(2, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 19);
            this.label9.TabIndex = 48;
            this.label9.Text = "Search By";
            // 
            // prroduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.product_datagrid);
            this.Controls.Add(this.panel1);
            this.Name = "prroduct";
            this.Size = new System.Drawing.Size(900, 550);
            this.Load += new System.EventHandler(this.prroduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox product_productname;
        private Bunifu.Framework.UI.BunifuMetroTextbox product_productid;
        private System.Windows.Forms.ComboBox product_category_id;
        private Bunifu.Framework.UI.BunifuCustomDataGrid product_datagrid;
        private System.Windows.Forms.BindingSource productBindingSource;
        private bakeryDataSet3 bakeryDataSet3;
        private bakeryDataSet2 bakeryDataSet2;
        private System.Windows.Forms.BindingSource bakeryDataSet2BindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private bakeryDataSet2TableAdapters.usersTableAdapter usersTableAdapter;
        private bakeryDataSet3TableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton product_addbutton;
        private Bunifu.Framework.UI.BunifuFlatButton product_showallbutton;
        private Bunifu.Framework.UI.BunifuFlatButton product_updatebutton;
        private Bunifu.Framework.UI.BunifuFlatButton product_searchbutton;
        private Bunifu.Framework.UI.BunifuFlatButton product_deletebutton;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox product_searchentry;
        private System.Windows.Forms.ComboBox product_searchchoice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label product_displaylabel;
        private Bunifu.Framework.UI.BunifuFlatButton product_clearbutton;
        private System.Windows.Forms.Label label4;
    }
}
