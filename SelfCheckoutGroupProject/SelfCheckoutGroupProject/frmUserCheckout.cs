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
    public partial class frmUserCheckout : Form
    {
        string chkTotal = UserInterface.pubTotal;
        string chkSub = UserInterface.pubSubTotal;
        string chkTax = UserInterface.pubTax;
        public frmUserCheckout()
        {
            InitializeComponent();
        }

        private void btnCreditCard_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnCash_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
        }

        private void btnCheck_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
        }

        private void btnConfirmPurchase_Click(object sender, EventArgs e)
        {
            string confirmPurchase = "Your purchase has been confirmed!";

            MessageBox.Show(confirmPurchase);

           

            UserInterface UI = new UserInterface();

            UI.Show();
            lblBalance.Text = string.Empty;
            lblSubtotal.Text = string.Empty;
            lblTax.Text = string.Empty;

            txtCardNum.Text = string.Empty;
            txtCVRNum.Text = string.Empty;
            txtExpMonth.Text = string.Empty;
            txtExpYear.Text = string.Empty;
            txtNameOnCard.Text = string.Empty;
            this.Hide();
        }

		private void frmUserCheckout_Load(object sender, EventArgs e)
		{
           
            lblSubtotal.Text = chkSub;

           
            lblTax.Text = chkTax;

            
            lblBalance.Text = chkTotal;
		}

		private void btnCancelPurchase_Click(object sender, EventArgs e)
		{
            UserInterface UIScreen = new UserInterface();
            UIScreen.Show();
            lblBalance.Text = string.Empty;
            lblSubtotal.Text = string.Empty;
            lblTax.Text = string.Empty;

            txtCardNum.Text = string.Empty;
            txtCVRNum.Text = string.Empty;
            txtExpMonth.Text = string.Empty;
           txtExpYear.Text = string.Empty;
            txtNameOnCard.Text = string.Empty;
            this.Hide();
            
		}
	}
}
