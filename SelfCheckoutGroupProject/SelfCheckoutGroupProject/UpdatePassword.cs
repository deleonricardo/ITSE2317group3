﻿using System;
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
            


		}

		private void btnUpdatePass_Click(object sender, EventArgs e)
		{
            string from, pass, msgBody;
            Random rand = new Random();
            randCode = (rand.Next(999999)).ToString();

            MailMessage resetEmail = new MailMessage();
            to = txtEmail.Text;
		}
	}
}
