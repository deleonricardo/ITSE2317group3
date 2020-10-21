namespace SelfCheckoutGroupProject
{
	partial class frmInventory
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
			this.InventoryDataGrid = new System.Windows.Forms.DataGridView();
			this.txtSearchBar = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnChangeQty = new System.Windows.Forms.Button();
			this.btnDeleteItem = new System.Windows.Forms.Button();
			this.btnEnterCoupon = new System.Windows.Forms.Button();
			this.btnCloseStation = new System.Windows.Forms.Button();
			this.InventoryMS = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.InventoryDataGrid)).BeginInit();
			this.InventoryMS.SuspendLayout();
			this.SuspendLayout();
			// 
			// InventoryDataGrid
			// 
			this.InventoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.InventoryDataGrid.Location = new System.Drawing.Point(12, 132);
			this.InventoryDataGrid.Name = "InventoryDataGrid";
			this.InventoryDataGrid.RowHeadersWidth = 62;
			this.InventoryDataGrid.RowTemplate.Height = 28;
			this.InventoryDataGrid.Size = new System.Drawing.Size(581, 306);
			this.InventoryDataGrid.TabIndex = 0;
			// 
			// txtSearchBar
			// 
			this.txtSearchBar.Location = new System.Drawing.Point(133, 65);
			this.txtSearchBar.Name = "txtSearchBar";
			this.txtSearchBar.Size = new System.Drawing.Size(275, 26);
			this.txtSearchBar.TabIndex = 1;
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(432, 61);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(87, 35);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "&Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// btnChangeQty
			// 
			this.btnChangeQty.Location = new System.Drawing.Point(630, 213);
			this.btnChangeQty.Name = "btnChangeQty";
			this.btnChangeQty.Size = new System.Drawing.Size(141, 32);
			this.btnChangeQty.TabIndex = 3;
			this.btnChangeQty.Text = "&Change Quantity";
			this.btnChangeQty.UseVisualStyleBackColor = true;
			// 
			// btnDeleteItem
			// 
			this.btnDeleteItem.Location = new System.Drawing.Point(630, 268);
			this.btnDeleteItem.Name = "btnDeleteItem";
			this.btnDeleteItem.Size = new System.Drawing.Size(141, 32);
			this.btnDeleteItem.TabIndex = 4;
			this.btnDeleteItem.Text = "&Delete Item";
			this.btnDeleteItem.UseVisualStyleBackColor = true;
			// 
			// btnEnterCoupon
			// 
			this.btnEnterCoupon.Location = new System.Drawing.Point(630, 323);
			this.btnEnterCoupon.Name = "btnEnterCoupon";
			this.btnEnterCoupon.Size = new System.Drawing.Size(141, 32);
			this.btnEnterCoupon.TabIndex = 5;
			this.btnEnterCoupon.Text = "&Enter Coupon";
			this.btnEnterCoupon.UseVisualStyleBackColor = true;
			// 
			// btnCloseStation
			// 
			this.btnCloseStation.Location = new System.Drawing.Point(630, 377);
			this.btnCloseStation.Name = "btnCloseStation";
			this.btnCloseStation.Size = new System.Drawing.Size(141, 32);
			this.btnCloseStation.TabIndex = 6;
			this.btnCloseStation.Text = "Close Station";
			this.btnCloseStation.UseVisualStyleBackColor = true;
			// 
			// InventoryMS
			// 
			this.InventoryMS.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.InventoryMS.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.InventoryMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.InventoryMS.Location = new System.Drawing.Point(0, 0);
			this.InventoryMS.Name = "InventoryMS";
			this.InventoryMS.Size = new System.Drawing.Size(800, 33);
			this.InventoryMS.TabIndex = 7;
			this.InventoryMS.Text = "InventoryMS";
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
			// frmInventory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnCloseStation);
			this.Controls.Add(this.btnEnterCoupon);
			this.Controls.Add(this.btnDeleteItem);
			this.Controls.Add(this.btnChangeQty);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtSearchBar);
			this.Controls.Add(this.InventoryDataGrid);
			this.Controls.Add(this.InventoryMS);
			this.MainMenuStrip = this.InventoryMS;
			this.Name = "frmInventory";
			this.Text = "Inventory";
			((System.ComponentModel.ISupportInitialize)(this.InventoryDataGrid)).EndInit();
			this.InventoryMS.ResumeLayout(false);
			this.InventoryMS.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView InventoryDataGrid;
		private System.Windows.Forms.TextBox txtSearchBar;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnChangeQty;
		private System.Windows.Forms.Button btnDeleteItem;
		private System.Windows.Forms.Button btnEnterCoupon;
		private System.Windows.Forms.Button btnCloseStation;
		private System.Windows.Forms.MenuStrip InventoryMS;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
	}
}