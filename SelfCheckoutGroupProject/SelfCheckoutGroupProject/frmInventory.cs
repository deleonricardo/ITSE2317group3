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
	public partial class frmInventory : Form
	{
		public frmInventory()
		{
			InitializeComponent();
		}

		private void fontToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FontDialog fdInventoryFont = new FontDialog();
			fdInventoryFont.ShowColor = true;
			if (fdInventoryFont.ShowDialog() == DialogResult.OK & !String.IsNullOrEmpty(txtSearchBar.Text))
				txtSearchBar.Font = fdInventoryFont.Font;


				//Change the text color as well
				txtSearchBar.ForeColor = fdInventoryFont.Color;
			}

		private void colorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//When the color option is selected the user will be able to change the color of the form
			ColorDialog cdInventoryColor = new ColorDialog();

			if (cdInventoryColor.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
			{
				this.BackColor = cdInventoryColor.Color;

			}
		}

        private void frmInventory_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
	
}
