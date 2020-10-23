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
    }
}
