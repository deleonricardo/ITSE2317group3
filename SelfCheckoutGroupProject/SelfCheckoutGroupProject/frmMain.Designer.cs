namespace SelfCheckoutGroupProject
{
	partial class frmMain
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
			this.lblTitle = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnUser = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btnAdmin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(143, 65);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(480, 40);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Self-Checkout Main Screen";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(170, 132);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(365, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "Select one of the Following:";
			// 
			// btnUser
			// 
			this.btnUser.Location = new System.Drawing.Point(176, 207);
			this.btnUser.Name = "btnUser";
			this.btnUser.Size = new System.Drawing.Size(104, 39);
			this.btnUser.TabIndex = 2;
			this.btnUser.Text = "&User";
			this.btnUser.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(305, 207);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 39);
			this.button1.TabIndex = 3;
			this.button1.Text = "&Employee";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// btnAdmin
			// 
			this.btnAdmin.Location = new System.Drawing.Point(451, 207);
			this.btnAdmin.Name = "btnAdmin";
			this.btnAdmin.Size = new System.Drawing.Size(104, 39);
			this.btnAdmin.TabIndex = 4;
			this.btnAdmin.Text = "&Admin";
			this.btnAdmin.UseVisualStyleBackColor = true;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(794, 306);
			this.Controls.Add(this.btnAdmin);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnUser);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblTitle);
			this.Name = "frmMain";
			this.Text = "Self Checkout Main Screen";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnUser;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnAdmin;
	}
}

