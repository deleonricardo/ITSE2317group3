﻿using System;
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
	public partial class frmMain : Form
	{
        public static Manager nManager = new Manager();
        public static Employee nEmployee = new Employee();
        public static Product pProduct = new Product();
        public static List<Product> cart = new List<Product>(); //create product cart list

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
			//Take the user to the user interface form - Andres
            //Should be logged in to user by employee or manager for use by "customer"? -RDL
			UserLogin userScreen = new UserLogin();
			userScreen.Show();
		}

		private void btnEmployee_Click(object sender, EventArgs e)
		{
            //open employee login screen - RDL
			EmployeeLogin empLoginScreen = new EmployeeLogin();
			empLoginScreen.Show();
		}

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            //open manager login screen - RDL
            managerLogin mngmtLoginScreen = new managerLogin();
            mngmtLoginScreen.Show();
        }

		private void frmMain_Load(object sender, EventArgs e)
		{
			//When the form loads, connect to the MySQL Database called group3. 
			//The console.writeline() commands are only there for testing purposes. 
			//I assume we will be referencing the database when coding the login and reset password functions - Andres
			string connectionString = "server=cstnt.tstc.edu;user=group3;database=group3;port=3306;password=password3";
			SqlConnection dbConnection = new SqlConnection(connectionString);

			try
			{
				Console.WriteLine("Connecting to MySQL database");
				dbConnection.Open();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			
			}
			dbConnection.Close();
			Console.WriteLine("Done");
			
		}



		//How are passwords safe if stored (security issues) -RDL



	}
          

}

public class Employee
{
    //customer class with variables get-set
    public string sEName { get; set; }
   public string sEIDNum { get; set; }
    //should passwords be here - rdl
    public string sEPass { get; set; }
  }
public class Manager
{
    //customer class with variables get-set
    public string sMName { get; set; }
    public string sMIDNum { get; set; }
    //should passwords be here - rdl
    public string sMPass { get; set; }
       }

public class Product
{
public string sName { get; set; }
    public double dPrice { get; set; }
    public string sSKUNum { get; set; }
    public int iCount { get; set; }
}
