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
	public partial class frmUserInterface : Form
	{
		public frmUserInterface()
		{
			InitializeComponent();
		}

		private void fontToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FontDialog fdUserFont = new FontDialog();
			fdUserFont.ShowColor = true;
			if (fdUserFont.ShowDialog() == DialogResult.OK & !String.IsNullOrEmpty(txtUserSearch.Text) && fdUserFont.ShowDialog() == DialogResult.OK & !String.IsNullOrEmpty(label1.Text))
			{
				txtUserSearch.Font = fdUserFont.Font;
				label1.Font = fdUserFont.Font;

				//Change the text color as well
				txtUserSearch.ForeColor = fdUserFont.Color;
				label1.ForeColor = fdUserFont.Color;

			}
		}

		private void colorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//When the color option is selected the user will be able to change the color of the form
			ColorDialog cdUserColor = new ColorDialog();

			if (cdUserColor.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
			{
				this.BackColor = cdUserColor.Color;

			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			frmMain firstScreen = new frmMain();
			this.Hide();
			firstScreen.Show();
		}
	}
}
