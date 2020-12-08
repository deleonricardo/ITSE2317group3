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

                lblResetCode.Show();
                //lblVerifyCode.Show();
                txtResetCode.Show();
                //txtVerifyCode.Show();
                btnVerifyCode.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            
            }
            
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
            
            }
		}
	}
}
