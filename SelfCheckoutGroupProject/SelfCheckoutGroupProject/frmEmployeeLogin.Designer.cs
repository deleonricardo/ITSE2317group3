namespace SelfCheckoutGroupProject
{
	partial class frmEmployeeLogin
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
			this.lblLoginTitle = new System.Windows.Forms.Label();
			this.lblNameLabel = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.txtEmployeeName = new System.Windows.Forms.TextBox();
			this.txtEmpPassword = new System.Windows.Forms.TextBox();
			this.btnSignIn = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.loginMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loginMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblLoginTitle
			// 
			this.lblLoginTitle.AutoSize = true;
			this.lblLoginTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLoginTitle.Location = new System.Drawing.Point(230, 85);
			this.lblLoginTitle.Name = "lblLoginTitle";
			this.lblLoginTitle.Size = new System.Drawing.Size(289, 40);
			this.lblLoginTitle.TabIndex = 0;
			this.lblLoginTitle.Text = "Employee Login";
			// 
			// lblNameLabel
			// 
			this.lblNameLabel.AutoSize = true;
			this.lblNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNameLabel.Location = new System.Drawing.Point(95, 163);
			this.lblNameLabel.Name = "lblNameLabel";
			this.lblNameLabel.Size = new System.Drawing.Size(232, 32);
			this.lblNameLabel.TabIndex = 1;
			this.lblNameLabel.Text = "&Employee Name:";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPassword.Location = new System.Drawing.Point(101, 221);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(147, 32);
			this.lblPassword.TabIndex = 2;
			this.lblPassword.Text = "Password:";
			// 
			// txtEmployeeName
			// 
			this.txtEmployeeName.Location = new System.Drawing.Point(333, 169);
			this.txtEmployeeName.Name = "txtEmployeeName";
			this.txtEmployeeName.Size = new System.Drawing.Size(137, 26);
			this.txtEmployeeName.TabIndex = 3;
			// 
			// txtEmpPassword
			// 
			this.txtEmpPassword.Location = new System.Drawing.Point(333, 227);
			this.txtEmpPassword.Name = "txtEmpPassword";
			this.txtEmpPassword.Size = new System.Drawing.Size(137, 26);
			this.txtEmpPassword.TabIndex = 4;
			// 
			// btnSignIn
			// 
			this.btnSignIn.Location = new System.Drawing.Point(485, 288);
			this.btnSignIn.Name = "btnSignIn";
			this.btnSignIn.Size = new System.Drawing.Size(92, 35);
			this.btnSignIn.TabIndex = 5;
			this.btnSignIn.Text = "&Sign In";
			this.btnSignIn.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(622, 288);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(92, 35);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(101, 288);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(155, 35);
			this.btnReset.TabIndex = 7;
			this.btnReset.Text = "&Reset Password";
			this.btnReset.UseVisualStyleBackColor = true;
			// 
			// loginMenuStrip
			// 
			this.loginMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.loginMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.loginMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.loginMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.loginMenuStrip.Name = "loginMenuStrip";
			this.loginMenuStrip.Size = new System.Drawing.Size(798, 33);
			this.loginMenuStrip.TabIndex = 8;
			this.loginMenuStrip.Text = "loginMenuStrip";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// customizeToolStripMenuItem
			// 
			this.customizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
			this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
			this.customizeToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
			this.customizeToolStripMenuItem.Text = "Customize";
			// 
			// fontToolStripMenuItem
			// 
			this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
			this.fontToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
			this.fontToolStripMenuItem.Text = "Font";
			this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
			// 
			// colorToolStripMenuItem
			// 
			this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
			this.colorToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
			this.colorToolStripMenuItem.Text = "Color";
			this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
			// 
			// frmEmployeeLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(798, 356);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSignIn);
			this.Controls.Add(this.txtEmpPassword);
			this.Controls.Add(this.txtEmployeeName);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblNameLabel);
			this.Controls.Add(this.lblLoginTitle);
			this.Controls.Add(this.loginMenuStrip);
			this.MainMenuStrip = this.loginMenuStrip;
			this.Name = "frmEmployeeLogin";
			this.Text = "Employee Login";
			this.loginMenuStrip.ResumeLayout(false);
			this.loginMenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblLoginTitle;
		private System.Windows.Forms.Label lblNameLabel;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox txtEmployeeName;
		private System.Windows.Forms.TextBox txtEmpPassword;
		private System.Windows.Forms.Button btnSignIn;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.MenuStrip loginMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
	}
}