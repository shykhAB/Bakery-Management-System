namespace project
{
    partial class main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.main_exitbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.main_changepassbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.main_userbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.main_supplierbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.main_productbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.main_categorybutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.main_stockbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.main_purchasebutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.main_salebutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sale1 = new project.sale_displaylabe();
            this.purchase1 = new project.purchase();
            this.user1 = new project.user();
            this.suppliers1 = new project.suppliers();
            this.stock1 = new project.stock();
            this.prroduct1 = new project.prroduct();
            this.changepassword1 = new project.changepassword();
            this.category1 = new project.category();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 115);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(118, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(84, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(118, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bakery ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "____________________";
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelmenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelmenu.BackgroundImage")));
            this.panelmenu.Controls.Add(this.main_exitbutton);
            this.panelmenu.Controls.Add(this.main_changepassbutton);
            this.panelmenu.Controls.Add(this.main_userbutton);
            this.panelmenu.Controls.Add(this.main_supplierbutton);
            this.panelmenu.Controls.Add(this.main_productbutton);
            this.panelmenu.Controls.Add(this.main_categorybutton);
            this.panelmenu.Controls.Add(this.main_stockbutton);
            this.panelmenu.Controls.Add(this.main_purchasebutton);
            this.panelmenu.Controls.Add(this.main_salebutton);
            this.panelmenu.Controls.Add(this.panel1);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(250, 550);
            this.panelmenu.TabIndex = 0;
            this.panelmenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelmenu_Paint);
            // 
            // main_exitbutton
            // 
            this.main_exitbutton.Activecolor = System.Drawing.Color.Gray;
            this.main_exitbutton.BackColor = System.Drawing.Color.Honeydew;
            this.main_exitbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("main_exitbutton.BackgroundImage")));
            this.main_exitbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.main_exitbutton.BorderRadius = 0;
            this.main_exitbutton.ButtonText = "Exit";
            this.main_exitbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_exitbutton.DisabledColor = System.Drawing.Color.Gray;
            this.main_exitbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_exitbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.main_exitbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("main_exitbutton.Iconimage")));
            this.main_exitbutton.Iconimage_right = null;
            this.main_exitbutton.Iconimage_right_Selected = null;
            this.main_exitbutton.Iconimage_Selected = null;
            this.main_exitbutton.IconMarginLeft = 0;
            this.main_exitbutton.IconMarginRight = 0;
            this.main_exitbutton.IconRightVisible = true;
            this.main_exitbutton.IconRightZoom = 0D;
            this.main_exitbutton.IconVisible = true;
            this.main_exitbutton.IconZoom = 85D;
            this.main_exitbutton.IsTab = false;
            this.main_exitbutton.Location = new System.Drawing.Point(0, 499);
            this.main_exitbutton.Name = "main_exitbutton";
            this.main_exitbutton.Normalcolor = System.Drawing.Color.Honeydew;
            this.main_exitbutton.OnHovercolor = System.Drawing.Color.Cyan;
            this.main_exitbutton.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.main_exitbutton.selected = false;
            this.main_exitbutton.Size = new System.Drawing.Size(250, 48);
            this.main_exitbutton.TabIndex = 9;
            this.main_exitbutton.Text = "Exit";
            this.main_exitbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.main_exitbutton.Textcolor = System.Drawing.Color.White;
            this.main_exitbutton.TextFont = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_exitbutton.Click += new System.EventHandler(this.main_exitbutton_Click);
            // 
            // main_changepassbutton
            // 
            this.main_changepassbutton.Activecolor = System.Drawing.Color.Gray;
            this.main_changepassbutton.BackColor = System.Drawing.Color.Honeydew;
            this.main_changepassbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("main_changepassbutton.BackgroundImage")));
            this.main_changepassbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.main_changepassbutton.BorderRadius = 0;
            this.main_changepassbutton.ButtonText = "Change Password";
            this.main_changepassbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_changepassbutton.DisabledColor = System.Drawing.Color.Gray;
            this.main_changepassbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_changepassbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.main_changepassbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("main_changepassbutton.Iconimage")));
            this.main_changepassbutton.Iconimage_right = null;
            this.main_changepassbutton.Iconimage_right_Selected = null;
            this.main_changepassbutton.Iconimage_Selected = null;
            this.main_changepassbutton.IconMarginLeft = 0;
            this.main_changepassbutton.IconMarginRight = 0;
            this.main_changepassbutton.IconRightVisible = true;
            this.main_changepassbutton.IconRightZoom = 0D;
            this.main_changepassbutton.IconVisible = true;
            this.main_changepassbutton.IconZoom = 85D;
            this.main_changepassbutton.IsTab = false;
            this.main_changepassbutton.Location = new System.Drawing.Point(0, 451);
            this.main_changepassbutton.Name = "main_changepassbutton";
            this.main_changepassbutton.Normalcolor = System.Drawing.Color.Honeydew;
            this.main_changepassbutton.OnHovercolor = System.Drawing.Color.Cyan;
            this.main_changepassbutton.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.main_changepassbutton.selected = false;
            this.main_changepassbutton.Size = new System.Drawing.Size(250, 48);
            this.main_changepassbutton.TabIndex = 8;
            this.main_changepassbutton.Text = "Change Password";
            this.main_changepassbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.main_changepassbutton.Textcolor = System.Drawing.Color.White;
            this.main_changepassbutton.TextFont = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_changepassbutton.Click += new System.EventHandler(this.main_changepassbutton_Click_1);
            // 
            // main_userbutton
            // 
            this.main_userbutton.Activecolor = System.Drawing.Color.Gray;
            this.main_userbutton.BackColor = System.Drawing.Color.Honeydew;
            this.main_userbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("main_userbutton.BackgroundImage")));
            this.main_userbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.main_userbutton.BorderRadius = 0;
            this.main_userbutton.ButtonText = "Users";
            this.main_userbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_userbutton.DisabledColor = System.Drawing.Color.Gray;
            this.main_userbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_userbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.main_userbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("main_userbutton.Iconimage")));
            this.main_userbutton.Iconimage_right = null;
            this.main_userbutton.Iconimage_right_Selected = null;
            this.main_userbutton.Iconimage_Selected = null;
            this.main_userbutton.IconMarginLeft = 0;
            this.main_userbutton.IconMarginRight = 0;
            this.main_userbutton.IconRightVisible = true;
            this.main_userbutton.IconRightZoom = 0D;
            this.main_userbutton.IconVisible = true;
            this.main_userbutton.IconZoom = 85D;
            this.main_userbutton.IsTab = false;
            this.main_userbutton.Location = new System.Drawing.Point(0, 403);
            this.main_userbutton.Name = "main_userbutton";
            this.main_userbutton.Normalcolor = System.Drawing.Color.Honeydew;
            this.main_userbutton.OnHovercolor = System.Drawing.Color.Cyan;
            this.main_userbutton.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.main_userbutton.selected = false;
            this.main_userbutton.Size = new System.Drawing.Size(250, 48);
            this.main_userbutton.TabIndex = 7;
            this.main_userbutton.Text = "Users";
            this.main_userbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.main_userbutton.Textcolor = System.Drawing.Color.White;
            this.main_userbutton.TextFont = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_userbutton.Click += new System.EventHandler(this.main_userbutton_Click_1);
            // 
            // main_supplierbutton
            // 
            this.main_supplierbutton.Activecolor = System.Drawing.Color.Gray;
            this.main_supplierbutton.BackColor = System.Drawing.Color.Honeydew;
            this.main_supplierbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("main_supplierbutton.BackgroundImage")));
            this.main_supplierbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.main_supplierbutton.BorderRadius = 0;
            this.main_supplierbutton.ButtonText = "Supplier";
            this.main_supplierbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_supplierbutton.DisabledColor = System.Drawing.Color.Gray;
            this.main_supplierbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_supplierbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.main_supplierbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("main_supplierbutton.Iconimage")));
            this.main_supplierbutton.Iconimage_right = null;
            this.main_supplierbutton.Iconimage_right_Selected = null;
            this.main_supplierbutton.Iconimage_Selected = null;
            this.main_supplierbutton.IconMarginLeft = 0;
            this.main_supplierbutton.IconMarginRight = 0;
            this.main_supplierbutton.IconRightVisible = true;
            this.main_supplierbutton.IconRightZoom = 0D;
            this.main_supplierbutton.IconVisible = true;
            this.main_supplierbutton.IconZoom = 85D;
            this.main_supplierbutton.IsTab = false;
            this.main_supplierbutton.Location = new System.Drawing.Point(0, 355);
            this.main_supplierbutton.Name = "main_supplierbutton";
            this.main_supplierbutton.Normalcolor = System.Drawing.Color.Honeydew;
            this.main_supplierbutton.OnHovercolor = System.Drawing.Color.Cyan;
            this.main_supplierbutton.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.main_supplierbutton.selected = false;
            this.main_supplierbutton.Size = new System.Drawing.Size(250, 48);
            this.main_supplierbutton.TabIndex = 6;
            this.main_supplierbutton.Text = "Supplier";
            this.main_supplierbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.main_supplierbutton.Textcolor = System.Drawing.Color.White;
            this.main_supplierbutton.TextFont = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_supplierbutton.Click += new System.EventHandler(this.main_supplierbutton_Click_1);
            // 
            // main_productbutton
            // 
            this.main_productbutton.Activecolor = System.Drawing.Color.Gray;
            this.main_productbutton.BackColor = System.Drawing.Color.Honeydew;
            this.main_productbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("main_productbutton.BackgroundImage")));
            this.main_productbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.main_productbutton.BorderRadius = 0;
            this.main_productbutton.ButtonText = "Product";
            this.main_productbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_productbutton.DisabledColor = System.Drawing.Color.Gray;
            this.main_productbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_productbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.main_productbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("main_productbutton.Iconimage")));
            this.main_productbutton.Iconimage_right = null;
            this.main_productbutton.Iconimage_right_Selected = null;
            this.main_productbutton.Iconimage_Selected = null;
            this.main_productbutton.IconMarginLeft = 0;
            this.main_productbutton.IconMarginRight = 0;
            this.main_productbutton.IconRightVisible = true;
            this.main_productbutton.IconRightZoom = 0D;
            this.main_productbutton.IconVisible = true;
            this.main_productbutton.IconZoom = 85D;
            this.main_productbutton.IsTab = false;
            this.main_productbutton.Location = new System.Drawing.Point(0, 307);
            this.main_productbutton.Name = "main_productbutton";
            this.main_productbutton.Normalcolor = System.Drawing.Color.Honeydew;
            this.main_productbutton.OnHovercolor = System.Drawing.Color.Cyan;
            this.main_productbutton.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.main_productbutton.selected = false;
            this.main_productbutton.Size = new System.Drawing.Size(250, 48);
            this.main_productbutton.TabIndex = 5;
            this.main_productbutton.Text = "Product";
            this.main_productbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.main_productbutton.Textcolor = System.Drawing.Color.White;
            this.main_productbutton.TextFont = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_productbutton.Click += new System.EventHandler(this.main_productbutton_Click_1);
            // 
            // main_categorybutton
            // 
            this.main_categorybutton.Activecolor = System.Drawing.Color.Gray;
            this.main_categorybutton.BackColor = System.Drawing.Color.Honeydew;
            this.main_categorybutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("main_categorybutton.BackgroundImage")));
            this.main_categorybutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.main_categorybutton.BorderRadius = 0;
            this.main_categorybutton.ButtonText = "Category";
            this.main_categorybutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_categorybutton.DisabledColor = System.Drawing.Color.Gray;
            this.main_categorybutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_categorybutton.Iconcolor = System.Drawing.Color.Transparent;
            this.main_categorybutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("main_categorybutton.Iconimage")));
            this.main_categorybutton.Iconimage_right = null;
            this.main_categorybutton.Iconimage_right_Selected = null;
            this.main_categorybutton.Iconimage_Selected = null;
            this.main_categorybutton.IconMarginLeft = 0;
            this.main_categorybutton.IconMarginRight = 0;
            this.main_categorybutton.IconRightVisible = true;
            this.main_categorybutton.IconRightZoom = 0D;
            this.main_categorybutton.IconVisible = true;
            this.main_categorybutton.IconZoom = 85D;
            this.main_categorybutton.IsTab = false;
            this.main_categorybutton.Location = new System.Drawing.Point(0, 259);
            this.main_categorybutton.Name = "main_categorybutton";
            this.main_categorybutton.Normalcolor = System.Drawing.Color.Honeydew;
            this.main_categorybutton.OnHovercolor = System.Drawing.Color.Cyan;
            this.main_categorybutton.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.main_categorybutton.selected = false;
            this.main_categorybutton.Size = new System.Drawing.Size(250, 48);
            this.main_categorybutton.TabIndex = 4;
            this.main_categorybutton.Text = "Category";
            this.main_categorybutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.main_categorybutton.Textcolor = System.Drawing.Color.White;
            this.main_categorybutton.TextFont = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_categorybutton.Click += new System.EventHandler(this.main_categorybutton_Click_1);
            // 
            // main_stockbutton
            // 
            this.main_stockbutton.Activecolor = System.Drawing.Color.Gray;
            this.main_stockbutton.BackColor = System.Drawing.Color.Honeydew;
            this.main_stockbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("main_stockbutton.BackgroundImage")));
            this.main_stockbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.main_stockbutton.BorderRadius = 0;
            this.main_stockbutton.ButtonText = "Stock";
            this.main_stockbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_stockbutton.DisabledColor = System.Drawing.Color.Gray;
            this.main_stockbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_stockbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.main_stockbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("main_stockbutton.Iconimage")));
            this.main_stockbutton.Iconimage_right = null;
            this.main_stockbutton.Iconimage_right_Selected = null;
            this.main_stockbutton.Iconimage_Selected = null;
            this.main_stockbutton.IconMarginLeft = 0;
            this.main_stockbutton.IconMarginRight = 0;
            this.main_stockbutton.IconRightVisible = true;
            this.main_stockbutton.IconRightZoom = 0D;
            this.main_stockbutton.IconVisible = true;
            this.main_stockbutton.IconZoom = 85D;
            this.main_stockbutton.IsTab = false;
            this.main_stockbutton.Location = new System.Drawing.Point(0, 211);
            this.main_stockbutton.Name = "main_stockbutton";
            this.main_stockbutton.Normalcolor = System.Drawing.Color.Honeydew;
            this.main_stockbutton.OnHovercolor = System.Drawing.Color.Cyan;
            this.main_stockbutton.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.main_stockbutton.selected = false;
            this.main_stockbutton.Size = new System.Drawing.Size(250, 48);
            this.main_stockbutton.TabIndex = 3;
            this.main_stockbutton.Text = "Stock";
            this.main_stockbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.main_stockbutton.Textcolor = System.Drawing.Color.White;
            this.main_stockbutton.TextFont = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_stockbutton.Click += new System.EventHandler(this.main_stockbutton_Click_1);
            // 
            // main_purchasebutton
            // 
            this.main_purchasebutton.Activecolor = System.Drawing.Color.Gray;
            this.main_purchasebutton.BackColor = System.Drawing.Color.Honeydew;
            this.main_purchasebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("main_purchasebutton.BackgroundImage")));
            this.main_purchasebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.main_purchasebutton.BorderRadius = 0;
            this.main_purchasebutton.ButtonText = "Purchase Stock";
            this.main_purchasebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_purchasebutton.DisabledColor = System.Drawing.Color.Gray;
            this.main_purchasebutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_purchasebutton.Iconcolor = System.Drawing.Color.Transparent;
            this.main_purchasebutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("main_purchasebutton.Iconimage")));
            this.main_purchasebutton.Iconimage_right = null;
            this.main_purchasebutton.Iconimage_right_Selected = null;
            this.main_purchasebutton.Iconimage_Selected = null;
            this.main_purchasebutton.IconMarginLeft = 0;
            this.main_purchasebutton.IconMarginRight = 0;
            this.main_purchasebutton.IconRightVisible = true;
            this.main_purchasebutton.IconRightZoom = 0D;
            this.main_purchasebutton.IconVisible = true;
            this.main_purchasebutton.IconZoom = 85D;
            this.main_purchasebutton.IsTab = false;
            this.main_purchasebutton.Location = new System.Drawing.Point(0, 163);
            this.main_purchasebutton.Name = "main_purchasebutton";
            this.main_purchasebutton.Normalcolor = System.Drawing.Color.Honeydew;
            this.main_purchasebutton.OnHovercolor = System.Drawing.Color.Cyan;
            this.main_purchasebutton.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.main_purchasebutton.selected = false;
            this.main_purchasebutton.Size = new System.Drawing.Size(250, 48);
            this.main_purchasebutton.TabIndex = 2;
            this.main_purchasebutton.Text = "Purchase Stock";
            this.main_purchasebutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.main_purchasebutton.Textcolor = System.Drawing.Color.White;
            this.main_purchasebutton.TextFont = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_purchasebutton.Click += new System.EventHandler(this.main_purchasebutton_Click_1);
            // 
            // main_salebutton
            // 
            this.main_salebutton.Activecolor = System.Drawing.Color.Gray;
            this.main_salebutton.BackColor = System.Drawing.Color.Transparent;
            this.main_salebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("main_salebutton.BackgroundImage")));
            this.main_salebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.main_salebutton.BorderRadius = 0;
            this.main_salebutton.ButtonText = "Sale";
            this.main_salebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_salebutton.DisabledColor = System.Drawing.Color.Gray;
            this.main_salebutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_salebutton.Iconcolor = System.Drawing.Color.Transparent;
            this.main_salebutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("main_salebutton.Iconimage")));
            this.main_salebutton.Iconimage_right = null;
            this.main_salebutton.Iconimage_right_Selected = null;
            this.main_salebutton.Iconimage_Selected = null;
            this.main_salebutton.IconMarginLeft = 0;
            this.main_salebutton.IconMarginRight = 0;
            this.main_salebutton.IconRightVisible = true;
            this.main_salebutton.IconRightZoom = 0D;
            this.main_salebutton.IconVisible = true;
            this.main_salebutton.IconZoom = 85D;
            this.main_salebutton.IsTab = false;
            this.main_salebutton.Location = new System.Drawing.Point(0, 115);
            this.main_salebutton.Name = "main_salebutton";
            this.main_salebutton.Normalcolor = System.Drawing.Color.Transparent;
            this.main_salebutton.OnHovercolor = System.Drawing.Color.Cyan;
            this.main_salebutton.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.main_salebutton.selected = false;
            this.main_salebutton.Size = new System.Drawing.Size(250, 48);
            this.main_salebutton.TabIndex = 1;
            this.main_salebutton.Text = "Sale";
            this.main_salebutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.main_salebutton.Textcolor = System.Drawing.Color.White;
            this.main_salebutton.TextFont = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_salebutton.Click += new System.EventHandler(this.main_salebutton_Click_1);
            // 
            // sale1
            // 
            this.sale1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sale1.Location = new System.Drawing.Point(250, 0);
            this.sale1.Name = "sale1";
            this.sale1.Size = new System.Drawing.Size(900, 550);
            this.sale1.TabIndex = 8;
            // 
            // purchase1
            // 
            this.purchase1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchase1.Location = new System.Drawing.Point(250, 0);
            this.purchase1.Name = "purchase1";
            this.purchase1.Size = new System.Drawing.Size(900, 550);
            this.purchase1.TabIndex = 7;
            // 
            // user1
            // 
            this.user1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user1.Location = new System.Drawing.Point(250, 0);
            this.user1.Name = "user1";
            this.user1.Size = new System.Drawing.Size(900, 550);
            this.user1.TabIndex = 6;
            // 
            // suppliers1
            // 
            this.suppliers1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suppliers1.Location = new System.Drawing.Point(250, 0);
            this.suppliers1.Name = "suppliers1";
            this.suppliers1.Size = new System.Drawing.Size(900, 550);
            this.suppliers1.TabIndex = 5;
            // 
            // stock1
            // 
            this.stock1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stock1.Location = new System.Drawing.Point(250, 0);
            this.stock1.Name = "stock1";
            this.stock1.Size = new System.Drawing.Size(900, 550);
            this.stock1.TabIndex = 4;
            // 
            // prroduct1
            // 
            this.prroduct1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prroduct1.Location = new System.Drawing.Point(250, 0);
            this.prroduct1.Name = "prroduct1";
            this.prroduct1.Size = new System.Drawing.Size(900, 550);
            this.prroduct1.TabIndex = 3;
            // 
            // changepassword1
            // 
            this.changepassword1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changepassword1.Location = new System.Drawing.Point(250, 0);
            this.changepassword1.Name = "changepassword1";
            this.changepassword1.Size = new System.Drawing.Size(900, 550);
            this.changepassword1.TabIndex = 2;
            // 
            // category1
            // 
            this.category1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.category1.Location = new System.Drawing.Point(250, 0);
            this.category1.Name = "category1";
            this.category1.Size = new System.Drawing.Size(900, 550);
            this.category1.TabIndex = 1;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1150, 550);
            this.Controls.Add(this.sale1);
            this.Controls.Add(this.purchase1);
            this.Controls.Add(this.user1);
            this.Controls.Add(this.suppliers1);
            this.Controls.Add(this.stock1);
            this.Controls.Add(this.prroduct1);
            this.Controls.Add(this.changepassword1);
            this.Controls.Add(this.category1);
            this.Controls.Add(this.panelmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private sale_displaylabe sale1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelmenu;
        private Bunifu.Framework.UI.BunifuFlatButton main_exitbutton;
        private Bunifu.Framework.UI.BunifuFlatButton main_changepassbutton;
        private Bunifu.Framework.UI.BunifuFlatButton main_userbutton;
        private Bunifu.Framework.UI.BunifuFlatButton main_supplierbutton;
        private Bunifu.Framework.UI.BunifuFlatButton main_productbutton;
        private Bunifu.Framework.UI.BunifuFlatButton main_categorybutton;
        private Bunifu.Framework.UI.BunifuFlatButton main_stockbutton;
        private Bunifu.Framework.UI.BunifuFlatButton main_purchasebutton;
        private Bunifu.Framework.UI.BunifuFlatButton main_salebutton;
        private changepassword changepassword1;
        private stock stock1;
        private suppliers suppliers1;
        private user user1;
        private purchase purchase1;
        private category category1;
        private prroduct prroduct1;
    }
}