namespace SelfCheckoutGroupProject
{
    partial class ManagerInterface
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdoBtnSales = new System.Windows.Forms.RadioButton();
			this.rdoBtnPass = new System.Windows.Forms.RadioButton();
			this.rdoBtnEmployeeList = new System.Windows.Forms.RadioButton();
			this.rdoButtonInventory = new System.Windows.Forms.RadioButton();
			this.btnEnter = new System.Windows.Forms.Button();
			this.EmployeesDataGrid = new System.Windows.Forms.DataGridView();
			this.btnAddEmployee = new System.Windows.Forms.Button();
			this.btnRemoveEmployee = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdoBtnSales);
			this.groupBox1.Controls.Add(this.rdoBtnPass);
			this.groupBox1.Controls.Add(this.rdoBtnEmployeeList);
			this.groupBox1.Controls.Add(this.rdoButtonInventory);
			this.groupBox1.Location = new System.Drawing.Point(14, 111);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox1.Size = new System.Drawing.Size(263, 258);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Options";
			// 
			// rdoBtnSales
			// 
			this.rdoBtnSales.Appearance = System.Windows.Forms.Appearance.Button;
			this.rdoBtnSales.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rdoBtnSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdoBtnSales.Location = new System.Drawing.Point(7, 195);
			this.rdoBtnSales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.rdoBtnSales.Name = "rdoBtnSales";
			this.rdoBtnSales.Size = new System.Drawing.Size(241, 49);
			this.rdoBtnSales.TabIndex = 3;
			this.rdoBtnSales.TabStop = true;
			this.rdoBtnSales.Text = "Current Sales";
			this.rdoBtnSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rdoBtnSales.UseVisualStyleBackColor = false;
			// 
			// rdoBtnPass
			// 
			this.rdoBtnPass.Appearance = System.Windows.Forms.Appearance.Button;
			this.rdoBtnPass.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rdoBtnPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdoBtnPass.Location = new System.Drawing.Point(7, 139);
			this.rdoBtnPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.rdoBtnPass.Name = "rdoBtnPass";
			this.rdoBtnPass.Size = new System.Drawing.Size(241, 49);
			this.rdoBtnPass.TabIndex = 2;
			this.rdoBtnPass.TabStop = true;
			this.rdoBtnPass.Text = "Update Password";
			this.rdoBtnPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rdoBtnPass.UseVisualStyleBackColor = false;
			// 
			// rdoBtnEmployeeList
			// 
			this.rdoBtnEmployeeList.Appearance = System.Windows.Forms.Appearance.Button;
			this.rdoBtnEmployeeList.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rdoBtnEmployeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdoBtnEmployeeList.Location = new System.Drawing.Point(7, 82);
			this.rdoBtnEmployeeList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.rdoBtnEmployeeList.Name = "rdoBtnEmployeeList";
			this.rdoBtnEmployeeList.Size = new System.Drawing.Size(241, 49);
			this.rdoBtnEmployeeList.TabIndex = 1;
			this.rdoBtnEmployeeList.TabStop = true;
			this.rdoBtnEmployeeList.Text = "Employees";
			this.rdoBtnEmployeeList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rdoBtnEmployeeList.UseVisualStyleBackColor = false;
			// 
			// rdoButtonInventory
			// 
			this.rdoButtonInventory.Appearance = System.Windows.Forms.Appearance.Button;
			this.rdoButtonInventory.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rdoButtonInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdoButtonInventory.Location = new System.Drawing.Point(7, 26);
			this.rdoButtonInventory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.rdoButtonInventory.Name = "rdoButtonInventory";
			this.rdoButtonInventory.Size = new System.Drawing.Size(241, 49);
			this.rdoButtonInventory.TabIndex = 0;
			this.rdoButtonInventory.TabStop = true;
			this.rdoButtonInventory.Text = "Inventory";
			this.rdoButtonInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rdoButtonInventory.UseVisualStyleBackColor = false;
			// 
			// btnEnter
			// 
			this.btnEnter.BackColor = System.Drawing.Color.Lime;
			this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEnter.Location = new System.Drawing.Point(20, 392);
			this.btnEnter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnEnter.Name = "btnEnter";
			this.btnEnter.Size = new System.Drawing.Size(241, 49);
			this.btnEnter.TabIndex = 1;
			this.btnEnter.Text = "Accept";
			this.btnEnter.UseVisualStyleBackColor = false;
			this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
			// 
			// EmployeesDataGrid
			// 
			this.EmployeesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.EmployeesDataGrid.Location = new System.Drawing.Point(315, 105);
			this.EmployeesDataGrid.Name = "EmployeesDataGrid";
			this.EmployeesDataGrid.RowHeadersWidth = 62;
			this.EmployeesDataGrid.RowTemplate.Height = 28;
			this.EmployeesDataGrid.Size = new System.Drawing.Size(513, 336);
			this.EmployeesDataGrid.TabIndex = 2;
			//this.EmployeesDataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeesDataGrid_CellEndEdit);
			// 
			// btnAddEmployee
			// 
			this.btnAddEmployee.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnAddEmployee.Location = new System.Drawing.Point(264, 460);
			this.btnAddEmployee.Name = "btnAddEmployee";
			this.btnAddEmployee.Size = new System.Drawing.Size(195, 55);
			this.btnAddEmployee.TabIndex = 3;
			this.btnAddEmployee.Text = "&Add Employee";
			this.btnAddEmployee.UseVisualStyleBackColor = false;
			this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
			// 
			// btnRemoveEmployee
			// 
			this.btnRemoveEmployee.BackColor = System.Drawing.Color.LightCoral;
			this.btnRemoveEmployee.Location = new System.Drawing.Point(499, 460);
			this.btnRemoveEmployee.Name = "btnRemoveEmployee";
			this.btnRemoveEmployee.Size = new System.Drawing.Size(195, 55);
			this.btnRemoveEmployee.TabIndex = 4;
			this.btnRemoveEmployee.Text = "Confirm &Delete";
			this.btnRemoveEmployee.UseVisualStyleBackColor = false;
			this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(714, 460);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(195, 55);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// ManagerInterface
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(953, 581);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnRemoveEmployee);
			this.Controls.Add(this.btnAddEmployee);
			this.Controls.Add(this.EmployeesDataGrid);
			this.Controls.Add(this.btnEnter);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "ManagerInterface";
			this.Text = "ManagerInterface";
			this.Load += new System.EventHandler(this.ManagerInterface_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGrid)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoBtnSales;
        private System.Windows.Forms.RadioButton rdoBtnPass;
        private System.Windows.Forms.RadioButton rdoBtnEmployeeList;
        private System.Windows.Forms.RadioButton rdoButtonInventory;
        private System.Windows.Forms.Button btnEnter;
		private System.Windows.Forms.DataGridView EmployeesDataGrid;
		private System.Windows.Forms.Button btnAddEmployee;
		private System.Windows.Forms.Button btnRemoveEmployee;
		private System.Windows.Forms.Button btnCancel;
	}
}