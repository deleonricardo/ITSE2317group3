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

                string sqlStatement = "SELECT EmployeeID, EmployeeName, Email, Password FROM group3.employees";
                sqlComm = new MySqlCommand(sqlStatement, empConn);
                sqlComm.Connection = empConn;

                empDataAdapt.SelectCommand = sqlComm;

                empDataAdapt.Fill(empDataSet, "employees");
                EmployeesDataGrid.DataSource = empDataSet ;
                EmployeesDataGrid.DataMember = "employees";

            }
            if (rdoBtnSales.Checked == true)
            {
                //display total sales amount for day
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
    }
}
