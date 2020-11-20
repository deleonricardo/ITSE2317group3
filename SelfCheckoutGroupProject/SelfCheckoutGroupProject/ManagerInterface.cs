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
    public partial class ManagerInterface : Form
    {
        public ManagerInterface()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (rdoButtonInventory.Checked == true)
            {
                //open user inventory screen - RDL
                frmInventory InventoryScreen = new frmInventory();
                InventoryScreen.Show();
                this.Hide();
            }
            if (rdoBtnEmployeeList.Checked == true)
            {
                //display employee list in listbox - rdl

            }
            if (rdoBtnSales.Checked == true)
            {
                //display total sales amount for day
            }
            if (rdoBtnPass.Checked == true)
            {
                //need a manager security login form -rdl
                //update password for specific employee in same form -rdl
            }


        }
    }
}
