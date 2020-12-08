namespace SelfCheckoutGroupProject
{
	partial class ResetPassword
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
			this.txtNewPass = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtVerifyPass = new System.Windows.Forms.TextBox();
			this.btnResetPass = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter New Password:";
			// 
			// txtNewPass
			// 
			this.txtNewPass.Location = new System.Drawing.Point(178, 46);
			this.txtNewPass.Name = "txtNewPass";
			this.txtNewPass.Size = new System.Drawing.Size(135, 26);
			this.txtNewPass.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(161, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "&Verify New Password:";
			// 
			// txtVerifyPass
			// 
			this.txtVerifyPass.Location = new System.Drawing.Point(180, 93);
			this.txtVerifyPass.Name = "txtVerifyPass";
			this.txtVerifyPass.Size = new System.Drawing.Size(133, 26);
			this.txtVerifyPass.TabIndex = 3;
			// 
			// btnResetPass
			// 
			this.btnResetPass.Location = new System.Drawing.Point(178, 174);
			this.btnResetPass.Name = "btnResetPass";
			this.btnResetPass.Size = new System.Drawing.Size(135, 39);
			this.btnResetPass.TabIndex = 4;
			this.btnResetPass.Text = "&Reset Password";
			this.btnResetPass.UseVisualStyleBackColor = true;
			this.btnResetPass.Click += new System.EventHandler(this.btnResetPass_Click);
			// 
			// ResetPassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(498, 272);
			this.Controls.Add(this.btnResetPass);
			this.Controls.Add(this.txtVerifyPass);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNewPass);
			this.Controls.Add(this.label1);
			this.Name = "ResetPassword";
			this.Text = "ResetPassword";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNewPass;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtVerifyPass;
		private System.Windows.Forms.Button btnResetPass;
	}
}