﻿namespace SelfCheckoutGroupProject
{
    partial class Report
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
			this.btnManager = new System.Windows.Forms.Button();
			this.btnReports = new System.Windows.Forms.Button();
			this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.btnEmpReport = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnManager
			// 
			this.btnManager.Location = new System.Drawing.Point(25, 31);
			this.btnManager.Name = "btnManager";
			this.btnManager.Size = new System.Drawing.Size(77, 38);
			this.btnManager.TabIndex = 0;
			this.btnManager.Text = "&Back";
			this.btnManager.UseVisualStyleBackColor = true;
			this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
			// 
			// btnReports
			// 
			this.btnReports.Location = new System.Drawing.Point(25, 99);
			this.btnReports.Name = "btnReports";
			this.btnReports.Size = new System.Drawing.Size(199, 34);
			this.btnReports.TabIndex = 1;
			this.btnReports.Text = "&View Inventory";
			this.btnReports.UseVisualStyleBackColor = true;
			this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
			// 
			// crystalReportViewer1
			// 
			this.crystalReportViewer1.ActiveViewIndex = -1;
			this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
			this.crystalReportViewer1.Location = new System.Drawing.Point(25, 157);
			this.crystalReportViewer1.Name = "crystalReportViewer1";
			this.crystalReportViewer1.Size = new System.Drawing.Size(1680, 530);
			this.crystalReportViewer1.TabIndex = 2;
			// 
			// btnEmpReport
			// 
			this.btnEmpReport.Location = new System.Drawing.Point(322, 99);
			this.btnEmpReport.Name = "btnEmpReport";
			this.btnEmpReport.Size = new System.Drawing.Size(199, 34);
			this.btnEmpReport.TabIndex = 3;
			this.btnEmpReport.Text = "&Employee Report";
			this.btnEmpReport.UseVisualStyleBackColor = true;
			this.btnEmpReport.Click += new System.EventHandler(this.btnEmpReport_Click);
			// 
			// Report
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1728, 699);
			this.Controls.Add(this.btnEmpReport);
			this.Controls.Add(this.crystalReportViewer1);
			this.Controls.Add(this.btnReports);
			this.Controls.Add(this.btnManager);
			this.Name = "Report";
			this.Text = "Report";
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button btnManager;
		private System.Windows.Forms.Button btnReports;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
		private System.Windows.Forms.Button btnEmpReport;
	}
}