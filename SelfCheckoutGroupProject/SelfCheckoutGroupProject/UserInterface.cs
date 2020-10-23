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
        public UserInterface()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //need to create an array for storing items to send to CalculateCost - RDL
            //should it be a running tally -RDL

            string sItemCost;



            //conversions to Int
            


                //call calculate cost
            CalculateCost();


        }


        public double CalculateCost()
        {
            double dTotal = 0;



            return dTotal;
        }

    }

}
