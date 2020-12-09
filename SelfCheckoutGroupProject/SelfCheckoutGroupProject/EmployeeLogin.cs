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

namespace SelfCheckoutGroupProject
{
    public partial class EmployeeLogin : Form
    {
        public EmployeeLogin()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {


                string empTest = "server=cstnt.tstc.edu;user=group3;database=group3;port=3306;password=password3";
                MySqlConnection Conn = new MySqlConnection(empTest);

                string selectStatement = "SELECT EmployeeID,EmployeeName,Password  FROM group3.employees WHERE EmployeeID = '" + txtEID.Text.Trim() + "'and EmployeeName = '" + txtEName.Text.Trim() + "'and Password = '" + txtPass.Text.Trim() + "'";
                MySqlCommand selectComm = new MySqlCommand(selectStatement, Conn);
                MySqlDataAdapter empDA = new MySqlDataAdapter(selectStatement, Conn);
                DataTable empTable = new DataTable();

                empDA.Fill(empTable);

                //If the manager successfully logs in, they will be greeted by name
                //before being taken to the manager Interface Screen
                if (empTable.Rows.Count == 1)
                {
                    MessageBox.Show("Login Successful! \n Welcome " + txtEName.Text);
                    frmInventory InterfaceScreen = new frmInventory();
                    InterfaceScreen.Show();
                    this.Hide();

                    //if (txtMID.Text != frmMain.nManager.sMIDNum && txtPassword.Text != frmMain.nManager.sMPass && txtMName.Text != frmMain.nManager.sMName)
                    //{
                    //    //error message and clear text boxes to try again
                    //    MessageBox.Show("Error, Incorrect Entry");
                    //    txtMID.Text = "";
                    //    txtPassword.Text = "";
                    //}
                    //else
                    //{

                    //    //open user input screen - RDL
                    //    UserInterface UI = new UserInterface();
                    //    UI.Show();
                    //    this.Hide();
                    //}

                }

                else
                {
                    //error message and clear text boxes to try again
                    MessageBox.Show(" ACCESS DENIED. \n Error, Incorrect Entry");
                    txtEID.Text = "";
                    txtEName.Text = "";
                    txtPass.Text = "";

                }

            }


            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }




        }





		private void btnCancel_Click(object sender, EventArgs e)
		{
            //Takes the user back to the main screen - AC
            //frmMain mainScreen = new frmMain();
            //mainScreen.Show(); - opens multiple Main forms - error at close
            this.Close();
		}
	}
}
