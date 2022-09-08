namespace DNUltimate
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Username = new System.Windows.Forms.TextBox();
            this.pwdInp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.showPwd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.createAcc = new System.Windows.Forms.Button();
            this.proceed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Username
            // 
            resources.ApplyResources(this.Username, "Username");
            this.Username.Name = "Username";
            // 
            // pwdInp
            // 
            resources.ApplyResources(this.pwdInp, "pwdInp");
            this.pwdInp.Name = "pwdInp";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // showPwd
            // 
            this.showPwd.BackColor = System.Drawing.SystemColors.Control;
            this.showPwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPwd.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.showPwd, "showPwd");
            this.showPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            this.showPwd.Name = "showPwd";
            this.showPwd.UseVisualStyleBackColor = false;
            this.showPwd.Click += new System.EventHandler(this.showPwd_Click);
            this.showPwd.MouseEnter += new System.EventHandler(this.LinkBtnMouseEnter);
            this.showPwd.MouseLeave += new System.EventHandler(this.LinkBtnMouseLeave);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // createAcc
            // 
            this.createAcc.BackColor = System.Drawing.SystemColors.Control;
            this.createAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAcc.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.createAcc, "createAcc");
            this.createAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            this.createAcc.Name = "createAcc";
            this.createAcc.UseVisualStyleBackColor = false;
            this.createAcc.Click += new System.EventHandler(this.createAcc_Click);
            this.createAcc.MouseEnter += new System.EventHandler(this.LinkBtnMouseEnter);
            this.createAcc.MouseLeave += new System.EventHandler(this.LinkBtnMouseLeave);
            // 
            // proceed
            // 
            this.proceed.BackColor = System.Drawing.SystemColors.Control;
            this.proceed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proceed.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.proceed, "proceed");
            this.proceed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            this.proceed.Name = "proceed";
            this.proceed.UseVisualStyleBackColor = false;
            this.proceed.Click += new System.EventHandler(this.ProceedClick);
            this.proceed.MouseEnter += new System.EventHandler(this.LinkBtnMouseEnter);
            this.proceed.MouseLeave += new System.EventHandler(this.LinkBtnMouseLeave);
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.proceed);
            this.Controls.Add(this.createAcc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.showPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pwdInp);
            this.Controls.Add(this.Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Username;
        private TextBox pwdInp;
        private Label label1;
        private Label label2;
        private Button showPwd;
        private Label label3;
        private Button createAcc;
        private Button proceed;
    }
}