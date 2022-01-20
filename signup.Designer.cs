namespace project
{
    partial class signup
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
            Bunifu.Framework.UI.BunifuThinButton2 sign_up;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.signup_showpass = new Bunifu.Framework.UI.BunifuCheckbox();
            this.back = new Bunifu.Framework.UI.BunifuThinButton2();
            this.clear = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label3 = new System.Windows.Forms.Label();
            this.security_ans = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.security_qu = new System.Windows.Forms.ComboBox();
            this.user_id = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.full_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.user_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pass_word = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.contact_no = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            sign_up = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sign_up
            // 
            sign_up.ActiveBorderThickness = 1;
            sign_up.ActiveCornerRadius = 20;
            sign_up.ActiveFillColor = System.Drawing.Color.DimGray;
            sign_up.ActiveForecolor = System.Drawing.Color.White;
            sign_up.ActiveLineColor = System.Drawing.Color.DimGray;
            sign_up.BackColor = System.Drawing.Color.Transparent;
            sign_up.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sign_up.BackgroundImage")));
            sign_up.ButtonText = "Signup";
            sign_up.Cursor = System.Windows.Forms.Cursors.Hand;
            sign_up.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sign_up.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            sign_up.IdleBorderThickness = 1;
            sign_up.IdleCornerRadius = 20;
            sign_up.IdleFillColor = System.Drawing.Color.White;
            sign_up.IdleForecolor = System.Drawing.Color.DimGray;
            sign_up.IdleLineColor = System.Drawing.Color.DimGray;
            sign_up.Location = new System.Drawing.Point(55, 289);
            sign_up.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            sign_up.Name = "sign_up";
            sign_up.Size = new System.Drawing.Size(250, 40);
            sign_up.TabIndex = 4;
            sign_up.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            sign_up.Click += new System.EventHandler(this.sign_up_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.signup_showpass);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(sign_up);
            this.panel1.Controls.Add(this.clear);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.security_ans);
            this.panel1.Controls.Add(this.security_qu);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 615);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(234, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Show Password";
            // 
            // signup_showpass
            // 
            this.signup_showpass.BackColor = System.Drawing.Color.White;
            this.signup_showpass.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.signup_showpass.Checked = false;
            this.signup_showpass.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.signup_showpass.ForeColor = System.Drawing.Color.White;
            this.signup_showpass.Location = new System.Drawing.Point(208, 251);
            this.signup_showpass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.signup_showpass.Name = "signup_showpass";
            this.signup_showpass.Size = new System.Drawing.Size(20, 20);
            this.signup_showpass.TabIndex = 6;
            this.signup_showpass.OnChange += new System.EventHandler(this.signup_showpass_OnChange);
            // 
            // back
            // 
            this.back.ActiveBorderThickness = 1;
            this.back.ActiveCornerRadius = 20;
            this.back.ActiveFillColor = System.Drawing.Color.DimGray;
            this.back.ActiveForecolor = System.Drawing.Color.White;
            this.back.ActiveLineColor = System.Drawing.Color.DimGray;
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.ButtonText = "Back";
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.back.IdleBorderThickness = 1;
            this.back.IdleCornerRadius = 20;
            this.back.IdleFillColor = System.Drawing.Color.White;
            this.back.IdleForecolor = System.Drawing.Color.DimGray;
            this.back.IdleLineColor = System.Drawing.Color.DimGray;
            this.back.Location = new System.Drawing.Point(55, 398);
            this.back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(250, 40);
            this.back.TabIndex = 5;
            this.back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // clear
            // 
            this.clear.ActiveBorderThickness = 1;
            this.clear.ActiveCornerRadius = 20;
            this.clear.ActiveFillColor = System.Drawing.Color.DimGray;
            this.clear.ActiveForecolor = System.Drawing.Color.White;
            this.clear.ActiveLineColor = System.Drawing.Color.DimGray;
            this.clear.BackColor = System.Drawing.Color.Transparent;
            this.clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clear.BackgroundImage")));
            this.clear.ButtonText = "Clear";
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clear.IdleBorderThickness = 1;
            this.clear.IdleCornerRadius = 20;
            this.clear.IdleFillColor = System.Drawing.Color.White;
            this.clear.IdleForecolor = System.Drawing.Color.DimGray;
            this.clear.IdleLineColor = System.Drawing.Color.DimGray;
            this.clear.Location = new System.Drawing.Point(55, 344);
            this.clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(250, 40);
            this.clear.TabIndex = 3;
            this.clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(77, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "User\'s Security";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // security_ans
            // 
            this.security_ans.BackColor = System.Drawing.Color.White;
            this.security_ans.BorderColorFocused = System.Drawing.Color.Blue;
            this.security_ans.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.security_ans.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.security_ans.BorderThickness = 3;
            this.security_ans.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.security_ans.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.security_ans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.security_ans.isPassword = false;
            this.security_ans.Location = new System.Drawing.Point(14, 200);
            this.security_ans.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.security_ans.Name = "security_ans";
            this.security_ans.Size = new System.Drawing.Size(350, 36);
            this.security_ans.TabIndex = 1;
            this.security_ans.Text = "Enter Security Question\'s Answer";
            this.security_ans.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // security_qu
            // 
            this.security_qu.BackColor = System.Drawing.Color.White;
            this.security_qu.DropDownHeight = 120;
            this.security_qu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.security_qu.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.security_qu.FormattingEnabled = true;
            this.security_qu.IntegralHeight = false;
            this.security_qu.Items.AddRange(new object[] {
            "Who was your Childhood Hero?",
            "What was your favourite place to visit as a child?",
            "What was your childhood nickname?",
            "what sports team do you love to see lose?"});
            this.security_qu.Location = new System.Drawing.Point(14, 130);
            this.security_qu.Name = "security_qu";
            this.security_qu.Size = new System.Drawing.Size(349, 27);
            this.security_qu.TabIndex = 0;
            this.security_qu.SelectedIndexChanged += new System.EventHandler(this.security_qu_SelectedIndexChanged);
            // 
            // user_id
            // 
            this.user_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user_id.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.user_id.HintForeColor = System.Drawing.Color.Empty;
            this.user_id.HintText = "";
            this.user_id.isPassword = false;
            this.user_id.LineFocusedColor = System.Drawing.Color.Blue;
            this.user_id.LineIdleColor = System.Drawing.Color.Gray;
            this.user_id.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.user_id.LineThickness = 3;
            this.user_id.Location = new System.Drawing.Point(390, 120);
            this.user_id.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(380, 40);
            this.user_id.TabIndex = 1;
            this.user_id.Text = "User Id";
            this.user_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // full_name
            // 
            this.full_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.full_name.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.full_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.full_name.HintForeColor = System.Drawing.Color.Empty;
            this.full_name.HintText = "";
            this.full_name.isPassword = false;
            this.full_name.LineFocusedColor = System.Drawing.Color.Blue;
            this.full_name.LineIdleColor = System.Drawing.Color.Gray;
            this.full_name.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.full_name.LineThickness = 3;
            this.full_name.Location = new System.Drawing.Point(390, 180);
            this.full_name.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.full_name.Name = "full_name";
            this.full_name.Size = new System.Drawing.Size(380, 40);
            this.full_name.TabIndex = 2;
            this.full_name.Text = "Full Name";
            this.full_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // user_name
            // 
            this.user_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user_name.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.user_name.HintForeColor = System.Drawing.Color.Empty;
            this.user_name.HintText = "";
            this.user_name.isPassword = false;
            this.user_name.LineFocusedColor = System.Drawing.Color.Blue;
            this.user_name.LineIdleColor = System.Drawing.Color.Gray;
            this.user_name.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.user_name.LineThickness = 3;
            this.user_name.Location = new System.Drawing.Point(390, 240);
            this.user_name.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(380, 40);
            this.user_name.TabIndex = 3;
            this.user_name.Text = "Username";
            this.user_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pass_word
            // 
            this.pass_word.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pass_word.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_word.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pass_word.HintForeColor = System.Drawing.Color.Empty;
            this.pass_word.HintText = "";
            this.pass_word.isPassword = true;
            this.pass_word.LineFocusedColor = System.Drawing.Color.Blue;
            this.pass_word.LineIdleColor = System.Drawing.Color.Gray;
            this.pass_word.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.pass_word.LineThickness = 3;
            this.pass_word.Location = new System.Drawing.Point(390, 300);
            this.pass_word.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pass_word.Name = "pass_word";
            this.pass_word.Size = new System.Drawing.Size(380, 40);
            this.pass_word.TabIndex = 4;
            this.pass_word.Text = "Password";
            this.pass_word.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // contact_no
            // 
            this.contact_no.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contact_no.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_no.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contact_no.HintForeColor = System.Drawing.Color.Empty;
            this.contact_no.HintText = "";
            this.contact_no.isPassword = false;
            this.contact_no.LineFocusedColor = System.Drawing.Color.Blue;
            this.contact_no.LineIdleColor = System.Drawing.Color.Gray;
            this.contact_no.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.contact_no.LineThickness = 3;
            this.contact_no.Location = new System.Drawing.Point(390, 360);
            this.contact_no.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.contact_no.Name = "contact_no";
            this.contact_no.Size = new System.Drawing.Size(380, 40);
            this.contact_no.TabIndex = 5;
            this.contact_no.Text = "Contact No (03XXXXXXXXXX)";
            this.contact_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 38);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sign Up for an account";
            // 
            // status
            // 
            this.status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Active",
            "In-Active"});
            this.status.Location = new System.Drawing.Point(390, 450);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(380, 24);
            this.status.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(390, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Security Question";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Security Answer";
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contact_no);
            this.Controls.Add(this.pass_word);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.full_name);
            this.Controls.Add(this.user_id);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox user_id;
        private Bunifu.Framework.UI.BunifuMaterialTextbox full_name;
        private Bunifu.Framework.UI.BunifuMaterialTextbox user_name;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pass_word;
        private Bunifu.Framework.UI.BunifuMaterialTextbox contact_no;
        private Bunifu.Framework.UI.BunifuMetroTextbox security_ans;
        private System.Windows.Forms.ComboBox security_qu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 back;
        private Bunifu.Framework.UI.BunifuThinButton2 clear;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuCheckbox signup_showpass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}