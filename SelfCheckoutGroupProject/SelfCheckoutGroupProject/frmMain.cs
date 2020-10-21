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
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void fontToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//When the font option is selected from the menu, allow the user to customize the text on the form
			FontDialog fdChangeFont = new FontDialog();
			fdChangeFont.ShowColor = true;
			if (fdChangeFont.ShowDialog() == DialogResult.OK & !String.IsNullOrEmpty(lblTitle.Text) && fdChangeFont.ShowDialog() == DialogResult.OK & !String.IsNullOrEmpty(label1.Text))
			{
				lblTitle.Font = fdChangeFont.Font;
				label1.Font = fdChangeFont.Font;

				//Change the text color as well
				lblTitle.ForeColor = fdChangeFont.Color;
				label1.ForeColor = fdChangeFont.Color;

			}
		}

		private void colorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//When the color option is selected the user will be able to change the color of the form
			ColorDialog cdformColorChange = new ColorDialog();
			
			if (cdformColorChange.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
			{
				this.BackColor = cdformColorChange.Color;
			
			}
		}

		private void btnUser_Click(object sender, EventArgs e)
		{
			//Take the user to the user interface form
			frmUserInterface userScreen = new frmUserInterface();
			this.Hide();
			userScreen.Show();
		}

		private void btnEmployee_Click(object sender, EventArgs e)
		{
			frmEmployeeLogin empLoginScreen = new frmEmployeeLogin();
			this.Hide();
			empLoginScreen.Show();
		}
	}
}
