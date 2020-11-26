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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                //need database to pull instance of Manager info?? RDL
                //check password

                //Connection has been made to the users table. Only has 2 columns: userId and userPassword for testing
                //Test is partially successful. Can get to the  user Interface form by entering the correct login information

                //ERRORS: Can still access the User Interface Form by putting in random / Incorrect login info
                //Maybe move the IF Statement made by RDL to help test for valid information? - Andres.

                //UPDATE [11/24/2020] - Error has been resolved. Only valid data is allowed. 
                //Will add the other columns. users table only had ID and Password for testing purposes - AC


                //UPDATE [11/26/2020] - Conditions are currently changing for the User Login Form. 
                                        //The users table has been dropped from the group3 MySql database
                                        //The Condition now tests to see if Manager and/or employee credentials are entered, 
                                        //if so, the user is denied access to the userInterface, otherwise casual users continue on

                                        //Currently testing employee logins only. Test is a success, works as intended. 
                                        //A second SELECT statement may have to be used to test for manager logins 
                                        //as a JOIN between employees and managers seems ineffective for testing the user login - AC 

                //UPDATE TEST RESULTS - Condition has been changed to resolve a previous login issue, 
                //condition now uses an AND statement to test for both Employee and Manager login 
                string userTest = "server=cstnt.tstc.edu;user=group3;database=group3;port=3306;password=password3";
                MySqlConnection Conn  = new MySqlConnection(userTest);

                string selectStatement = "SELECT * FROM group3.employees WHERE EmployeeID = '" + txtID.Text.Trim() + "'and Password = '" + txtPassword.Text.Trim()+"'";
                MySqlCommand selectComm = new MySqlCommand(selectStatement, Conn);
                MySqlDataAdapter userDA = new MySqlDataAdapter(selectStatement, Conn);
                DataTable userTable = new DataTable();

                userDA.Fill(userTable);

                string managerSelect = "SELECT * FROM group3.managertable WHERE ManagerID = '" + txtID.Text.Trim() + "'and Password = '" + txtPassword.Text.Trim() + "'";
                MySqlCommand ManagerselectComm = new MySqlCommand(managerSelect, Conn);
                MySqlDataAdapter ManagerDA = new MySqlDataAdapter(managerSelect, Conn);
                DataTable manTable = new DataTable();

                ManagerDA.Fill(manTable);

                


                if (userTable.Rows.Count != 1 && manTable.Rows.Count !=1)
                {
                    MessageBox.Show("Login Successful!");
                    UserInterface InterfaceScreen = new UserInterface();
                    InterfaceScreen.Show();
                    this.Hide();

                }

                else
                //error message and clear text boxes to try again
                {
                    MessageBox.Show("Error! Incorrect Entry \n Detected as Employee Or Manager. \n Unauthorized Access to User Interface");
                    txtID.Text = "";
                    txtPassword.Text = "";
                }


               

                //if (manTable.Rows.Count != 1)
                //{
                //    MessageBox.Show("Login Successful!");
                //    UserInterface InterfaceScreen = new UserInterface();
                //    InterfaceScreen.Show();
                //    this.Hide();

                //}

                //else
                ////error message and clear text boxes to try again
                //{
                //    MessageBox.Show("Error! Incorrect Entry \n Detected as Manager. \n Unauthorized Access to User Interface");
                //    txtID.Text = "";
                //    txtPassword.Text = "";
                //}






                //            if ((txtID.Text != frmMain.nManager.sMIDNum && txtPassword.Text != frmMain.nManager.sMPass) || (txtID.Text != frmMain.nEmployee.sEIDNum && txtPassword.Text != frmMain.nEmployee.sEPass))
                //{
                //	//error message and clear text boxes to try again
                //	MessageBox.Show("Error, Incorrect Entry");
                //	txtID.Text = "";
                //	txtPassword.Text = "";
                //}
                //else
                //{

                //	//open user input screen - RDL
                //	UserInterface InterfaceScreen = new UserInterface();
                //	InterfaceScreen.Show();
                //	this.Hide();
                //}

            }
            catch(Exception c)
            {
                MessageBox.Show(c.Message);
            }


           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtPassword.Text = "";
            //Added the code to take the user back frmMain - AC
            frmMain mainScreen = new frmMain();
            mainScreen.Show();
            this.Hide();
        }
    }
}
