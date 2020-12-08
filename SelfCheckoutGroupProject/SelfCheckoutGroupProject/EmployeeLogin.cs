using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                
                //check password RDL
                if ((txtEName.Text != frmMain.nEmployee.sEName) && (frmMain.nEmployee.sEIDNum != txtEID.Text) && (txtEPass.Text != frmMain.nEmployee.sEPass))
                    {
                        //error message and clear text boxes to try again
                        MessageBox.Show("Error, Incorrect Entry");
                        txtEName.Text = "";
                        txtEPass.Text = "";
                    txtEID.Text = "";
                    }
                    else
                    {

                        //open user input screen - RDL
                        frmInventory InterfaceScreen = new frmInventory();
                        InterfaceScreen.Show();
                        this.Hide();
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
