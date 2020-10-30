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
                if ((txtID.Text != frmMain.nManager.sMIDNum && txtPassword.Text != frmMain.nManager.sMPass) || (txtID.Text != frmMain.nEmployee.sEIDNum && txtPassword.Text != frmMain.nEmployee.sEPass))
                {
                    //error message and clear text boxes to try again
                    MessageBox.Show("Error, Incorrect Entry");
                    txtID.Text = "";
                    txtPassword.Text = "";
                }
                else
                {

                //open user input screen - RDL
                UserInterface InterfaceScreen = new UserInterface();
                InterfaceScreen.Show();
                this.Hide();
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
            this.Hide();
        }
    }
}
