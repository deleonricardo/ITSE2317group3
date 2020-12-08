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

namespace SelfCheckoutGroupProject
{
	public partial class ResetPassword : Form
	{
		string userEmail = UpdatePassword.to;
		public ResetPassword()
		{
			InitializeComponent();
		}

		private void btnResetPass_Click(object sender, EventArgs e)
		{
			if (txtNewPass.Text == txtVerifyPass.Text)
			{
				//If the two passwords entered by the user match, update their password in the employee table - AC
				string Conn = "server=cstnt.tstc.edu;user=group3;database=group3;port=3306;password=password3";
				MySqlConnection passwordConn = new MySqlConnection(Conn);

				string updateCommand = "UPDATE group3.employees SET Password = '" + txtVerifyPass.Text + "'WHERE Email= '" + userEmail + "'";
				MySqlCommand update = new MySqlCommand(updateCommand, passwordConn);
				passwordConn.Open();
				update.ExecuteNonQuery();
				passwordConn.Close();
				MessageBox.Show("Password reset successfully!");

			}

			else
			{
				MessageBox.Show("The two passwords entered do not match!\nPlease check your email again and enter the correct code");
			}


		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			//Take the user back to the previous screen
			UpdatePassword updateForm = new UpdatePassword();
			updateForm.Show();
			this.Hide();
		}
	}
}
