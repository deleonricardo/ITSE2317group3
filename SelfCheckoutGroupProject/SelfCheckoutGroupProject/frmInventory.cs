using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace SelfCheckoutGroupProject
{
	
	public partial class frmInventory : Form
	{
		MySqlCommandBuilder cmdBuilder;
		MySqlConnection sqlConn;
		MySqlDataAdapter dataApdapter;
		MySqlCommand sqlCommand;
		DataSet sqlDataSet;

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
			 sqlConn = new MySqlConnection(connection);
			 dataApdapter = new MySqlDataAdapter();
			 sqlDataSet = new DataSet();

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

		private void btnAddItem_Click(object sender, EventArgs e)
		{
			//When the Add Item button is clicked, after a new prodruct has been typed into the datagridview, it will be inserted into
			//the inventory table and the table will update accordingly. - AC
			//Test is successful, Inventory table updates and adds in the data entered by the user as a new record - AC
			cmdBuilder = new MySqlCommandBuilder(dataApdapter);
			dataApdapter.Update(sqlDataSet, "inventory");
			MessageBox.Show("Data has been modified. \n Inventory has been updated");
		}

		

		private void pbNewItem_Click(object sender, EventArgs e)
		{
			//When this picture box control is clicked, the user will be able to select an image to upload to the database - AC
			OpenFileDialog userImage = new OpenFileDialog();
			if (userImage.ShowDialog() == DialogResult.OK)
			{
				pbNewItem.Image = Image.FromFile(userImage.FileName);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			//Takes the user back to the Manager Interface screen - AC
			ManagerInterface manager = new ManagerInterface();
			manager.Show(); 
			this.Hide();
		}

		private void btnUploadImage_Click(object sender, EventArgs e)
		{
			string connection = "server=cstnt.tstc.edu;user=group3;database=group3;port=3306;password=password3";
			MySqlConnection imgConn = new MySqlConnection(connection);
			dataApdapter = new MySqlDataAdapter();
			sqlDataSet = new DataSet();
			MySqlCommand imgCommand;
			//Clicking the Upload Image button will upload the image that it is in the picture box

			MemoryStream memStream = new MemoryStream();
			pbNewItem.Image.Save(memStream, pbNewItem.Image.RawFormat);
			byte[] newImage = memStream.ToArray();
			string sqlInsert = "INSERT INTO group3.images(imageID, imageName, image, inventory_ItemIDNumber) VALUES (imageID, @imageName, @image, @inventory_ItemIDNUmber)";
			imgConn.Open();
			imgCommand = new MySqlCommand(sqlInsert, imgConn);
			imgCommand.Parameters.Add("@imageName", MySqlDbType.VarChar, 50);
			imgCommand.Parameters.Add("@image", MySqlDbType.MediumBlob);
			imgCommand.Parameters.Add("@inventory_ItemIDNUmber", MySqlDbType.Int32);

			imgCommand.Parameters["@imageName"].Value = txtImageName.Text;
			imgCommand.Parameters["@image"].Value = newImage;
			imgCommand.Parameters["@inventory_ItemIDNUmber"].Value = txtProdNum.Text;

			if (imgCommand.ExecuteNonQuery() == 1)
			{
				MessageBox.Show("New Image Data Inserted!");
				
			}

			txtImageName.Text = string.Empty;
			txtProdNum.Text = string.Empty;
			pbNewItem.Image = null;
			imgConn.Close();



		}
	}
	
}
