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
        public const double tax = .08245;

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

        private void frmUserCheckout_Load(object sender, EventArgs e)
        {
            //Read only Text Box
            txtTax.Enabled = false;
            txtSubtotal.Enabled = false;
            txtBalance.Enabled = false;

            int numProduct = 0;
            foreach (Product product in frmMain.cart)
            {
                ++numProduct;
                lstOrderSummary.Items.Add((object)("Item #" + numProduct.ToString()));
                lstOrderSummary.Items.Add((object)("Product Name: " + product.sName.ToString()));
                lstOrderSummary.Items.Add((object)("Product Price: " + product.dPrice));
                lstOrderSummary.Items.Add((object)("Product Number: " + product.sSKUNum.ToString()));
                lstOrderSummary.Items.Add((object)" ");



                //Display total, fee, and taxs into list box
                //double dNum1 = 0.0, DNum2 = dNum1 * tax;

                //foreach (pizza pizza in frmMain.cart)
                //    dNum1 += pizza.Cost;

                //lblDeliveryCharge.Text = delivery.ToString("C2");
                //lblPizzaTotal.Text = dNum1.ToString("C2");
                //lblTax.Text = DNum2.ToString("C2");
                //lblOrderTotal.Text = (dNum1 + DNum2 + delivery).ToString("C2");
            }



        }
    }
}
