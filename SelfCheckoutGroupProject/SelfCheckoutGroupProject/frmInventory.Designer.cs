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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAddItem = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.pbNewItem = new System.Windows.Forms.PictureBox();
			this.btnUploadImage = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtImageName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtProdNum = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbNewItem)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 51);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(724, 456);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(183, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "Inventory List";
			// 
			// btnAddItem
			// 
			this.btnAddItem.BackColor = System.Drawing.Color.Lime;
			this.btnAddItem.Location = new System.Drawing.Point(742, 362);
			this.btnAddItem.Name = "btnAddItem";
			this.btnAddItem.Size = new System.Drawing.Size(144, 46);
			this.btnAddItem.TabIndex = 2;
			this.btnAddItem.Text = "&Add Item";
			this.btnAddItem.UseVisualStyleBackColor = false;
			this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
			this.btnDelete.Location = new System.Drawing.Point(1078, 362);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(144, 46);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "Confirm &Delete";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// pbNewItem
			// 
			this.pbNewItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbNewItem.Location = new System.Drawing.Point(962, 51);
			this.pbNewItem.Name = "pbNewItem";
			this.pbNewItem.Size = new System.Drawing.Size(201, 162);
			this.pbNewItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbNewItem.TabIndex = 4;
			this.pbNewItem.TabStop = false;
			this.pbNewItem.Click += new System.EventHandler(this.pbNewItem_Click);
			// 
			// btnUploadImage
			// 
			this.btnUploadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnUploadImage.Location = new System.Drawing.Point(915, 362);
			this.btnUploadImage.Name = "btnUploadImage";
			this.btnUploadImage.Size = new System.Drawing.Size(144, 46);
			this.btnUploadImage.TabIndex = 5;
			this.btnUploadImage.Text = "&Upload Image";
			this.btnUploadImage.UseVisualStyleBackColor = false;
			this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(1078, 461);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(144, 46);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(847, 233);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(147, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Enter Image Name:";
			// 
			// txtImageName
			// 
			this.txtImageName.Location = new System.Drawing.Point(1001, 233);
			this.txtImageName.Name = "txtImageName";
			this.txtImageName.Size = new System.Drawing.Size(162, 26);
			this.txtImageName.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(851, 286);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(163, 20);
			this.label3.TabIndex = 9;
			this.label3.Text = "New Product Number:";
			// 
			// txtProdNum
			// 
			this.txtProdNum.Location = new System.Drawing.Point(1021, 286);
			this.txtProdNum.Name = "txtProdNum";
			this.txtProdNum.Size = new System.Drawing.Size(142, 26);
			this.txtProdNum.TabIndex = 10;
			// 
			// frmInventory
			// 
			this.ClientSize = new System.Drawing.Size(1441, 542);
			this.Controls.Add(this.txtProdNum);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtImageName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnUploadImage);
			this.Controls.Add(this.pbNewItem);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAddItem);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "frmInventory";
			this.Load += new System.EventHandler(this.frmInventory_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbNewItem)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAddItem;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.PictureBox pbNewItem;
		private System.Windows.Forms.Button btnUploadImage;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtImageName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtProdNum;
	}
}