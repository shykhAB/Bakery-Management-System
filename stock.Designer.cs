namespace project
{
    partial class stock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stock));
            this.stock_searchentry = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.stock_displaylabel = new System.Windows.Forms.Label();
            this.stock_searchchoice = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bakeryDataSet11 = new project.bakeryDataSet11();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new project.bakeryDataSet11TableAdapters.stockTableAdapter();
            this.bakeryDataSet16 = new project.bakeryDataSet16();
            this.stockBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter1 = new project.bakeryDataSet16TableAdapters.stockTableAdapter();
            this.stock_datagrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bakeryDataSet18 = new project.bakeryDataSet18();
            this.bakeryDataSet18BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bakeryDataSet16BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bakeryDataSet20 = new project.bakeryDataSet20();
            this.productTableAdapter = new project.bakeryDataSet20TableAdapters.productTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stock_showallbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.stock_searchbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet18BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet16BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet20)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // stock_searchentry
            // 
            this.stock_searchentry.BackColor = System.Drawing.Color.White;
            this.stock_searchentry.BorderColorFocused = System.Drawing.Color.Blue;
            this.stock_searchentry.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stock_searchentry.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.stock_searchentry.BorderThickness = 3;
            this.stock_searchentry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stock_searchentry.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_searchentry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stock_searchentry.isPassword = false;
            this.stock_searchentry.Location = new System.Drawing.Point(574, 10);
            this.stock_searchentry.Margin = new System.Windows.Forms.Padding(5);
            this.stock_searchentry.Name = "stock_searchentry";
            this.stock_searchentry.Size = new System.Drawing.Size(321, 30);
            this.stock_searchentry.TabIndex = 30;
            this.stock_searchentry.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // stock_displaylabel
            // 
            this.stock_displaylabel.AutoSize = true;
            this.stock_displaylabel.BackColor = System.Drawing.Color.Transparent;
            this.stock_displaylabel.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_displaylabel.ForeColor = System.Drawing.Color.White;
            this.stock_displaylabel.Location = new System.Drawing.Point(311, 15);
            this.stock_displaylabel.Name = "stock_displaylabel";
            this.stock_displaylabel.Size = new System.Drawing.Size(0, 19);
            this.stock_displaylabel.TabIndex = 29;
            // 
            // stock_searchchoice
            // 
            this.stock_searchchoice.BackColor = System.Drawing.Color.White;
            this.stock_searchchoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stock_searchchoice.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_searchchoice.FormattingEnabled = true;
            this.stock_searchchoice.Items.AddRange(new object[] {
            "By Product ID",
            "By Product Name"});
            this.stock_searchchoice.Location = new System.Drawing.Point(111, 10);
            this.stock_searchchoice.Name = "stock_searchchoice";
            this.stock_searchchoice.Size = new System.Drawing.Size(194, 30);
            this.stock_searchchoice.TabIndex = 27;
            this.stock_searchchoice.SelectedIndexChanged += new System.EventHandler(this.stock_searchchoice_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 24);
            this.label9.TabIndex = 28;
            this.label9.Text = "Search By";
            // 
            // bakeryDataSet11
            // 
            this.bakeryDataSet11.DataSetName = "bakeryDataSet11";
            this.bakeryDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "stock";
            this.stockBindingSource.DataSource = this.bakeryDataSet11;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // bakeryDataSet16
            // 
            this.bakeryDataSet16.DataSetName = "bakeryDataSet16";
            this.bakeryDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockBindingSource1
            // 
            this.stockBindingSource1.DataMember = "stock";
            this.stockBindingSource1.DataSource = this.bakeryDataSet16;
            // 
            // stockTableAdapter1
            // 
            this.stockTableAdapter1.ClearBeforeFill = true;
            // 
            // stock_datagrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.stock_datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.stock_datagrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.stock_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stock_datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stock_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.stock_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stock_datagrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stock_datagrid.DoubleBuffered = true;
            this.stock_datagrid.EnableHeadersVisualStyles = false;
            this.stock_datagrid.HeaderBgColor = System.Drawing.Color.DimGray;
            this.stock_datagrid.HeaderForeColor = System.Drawing.Color.White;
            this.stock_datagrid.Location = new System.Drawing.Point(0, 151);
            this.stock_datagrid.Name = "stock_datagrid";
            this.stock_datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.stock_datagrid.RowHeadersWidth = 80;
            this.stock_datagrid.Size = new System.Drawing.Size(900, 399);
            this.stock_datagrid.TabIndex = 33;
            // 
            // bakeryDataSet18
            // 
            this.bakeryDataSet18.DataSetName = "bakeryDataSet18";
            this.bakeryDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bakeryDataSet18BindingSource
            // 
            this.bakeryDataSet18BindingSource.DataSource = this.bakeryDataSet18;
            this.bakeryDataSet18BindingSource.Position = 0;
            // 
            // bakeryDataSet16BindingSource
            // 
            this.bakeryDataSet16BindingSource.DataSource = this.bakeryDataSet16;
            this.bakeryDataSet16BindingSource.Position = 0;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.bakeryDataSet20;
            // 
            // bakeryDataSet20
            // 
            this.bakeryDataSet20.DataSetName = "bakeryDataSet20";
            this.bakeryDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.stock_showallbutton);
            this.panel1.Controls.Add(this.stock_searchbutton);
            this.panel1.Controls.Add(this.stock_searchentry);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.stock_searchchoice);
            this.panel1.Controls.Add(this.stock_displaylabel);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 119);
            this.panel1.TabIndex = 34;
            // 
            // stock_showallbutton
            // 
            this.stock_showallbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.stock_showallbutton.BackColor = System.Drawing.Color.White;
            this.stock_showallbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stock_showallbutton.BackgroundImage")));
            this.stock_showallbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stock_showallbutton.BorderRadius = 0;
            this.stock_showallbutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stock_showallbutton.ButtonText = "Show All";
            this.stock_showallbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stock_showallbutton.DisabledColor = System.Drawing.Color.Gray;
            this.stock_showallbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.stock_showallbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("stock_showallbutton.Iconimage")));
            this.stock_showallbutton.Iconimage_right = null;
            this.stock_showallbutton.Iconimage_right_Selected = null;
            this.stock_showallbutton.Iconimage_Selected = null;
            this.stock_showallbutton.IconMarginLeft = 0;
            this.stock_showallbutton.IconMarginRight = 0;
            this.stock_showallbutton.IconRightVisible = true;
            this.stock_showallbutton.IconRightZoom = 0D;
            this.stock_showallbutton.IconVisible = true;
            this.stock_showallbutton.IconZoom = 90D;
            this.stock_showallbutton.IsTab = false;
            this.stock_showallbutton.Location = new System.Drawing.Point(480, 60);
            this.stock_showallbutton.Name = "stock_showallbutton";
            this.stock_showallbutton.Normalcolor = System.Drawing.Color.White;
            this.stock_showallbutton.OnHovercolor = System.Drawing.Color.Cyan;
            this.stock_showallbutton.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.stock_showallbutton.selected = false;
            this.stock_showallbutton.Size = new System.Drawing.Size(200, 55);
            this.stock_showallbutton.TabIndex = 33;
            this.stock_showallbutton.Text = "Show All";
            this.stock_showallbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.stock_showallbutton.Textcolor = System.Drawing.Color.White;
            this.stock_showallbutton.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_showallbutton.Click += new System.EventHandler(this.stock_showallbutton_Click);
            // 
            // stock_searchbutton
            // 
            this.stock_searchbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.stock_searchbutton.BackColor = System.Drawing.Color.White;
            this.stock_searchbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stock_searchbutton.BackgroundImage")));
            this.stock_searchbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stock_searchbutton.BorderRadius = 0;
            this.stock_searchbutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stock_searchbutton.ButtonText = "Search Stock";
            this.stock_searchbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stock_searchbutton.DisabledColor = System.Drawing.Color.Gray;
            this.stock_searchbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.stock_searchbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("stock_searchbutton.Iconimage")));
            this.stock_searchbutton.Iconimage_right = null;
            this.stock_searchbutton.Iconimage_right_Selected = null;
            this.stock_searchbutton.Iconimage_Selected = null;
            this.stock_searchbutton.IconMarginLeft = 0;
            this.stock_searchbutton.IconMarginRight = 0;
            this.stock_searchbutton.IconRightVisible = true;
            this.stock_searchbutton.IconRightZoom = 0D;
            this.stock_searchbutton.IconVisible = true;
            this.stock_searchbutton.IconZoom = 90D;
            this.stock_searchbutton.IsTab = false;
            this.stock_searchbutton.Location = new System.Drawing.Point(215, 60);
            this.stock_searchbutton.Name = "stock_searchbutton";
            this.stock_searchbutton.Normalcolor = System.Drawing.Color.White;
            this.stock_searchbutton.OnHovercolor = System.Drawing.Color.Cyan;
            this.stock_searchbutton.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.stock_searchbutton.selected = false;
            this.stock_searchbutton.Size = new System.Drawing.Size(200, 55);
            this.stock_searchbutton.TabIndex = 34;
            this.stock_searchbutton.Text = "Search Stock";
            this.stock_searchbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.stock_searchbutton.Textcolor = System.Drawing.Color.White;
            this.stock_searchbutton.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_searchbutton.Click += new System.EventHandler(this.stock_searchbutton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.backButton);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 30);
            this.panel2.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(343, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Stock Available";
            // 
            // backButton
            // 
            this.backButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(0, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(40, 30);
            this.backButton.TabIndex = 0;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.stock_datagrid);
            this.Name = "stock";
            this.Size = new System.Drawing.Size(900, 550);
            this.Load += new System.EventHandler(this.stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet18BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet16BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet20)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox stock_searchentry;
        private System.Windows.Forms.Label stock_displaylabel;
        private System.Windows.Forms.ComboBox stock_searchchoice;
        private System.Windows.Forms.Label label9;
        private bakeryDataSet11 bakeryDataSet11;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private bakeryDataSet11TableAdapters.stockTableAdapter stockTableAdapter;
        private System.Windows.Forms.BindingSource stockBindingSource1;
        private bakeryDataSet16 bakeryDataSet16;
        private bakeryDataSet16TableAdapters.stockTableAdapter stockTableAdapter1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid stock_datagrid;
        private System.Windows.Forms.BindingSource productBindingSource;
        private bakeryDataSet20 bakeryDataSet20;
        private bakeryDataSet18 bakeryDataSet18;
        private System.Windows.Forms.BindingSource bakeryDataSet18BindingSource;
        private bakeryDataSet20TableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource bakeryDataSet16BindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private Bunifu.Framework.UI.BunifuFlatButton stock_showallbutton;
        private Bunifu.Framework.UI.BunifuFlatButton stock_searchbutton;
    }
}
