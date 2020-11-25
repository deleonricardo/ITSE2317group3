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
    public partial class EmployeeLogin : Form
    {
        public EmployeeLogin()
        {
            InitializeComponent();
        }

		private void btnSignIn_Click(object sender, EventArgs e)
		{
            //When the Sign In button is clicked, the group3 database will be accessed to check
            //for matching credentials - AC

            //UPDATE: [11/24/2020]  - The login error has now been resolved. Managers can not log in as employees
            //Only valid entries are accepted - Andres Cortez

            //EMPLOYEES TEST
            //Ricardo De Leon       Aiden Candanoza
            //ID: 987654            ID: 012345
            //PW: 098765            PW: 112233

            //Ashley Green                Jack Brown
            //ID: 663219                   //ID: 884362
            //PW: 559095                   //PW: 774231

            // Above are the logins that will be used for testing - AC
            try
            {
                string empTest = "server=cstnt.tstc.edu;user=group3;database=group3;port=3306;password=password3";
                MySqlConnection Conn = new MySqlConnection(empTest);

                string selectStatement = "SELECT * FROM group3.employees WHERE EmployeeID = '" + txtID.Text.Trim() +"'and  EmployeeName = '"+txtName.Text.Trim()+"'and Password = '" + textBox1.Text.Trim() + "'";
                MySqlCommand selectComm = new MySqlCommand(selectStatement, Conn);
                MySqlDataAdapter empDA = new MySqlDataAdapter(selectStatement, Conn);
                DataTable empTable = new DataTable();

                empDA.Fill(empTable);

                if (empTable.Rows.Count == 1)
                {
                    MessageBox.Show("Login Successful!\n Welcome " + txtName.Text + "!");
                    UserInterface InterfaceScreen = new UserInterface();
                    InterfaceScreen.Show();
                    this.Hide();

                }

                else
                {
                    MessageBox.Show("ACCESS DENIED \n  Error: Incorrect Login");
                    txtName.Text = "";
                    txtID.Text = "";
                    textBox1.Text = "";

                }
            }

            catch (Exception empEX)
            {
                MessageBox.Show(empEX.Message);
            
            }
        }

		private void btnCancel_Click(object sender, EventArgs e)
		{
            //When the Cancel Button is clicked, the user will return to the main menu 
            //Cancel Button has been coded - Andres Cortez
            frmMain mainScreen = new frmMain();
            mainScreen.Show();
            this.Hide();
		}
	}
}
