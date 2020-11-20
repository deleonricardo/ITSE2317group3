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
            this.rdoButtonInventory = new System.Windows.Forms.RadioButton();
            this.rdoBtnEmployeeList = new System.Windows.Forms.RadioButton();
            this.rdoBtnPass = new System.Windows.Forms.RadioButton();
            this.rdoBtnSales = new System.Windows.Forms.RadioButton();
            this.btnEnter = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoBtnSales);
            this.groupBox1.Controls.Add(this.rdoBtnPass);
            this.groupBox1.Controls.Add(this.rdoBtnEmployeeList);
            this.groupBox1.Controls.Add(this.rdoButtonInventory);
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdoButtonInventory
            // 
            this.rdoButtonInventory.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoButtonInventory.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoButtonInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoButtonInventory.Location = new System.Drawing.Point(6, 21);
            this.rdoButtonInventory.Name = "rdoButtonInventory";
            this.rdoButtonInventory.Size = new System.Drawing.Size(214, 39);
            this.rdoButtonInventory.TabIndex = 0;
            this.rdoButtonInventory.TabStop = true;
            this.rdoButtonInventory.Text = "Inventory";
            this.rdoButtonInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoButtonInventory.UseVisualStyleBackColor = false;
            // 
            // rdoBtnEmployeeList
            // 
            this.rdoBtnEmployeeList.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoBtnEmployeeList.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoBtnEmployeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnEmployeeList.Location = new System.Drawing.Point(6, 66);
            this.rdoBtnEmployeeList.Name = "rdoBtnEmployeeList";
            this.rdoBtnEmployeeList.Size = new System.Drawing.Size(214, 39);
            this.rdoBtnEmployeeList.TabIndex = 1;
            this.rdoBtnEmployeeList.TabStop = true;
            this.rdoBtnEmployeeList.Text = "Employees";
            this.rdoBtnEmployeeList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoBtnEmployeeList.UseVisualStyleBackColor = false;
            // 
            // rdoBtnPass
            // 
            this.rdoBtnPass.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoBtnPass.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoBtnPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnPass.Location = new System.Drawing.Point(6, 111);
            this.rdoBtnPass.Name = "rdoBtnPass";
            this.rdoBtnPass.Size = new System.Drawing.Size(214, 39);
            this.rdoBtnPass.TabIndex = 2;
            this.rdoBtnPass.TabStop = true;
            this.rdoBtnPass.Text = "Update Password";
            this.rdoBtnPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoBtnPass.UseVisualStyleBackColor = false;
            // 
            // rdoBtnSales
            // 
            this.rdoBtnSales.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoBtnSales.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoBtnSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnSales.Location = new System.Drawing.Point(6, 156);
            this.rdoBtnSales.Name = "rdoBtnSales";
            this.rdoBtnSales.Size = new System.Drawing.Size(214, 39);
            this.rdoBtnSales.TabIndex = 3;
            this.rdoBtnSales.TabStop = true;
            this.rdoBtnSales.Text = "Current Sales";
            this.rdoBtnSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoBtnSales.UseVisualStyleBackColor = false;
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(18, 314);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(214, 39);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Accept";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(292, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(411, 260);
            this.listBox1.TabIndex = 2;
            // 
            // ManagerInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManagerInterface";
            this.Text = "ManagerInterface";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoBtnSales;
        private System.Windows.Forms.RadioButton rdoBtnPass;
        private System.Windows.Forms.RadioButton rdoBtnEmployeeList;
        private System.Windows.Forms.RadioButton rdoButtonInventory;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.ListBox listBox1;
    }
}