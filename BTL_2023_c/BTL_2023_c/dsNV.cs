using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_2023_c
{
    public partial class dsNV : Form
    {
        string masv;
        public dsNV( string masv )
        {
            InitializeComponent();
            this.masv = masv;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportDocument cry = new ReportDocument();
            cry.Load(@"C:\Users\ADMIN\Desktop\c#\BTL_2023_c\BTL_2023_c\dsDiem.rpt");
            dsNvCrys.ReportSource = cry;
            dsNvCrys.Refresh();
        }

        private void dsNV_Load(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("pr_diemTheoSVV", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@masv", masv);
                    using (SqlDataAdapter ad = new SqlDataAdapter())
                    {
                        ad.SelectCommand = cmd;
                        DataTable data = new DataTable();
                        ad.Fill(data);
                        dsDiem rpt = new dsDiem();
                        rpt.SetDataSource(data);
                        dsNvCrys.ReportSource = rpt;
                        dsNvCrys.Refresh();
                    }
                }
            }
        }
    }
}
