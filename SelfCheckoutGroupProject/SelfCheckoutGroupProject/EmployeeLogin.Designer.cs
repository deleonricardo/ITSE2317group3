namespace SelfCheckoutGroupProject
{
    partial class EmployeeLogin
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtEName = new System.Windows.Forms.TextBox();
			this.txtEID = new System.Windows.Forms.TextBox();
			this.btnSignIn = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txtEPass = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(21, 86);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(228, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Employee Login:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 164);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(232, 32);
			this.label2.TabIndex = 1;
			this.label2.Text = "Employee Name:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(63, 238);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(184, 32);
			this.label3.TabIndex = 2;
			this.label3.Text = "Employee ID:";
			// 
			// txtEName
			// 
			this.txtEName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEName.Location = new System.Drawing.Point(246, 158);
			this.txtEName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtEName.Name = "txtEName";
			this.txtEName.Size = new System.Drawing.Size(327, 39);
			this.txtEName.TabIndex = 3;
			// 
			// txtEID
			// 
			this.txtEID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEID.Location = new System.Drawing.Point(246, 238);
			this.txtEID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtEID.Name = "txtEID";
			this.txtEID.Size = new System.Drawing.Size(217, 39);
			this.txtEID.TabIndex = 4;
			// 
			// btnSignIn
			// 
			this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSignIn.Location = new System.Drawing.Point(399, 431);
			this.btnSignIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnSignIn.Name = "btnSignIn";
			this.btnSignIn.Size = new System.Drawing.Size(163, 96);
			this.btnSignIn.TabIndex = 5;
			this.btnSignIn.Text = "Sign In";
			this.btnSignIn.UseVisualStyleBackColor = true;
			this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(580, 431);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(163, 96);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(84, 305);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(147, 32);
			this.label4.TabIndex = 7;
			this.label4.Text = "Password:";
			// 
			// txtEPass
			// 
			this.txtEPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEPass.Location = new System.Drawing.Point(246, 305);
			this.txtEPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtEPass.Name = "txtEPass";
			this.txtEPass.Size = new System.Drawing.Size(217, 39);
			this.txtEPass.TabIndex = 8;
			this.txtEPass.TextChanged += new System.EventHandler(this.btnSignIn_Click);
			// 
			// EmployeeLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(900, 562);
			this.Controls.Add(this.txtEPass);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSignIn);
			this.Controls.Add(this.txtEID);
			this.Controls.Add(this.txtEName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "EmployeeLogin";
			this.Text = "EmployeeLogin";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEName;
        private System.Windows.Forms.TextBox txtEID;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEPass;
    }
}