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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtEmpID = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnUpdatePass = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(147, 118);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Employee Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(147, 163);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Employee ID:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(147, 265);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(192, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Enter Manager Password:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(282, 115);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(150, 26);
			this.txtName.TabIndex = 1;
			// 
			// txtEmpID
			// 
			this.txtEmpID.Location = new System.Drawing.Point(282, 160);
			this.txtEmpID.Name = "txtEmpID";
			this.txtEmpID.Size = new System.Drawing.Size(150, 26);
			this.txtEmpID.TabIndex = 3;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(345, 262);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(144, 26);
			this.txtPassword.TabIndex = 7;
			// 
			// btnUpdatePass
			// 
			this.btnUpdatePass.Location = new System.Drawing.Point(151, 337);
			this.btnUpdatePass.Name = "btnUpdatePass";
			this.btnUpdatePass.Size = new System.Drawing.Size(165, 36);
			this.btnUpdatePass.TabIndex = 8;
			this.btnUpdatePass.Text = "&Update Password";
			this.btnUpdatePass.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(345, 341);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(123, 29);
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(150, 214);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(126, 20);
			this.label4.TabIndex = 4;
			this.label4.Text = "Employee Email:";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(283, 211);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(149, 26);
			this.txtEmail.TabIndex = 5;
			// 
			// UpdatePassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnUpdatePass);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtEmpID);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "UpdatePassword";
			this.Text = "UpdatePassword";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtEmpID;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnUpdatePass;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtEmail;
	}
}