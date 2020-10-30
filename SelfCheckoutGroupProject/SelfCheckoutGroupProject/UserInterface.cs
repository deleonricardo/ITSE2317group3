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
    public partial class UserInterface : Form
    {
        double cost; 

        public UserInterface()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //need to create an array for storing items to send to CalculateCost - RDL
            //should it be a running tally -RDL
            try
            {
                cost = Convert.ToDouble(lblPrice.Text);
              //call calculate cost-RDL
                 CalculateCost(cost);

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
            try
            {
                if (txtSKU.Text == frmMain.pProduct.sSKUNum)
                {
                    lblName.Text = frmMain.pProduct.sName;
                    lblPrice.Text = frmMain.pProduct.dPrice.ToString();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
    }

}
