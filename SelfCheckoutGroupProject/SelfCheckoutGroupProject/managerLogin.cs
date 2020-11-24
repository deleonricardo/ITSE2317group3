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
                if (txtMID.Text != frmMain.nManager.sMIDNum && txtPassword.Text != frmMain.nManager.sMPass && txtMName.Text != frmMain.nManager.sMName)                 {
                    //error message and clear text boxes to try again
                    MessageBox.Show("Error, Incorrect Entry");
                    txtMID.Text = "";
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
            this.Hide();
            
        }
    }
}
