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
    public partial class hienDSDiem : Form
    {
        public hienDSDiem()
        {
            InitializeComponent();
        }

        private void hienDSDiem_Load(object sender, EventArgs e)
        {

        }

        private void btnHien_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("pr_timdiemTheoKhoang", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@diema", tb_diemA.Text);
                    cmd.Parameters.AddWithValue("@diemb", tb_DiemB.Text);
                    using (SqlDataAdapter ad = new SqlDataAdapter())
                    {
                        ad.SelectCommand = cmd;
                        DataTable data = new DataTable();
                        ad.Fill(data);
                        diemKhoang rpt = new diemKhoang();
                        rpt.SetDataSource(data);
                        hienbangDiemCrys.ReportSource = rpt;
                        hienbangDiemCrys.Refresh();
                    }
                }
            }
        }

        private void hienbangDiemCrys_Load(object sender, EventArgs e)
        {
            ReportDocument cry = new ReportDocument();
            cry.Load(@"C:\Users\ADMIN\Desktop\c#\BTL_2023_c\BTL_2023_c\diemKhoang.rpt");
            hienbangDiemCrys.ReportSource = cry;
            hienbangDiemCrys.Refresh();
        }
    }

    }















/*
 void hienTenMonHoc()
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("select *from tblMonHoc", cnn))
                {
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            cbxMonHoc.Items.Add(rd["sTenMH"].ToString());
                        }
                    }
                }
                cnn.Close();
            }

 
 */