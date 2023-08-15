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
    public partial class QLKhoa : Form
    {
        string tk = "", mk = "", quyen = "";
        public QLKhoa(string tk, string mk, string quyen)
        {
            InitializeComponent();
            this.tk = tk;
            this.mk = mk;
            this.quyen = quyen;
        }

        public void laydataGridKhoa()
        {
            string couter = ConfigurationManager.ConnectionStrings["btl_c#"].ConnectionString;

            using (SqlConnection cnn = new SqlConnection(couter))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT sMaKhoa AS 'Mã khoa' , sTenKhoa AS 'Tên khoa' , sSDT AS 'Số điện thoại' , sDiaChiKhoa AS 'Địa chỉ khoa' FROM vw_dtgridKhoa", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("tb_Khoa");
                        ad.Fill(tb);
                        dtGridKhoa.DataSource = tb;
                    }
                }
            }
        }

        public static void themKhoa(string makhoa, string tenkhoa, string sdt, string diaChi)
        {
            
            string sqlInsert = "INSERT INTO tblKhoa  " +
                "VALUES( '" + makhoa + "' , N'" + tenkhoa + "' , '" + sdt + "' , N'" + diaChi + "' )";
            ConnectSQL sQL = new ConnectSQL();
            sQL.ketnoi();
            sQL.QueryData(sqlInsert);
        }

        public static void xoaaKhoa(string maKhoa)
        {
            
            string sqlInsert = "DELETE FROM tblKhoa WHERE sMaKhoa = '" + maKhoa + " '  ";
            ConnectSQL sQL = new ConnectSQL();
            sQL.ketnoi();
            sQL.QueryData(sqlInsert);
        }
        public static void suaKhoa(string maKhoa, string tenKhoa)
        {
            
            string sqlInsert = "Update tblKhoa SET sTenKhoa = N'" + tenKhoa + "' WHERE sMaKhoa = '" + maKhoa + "'  ";
            ConnectSQL sQL = new ConnectSQL();
            sQL.ketnoi();
            sQL.QueryData(sqlInsert);

        }

        private void QLKhoa_Load(object sender, EventArgs e)
        {
            laydataGridKhoa();

        }

        private void btn_xoaKhoa_Click(object sender, EventArgs e)
        {
            
            if (quyen == "Admin")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa khoa này ??", "Thông báo ", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    xoaaKhoa(Convert.ToString(mask_maKhoa.Text));
                    laydataGridKhoa();
                }
            }
            else
                MessageBox.Show("Bạn không có quyền xóa khoa", "Thông báo");

        }

        private void dtGridKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mask_maKhoa.Text = dtGridKhoa.CurrentRow.Cells["Mã khoa"].Value.ToString();
            mask_tenKhoa.Text = dtGridKhoa.CurrentRow.Cells["Tên khoa"].Value.ToString();
      //      mask_maKhoa.Enabled = false;
        }

        private void btn_suaKhoa_Click(object sender, EventArgs e)
        {
            if (quyen == "Admin" )
            {
                suaKhoa(Convert.ToString(mask_maKhoa.Text), Convert.ToString(mask_tenKhoa.Text));
                laydataGridKhoa();
        //        mask_maKhoa.Enabled = true;
            }
            else
                MessageBox.Show("Bạn không có quyền sửa khoa", "Thông báo");
            
        }

        private void btn_themKhoa_Click(object sender, EventArgs e)
        {
            
            if (quyen == "Admin")
            {
                themKhoa(Convert.ToString(mask_maKhoa.Text), Convert.ToString(mask_tenKhoa.Text), Convert.ToString(mask_sdt.Text), Convert.ToString(mask_diaChi.Text));
                laydataGridKhoa();
            }
            else
                MessageBox.Show("Bạn không có quyền thêm khoa", "Thông báo");

        }
        
       
    }
}















































/*
 private void tb_Search_TextChanged(object sender, EventArgs e)
{
    search_textbox(tb_Search.Text.ToString());
}




private void search_textbox(string x)
        {
            string sql = "SELECT sMaKhoa AS 'Mã  khoa' , sTenKhoa AS 'Tên khoa' , sSDT AS 'Số điện thoại' , sDiaChiKhoa AS N'Địa chỉ' FROM tblKhoa WHERE CONCAT(sMaKhoa , sTenKhoa) LIKE '%" + x + "%' OR CONCAT(sSDT , sDiaChiKhoa) LIKE '%" + x + "%'";
            string couter = ConfigurationManager.ConnectionStrings["btl_c#"].ConnectionString;

            using (SqlConnection cnn = new SqlConnection(couter))
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("tb_Khoa");
                        ad.Fill(tb);
                        dtGridKhoa.DataSource = tb;
                    }
                }
            }
        }
 */

