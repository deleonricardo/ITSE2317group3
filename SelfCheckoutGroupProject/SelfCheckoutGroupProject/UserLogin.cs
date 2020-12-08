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
                //no need for user info - log in by employee or manager to user area -RDL

                //ERRORS: Can still access the User Interface Form by putting in random / Incorrect login info
                //Maybe move the IF Statement made by RDL to help test for valid information? - Andres.

                string userTest = "server=cstnt.tstc.edu;user=group3;database=group3;port=3306;password=password3";
                MySqlConnection Conn  = new MySqlConnection(userTest);

                string selectStatement = "SELECT * FROM group3.employees WHERE EmployeeID = '" + txtID.Text.Trim() + "'or Password = '" + txtPassword.Text.Trim()+"'";
                MySqlCommand selectComm = new MySqlCommand(selectStatement, Conn);
                MySqlDataAdapter userDA = new MySqlDataAdapter(selectStatement, Conn);
                DataTable userTable = new DataTable();
                
               userDA.Fill(userTable);


                string manTest = "server=cstnt.tstc.edu;user=group3;database=group3;port=3306;password=password3";
                MySqlConnection manConn = new MySqlConnection(manTest);

                string manSelect = "SELECT * FROM group3.managertable WHERE ManagerID = '" + txtID.Text.Trim() + "'or Password = '" + txtPassword.Text.Trim() + "'";
                MySqlCommand manComm = new MySqlCommand(manSelect, Conn);
                MySqlDataAdapter manDA = new MySqlDataAdapter(manSelect, Conn);
                DataTable managerTable = new DataTable();

                manDA.Fill(managerTable);


                //THIS CODE HERE IS POPULATING THE TABLE AND OPENING UP THE INTERFACE IT DOES NOT ALLOW FOR THE PASSWORD ID CHECK
                if (userTable.Rows.Count != 1 || managerTable.Rows.Count!=1)
                {
                    MessageBox.Show("Login Successful!");
                    UserInterface InterfaceScreen = new UserInterface();
                    InterfaceScreen.Show();
                    this.Hide();

                }


                //THIS CODE HERE IS POPULATING THE TABLE AND OPENING UP THE INTERFACE IT DOES NOT ALLOW FOR THE PASSWORD ID CHECK
                //if (userTable.Rows.Count != 1)
                //{
                //    MessageBox.Show("Login Successful!");
                //UserInterface InterfaceScreen = new UserInterface();
                //InterfaceScreen.Show();
                //this.Hide();
                
                //}




                










                //if ((txtID.Text != frmMain.nManager.sMIDNum && txtPassword.Text != frmMain.nManager.sMPass) || (txtID.Text != frmMain.nEmployee.sEIDNum && txtPassword.Text != frmMain.nEmployee.sEPass))
                //{
                //error message and clear text boxes to try again
                //MessageBox.Show("Error, Incorrect Entry");
                //txtID.Text = "";
                //txtPassword.Text = "";
                //}
                else
                {

                    //error message and clear text boxes to try again
                    MessageBox.Show("Error, Incorrect Entry");
                    txtID.Text = "";
                    txtPassword.Text = "";

                    ////open user input screen - RDL
                    //UserInterface InterfaceScreen = new UserInterface();
                    //InterfaceScreen.Show();
                    //this.Hide();
                }

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
            //frmMain MainScreen = new frmMain();
            //MainScreen.Show(); - opens multiple main form - error on close RDL
            this.Hide();
        }
    }
}
