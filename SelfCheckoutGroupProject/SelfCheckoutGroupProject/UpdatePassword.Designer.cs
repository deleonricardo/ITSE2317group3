namespace SelfCheckoutGroupProject
{
    partial class UpdatePassword
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
			this.lblEmpName = new System.Windows.Forms.Label();
			this.lblEmpID = new System.Windows.Forms.Label();
			this.lblManPW = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtEmpID = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnUpdatePass = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblEmail = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.lblResetCode = new System.Windows.Forms.Label();
			this.txtResetCode = new System.Windows.Forms.TextBox();
			this.lblVerifyCode = new System.Windows.Forms.Label();
			this.txtVerifyCode = new System.Windows.Forms.TextBox();
			this.btnVerifyCode = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblEmpName
			// 
			this.lblEmpName.AutoSize = true;
			this.lblEmpName.Location = new System.Drawing.Point(172, 63);
			this.lblEmpName.Name = "lblEmpName";
			this.lblEmpName.Size = new System.Drawing.Size(129, 20);
			this.lblEmpName.TabIndex = 0;
			this.lblEmpName.Text = "Employee Name:";
			// 
			// lblEmpID
			// 
			this.lblEmpID.AutoSize = true;
			this.lblEmpID.Location = new System.Drawing.Point(172, 108);
			this.lblEmpID.Name = "lblEmpID";
			this.lblEmpID.Size = new System.Drawing.Size(104, 20);
			this.lblEmpID.TabIndex = 2;
			this.lblEmpID.Text = "Employee ID:";
			// 
			// lblManPW
			// 
			this.lblManPW.AutoSize = true;
			this.lblManPW.Location = new System.Drawing.Point(172, 210);
			this.lblManPW.Name = "lblManPW";
			this.lblManPW.Size = new System.Drawing.Size(192, 20);
			this.lblManPW.TabIndex = 6;
			this.lblManPW.Text = "Enter Manager Password:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(364, 57);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(150, 26);
			this.txtName.TabIndex = 1;
			// 
			// txtEmpID
			// 
			this.txtEmpID.Location = new System.Drawing.Point(364, 105);
			this.txtEmpID.Name = "txtEmpID";
			this.txtEmpID.Size = new System.Drawing.Size(150, 26);
			this.txtEmpID.TabIndex = 3;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(370, 207);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(144, 26);
			this.txtPassword.TabIndex = 7;
			// 
			// btnUpdatePass
			// 
			this.btnUpdatePass.Location = new System.Drawing.Point(156, 428);
			this.btnUpdatePass.Name = "btnUpdatePass";
			this.btnUpdatePass.Size = new System.Drawing.Size(165, 36);
			this.btnUpdatePass.TabIndex = 8;
			this.btnUpdatePass.Text = "&Update Password";
			this.btnUpdatePass.UseVisualStyleBackColor = true;
			this.btnUpdatePass.Click += new System.EventHandler(this.btnUpdatePass_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(576, 435);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(123, 29);
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(175, 159);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(126, 20);
			this.lblEmail.TabIndex = 4;
			this.lblEmail.Text = "Employee Email:";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(364, 156);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(149, 26);
			this.txtEmail.TabIndex = 5;
			// 
			// lblResetCode
			// 
			this.lblResetCode.AutoSize = true;
			this.lblResetCode.Location = new System.Drawing.Point(179, 264);
			this.lblResetCode.Name = "lblResetCode";
			this.lblResetCode.Size = new System.Drawing.Size(98, 20);
			this.lblResetCode.TabIndex = 10;
			this.lblResetCode.Text = "Reset Code:";
			// 
			// txtResetCode
			// 
			this.txtResetCode.Location = new System.Drawing.Point(364, 261);
			this.txtResetCode.Name = "txtResetCode";
			this.txtResetCode.Size = new System.Drawing.Size(150, 26);
			this.txtResetCode.TabIndex = 11;
			// 
			// lblVerifyCode
			// 
			this.lblVerifyCode.AutoSize = true;
			this.lblVerifyCode.Location = new System.Drawing.Point(179, 309);
			this.lblVerifyCode.Name = "lblVerifyCode";
			this.lblVerifyCode.Size = new System.Drawing.Size(142, 20);
			this.lblVerifyCode.TabIndex = 12;
			this.lblVerifyCode.Text = "Verify Reset Code:";
			// 
			// txtVerifyCode
			// 
			this.txtVerifyCode.Location = new System.Drawing.Point(364, 309);
			this.txtVerifyCode.Name = "txtVerifyCode";
			this.txtVerifyCode.Size = new System.Drawing.Size(150, 26);
			this.txtVerifyCode.TabIndex = 13;
			// 
			// btnVerifyCode
			// 
			this.btnVerifyCode.Location = new System.Drawing.Point(370, 431);
			this.btnVerifyCode.Name = "btnVerifyCode";
			this.btnVerifyCode.Size = new System.Drawing.Size(165, 36);
			this.btnVerifyCode.TabIndex = 14;
			this.btnVerifyCode.Text = "Verify Code";
			this.btnVerifyCode.UseVisualStyleBackColor = true;
			this.btnVerifyCode.Click += new System.EventHandler(this.btnVerifyCode_Click);
			// 
			// UpdatePassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(886, 522);
			this.Controls.Add(this.btnVerifyCode);
			this.Controls.Add(this.txtVerifyCode);
			this.Controls.Add(this.lblVerifyCode);
			this.Controls.Add(this.txtResetCode);
			this.Controls.Add(this.lblResetCode);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnUpdatePass);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtEmpID);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblManPW);
			this.Controls.Add(this.lblEmpID);
			this.Controls.Add(this.lblEmpName);
			this.Name = "UpdatePassword";
			this.Text = "UpdatePassword";
			this.Load += new System.EventHandler(this.UpdatePassword_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label lblEmpName;
		private System.Windows.Forms.Label lblEmpID;
		private System.Windows.Forms.Label lblManPW;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtEmpID;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnUpdatePass;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label lblResetCode;
		private System.Windows.Forms.TextBox txtResetCode;
		private System.Windows.Forms.Label lblVerifyCode;
		private System.Windows.Forms.TextBox txtVerifyCode;
		private System.Windows.Forms.Button btnVerifyCode;
	}
}