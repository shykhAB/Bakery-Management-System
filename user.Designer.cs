namespace project
{
    partial class user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.user_searchentry = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.user_display = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.user_securityqu = new System.Windows.Forms.ComboBox();
            this.user_status = new System.Windows.Forms.ComboBox();
            this.user_contactno = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.user_displaylabel = new System.Windows.Forms.Label();
            this.user_securityans = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.user_password = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.user_searchchoice = new System.Windows.Forms.ComboBox();
            this.user_username = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.user_fullname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.user_userid = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.user_datagrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.useriddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passworddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statussDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.securityquestionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.securityanswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bakeryDataSet2 = new project.bakeryDataSet2();
            this.usersTableAdapter = new project.bakeryDataSet2TableAdapters.usersTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.user_addbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.user_showallbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.user_updatebutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.user_searchbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.user_deletebutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.user_clearbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet2)).BeginInit();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // user_searchentry
            // 
            this.user_searchentry.BorderColorFocused = System.Drawing.Color.Blue;
            this.user_searchentry.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.user_searchentry.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.user_searchentry.BorderThickness = 3;
            this.user_searchentry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user_searchentry.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_searchentry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.user_searchentry.isPassword = false;
            this.user_searchentry.Location = new System.Drawing.Point(401, 9);
            this.user_searchentry.Margin = new System.Windows.Forms.Padding(4);
            this.user_searchentry.Name = "user_searchentry";
            this.user_searchentry.Size = new System.Drawing.Size(220, 25);
            this.user_searchentry.TabIndex = 19;
            this.user_searchentry.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // user_display
            // 
            this.user_display.AutoSize = true;
            this.user_display.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_display.Location = new System.Drawing.Point(552, 19);
            this.user_display.Name = "user_display";
            this.user_display.Size = new System.Drawing.Size(0, 15);
            this.user_display.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(10, 474);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(143, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Security Answer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(10, 415);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(155, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Security Question";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(10, 355);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(61, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(10, 289);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(258, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Contact No (03XXXXXXXXX)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(10, 224);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(10, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(10, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Full Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "User ID";
            // 
            // user_securityqu
            // 
            this.user_securityqu.BackColor = System.Drawing.Color.White;
            this.user_securityqu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.user_securityqu.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_securityqu.FormattingEnabled = true;
            this.user_securityqu.Items.AddRange(new object[] {
            "Who was your childhood hero?",
            "What was your favourite place to visit as a child?",
            "What was your childhood nickname?",
            "What sports team do you love to see lose?"});
            this.user_securityqu.Location = new System.Drawing.Point(11, 440);
            this.user_securityqu.Name = "user_securityqu";
            this.user_securityqu.Size = new System.Drawing.Size(250, 24);
            this.user_securityqu.TabIndex = 7;
            // 
            // user_status
            // 
            this.user_status.BackColor = System.Drawing.Color.White;
            this.user_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.user_status.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_status.FormattingEnabled = true;
            this.user_status.Items.AddRange(new object[] {
            "Active",
            "In-Active"});
            this.user_status.Location = new System.Drawing.Point(10, 380);
            this.user_status.Name = "user_status";
            this.user_status.Size = new System.Drawing.Size(250, 24);
            this.user_status.TabIndex = 6;
            this.user_status.SelectedIndexChanged += new System.EventHandler(this.user_status_SelectedIndexChanged);
            // 
            // user_contactno
            // 
            this.user_contactno.BackColor = System.Drawing.Color.White;
            this.user_contactno.BorderColorFocused = System.Drawing.Color.Blue;
            this.user_contactno.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.user_contactno.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.user_contactno.BorderThickness = 3;
            this.user_contactno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user_contactno.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_contactno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.user_contactno.isPassword = false;
            this.user_contactno.Location = new System.Drawing.Point(10, 315);
            this.user_contactno.Margin = new System.Windows.Forms.Padding(4);
            this.user_contactno.Name = "user_contactno";
            this.user_contactno.Size = new System.Drawing.Size(250, 35);
            this.user_contactno.TabIndex = 4;
            this.user_contactno.Text = "Enter Contact Number";
            this.user_contactno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.user_contactno.OnValueChanged += new System.EventHandler(this.user_contactno_OnValueChanged);
            // 
            // user_displaylabel
            // 
            this.user_displaylabel.AutoSize = true;
            this.user_displaylabel.BackColor = System.Drawing.Color.Transparent;
            this.user_displaylabel.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_displaylabel.ForeColor = System.Drawing.Color.White;
            this.user_displaylabel.Location = new System.Drawing.Point(235, 15);
            this.user_displaylabel.Name = "user_displaylabel";
            this.user_displaylabel.Size = new System.Drawing.Size(0, 19);
            this.user_displaylabel.TabIndex = 18;
            // 
            // user_securityans
            // 
            this.user_securityans.BackColor = System.Drawing.Color.White;
            this.user_securityans.BorderColorFocused = System.Drawing.Color.Blue;
            this.user_securityans.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.user_securityans.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.user_securityans.BorderThickness = 3;
            this.user_securityans.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user_securityans.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_securityans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.user_securityans.isPassword = false;
            this.user_securityans.Location = new System.Drawing.Point(11, 500);
            this.user_securityans.Margin = new System.Windows.Forms.Padding(4);
            this.user_securityans.Name = "user_securityans";
            this.user_securityans.Size = new System.Drawing.Size(250, 35);
            this.user_securityans.TabIndex = 5;
            this.user_securityans.Text = "Enter Above Question\'s Answer";
            this.user_securityans.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // user_password
            // 
            this.user_password.BackColor = System.Drawing.Color.White;
            this.user_password.BorderColorFocused = System.Drawing.Color.Blue;
            this.user_password.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.user_password.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.user_password.BorderThickness = 3;
            this.user_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user_password.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.user_password.isPassword = true;
            this.user_password.Location = new System.Drawing.Point(11, 250);
            this.user_password.Margin = new System.Windows.Forms.Padding(4);
            this.user_password.Name = "user_password";
            this.user_password.Size = new System.Drawing.Size(250, 35);
            this.user_password.TabIndex = 3;
            this.user_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.user_password.OnValueChanged += new System.EventHandler(this.user_password_OnValueChanged);
            // 
            // user_searchchoice
            // 
            this.user_searchchoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.user_searchchoice.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_searchchoice.FormattingEnabled = true;
            this.user_searchchoice.Items.AddRange(new object[] {
            "By User ID",
            "By Username",
            "By Full Name"});
            this.user_searchchoice.Location = new System.Drawing.Point(82, 12);
            this.user_searchchoice.Name = "user_searchchoice";
            this.user_searchchoice.Size = new System.Drawing.Size(150, 23);
            this.user_searchchoice.TabIndex = 15;
            this.user_searchchoice.SelectedIndexChanged += new System.EventHandler(this.user_searchchoice_SelectedIndexChanged);
            // 
            // user_username
            // 
            this.user_username.BackColor = System.Drawing.Color.White;
            this.user_username.BorderColorFocused = System.Drawing.Color.Blue;
            this.user_username.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.user_username.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.user_username.BorderThickness = 3;
            this.user_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user_username.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.user_username.isPassword = false;
            this.user_username.Location = new System.Drawing.Point(10, 185);
            this.user_username.Margin = new System.Windows.Forms.Padding(4);
            this.user_username.Name = "user_username";
            this.user_username.Size = new System.Drawing.Size(250, 35);
            this.user_username.TabIndex = 2;
            this.user_username.Text = "Enter Username";
            this.user_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.user_username.OnValueChanged += new System.EventHandler(this.user_username_OnValueChanged);
            // 
            // user_fullname
            // 
            this.user_fullname.BackColor = System.Drawing.Color.White;
            this.user_fullname.BorderColorFocused = System.Drawing.Color.Blue;
            this.user_fullname.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.user_fullname.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.user_fullname.BorderThickness = 3;
            this.user_fullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user_fullname.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_fullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.user_fullname.isPassword = false;
            this.user_fullname.Location = new System.Drawing.Point(10, 120);
            this.user_fullname.Margin = new System.Windows.Forms.Padding(4);
            this.user_fullname.Name = "user_fullname";
            this.user_fullname.Size = new System.Drawing.Size(250, 35);
            this.user_fullname.TabIndex = 1;
            this.user_fullname.Text = "Enter Full Name";
            this.user_fullname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.user_fullname.OnValueChanged += new System.EventHandler(this.user_fullname_OnValueChanged);
            // 
            // user_userid
            // 
            this.user_userid.BackColor = System.Drawing.Color.White;
            this.user_userid.BorderColorFocused = System.Drawing.Color.Blue;
            this.user_userid.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.user_userid.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.user_userid.BorderThickness = 3;
            this.user_userid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user_userid.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_userid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.user_userid.isPassword = false;
            this.user_userid.Location = new System.Drawing.Point(10, 55);
            this.user_userid.Margin = new System.Windows.Forms.Padding(4);
            this.user_userid.Name = "user_userid";
            this.user_userid.Size = new System.Drawing.Size(250, 35);
            this.user_userid.TabIndex = 0;
            this.user_userid.Text = "Enter User ID";
            this.user_userid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.user_userid.OnValueChanged += new System.EventHandler(this.user_userid_OnValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.user_securityqu);
            this.panel1.Controls.Add(this.user_status);
            this.panel1.Controls.Add(this.user_securityans);
            this.panel1.Controls.Add(this.user_contactno);
            this.panel1.Controls.Add(this.user_password);
            this.panel1.Controls.Add(this.user_username);
            this.panel1.Controls.Add(this.user_fullname);
            this.panel1.Controls.Add(this.user_userid);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 554);
            this.panel1.TabIndex = 13;
            // 
            // user_datagrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.user_datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.user_datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.user_datagrid.AutoGenerateColumns = false;
            this.user_datagrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.user_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user_datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.user_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.user_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useriddDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passworddDataGridViewTextBoxColumn,
            this.contactnoDataGridViewTextBoxColumn,
            this.statussDataGridViewTextBoxColumn,
            this.securityquestionDataGridViewTextBoxColumn,
            this.securityanswerDataGridViewTextBoxColumn});
            this.user_datagrid.DataSource = this.usersBindingSource;
            this.user_datagrid.DoubleBuffered = true;
            this.user_datagrid.EnableHeadersVisualStyles = false;
            this.user_datagrid.HeaderBgColor = System.Drawing.Color.DimGray;
            this.user_datagrid.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.user_datagrid.Location = new System.Drawing.Point(275, 200);
            this.user_datagrid.Name = "user_datagrid";
            this.user_datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.user_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.user_datagrid.Size = new System.Drawing.Size(625, 350);
            this.user_datagrid.TabIndex = 26;
            this.user_datagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.user_datagrid_CellClick_1);
            // 
            // useriddDataGridViewTextBoxColumn
            // 
            this.useriddDataGridViewTextBoxColumn.DataPropertyName = "user_idd";
            this.useriddDataGridViewTextBoxColumn.HeaderText = "User ID";
            this.useriddDataGridViewTextBoxColumn.Name = "useriddDataGridViewTextBoxColumn";
            this.useriddDataGridViewTextBoxColumn.Width = 80;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "full_name";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "Full Name";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passworddDataGridViewTextBoxColumn
            // 
            this.passworddDataGridViewTextBoxColumn.DataPropertyName = "passwordd";
            this.passworddDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passworddDataGridViewTextBoxColumn.Name = "passworddDataGridViewTextBoxColumn";
            this.passworddDataGridViewTextBoxColumn.Visible = false;
            // 
            // contactnoDataGridViewTextBoxColumn
            // 
            this.contactnoDataGridViewTextBoxColumn.DataPropertyName = "contact_no";
            this.contactnoDataGridViewTextBoxColumn.HeaderText = "Contact Number";
            this.contactnoDataGridViewTextBoxColumn.Name = "contactnoDataGridViewTextBoxColumn";
            // 
            // statussDataGridViewTextBoxColumn
            // 
            this.statussDataGridViewTextBoxColumn.DataPropertyName = "statuss";
            this.statussDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statussDataGridViewTextBoxColumn.Name = "statussDataGridViewTextBoxColumn";
            this.statussDataGridViewTextBoxColumn.Width = 80;
            // 
            // securityquestionDataGridViewTextBoxColumn
            // 
            this.securityquestionDataGridViewTextBoxColumn.DataPropertyName = "security_question";
            this.securityquestionDataGridViewTextBoxColumn.HeaderText = "Security Question";
            this.securityquestionDataGridViewTextBoxColumn.Name = "securityquestionDataGridViewTextBoxColumn";
            // 
            // securityanswerDataGridViewTextBoxColumn
            // 
            this.securityanswerDataGridViewTextBoxColumn.DataPropertyName = "security_answer";
            this.securityanswerDataGridViewTextBoxColumn.HeaderText = "Security Answer";
            this.securityanswerDataGridViewTextBoxColumn.Name = "securityanswerDataGridViewTextBoxColumn";
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.user_searchentry);
            this.panel3.Controls.Add(this.user_searchchoice);
            this.panel3.Controls.Add(this.user_displaylabel);
            this.panel3.Location = new System.Drawing.Point(275, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(625, 41);
            this.panel3.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(2, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 19);
            this.label10.TabIndex = 48;
            this.label10.Text = "Search By";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.Controls.Add(this.user_addbutton);
            this.flowLayoutPanel1.Controls.Add(this.user_showallbutton);
            this.flowLayoutPanel1.Controls.Add(this.user_updatebutton);
            this.flowLayoutPanel1.Controls.Add(this.user_searchbutton);
            this.flowLayoutPanel1.Controls.Add(this.user_deletebutton);
            this.flowLayoutPanel1.Controls.Add(this.user_clearbutton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(275, 70);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(625, 128);
            this.flowLayoutPanel1.TabIndex = 59;
            // 
            // user_addbutton
            // 
            this.user_addbutton.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.user_addbutton.BackColor = System.Drawing.Color.White;
            this.user_addbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("user_addbutton.BackgroundImage")));
            this.user_addbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.user_addbutton.BorderRadius = 0;
            this.user_addbutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.user_addbutton.ButtonText = "Add User";
            this.user_addbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user_addbutton.DisabledColor = System.Drawing.Color.Gray;
            this.user_addbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.user_addbutton.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_addbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.user_addbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("user_addbutton.Iconimage")));
            this.user_addbutton.Iconimage_right = null;
            this.user_addbutton.Iconimage_right_Selected = null;
            this.user_addbutton.Iconimage_Selected = null;
            this.user_addbutton.IconMarginLeft = 1;
            this.user_addbutton.IconMarginRight = 0;
            this.user_addbutton.IconRightVisible = true;
            this.user_addbutton.IconRightZoom = 0D;
            this.user_addbutton.IconVisible = true;
            this.user_addbutton.IconZoom = 80D;
            this.user_addbutton.IsTab = false;
            this.user_addbutton.Location = new System.Drawing.Point(3, 3);
            this.user_addbutton.Name = "user_addbutton";
            this.user_addbutton.Normalcolor = System.Drawing.Color.White;
            this.user_addbutton.OnHovercolor = System.Drawing.Color.Cyan;
            this.user_addbutton.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.user_addbutton.selected = false;
            this.user_addbutton.Size = new System.Drawing.Size(200, 55);
            this.user_addbutton.TabIndex = 2;
            this.user_addbutton.Text = "Add User";
            this.user_addbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.user_addbutton.Textcolor = System.Drawing.Color.White;
            this.user_addbutton.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_addbutton.Click += new System.EventHandler(this.user_addbutton_Click_1);
            // 
            // user_showallbutton
            // 
            this.user_showallbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.user_showallbutton.BackColor = System.Drawing.Color.White;
            this.user_showallbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("user_showallbutton.BackgroundImage")));
            this.user_showallbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.user_showallbutton.BorderRadius = 0;
            this.user_showallbutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.user_showallbutton.ButtonText = "Show All";
            this.user_showallbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user_showallbutton.DisabledColor = System.Drawing.Color.Gray;
            this.user_showallbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.user_showallbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.user_showallbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("user_showallbutton.Iconimage")));
            this.user_showallbutton.Iconimage_right = null;
            this.user_showallbutton.Iconimage_right_Selected = null;
            this.user_showallbutton.Iconimage_Selected = null;
            this.user_showallbutton.IconMarginLeft = 0;
            this.user_showallbutton.IconMarginRight = 0;
            this.user_showallbutton.IconRightVisible = true;
            this.user_showallbutton.IconRightZoom = 0D;
            this.user_showallbutton.IconVisible = true;
            this.user_showallbutton.IconZoom = 90D;
            this.user_showallbutton.IsTab = false;
            this.user_showallbutton.Location = new System.Drawing.Point(209, 3);
            this.user_showallbutton.Name = "user_showallbutton";
            this.user_showallbutton.Normalcolor = System.Drawing.Color.White;
            this.user_showallbutton.OnHovercolor = System.Drawing.Color.Cyan;
            this.user_showallbutton.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.user_showallbutton.selected = false;
            this.user_showallbutton.Size = new System.Drawing.Size(200, 55);
            this.user_showallbutton.TabIndex = 4;
            this.user_showallbutton.Text = "Show All";
            this.user_showallbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.user_showallbutton.Textcolor = System.Drawing.Color.White;
            this.user_showallbutton.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_showallbutton.Click += new System.EventHandler(this.user_showallbutton_Click_1);
            // 
            // user_updatebutton
            // 
            this.user_updatebutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.user_updatebutton.BackColor = System.Drawing.Color.White;
            this.user_updatebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("user_updatebutton.BackgroundImage")));
            this.user_updatebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.user_updatebutton.BorderRadius = 0;
            this.user_updatebutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.user_updatebutton.ButtonText = "Update User";
            this.user_updatebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user_updatebutton.DisabledColor = System.Drawing.Color.Gray;
            this.user_updatebutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.user_updatebutton.Iconcolor = System.Drawing.Color.Transparent;
            this.user_updatebutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("user_updatebutton.Iconimage")));
            this.user_updatebutton.Iconimage_right = null;
            this.user_updatebutton.Iconimage_right_Selected = null;
            this.user_updatebutton.Iconimage_Selected = null;
            this.user_updatebutton.IconMarginLeft = 0;
            this.user_updatebutton.IconMarginRight = 0;
            this.user_updatebutton.IconRightVisible = true;
            this.user_updatebutton.IconRightZoom = 0D;
            this.user_updatebutton.IconVisible = true;
            this.user_updatebutton.IconZoom = 90D;
            this.user_updatebutton.IsTab = false;
            this.user_updatebutton.Location = new System.Drawing.Point(415, 3);
            this.user_updatebutton.Name = "user_updatebutton";
            this.user_updatebutton.Normalcolor = System.Drawing.Color.White;
            this.user_updatebutton.OnHovercolor = System.Drawing.Color.Cyan;
            this.user_updatebutton.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.user_updatebutton.selected = false;
            this.user_updatebutton.Size = new System.Drawing.Size(200, 55);
            this.user_updatebutton.TabIndex = 5;
            this.user_updatebutton.Text = "Update User";
            this.user_updatebutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.user_updatebutton.Textcolor = System.Drawing.Color.White;
            this.user_updatebutton.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_updatebutton.Click += new System.EventHandler(this.user_updatebutton_Click_1);
            // 
            // user_searchbutton
            // 
            this.user_searchbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.user_searchbutton.BackColor = System.Drawing.Color.White;
            this.user_searchbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("user_searchbutton.BackgroundImage")));
            this.user_searchbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.user_searchbutton.BorderRadius = 0;
            this.user_searchbutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.user_searchbutton.ButtonText = "Search User";
            this.user_searchbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user_searchbutton.DisabledColor = System.Drawing.Color.Gray;
            this.user_searchbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.user_searchbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.user_searchbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("user_searchbutton.Iconimage")));
            this.user_searchbutton.Iconimage_right = null;
            this.user_searchbutton.Iconimage_right_Selected = null;
            this.user_searchbutton.Iconimage_Selected = null;
            this.user_searchbutton.IconMarginLeft = 0;
            this.user_searchbutton.IconMarginRight = 0;
            this.user_searchbutton.IconRightVisible = true;
            this.user_searchbutton.IconRightZoom = 0D;
            this.user_searchbutton.IconVisible = true;
            this.user_searchbutton.IconZoom = 90D;
            this.user_searchbutton.IsTab = false;
            this.user_searchbutton.Location = new System.Drawing.Point(3, 64);
            this.user_searchbutton.Name = "user_searchbutton";
            this.user_searchbutton.Normalcolor = System.Drawing.Color.White;
            this.user_searchbutton.OnHovercolor = System.Drawing.Color.Cyan;
            this.user_searchbutton.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.user_searchbutton.selected = false;
            this.user_searchbutton.Size = new System.Drawing.Size(200, 55);
            this.user_searchbutton.TabIndex = 6;
            this.user_searchbutton.Text = "Search User";
            this.user_searchbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.user_searchbutton.Textcolor = System.Drawing.Color.White;
            this.user_searchbutton.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_searchbutton.Click += new System.EventHandler(this.user_searchbutton_Click_1);
            // 
            // user_deletebutton
            // 
            this.user_deletebutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.user_deletebutton.BackColor = System.Drawing.Color.White;
            this.user_deletebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("user_deletebutton.BackgroundImage")));
            this.user_deletebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.user_deletebutton.BorderRadius = 0;
            this.user_deletebutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.user_deletebutton.ButtonText = "Delete User";
            this.user_deletebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user_deletebutton.DisabledColor = System.Drawing.Color.Gray;
            this.user_deletebutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.user_deletebutton.Iconcolor = System.Drawing.Color.Transparent;
            this.user_deletebutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("user_deletebutton.Iconimage")));
            this.user_deletebutton.Iconimage_right = null;
            this.user_deletebutton.Iconimage_right_Selected = null;
            this.user_deletebutton.Iconimage_Selected = null;
            this.user_deletebutton.IconMarginLeft = 0;
            this.user_deletebutton.IconMarginRight = 0;
            this.user_deletebutton.IconRightVisible = true;
            this.user_deletebutton.IconRightZoom = 0D;
            this.user_deletebutton.IconVisible = true;
            this.user_deletebutton.IconZoom = 90D;
            this.user_deletebutton.IsTab = false;
            this.user_deletebutton.Location = new System.Drawing.Point(209, 64);
            this.user_deletebutton.Name = "user_deletebutton";
            this.user_deletebutton.Normalcolor = System.Drawing.Color.White;
            this.user_deletebutton.OnHovercolor = System.Drawing.Color.Cyan;
            this.user_deletebutton.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.user_deletebutton.selected = false;
            this.user_deletebutton.Size = new System.Drawing.Size(200, 55);
            this.user_deletebutton.TabIndex = 7;
            this.user_deletebutton.Text = "Delete User";
            this.user_deletebutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.user_deletebutton.Textcolor = System.Drawing.Color.White;
            this.user_deletebutton.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_deletebutton.Click += new System.EventHandler(this.user_deletebutton_Click_1);
            // 
            // user_clearbutton
            // 
            this.user_clearbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.user_clearbutton.BackColor = System.Drawing.Color.White;
            this.user_clearbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("user_clearbutton.BackgroundImage")));
            this.user_clearbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.user_clearbutton.BorderRadius = 0;
            this.user_clearbutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.user_clearbutton.ButtonText = "Clear All";
            this.user_clearbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user_clearbutton.DisabledColor = System.Drawing.Color.Gray;
            this.user_clearbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.user_clearbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.user_clearbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("user_clearbutton.Iconimage")));
            this.user_clearbutton.Iconimage_right = null;
            this.user_clearbutton.Iconimage_right_Selected = null;
            this.user_clearbutton.Iconimage_Selected = null;
            this.user_clearbutton.IconMarginLeft = 0;
            this.user_clearbutton.IconMarginRight = 0;
            this.user_clearbutton.IconRightVisible = true;
            this.user_clearbutton.IconRightZoom = 0D;
            this.user_clearbutton.IconVisible = true;
            this.user_clearbutton.IconZoom = 90D;
            this.user_clearbutton.IsTab = false;
            this.user_clearbutton.Location = new System.Drawing.Point(415, 64);
            this.user_clearbutton.Name = "user_clearbutton";
            this.user_clearbutton.Normalcolor = System.Drawing.Color.White;
            this.user_clearbutton.OnHovercolor = System.Drawing.Color.Cyan;
            this.user_clearbutton.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.user_clearbutton.selected = false;
            this.user_clearbutton.Size = new System.Drawing.Size(200, 55);
            this.user_clearbutton.TabIndex = 8;
            this.user_clearbutton.Text = "Clear All";
            this.user_clearbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.user_clearbutton.Textcolor = System.Drawing.Color.White;
            this.user_clearbutton.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_clearbutton.Click += new System.EventHandler(this.user_clearbutton_Click_1);
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
            this.panel2.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(265, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 24);
            this.label9.TabIndex = 10;
            this.label9.Text = "Users";
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
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.user_datagrid);
            this.Controls.Add(this.user_display);
            this.Controls.Add(this.panel1);
            this.Name = "user";
            this.Size = new System.Drawing.Size(900, 550);
            this.Load += new System.EventHandler(this.user_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox user_searchentry;
        private System.Windows.Forms.Label user_display;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox user_securityqu;
        private System.Windows.Forms.ComboBox user_status;
        private Bunifu.Framework.UI.BunifuMetroTextbox user_contactno;
        private System.Windows.Forms.Label user_displaylabel;
        private Bunifu.Framework.UI.BunifuMetroTextbox user_securityans;
        private Bunifu.Framework.UI.BunifuMetroTextbox user_password;
        private System.Windows.Forms.ComboBox user_searchchoice;
        private Bunifu.Framework.UI.BunifuMetroTextbox user_username;
        private Bunifu.Framework.UI.BunifuMetroTextbox user_fullname;
        private Bunifu.Framework.UI.BunifuMetroTextbox user_userid;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid user_datagrid;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private bakeryDataSet2 bakeryDataSet2;
        private bakeryDataSet2TableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn useriddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passworddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statussDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn securityquestionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn securityanswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton user_addbutton;
        private Bunifu.Framework.UI.BunifuFlatButton user_showallbutton;
        private Bunifu.Framework.UI.BunifuFlatButton user_updatebutton;
        private Bunifu.Framework.UI.BunifuFlatButton user_searchbutton;
        private Bunifu.Framework.UI.BunifuFlatButton user_deletebutton;
        private Bunifu.Framework.UI.BunifuFlatButton user_clearbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label9;
    }
}
