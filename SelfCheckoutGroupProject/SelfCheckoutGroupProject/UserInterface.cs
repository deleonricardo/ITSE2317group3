﻿using System;
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

using System.IO;
namespace SelfCheckoutGroupProject
{
    public partial class UserInterface : Form
    {
        public static string pubSubTotal;
        public static string pubTax;
        public static string pubTotal;
        public static string qtyUpdate;
        


        double cost;
        double dConvert;
        double dSubTotal, dTotal;
        int userQTYTest;
        MySqlDataReader testReader;
        MySqlDataReader imageReader;
        MySqlConnection imgConn;
        public UserInterface()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product();

            int iOrderCount;
            double dItemTotal;

            //need to create an array for storing items to send to CalculateCost - RDL
            //should it be a running tally -RDL
            try
            {
                userQTYTest = Convert.ToInt32(lblCount.Text);
                iOrderCount = Convert.ToInt32(txtOrderNum.Text);
                dItemTotal = iOrderCount * Convert.ToDouble(lblPrice.Text);
                lblItemTotal.Text = dItemTotal.ToString("C2");

                //cost - cart needed to store items
              //call calculate cost-RDL
                 dSubTotal += CalculateCost(dItemTotal);

                //calculations for main total numbers RDL

                lblSubTotal.Text = dSubTotal.ToString("C2");
                lblTaxes.Text = (dSubTotal * .00825).ToString("C2");
                dConvert = dSubTotal + (dSubTotal * .00825);

                lblTotal.Text = dConvert.ToString("C2");

                pubSubTotal = dSubTotal.ToString("C2");
               pubTax = (dSubTotal * .00825).ToString("C2");
                pubTotal = dConvert.ToString("C2");
                int currentStock = userQTYTest - iOrderCount;
                lblCount.Text = currentStock.ToString();
                if (currentStock <= 0)
                {
                    currentStock = 0;
                    lblCount.Text = currentStock.ToString();
                    MessageBox.Show("Quantity entered exceeds current amount in stock...");
                    
                }
                qtyUpdate = lblCount.Text;
                
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }

            frmMain.cart.Add(newProduct);


          

        }

        //method to calculate cost and fill labels -RDL
        public double CalculateCost(double cost)
        {
            double dTotal = 0; 
            dTotal= dTotal + cost;



            return dTotal;
        }

		private void btnDelete_Click(object sender, EventArgs e)
		{
            Product newProduct = new Product();

            int iOrderCount;
            double dItemTotal;

            //need to create an array for storing items to send to CalculateCost - RDL
            //should it be a running tally -RDL
            try
            {
                iOrderCount = Convert.ToInt32(txtOrderNum.Text);
                dItemTotal = iOrderCount * Convert.ToDouble(lblPrice.Text);
                lblItemTotal.Text = dItemTotal.ToString("C2");

                //cost - cart needed to store items
                //call calculate cost-RDL
                dSubTotal -= CalculateCost(dItemTotal);

                //calculations for main total numbers RDL

                lblSubTotal.Text = dSubTotal.ToString("C2");
                lblTaxes.Text = (dSubTotal * .00825).ToString("C2");
                dConvert = dSubTotal + (dSubTotal * .00825);

                lblTotal.Text = dConvert.ToString("C2");

                pubSubTotal = dSubTotal.ToString("C2");
                pubTax = (dSubTotal * .00825).ToString("C2");
                pubTotal = dConvert.ToString("C2");
                lblCount.Text = (userQTYTest + iOrderCount).ToString();
                qtyUpdate = lblCount.Text;
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }

            frmMain.cart.Remove(newProduct);




        }

        private void btnCheckout_Click(object sender, EventArgs e)
		{
            frmUserCheckout chkOutScreen = new frmUserCheckout();
            chkOutScreen.Show();
            this.Hide();
		}

		private void UserInterface_Load(object sender, EventArgs e)
		{
            pubSubTotal = string.Empty;
            pubTax = string.Empty;
            pubTotal = string.Empty;
		}

		private void btnSearch_Click(object sender, EventArgs e)
        {


            try  //try catch and populate labels RDL
            {
                //This is a test to see if a product image will be displayed based on if the user enters the correct SKU
                //Currently, only the first item is displayed (Aloe Organic). An error message is displayed if the user's input is invalid
                //Maybe use a FOR LOOP to test against user input and what is actually in the group3.inventory table?
                //Also, which form will we be uploading the images to the database in? - AC

                txtOrderNum.Text = string.Empty;
                lblItemTotal.Text = string.Empty;

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
                    

                    //Change the image based on user input - AC
                    //Will also use this code on manager interface when they a select a row in the datagridview
                    string testConn = "server=cstnt.tstc.edu;user=group3;database=group3;port=3306;password=password3";
                    MySqlConnection imageConn = new MySqlConnection(testConn);
                    imageConn.Open();

                    //Used an INNER JOIN to show images that match from both group3.images and group3.inventory based on
                    //the SKU entered by the user - AC
                    string testCommand = "SELECT image FROM group3.images INNER JOIN group3.inventory ON group3.images.inventory_ItemIDNumber = group3.inventory.ItemIDNumber WHERE inventory_ItemIDNumber = '" + txtSKU.Text.Trim()+"'";
                    MySqlCommand cmd = new MySqlCommand(testCommand, imageConn);
                    MySqlDataAdapter testDA = new MySqlDataAdapter(cmd);
                    DataSet testDS = new DataSet();
                    testDA.Fill(testDS, "images");
                    int c = testDS.Tables["images"].Rows.Count;

                    if (c > 0)
                    {
                        Byte[] byteTest = new Byte[0];
                        byteTest = (Byte[])(testDS.Tables["images"].Rows[c - 1]["image"]);
                        MemoryStream stream = new MemoryStream(byteTest);
                        pbProduct.Image = Image.FromStream(stream);
             
                    }
                    imageConn.Close();
                    




                    //Update the QTY field in the database to subtract whatever quanity is entered by the user
                    // string qtyUpdate = "UPDATE group3.inventory SET QTY = "+int.Parse(testReader["QTY"].ToString())+" - " + int.Parse(txtOrderNum.Text) + "WHERE ItemIDNumber = '" + txtSKU.Text.Trim() + "'";
                    testReader.Read();
                    lblName.Text= testReader["ItemName"].ToString();
                    lblPrice.Text = testReader["Price"].ToString();
                    lblCount.Text = testReader["QTY"].ToString();


                }

                else
                {
                    MessageBox.Show("Item not found. \n Invalid SKU Entered");
                    txtSKU.Text = string.Empty;
                }



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
