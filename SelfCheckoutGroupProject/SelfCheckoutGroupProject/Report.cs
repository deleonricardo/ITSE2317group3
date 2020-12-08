using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace SelfCheckoutGroupProject
{
    public partial class Report : Form
    {
       
        public Report()
        {
            InitializeComponent();
        }

		private void btnReports_Click(object sender, EventArgs e)
		{
            
            string crConnect = "server=cstnt.tstc.edu;user=group3;database=group3;port=3306;password=password3";
            MySqlConnection reportConn = new MySqlConnection(crConnect);
            CrystalReport2 cr = new CrystalReport2();
            string sqlStatement = "SELECT * FROM group3.inventory";
            DataSet rds = new DataSet();
            MySqlDataAdapter reportAdaptor = new MySqlDataAdapter(sqlStatement, reportConn);

            reportAdaptor.Fill(rds, "inventory");
            cr.SetDataSource(rds);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
            
            
            
            


        }

		private void btnEmpReport_Click(object sender, EventArgs e)
		{
            string empConnect = "server=cstnt.tstc.edu;user=group3;database=group3;port=3306;password=password3";
            MySqlConnection reportConn = new MySqlConnection(empConnect);
            EmployeeReport empReport = new EmployeeReport();

            string select = "SELECT * FROM group3.employees";
            DataSet empDS = new DataSet();
            MySqlDataAdapter empReportAdapt = new MySqlDataAdapter(select, reportConn);

            empReportAdapt.Fill(empDS, "employees");
            empReport.SetDataSource(empDS);
            crystalReportViewer1.ReportSource = empReport;
            crystalReportViewer1.Refresh();


        }

		private void btnManager_Click(object sender, EventArgs e)
		{
            //Take the user back to the manager interface - AC
            ManagerInterface managerScreen = new ManagerInterface();
            managerScreen.Show();
            this.Hide();
		}
	}
    
}
