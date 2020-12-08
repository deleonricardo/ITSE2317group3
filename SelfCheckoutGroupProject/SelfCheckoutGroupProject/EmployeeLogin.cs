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

                string selectStatement = "SELECT * FROM group3.employees WHERE EmployeeID = '" + txtEID.Text.Trim() + "' or EmployeeName = '" + txtEName.Text.Trim() + "'or Password= '"+txtEPass.Text.Trim()+"'";
                MySqlCommand selectComm = new MySqlCommand(selectStatement, Conn);
                MySqlDataAdapter empDA = new MySqlDataAdapter(selectStatement, Conn);
                DataTable empInfotable = new DataTable();

                empDA.Fill(empInfotable);


                //THIS CODE HERE IS POPULATING THE TABLE AND OPENING UP THE INTERFACE IT DOES NOT ALLOW FOR THE PASSWORD ID CHECK
                if (empInfotable.Rows.Count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    UserInterface InterfaceScreen = new UserInterface();
                    InterfaceScreen.Show();
                    this.Hide();

                }
                
                //check password RDL
                //if ((txtEName.Text != frmMain.nEmployee.sEName) && (frmMain.nEmployee.sEIDNum != txtEID.Text) && (txtEPass.Text != frmMain.nEmployee.sEPass))
                //    {
                //        
                //    }
                else
                    {

                    //error message and clear text boxes to try again
                           MessageBox.Show("Error, Incorrect Entry");
                            txtEName.Text = "";
                            txtEPass.Text = "";
                            txtEID.Text = "";
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
            frmMain mainScreen = new frmMain();
            mainScreen.Show();
            this.Hide();
		}
	}
}
