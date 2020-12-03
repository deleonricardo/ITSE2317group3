namespace SelfCheckoutGroupProject
{
    partial class UserInterface
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
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblSubTotal = new System.Windows.Forms.Label();
			this.lblTaxes = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblPrice = new System.Windows.Forms.Label();
			this.txtSKU = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lblCount = new System.Windows.Forms.Label();
			this.txtOrderNum = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.lblItemTotal = new System.Windows.Forms.Label();
			this.pbProduct = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(341, 450);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(153, 74);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "Add Item";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(547, 450);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(153, 74);
			this.btnDelete.TabIndex = 1;
			this.btnDelete.Text = "Delete Item";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(564, 339);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 32);
			this.label1.TabIndex = 2;
			this.label1.Text = "Total:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(508, 240);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(145, 32);
			this.label3.TabIndex = 3;
			this.label3.Text = "Sub Total:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(551, 290);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 32);
			this.label2.TabIndex = 4;
			this.label2.Text = "Taxes:";
			// 
			// lblSubTotal
			// 
			this.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubTotal.Location = new System.Drawing.Point(654, 240);
			this.lblSubTotal.Name = "lblSubTotal";
			this.lblSubTotal.Size = new System.Drawing.Size(112, 28);
			this.lblSubTotal.TabIndex = 5;
			// 
			// lblTaxes
			// 
			this.lblTaxes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblTaxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTaxes.Location = new System.Drawing.Point(654, 290);
			this.lblTaxes.Name = "lblTaxes";
			this.lblTaxes.Size = new System.Drawing.Size(112, 28);
			this.lblTaxes.TabIndex = 6;
			// 
			// lblTotal
			// 
			this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.Location = new System.Drawing.Point(654, 346);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(112, 28);
			this.lblTotal.TabIndex = 7;
			// 
			// lblName
			// 
			this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(259, 139);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(112, 28);
			this.lblName.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(99, 131);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(159, 32);
			this.label5.TabIndex = 9;
			this.label5.Text = "Item Name:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(109, 168);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(149, 32);
			this.label6.TabIndex = 10;
			this.label6.Text = "Item Price:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(96, 95);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(165, 32);
			this.label7.TabIndex = 11;
			this.label7.Text = "Item SKU #:";
			// 
			// lblPrice
			// 
			this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrice.Location = new System.Drawing.Point(259, 175);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(112, 28);
			this.lblPrice.TabIndex = 12;
			// 
			// txtSKU
			// 
			this.txtSKU.Location = new System.Drawing.Point(259, 104);
			this.txtSKU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtSKU.Name = "txtSKU";
			this.txtSKU.Size = new System.Drawing.Size(112, 26);
			this.txtSKU.TabIndex = 13;
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.Location = new System.Drawing.Point(119, 450);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(153, 74);
			this.btnSearch.TabIndex = 14;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(52, 204);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(212, 32);
			this.label4.TabIndex = 15;
			this.label4.Text = "Total Available:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(24, 240);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(241, 32);
			this.label8.TabIndex = 16;
			this.label8.Text = "Quantity Ordered:";
			// 
			// lblCount
			// 
			this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCount.Location = new System.Drawing.Point(259, 211);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new System.Drawing.Size(112, 28);
			this.lblCount.TabIndex = 17;
			// 
			// txtOrderNum
			// 
			this.txtOrderNum.Location = new System.Drawing.Point(259, 249);
			this.txtOrderNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtOrderNum.Name = "txtOrderNum";
			this.txtOrderNum.Size = new System.Drawing.Size(112, 26);
			this.txtOrderNum.TabIndex = 18;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(109, 275);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(148, 32);
			this.label10.TabIndex = 19;
			this.label10.Text = "Item Total:";
			// 
			// lblItemTotal
			// 
			this.lblItemTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblItemTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblItemTotal.Location = new System.Drawing.Point(258, 282);
			this.lblItemTotal.Name = "lblItemTotal";
			this.lblItemTotal.Size = new System.Drawing.Size(112, 28);
			this.lblItemTotal.TabIndex = 20;
			// 
			// pbProduct
			// 
			this.pbProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbProduct.Location = new System.Drawing.Point(514, 53);
			this.pbProduct.Name = "pbProduct";
			this.pbProduct.Size = new System.Drawing.Size(291, 165);
			this.pbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbProduct.TabIndex = 21;
			this.pbProduct.TabStop = false;
			// 
			// UserInterface
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(900, 562);
			this.Controls.Add(this.pbProduct);
			this.Controls.Add(this.lblItemTotal);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtOrderNum);
			this.Controls.Add(this.lblCount);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtSKU);
			this.Controls.Add(this.lblPrice);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.lblTaxes);
			this.Controls.Add(this.lblSubTotal);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "UserInterface";
			this.Text = "UserInterface";
			((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblTaxes;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox txtOrderNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblItemTotal;
		private System.Windows.Forms.PictureBox pbProduct;
	}
}