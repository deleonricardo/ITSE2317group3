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
    public partial class UserInterface : Form
    {
        double cost;
        double dSubTotal, dTotal;

        public UserInterface()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int iOrderCount;
            double dItemTotal;

            //need to create an array for storing items to send to CalculateCost - RDL
            //should it be a running tally -RDL
            try
            {
                iOrderCount = Convert.ToInt32(txtOrderNum.Text);
                dItemTotal = iOrderCount * (Convert.ToDouble(lblPrice.Text));
                lblItemTotal.Text = dItemTotal.ToString();

                //cost - cart needed to store items
              //call calculate cost-RDL
                 dSubTotal = CalculateCost(cost);

                //calculations for main total numbers RDL
                lblSubTotal.Text += dSubTotal.ToString();
                lblTaxes.Text = (dSubTotal * .00825).ToString();
                lblTotal.Text = ((Convert.ToDouble(lblSubTotal.Text)) + (Convert.ToDouble(lblTaxes.Text))).ToString();
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }




          

        }

        //method to calculate cost and fill labels -RDL
        public double CalculateCost(double cost)
        {
            double dTotal = 0;



            return dTotal;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try  //try catch and populate labels RDL
            {
                if (txtSKU.Text == frmMain.pProduct.sSKUNum)
                {
                    lblName.Text = frmMain.pProduct.sName;
                    lblPrice.Text = frmMain.pProduct.dPrice.ToString();
                    lblCount.Text = frmMain.pProduct.iCount.ToString();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
    }

}
