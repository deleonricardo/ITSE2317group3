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
    public partial class managerLogin : Form
    {
        string sMLName;
        string sMLID;
        string sMLPass;

        public managerLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sMLName = txtMName.Text;
            sMLID = txtMID.Text;
            sMLPass = txtPassword.Text;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                //need database to pull instance of Manager info?? RDL
                //check password

                //Code to connect to the managerTable in the group3 database for testing

                //Manager Name(s)       ID#             Password

                // Andres Cortez       65432            111222 
                // Don Jones           99123            123456 

                //TESTING RESULTS:
                //Both Managers can succsessfully sign in using their appropriate ID and Password
                //ERROR: The PopUp dialog box still occurs even if the manager successfully logs in with the right credentials

                //Employees who attempt to sign in with their own credentials cannot access the next screen
                //If employees sign in using their own name, but a manager's ID and Password, they will still be denied access
                //(error message should pop up there, need to check IF statement) - Andres Cortez

                //UPDATE [11/24/2020] 
                //Popup Messagebox Error resolved by Andres Cortez
                //Tab order on the Manager Login

                string manTest = "server=cstnt.tstc.edu;user=group3;database=group3;port=3306;password=password3";
                MySqlConnection Conn = new MySqlConnection(manTest);

                string selectStatement = "SELECT * FROM group3.managertable WHERE ManagerID = '" + txtMID.Text.Trim() + "'and  ManagerName = '" + txtMName.Text.Trim() + "'and Password = '" + txtPassword.Text.Trim() + "'";
                MySqlCommand selectComm = new MySqlCommand(selectStatement, Conn);
                MySqlDataAdapter manDA = new MySqlDataAdapter(selectStatement, Conn);
                DataTable manTable = new DataTable();

                manDA.Fill(manTable);

                //If the manager successfully logs in, they will be greeted by name
                //before being taken to the manager Interface Screen
                if (manTable.Rows.Count == 1)
                {
                    MessageBox.Show("Login Successful! \n Welcome " + txtMName.Text);
                    ManagerInterface InterfaceScreen = new ManagerInterface();
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
                    txtMID.Text = "";
                    txtMName.Text = "";
                    txtPassword.Text = "";

                }

            }


            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMID.Text = "";
            txtMName.Text = "";
            txtPassword.Text = "";
            //Added the code to take the user back frmMain - AC
            frmMain mainScreen = new frmMain();
            mainScreen.Show();
            this.Hide();
            
        }
    }
}
