namespace L25_GroupBox
{
    partial class mainFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblGender = new System.Windows.Forms.Label();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.gbPaymentMethods = new System.Windows.Forms.GroupBox();
            this.rdCredit = new System.Windows.Forms.RadioButton();
            this.rdPaypal = new System.Windows.Forms.RadioButton();
            this.pnlGender = new System.Windows.Forms.Panel();
            this.gbPaymentMethods.SuspendLayout();
            this.pnlGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(225, 190);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(70, 24);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(57, 25);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(59, 55);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(118, 22);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(153, 20);
            this.txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(118, 52);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(153, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(46, 190);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(75, 23);
            this.btnSignUp.TabIndex = 6;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(135, 190);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(70, 87);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 8;
            this.lblGender.Text = "Gender";
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rdMale.Location = new System.Drawing.Point(17, 6);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(48, 17);
            this.rdMale.TabIndex = 9;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(82, 6);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 10;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // gbPaymentMethods
            // 
            this.gbPaymentMethods.Controls.Add(this.rdPaypal);
            this.gbPaymentMethods.Controls.Add(this.rdCredit);
            this.gbPaymentMethods.Location = new System.Drawing.Point(62, 129);
            this.gbPaymentMethods.Name = "gbPaymentMethods";
            this.gbPaymentMethods.Size = new System.Drawing.Size(233, 41);
            this.gbPaymentMethods.TabIndex = 11;
            this.gbPaymentMethods.TabStop = false;
            this.gbPaymentMethods.Text = "Payment Methods";
            // 
            // rdCredit
            // 
            this.rdCredit.AutoSize = true;
            this.rdCredit.Location = new System.Drawing.Point(73, 17);
            this.rdCredit.Name = "rdCredit";
            this.rdCredit.Size = new System.Drawing.Size(52, 17);
            this.rdCredit.TabIndex = 0;
            this.rdCredit.TabStop = true;
            this.rdCredit.Text = "Credit";
            this.rdCredit.UseVisualStyleBackColor = true;
            // 
            // rdPaypal
            // 
            this.rdPaypal.AutoSize = true;
            this.rdPaypal.Location = new System.Drawing.Point(138, 17);
            this.rdPaypal.Name = "rdPaypal";
            this.rdPaypal.Size = new System.Drawing.Size(57, 17);
            this.rdPaypal.TabIndex = 1;
            this.rdPaypal.TabStop = true;
            this.rdPaypal.Text = "Paypal";
            this.rdPaypal.UseVisualStyleBackColor = true;
            // 
            // pnlGender
            // 
            this.pnlGender.Controls.Add(this.rdMale);
            this.pnlGender.Controls.Add(this.rbFemale);
            this.pnlGender.Location = new System.Drawing.Point(118, 87);
            this.pnlGender.Name = "pnlGender";
            this.pnlGender.Size = new System.Drawing.Size(153, 31);
            this.pnlGender.TabIndex = 12;
            // 
            // mainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 244);
            this.Controls.Add(this.pnlGender);
            this.Controls.Add(this.gbPaymentMethods);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnExit);
            this.Name = "mainFrame";
            this.Text = "Login";
            this.gbPaymentMethods.ResumeLayout(false);
            this.gbPaymentMethods.PerformLayout();
            this.pnlGender.ResumeLayout(false);
            this.pnlGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.GroupBox gbPaymentMethods;
        private System.Windows.Forms.RadioButton rdCredit;
        private System.Windows.Forms.RadioButton rdPaypal;
        private System.Windows.Forms.Panel pnlGender;
    }
}

