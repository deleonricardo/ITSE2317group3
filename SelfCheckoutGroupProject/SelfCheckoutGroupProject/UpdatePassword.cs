using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

using MySql.Data;
using MySql.Data.MySqlClient;

//Designed Form Interface and Cancel Button Functionality - AC

//In this form, the manager will be able to update / reset an employee's password
//by sending a code to their appropriate email address. 
//Will everything be done on this one form? - AC



namespace SelfCheckoutGroupProject
{
    public partial class UpdatePassword : Form
    {
        string randCode;
       public static string to;
        SmtpClient smtp;
        public UpdatePassword()
        {
            InitializeComponent();
        }

		private void btnCancel_Click(object sender, EventArgs e)
		{
            //Take the user back to the ManagerInterface Form - AC
            ManagerInterface managerInterfaceScreen = new ManagerInterface();
            managerInterfaceScreen.Show();
            this.Hide();
		}

		private void UpdatePassword_Load(object sender, EventArgs e)
		{
            //When this form loads, Hide the Reset Code and Verify Reset Code labels and textboxes - AC
            lblResetCode.Hide();
            lblVerifyCode.Hide();
            txtResetCode.Hide();
            txtVerifyCode.Hide();
            btnVerifyCode.Hide();
        }

		private void btnUpdatePass_Click(object sender, EventArgs e)
		{
            try
            {


                //string empTest = "server=cstnt.tstc.edu;user=group3;database=group3;port=3306;password=password3";
                //MySqlConnection Conn = new MySqlConnection(empTest);

                //string selectStatement = "SELECT EmployeeName, EmployeeID,Email  FROM group3.employees WHERE EmployeeName = '" + txtName.Text.Trim() + "'and EmployeeID = '" + txtEmpID.Text.Trim() + "'and Email = '" + txtEmail.Text.Trim() + ";" +
                //    "SELECT Password FROM group3.managertable WHERE ManagerPass= '"+txtPassword.Text.Trim()+"'";
                //MySqlCommand selectComm = new MySqlCommand(selectStatement, Conn);
                //MySqlDataAdapter empDA = new MySqlDataAdapter(selectStatement, Conn);
                //DataTable empTable = new DataTable();

                //empDA.Fill(empTable);

                ////If the manager successfully logs in, they will be greeted by name
                ////before being taken to the manager Interface Screen
                //if (empTable.Rows.Count == 1)
                //{

                    string from, pass, msgBody;
                    Random rand = new Random();
                    randCode = (rand.Next(999999)).ToString();

                    MailMessage resetEmail = new MailMessage();
                    to = (txtEmail.Text).ToString();
                    from = "checkoutreset@gmail.com";
                    pass = "resettest123";
                    msgBody = "Your reset code is: " + randCode;

                    resetEmail.To.Add(to);
                    resetEmail.From = new MailAddress(from);
                    resetEmail.Body = msgBody;
                    resetEmail.Subject = "SelfCheckout password reset";


                    smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                    smtp.Credentials = new NetworkCredential(from, pass);

                    try
                    {
                        smtp.Send(resetEmail);
                        MessageBox.Show("Code Sent Successfully!");

                        //Hide the previous textBoxes
                        txtName.Hide();
                        txtEmpID.Hide();
                         txtEmail.Hide();
                        txtPassword.Hide();
                        lblEmail.Hide();
                    lblEmpID.Hide();
                    lblEmpName.Hide();
                    lblManPW.Hide();

                        lblResetCode.Show();
                        txtResetCode.Show();

                        btnVerifyCode.Show();
                        btnUpdatePass.Hide();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
               // }

                //else
                //{
                //    //error message and clear text boxes to try again
                //    MessageBox.Show("Error");

                //}

            }


            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }


            //If the records match, send the user the code and take them to the reset password form - AC

            //if (updateDT.Rows.Count == 1)
            //{

            //string from, pass, msgBody;
            //    Random rand = new Random();
            //    randCode = (rand.Next(999999)).ToString();

            //    MailMessage resetEmail = new MailMessage();
            //    to = (txtEmail.Text).ToString();
            //    from = "checkoutreset@gmail.com";
            //    pass = "resettest123";
            //    msgBody = "Your reset code is: " + randCode;

            //    resetEmail.To.Add(to);
            //    resetEmail.From = new MailAddress(from);
            //    resetEmail.Body = msgBody;
            //    resetEmail.Subject = "SelfCheckout password reset";


            //    smtp = new SmtpClient("smtp.gmail.com");
            //    smtp.EnableSsl = true;
            //    smtp.UseDefaultCredentials = false;
            //    smtp.Port = 587;
            //    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            //    smtp.Credentials = new NetworkCredential(from, pass);

            //    try
            //    {
            //        smtp.Send(resetEmail);
            //        MessageBox.Show("Code Sent Successfully!");

            //    //Hide the previous textBoxes
            //    txtName.Hide();
            //    txtEmpID.Hide();
            //    txtPassword.Hide();
                    
            //        lblResetCode.Show();
            //        //lblVerifyCode.Show();
            //        txtResetCode.Show();
            //        //txtVerifyCode.Show();
            //        btnVerifyCode.Show();
            //        btnUpdatePass.Hide();

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);

            //    }

            //}

            //else
            //{
                //Clear out the visible textboxes and display an error message - AC
                //string errorMsg = "1 or more fields does not match any record in the database.\nPlease enter valid information";
                //MessageBox.Show(errorMsg);
                //txtName.Text = string.Empty;
                //txtEmpID.Text = string.Empty;
                //txtEmail.Text = string.Empty;
                //txtPassword.Text = string.Empty;


            //}

               
            
		}

		private void btnVerifyCode_Click(object sender, EventArgs e)
		{
            if (randCode == (txtResetCode.Text).ToString())
            {

                to = txtEmail.Text;
                ResetPassword resetScreen = new ResetPassword();
                this.Hide();
                resetScreen.Show();

            }

            else
            {
                MessageBox.Show("Incorrect Code.\nPlease check your email address and try again");
                txtResetCode.Text = string.Empty;
            
            }
		}
	}
}
