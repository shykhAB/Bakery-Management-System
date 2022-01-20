namespace project
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.uname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.showpass = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label1 = new System.Windows.Forms.Label();
            this.log_in = new Bunifu.Framework.UI.BunifuThinButton2();
            this.exit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.clear = new Bunifu.Framework.UI.BunifuThinButton2();
            this.create_ = new System.Windows.Forms.LinkLabel();
            this.forgot_ = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Name = "panel1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // uname
            // 
            this.uname.BackColor = System.Drawing.Color.White;
            this.uname.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.uname, "uname");
            this.uname.ForeColor = System.Drawing.Color.Black;
            this.uname.HintForeColor = System.Drawing.Color.Empty;
            this.uname.HintText = "";
            this.uname.isPassword = false;
            this.uname.LineFocusedColor = System.Drawing.Color.Blue;
            this.uname.LineIdleColor = System.Drawing.Color.Gray;
            this.uname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.uname.LineThickness = 4;
            this.uname.Name = "uname";
            this.uname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pass
            // 
            this.pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.pass, "pass");
            this.pass.ForeColor = System.Drawing.Color.Black;
            this.pass.HintForeColor = System.Drawing.Color.Empty;
            this.pass.HintText = "";
            this.pass.isPassword = true;
            this.pass.LineFocusedColor = System.Drawing.Color.Blue;
            this.pass.LineIdleColor = System.Drawing.Color.Gray;
            this.pass.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.pass.LineThickness = 4;
            this.pass.Name = "pass";
            this.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // showpass
            // 
            this.showpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.showpass.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.showpass.Checked = false;
            this.showpass.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.showpass.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.showpass, "showpass");
            this.showpass.Name = "showpass";
            this.showpass.OnChange += new System.EventHandler(this.showpass_OnChange);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // log_in
            // 
            this.log_in.ActiveBorderThickness = 1;
            this.log_in.ActiveCornerRadius = 20;
            this.log_in.ActiveFillColor = System.Drawing.Color.DimGray;
            this.log_in.ActiveForecolor = System.Drawing.Color.White;
            this.log_in.ActiveLineColor = System.Drawing.Color.DimGray;
            this.log_in.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.log_in, "log_in");
            this.log_in.ButtonText = "Log In";
            this.log_in.Cursor = System.Windows.Forms.Cursors.Hand;
            this.log_in.ForeColor = System.Drawing.Color.DimGray;
            this.log_in.IdleBorderThickness = 1;
            this.log_in.IdleCornerRadius = 20;
            this.log_in.IdleFillColor = System.Drawing.Color.White;
            this.log_in.IdleForecolor = System.Drawing.Color.DimGray;
            this.log_in.IdleLineColor = System.Drawing.Color.DimGray;
            this.log_in.Name = "log_in";
            this.log_in.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.log_in.Click += new System.EventHandler(this.log_in_Click);
            // 
            // exit
            // 
            this.exit.ActiveBorderThickness = 1;
            this.exit.ActiveCornerRadius = 20;
            this.exit.ActiveFillColor = System.Drawing.Color.DimGray;
            this.exit.ActiveForecolor = System.Drawing.Color.White;
            this.exit.ActiveLineColor = System.Drawing.Color.DimGray;
            this.exit.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.exit, "exit");
            this.exit.ButtonText = "Exit";
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.ForeColor = System.Drawing.Color.DimGray;
            this.exit.IdleBorderThickness = 1;
            this.exit.IdleCornerRadius = 20;
            this.exit.IdleFillColor = System.Drawing.Color.White;
            this.exit.IdleForecolor = System.Drawing.Color.DimGray;
            this.exit.IdleLineColor = System.Drawing.Color.DimGray;
            this.exit.Name = "exit";
            this.exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // clear
            // 
            this.clear.ActiveBorderThickness = 1;
            this.clear.ActiveCornerRadius = 20;
            this.clear.ActiveFillColor = System.Drawing.Color.DimGray;
            this.clear.ActiveForecolor = System.Drawing.Color.White;
            this.clear.ActiveLineColor = System.Drawing.Color.DimGray;
            this.clear.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.clear, "clear");
            this.clear.ButtonText = "Clear";
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.ForeColor = System.Drawing.Color.DimGray;
            this.clear.IdleBorderThickness = 1;
            this.clear.IdleCornerRadius = 20;
            this.clear.IdleFillColor = System.Drawing.Color.White;
            this.clear.IdleForecolor = System.Drawing.Color.DimGray;
            this.clear.IdleLineColor = System.Drawing.Color.DimGray;
            this.clear.Name = "clear";
            this.clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // create_
            // 
            this.create_.ActiveLinkColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.create_, "create_");
            this.create_.LinkColor = System.Drawing.Color.DimGray;
            this.create_.Name = "create_";
            this.create_.TabStop = true;
            this.create_.VisitedLinkColor = System.Drawing.Color.Black;
            this.create_.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.create__LinkClicked);
            // 
            // forgot_
            // 
            this.forgot_.ActiveLinkColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.forgot_, "forgot_");
            this.forgot_.LinkColor = System.Drawing.Color.DimGray;
            this.forgot_.Name = "forgot_";
            this.forgot_.TabStop = true;
            this.forgot_.VisitedLinkColor = System.Drawing.Color.Black;
            this.forgot_.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgot__LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Name = "label6";
            // 
            // login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.forgot_);
            this.Controls.Add(this.create_);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.log_in);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showpass);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox uname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pass;
        private Bunifu.Framework.UI.BunifuCheckbox showpass;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 log_in;
        private Bunifu.Framework.UI.BunifuThinButton2 exit;
        private Bunifu.Framework.UI.BunifuThinButton2 clear;
        private System.Windows.Forms.LinkLabel create_;
        private System.Windows.Forms.LinkLabel forgot_;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}