namespace SelfCheckoutGroupProject
{
	partial class frmUserInterface
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
			this.txtUserSearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(62, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(194, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Enter An Item:";
			// 
			// txtUserSearch
			// 
			this.txtUserSearch.Location = new System.Drawing.Point(262, 56);
			this.txtUserSearch.Name = "txtUserSearch";
			this.txtUserSearch.Size = new System.Drawing.Size(185, 26);
			this.txtUserSearch.TabIndex = 1;
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(463, 53);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(183, 32);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "&Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(463, 184);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(183, 38);
			this.button1.TabIndex = 3;
			this.button1.Text = "&View Payment Oprions";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(664, 184);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(183, 38);
			this.button2.TabIndex = 4;
			this.button2.Text = "View &Receipt Options";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// frmUserInterface
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(859, 272);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtUserSearch);
			this.Controls.Add(this.label1);
			this.Name = "frmUserInterface";
			this.Text = "User_Interface";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUserSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}