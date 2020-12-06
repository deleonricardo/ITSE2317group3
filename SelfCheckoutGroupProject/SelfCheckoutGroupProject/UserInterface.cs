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
        int userQTYTest;
        MySqlDataReader testReader;
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
                //This is a test to see if a product image will be displayed based on if the user enters the correct SKU
                //Currently, only the first item is displayed (Aloe Organic). An error message is displayed if the user's input is invalid
                //Maybe use a FOR LOOP to test against user input and what is actually in the group3.inventory table?
                //Also, which form will we be uploading the images to the database in? - AC


                string productTest = "server=cstnt.tstc.edu;user=group3;database=group3;port=3306;password=password3";
                MySqlConnection Conn = new MySqlConnection(productTest);
                Conn.Open();

                string selectInventoryStatement = "SELECT * FROM group3.inventory WHERE ItemIDNumber = '" + txtSKU.Text.Trim() + "'";
                MySqlCommand selectComm = new MySqlCommand(selectInventoryStatement, Conn);
               
                MySqlDataAdapter productDA = new MySqlDataAdapter(selectInventoryStatement, Conn);
                //Cannot delete - will currently cause error - AC
                DataTable productTable = new DataTable();

                productDA.Fill(productTable);
                testReader = selectComm.ExecuteReader();

              



                if (productTable.Rows.Count == 1)
                {
                    //This will fill in the name price and QTY labels depending on the SKU entered.
                    //Test is successful. Image needs to change to reflect the correct Item
                    //Everything else updates to reflect the correct item
                    MessageBox.Show("Success!");
                    Image test = Image.FromFile("aloe organic.jpeg");
                    pbProduct.Image = test;
                    
                    //Update the QTY field in the database to subtract whatever quanity is entered by the user
                   // string qtyUpdate = "UPDATE group3.inventory SET QTY = "+int.Parse(testReader["QTY"].ToString())+" - " + int.Parse(txtOrderNum.Text) + "WHERE ItemIDNumber = '" + txtSKU.Text.Trim() + "'";
                    testReader.Read();
                    lblName.Text = testReader["ItemName"].ToString();
                    lblPrice.Text = testReader["Price"].ToString();
                    lblCount.Text = testReader["QTY"].ToString();
                   

                }

                else
                    MessageBox.Show("Item not found. \n Invalid SKU Entered");



                //if (txtSKU.Text == frmMain.pProduct.sSKUNum)
                //{
                //    lblName.Text = frmMain.pProduct.sName;
                //    lblPrice.Text = frmMain.pProduct.dPrice.ToString();
                //    lblCount.Text = frmMain.pProduct.iCount.ToString();
                //}
                testReader.Close();
                Conn.Close();

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                
            }
        }
    }

}
