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
			this.UIMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnCancel = new System.Windows.Forms.Button();
			this.UIMenuStrip.SuspendLayout();
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
			// UIMenuStrip
			// 
			this.UIMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.UIMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.UIMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.UIMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.UIMenuStrip.Name = "UIMenuStrip";
			this.UIMenuStrip.Size = new System.Drawing.Size(859, 36);
			this.UIMenuStrip.TabIndex = 5;
			this.UIMenuStrip.Text = "UserMenuStrip";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 32);
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
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(13, 184);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(183, 38);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// frmUserInterface
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(859, 272);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtUserSearch);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.UIMenuStrip);
			this.MainMenuStrip = this.UIMenuStrip;
			this.Name = "frmUserInterface";
			this.Text = "User_Interface";
			this.UIMenuStrip.ResumeLayout(false);
			this.UIMenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUserSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.MenuStrip UIMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
		private System.Windows.Forms.Button btnCancel;
	}
}