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
			((System.ComponentModel.ISupportInitialize)(this.InventoryDataGrid)).BeginInit();
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
			this.Name = "frmInventory";
			this.Text = "Inventory";
			((System.ComponentModel.ISupportInitialize)(this.InventoryDataGrid)).EndInit();
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
	}
}