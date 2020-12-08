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

            this.Hide();

            UserLogin frmLogin = new UserLogin();
            frmLogin.Show();
        }
    }
}
