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
    public partial class DanhSachSV : Form
    {
        public DanhSachSV()
        {
            InitializeComponent();
        }

        private void DanhSachSV_Load(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("pr_DSSV", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter ad = new SqlDataAdapter())
                    {
                        ad.SelectCommand = cmd;
                        DataTable data = new DataTable();
                        ad.Fill(data);
                        diemKhoang rpt = new diemKhoang();
                        rpt.SetDataSource(data);
                        cryDSSV.ReportSource = rpt;
                        cryDSSV.Refresh();
                    }
                }
            }
        }

        private void cryDSSV_Load(object sender, EventArgs e)
        {
            ReportDocument cry = new ReportDocument();
            cry.Load(@"C:\Users\ADMIN\Desktop\c#\BTL_2023_c\BTL_2023_c\DSSV.rpt");
            cryDSSV.ReportSource = cry;
            cryDSSV.Refresh();
        }
    }
}
