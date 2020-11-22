using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

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
			//This will load what is currently in the group3.inventory table in the group3 database
			//I will be changing the values to what is in the text file sent by Ricardo
			//Currently, datagridView1 has my test values in it. - Andres

			//This code is successful
			//Question: How is the data in the produce text file supposed to be formatted? Is it:

			//Product Name:		Price:		Location:	Notes
			//Aloe Organic		$2.80		California	Organic

			//Please let me know so I can start entering in the new product data into the inventory table 
			//- Andres
			string connection = "server=cstnt.tstc.edu;user=group3;database=group3;port=3306;password=password3";
			MySqlConnection sqlConn = new MySqlConnection(connection);
			MySqlDataAdapter dataApdapter = new MySqlDataAdapter();
			MySqlCommand sqlCommand;
			DataSet sqlDataSet = new DataSet();

			string sqlStatement = "SELECT * FROM group3.inventory";
			sqlCommand = new MySqlCommand(sqlStatement, sqlConn);
			sqlCommand.Connection = sqlConn;

			dataApdapter.SelectCommand = sqlCommand;
			
			dataApdapter.Fill(sqlDataSet, "inventory");
			dataGridView1.DataSource = sqlDataSet;
			dataGridView1.DataMember = "inventory";



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
	
}
