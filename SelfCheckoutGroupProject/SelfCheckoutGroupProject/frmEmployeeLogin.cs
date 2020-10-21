using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelfCheckoutGroupProject
{
	public partial class frmEmployeeLogin : Form
	{
		public frmEmployeeLogin()
		{
			InitializeComponent();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			//Take the user back to the main form
			frmMain mainScreen = new frmMain();
			this.Hide();
			mainScreen.Show();
		}

		private void fontToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FontDialog fdLoginFont = new FontDialog();
			fdLoginFont.ShowColor = true;
			if (fdLoginFont.ShowDialog() == DialogResult.OK & !String.IsNullOrEmpty(lblLoginTitle.Text) && fdLoginFont.ShowDialog() == DialogResult.OK & !String.IsNullOrEmpty(lblNameLabel.Text) && fdLoginFont.ShowDialog() == DialogResult.OK & !String.IsNullOrEmpty(lblPassword.Text))
			{
				lblLoginTitle.Font = fdLoginFont.Font;
				lblPassword.Font = fdLoginFont.Font;
				lblNameLabel.Font = fdLoginFont.Font;

				//Change the text color as well
				lblLoginTitle.ForeColor = fdLoginFont.Color;
				lblPassword.ForeColor = fdLoginFont.Color;
				lblNameLabel.ForeColor = fdLoginFont.Color;

			}



		}

		private void colorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//When the color option is selected the user will be able to change the color of the form
			ColorDialog cdLoginColor = new ColorDialog();

			if (cdLoginColor.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
			{
				this.BackColor = cdLoginColor.Color;

			}
		}
	}
}
