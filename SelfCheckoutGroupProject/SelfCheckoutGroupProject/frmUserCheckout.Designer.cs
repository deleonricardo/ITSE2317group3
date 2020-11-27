namespace SelfCheckoutGroupProject
{
    partial class frmUserCheckout
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
            this.lstOrderSummary = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCVRNum = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtCardNum = new System.Windows.Forms.TextBox();
            this.txtNameOnCard = new System.Windows.Forms.TextBox();
            this.lable6 = new System.Windows.Forms.Label();
            this.txtExpYear = new System.Windows.Forms.Label();
            this.txtExpMonth = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCheck = new System.Windows.Forms.RadioButton();
            this.btnCash = new System.Windows.Forms.RadioButton();
            this.btnCreditCard = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.btnCancelPurchase = new System.Windows.Forms.Button();
            this.btnConfirmPurchase = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstOrderSummary);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Summary";
            // 
            // lstOrderSummary
            // 
            this.lstOrderSummary.FormattingEnabled = true;
            this.lstOrderSummary.ItemHeight = 16;
            this.lstOrderSummary.Location = new System.Drawing.Point(6, 21);
            this.lstOrderSummary.Name = "lstOrderSummary";
            this.lstOrderSummary.Size = new System.Drawing.Size(234, 388);
            this.lstOrderSummary.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCVRNum);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.txtCardNum);
            this.groupBox2.Controls.Add(this.txtNameOnCard);
            this.groupBox2.Controls.Add(this.lable6);
            this.groupBox2.Controls.Add(this.txtExpYear);
            this.groupBox2.Controls.Add(this.txtExpMonth);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(264, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 237);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Credit Card Information";
            // 
            // txtCVRNum
            // 
            this.txtCVRNum.Location = new System.Drawing.Point(111, 185);
            this.txtCVRNum.Name = "txtCVRNum";
            this.txtCVRNum.Size = new System.Drawing.Size(100, 22);
            this.txtCVRNum.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(85, 134);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(76, 22);
            this.textBox4.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(242, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(73, 22);
            this.textBox3.TabIndex = 10;
            // 
            // txtCardNum
            // 
            this.txtCardNum.Location = new System.Drawing.Point(111, 78);
            this.txtCardNum.Name = "txtCardNum";
            this.txtCardNum.Size = new System.Drawing.Size(204, 22);
            this.txtCardNum.TabIndex = 9;
            // 
            // txtNameOnCard
            // 
            this.txtNameOnCard.Location = new System.Drawing.Point(120, 31);
            this.txtNameOnCard.Name = "txtNameOnCard";
            this.txtNameOnCard.Size = new System.Drawing.Size(195, 22);
            this.txtNameOnCard.TabIndex = 8;
            // 
            // lable6
            // 
            this.lable6.AutoSize = true;
            this.lable6.Location = new System.Drawing.Point(11, 188);
            this.lable6.Name = "lable6";
            this.lable6.Size = new System.Drawing.Size(94, 17);
            this.lable6.TabIndex = 3;
            this.lable6.Text = "CVR Number:";
            // 
            // txtExpYear
            // 
            this.txtExpYear.AutoSize = true;
            this.txtExpYear.Location = new System.Drawing.Point(167, 137);
            this.txtExpYear.Name = "txtExpYear";
            this.txtExpYear.Size = new System.Drawing.Size(69, 17);
            this.txtExpYear.TabIndex = 4;
            this.txtExpYear.Text = "Exp Year:";
            // 
            // txtExpMonth
            // 
            this.txtExpMonth.AutoSize = true;
            this.txtExpMonth.Location = new System.Drawing.Point(11, 137);
            this.txtExpMonth.Name = "txtExpMonth";
            this.txtExpMonth.Size = new System.Drawing.Size(78, 17);
            this.txtExpMonth.TabIndex = 6;
            this.txtExpMonth.Text = "Exp Month:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Card Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name on Card:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCheck);
            this.groupBox3.Controls.Add(this.btnCash);
            this.groupBox3.Controls.Add(this.btnCreditCard);
            this.groupBox3.Location = new System.Drawing.Point(264, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(632, 74);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payment Option";
            // 
            // btnCheck
            // 
            this.btnCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnCheck.Location = new System.Drawing.Point(393, 26);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(116, 32);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.TabStop = true;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // btnCash
            // 
            this.btnCash.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnCash.Location = new System.Drawing.Point(226, 26);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(104, 32);
            this.btnCash.TabIndex = 1;
            this.btnCash.TabStop = true;
            this.btnCash.Text = "Cash";
            this.btnCash.UseVisualStyleBackColor = true;
            // 
            // btnCreditCard
            // 
            this.btnCreditCard.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnCreditCard.Location = new System.Drawing.Point(49, 26);
            this.btnCreditCard.Name = "btnCreditCard";
            this.btnCreditCard.Size = new System.Drawing.Size(104, 32);
            this.btnCreditCard.TabIndex = 0;
            this.btnCreditCard.TabStop = true;
            this.btnCreditCard.Text = "Credit Card";
            this.btnCreditCard.UseVisualStyleBackColor = true;
            this.btnCreditCard.CheckedChanged += new System.EventHandler(this.btnCreditCard_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtSubtotal);
            this.groupBox4.Controls.Add(this.txtTax);
            this.groupBox4.Controls.Add(this.txtBalance);
            this.groupBox4.Location = new System.Drawing.Point(591, 92);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(305, 237);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Payment Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Balance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tax:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subtotal:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(86, 48);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(147, 22);
            this.txtSubtotal.TabIndex = 2;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(86, 114);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(147, 22);
            this.txtTax.TabIndex = 1;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(86, 183);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(147, 22);
            this.txtBalance.TabIndex = 0;
            // 
            // btnCancelPurchase
            // 
            this.btnCancelPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelPurchase.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelPurchase.Location = new System.Drawing.Point(264, 395);
            this.btnCancelPurchase.Name = "btnCancelPurchase";
            this.btnCancelPurchase.Size = new System.Drawing.Size(632, 43);
            this.btnCancelPurchase.TabIndex = 1;
            this.btnCancelPurchase.Text = "Cancel Purchase";
            this.btnCancelPurchase.UseVisualStyleBackColor = false;
            // 
            // btnConfirmPurchase
            // 
            this.btnConfirmPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirmPurchase.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmPurchase.Location = new System.Drawing.Point(264, 335);
            this.btnConfirmPurchase.Name = "btnConfirmPurchase";
            this.btnConfirmPurchase.Size = new System.Drawing.Size(632, 46);
            this.btnConfirmPurchase.TabIndex = 2;
            this.btnConfirmPurchase.Text = "Confirm Purchase";
            this.btnConfirmPurchase.UseVisualStyleBackColor = false;
            // 
            // frmUserCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 450);
            this.Controls.Add(this.btnConfirmPurchase);
            this.Controls.Add(this.btnCancelPurchase);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmUserCheckout";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstOrderSummary;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCVRNum;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtCardNum;
        private System.Windows.Forms.TextBox txtNameOnCard;
        private System.Windows.Forms.Label lable6;
        private System.Windows.Forms.Label txtExpYear;
        private System.Windows.Forms.Label txtExpMonth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton btnCheck;
        private System.Windows.Forms.RadioButton btnCash;
        private System.Windows.Forms.RadioButton btnCreditCard;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Button btnCancelPurchase;
        private System.Windows.Forms.Button btnConfirmPurchase;
    }
}