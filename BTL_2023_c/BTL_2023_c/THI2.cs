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
    public partial class THI2 : Form
    {
        public THI2()
        {
            InitializeComponent();
        }

        private void THI2_Load(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("pr_DSSVV", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter ad = new SqlDataAdapter())
                    {
                        ad.SelectCommand = cmd;
                        DataTable data = new DataTable();
                        ad.Fill(data);
                        THI22 rpt = new THI22();
                        rpt.SetDataSource(data);
                        cryThi2.ReportSource = rpt;
                        cryThi2.Refresh();
                    }
                }
            }
        }

        private void cryThi2_Load(object sender, EventArgs e)
        {
            ReportDocument cry = new ReportDocument();
            cry.Load(@"C:\Users\ADMIN\Desktop\c#\BTL_2023_c\BTL_2023_c\thi22.rpt");
            cryThi2.ReportSource = cry;
            cryThi2.Refresh();
        }
    }
}
