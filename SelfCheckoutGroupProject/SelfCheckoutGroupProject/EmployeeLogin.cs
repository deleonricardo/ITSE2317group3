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

                string userTest = "server=cstnt.tstc.edu;user=group3;database=group3;port=3306;password=password3";
                MySqlConnection Conn = new MySqlConnection(userTest);

                string selectStatement = "SELECT * FROM group3.employees WHERE EmployeeID= '" + txtEName.Text.Trim() + "'and EmployeeName= '" + txtEName.Text.Trim() + "'and Password= '"+txtPass.Text.Trim()+"'";
                MySqlCommand selectComm = new MySqlCommand(selectStatement, Conn);
                MySqlDataAdapter userDA = new MySqlDataAdapter(selectStatement, Conn);
                DataTable userTable = new DataTable();

                userDA.Fill(userTable);

                //check password RDL
                //if ((txtEName.Text == frmMain.nEmployee.sEName) && ( txtEID.Text== frmMain.nEmployee.sEIDNum) && (txtPass.Text == frmMain.nEmployee.sEPass))
                if(userTable.Rows.Count == 1)
                    {
                    //open user input screen - RDL
                    frmInventory InterfaceScreen = new frmInventory();
                    InterfaceScreen.Show();
                    this.Hide();
                    }
                    else
                    {

                    //error message and clear text boxes to try again
                    MessageBox.Show("Error, Incorrect Entry");
                    txtEName.Text = "";
                    txtPass.Text = "";
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
            //frmMain mainScreen = new frmMain();
            //mainScreen.Show(); - opens multiple Main forms - error at close
            this.Close();
		}
	}
}
