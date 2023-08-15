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
    public partial class QLMH : Form
    {
        string tk = "", mk = "", quyen = "";
        public QLMH(string tk, string mk, string quyen)
        {
            InitializeComponent();
            this.tk = tk;
            this.mk = mk;
            this.quyen = quyen;
        }

        private void QLMH_Load(object sender, EventArgs e)
        {
            laydataGridMH();
        }
        public void laydataGridMH()
        {
            string couter = ConfigurationManager.ConnectionStrings["btl_c#"].ConnectionString;

            using (SqlConnection cnn = new SqlConnection(couter))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT sMaMH AS 'Mã môn học' , sTenMH AS 'Tên môn học' , iSoTC AS 'Số tín chỉ' FROM vw_dtgridMonHoc", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("tb_MonHoc");
                        ad.Fill(tb);
                        dtgridMH.DataSource = tb;
                    }
                }
            }
        }

        public static bool themMH(string maMH, string tenMH, int soTC)
        {
            string counter = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(counter))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "pr_themMh";
                    cmd.Parameters.AddWithValue("@maMH", maMH);
                    cmd.Parameters.AddWithValue("@tenMH", tenMH);
                    cmd.Parameters.AddWithValue("@soTC", soTC);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;

                }
            }

        }


        public static bool suaMH(string maMH, string tenMH, int soTC)
        {
            string counter = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(counter))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "pr_suaMh";
                    cmd.Parameters.AddWithValue("@maMH", maMH);
                    cmd.Parameters.AddWithValue("@tenMH", tenMH);
                    cmd.Parameters.AddWithValue("@soTC", soTC);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;

                }
            }

        }

        public static bool xoaMH(string maMH)
        {
            string counter = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(counter))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "pr_xoaMh";
                    cmd.Parameters.AddWithValue("@maMH", maMH);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;

                }
            }

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (mask_maMH.Text == "" || mask_tenMH.Text == "" || mask_soTC.Text == "")
            {
                MessageBox.Show("Bạn phai nhap du cac truong", "Thông báo");
            }
            else if (int.Parse(mask_soTC.Text) < 0)
            {
                MessageBox.Show("du lieu so phai lon hon 0", "Thông báo");
            }
            else 
            {
                themMH(Convert.ToString(mask_maMH.Text), mask_tenMH.Text.ToString().Trim(), int.Parse(mask_soTC.Text));
                laydataGridMH();
            }

                
            
            

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            
            if (quyen == "Admin")
            {
                suaMH(Convert.ToString(mask_maMH.Text), mask_tenMH.Text.ToString().Trim(), int.Parse(mask_soTC.Text));
                laydataGridMH();
                mask_maMH.Enabled = true;
            }
            else
                MessageBox.Show("Bạn không có quyền sửa môn học", "Thông báo");
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (quyen == "Admin")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa môn học này ??", "Thông báo ", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    xoaMH(Convert.ToString(mask_maMH.Text));
                    laydataGridMH();
                }
                
            }
            else
                MessageBox.Show("Bạn không có quyền xóa môn học", "Thông báo");
            
        }

        private void dtgridMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mask_maMH.Text = dtgridMH.CurrentRow.Cells["Mã môn học"].Value.ToString();
            mask_tenMH.Text = dtgridMH.CurrentRow.Cells["Tên môn học"].Value.ToString();
            mask_soTC.Text = dtgridMH.CurrentRow.Cells["Số tín chỉ"].Value.ToString();
            mask_maMH.Enabled = false;
        }

        

        
    }
}





















/*
 private void tb_search_TextChanged(object sender, EventArgs e)
        {
            search_textbox(tb_search.Text);
        }
 private void search_textbox(string x)
        {
            string sql = "SELECT sMaMH AS 'Mã môn học' , sTenMH AS 'Tên môn học' , iSoTC AS 'Số tín chỉ' FROM tblMonHoc WHERE CONCAT(sMaMH , sTenMH) LIKE '%" + x + "%' OR iSoTC LIKE '%" + x + "%'";
            string couter = ConfigurationManager.ConnectionStrings["btl_c#"].ConnectionString;

            using (SqlConnection cnn = new SqlConnection(couter))
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("tb_MonHoc");
                        ad.Fill(tb);
                        dtgridMH.DataSource = tb;
                    }
                }
            }
        }
 */