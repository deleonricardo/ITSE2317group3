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
    public partial class ManagerInterface : Form
    {

        MySqlConnection empConn;
        MySqlDataAdapter empDataAdapt;
        MySqlCommand sqlComm;
        DataSet empDataSet;
        MySqlCommandBuilder empCommBuild;
        public ManagerInterface()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (rdoButtonInventory.Checked == true)
            {
                //open user inventory screen - RDL
                frmInventory InventoryScreen = new frmInventory();
                InventoryScreen.Show();
                this.Hide();
            }
            if (rdoBtnEmployeeList.Checked == true)
            {
                //display employee list in listbox - rdl
                //This has been changed to a DataGridView Control which will display the list of employees currently in the group3.employee table - AC
                string connection = "server=cstnt.tstc.edu;user=group3;database=group3;port=3306;password=password3";
                empConn = new MySqlConnection(connection);
                empDataAdapt = new MySqlDataAdapter();
                empDataSet = new DataSet();


                string sqlStatement = "SELECT * FROM group3.employees; UPDATE group3.employees SET Total_Hours = Daily_Hours * 5; UPDATE group3.employees SET Total_Pay = Total_Hours * Pay;";
                sqlComm = new MySqlCommand(sqlStatement, empConn);
                sqlComm.Connection = empConn;

                empDataAdapt.SelectCommand = sqlComm;

                empDataAdapt.Fill(empDataSet, "employees");
                EmployeesDataGrid.DataSource = empDataSet ;
                EmployeesDataGrid.DataMember = "employees";

              

                btnAddEmployee.Show();
                btnRemoveEmployee.Show();

            }
            if (rdoBtnSales.Checked == true)
            {
                //display total sales amount for day
                //Take the user to Report Form (Testing Only) - AC
                Report reportForm = new Report();
                reportForm.Show();
                this.Hide();
            }
            if (rdoBtnPass.Checked == true)
            {
                //need a manager security login form -rdl
                //update password for specific employee in same form -rdl

                //Open the UpdatePassword Interface - AC
                UpdatePassword resetPWInterface = new UpdatePassword();
                resetPWInterface.Show();
                this.Hide();


            }


        }

		private void ManagerInterface_Load(object sender, EventArgs e)
		{
            //When the form loads, Hide the Add and Delete Employee Buttons. They will be visible once the Employees option is selected - AC
            btnAddEmployee.Hide();
            btnRemoveEmployee.Hide();
		}

		private void btnAddEmployee_Click(object sender, EventArgs e)
		{
            //This will add an Employee to the employee table in the MySql Database based on user input. Similar to the Inventory - AC
            //Test is succsessful. New employees are added, and the columns that are not selected are defaulted to a value of 0 - AC
            empCommBuild = new MySqlCommandBuilder(empDataAdapt);
            empDataAdapt.Update(empDataSet, "employees");
            MessageBox.Show("A new employee has been added! \n Employees table has been updated!");
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
            rdoBtnEmployeeList.Checked = false;
            rdoBtnPass.Checked = false;
            rdoBtnSales.Checked = false;
            rdoButtonInventory.Checked = false;
            ////Take the user back to the main menu
            //frmMain mainScreen = new frmMain();
            //mainScreen.Show(); - creates multiple main screens -error on close RDL
            this.Hide();
		}

		private void btnRemoveEmployee_Click(object sender, EventArgs e)
		{
            // Delete a selected row and the database will update - AC
            empCommBuild = new MySqlCommandBuilder(empDataAdapt);
            empDataAdapt.Update(empDataSet, "employees");
            MessageBox.Show("The selected record has been deleted from the database!\nThe Employee table has been updated!");
		}

		
	}
}
