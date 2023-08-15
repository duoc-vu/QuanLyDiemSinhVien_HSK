using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_2023_c
{
    public partial class QLLop : Form
    {
        string tk = "", mk = "", quyen = "";
        public QLLop(string tk, string mk, string quyen)
        {
            InitializeComponent();
            this.tk = tk;
            this.mk = mk;
            this.quyen = quyen;
        }

        private void btn_ThemLop_Click(object sender, EventArgs e)
        {
            
            if (quyen == "Admin")
            {
                themLop(Convert.ToString(mask_maLop.Text), Convert.ToString(mask_tenLop.Text), Convert.ToString(mask_maKhoa.Text));
                laydataGridLop();
            }
            else
                MessageBox.Show("Bạn không có quyền thêm lớp", "Thông báo");
        }

        


        public static void themLop(string malop, string tenlop, string makhoa)
        {
            string sqlInsert = "INSERT INTO tblLop (sMalop , sTenLop , sMaKhoa ) " +
                "VALUES( '" + malop + "' , N'" + tenlop + "' , '" + makhoa + ")";
            ConnectSQL sQL = new ConnectSQL();
            sQL.ketnoi();
            sQL.QueryData(sqlInsert);
        }

        public void laydataGridLop()
        {
            string couter = ConfigurationManager.ConnectionStrings["btl_c#"].ConnectionString;
            ConnectSQL csql = new ConnectSQL();
            csql.ketnoi();
            dtGridLop.DataSource = csql.getTable("SELECT sMaLop AS 'Mã lớp' , sTenLop AS 'Tên lớp' , sMaKhoa AS 'Mã khoa' , fSoSV AS 'Số sinh viên' FROM vw_dtgridLop");
        }

        public static void suaLop(string maLop, string tenLop)
        {
            string sqlInsert = "Update tblLop SET sTenLop = N'" + tenLop + "' WHERE sMaLop = '" + maLop + "'  ";
            ConnectSQL sQL = new ConnectSQL();
            sQL.ketnoi();
            sQL.QueryData(sqlInsert);

        }

        public static void xoaaLop(string maLop)
        {
            string sqlInsert = "DELETE FROM tblLop WHERE sMaLop = '" + maLop + " '  ";
            ConnectSQL sQL = new ConnectSQL();
            sQL.ketnoi();
            sQL.QueryData(sqlInsert);
        }

        private void btn_suaLop_Click(object sender, EventArgs e)
        {
            
            if (quyen == "Admin")
            {
                suaLop(Convert.ToString(mask_maLop.Text), Convert.ToString(mask_tenLop.Text));
                laydataGridLop();
      //          mask_maLop.Enabled = true;
            }
            else
                MessageBox.Show("Bạn không có quyền sửa lớp", "Thông báo");
        }

        private void btn_xoaLop_Click(object sender, EventArgs e)
        {

            
            if (quyen == "Admin")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa lop này ??", "Thông báo ", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    xoaaLop(Convert.ToString(mask_maLop.Text));
                    laydataGridLop();
                }
            }
            else
                MessageBox.Show("Bạn không có quyền xóa lớp", "Thông báo");

        }



        

        private void dtGridLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mask_maLop.Text = dtGridLop.CurrentRow.Cells["Mã lớp"].Value.ToString();
            mask_tenLop.Text = dtGridLop.CurrentRow.Cells["Tên lớp"].Value.ToString();
  //          mask_maLop.Enabled = false;
        }

        private void QLLop_Load(object sender, EventArgs e)
        {

            laydataGridLop();
          //  layKhoa();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            laydataGridLop();
        }

        private void dtGridLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        


    }
}
















/*
 private void layDSLop()
        {
            string ctr = ConfigurationManager.ConnectionStrings["btl_c#"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(ctr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblLop", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("SV");
                        ad.Fill(tb);

                        DataView v = new DataView(tb);
                        v.Sort = "sTenLop";
                        combo_maKhoa.DataSource = v;
                        combo_maKhoa.DisplayMember = "sTenLop";
                        combo_maKhoa.ValueMember = "sMaKhoa";

                    }
                }
            }
        }
 

private void layKhoa()
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblKhoa", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("Lop");
                        ad.Fill(tb);
                        combo_maKhoa.DataSource = tb;
                        combo_maKhoa.DisplayMember = "sMaKhoa";
                        combo_maKhoa.ValueMember = "sTenKhoa";
                    }
                }
            }
        }
 

private void tb_Search_TextChanged(object sender, EventArgs e)
        {

            search_textbox(tb_Search.Text);

        }
        private void search_textbox(string x)
        {
            string sql = "SELECT * FROM tblLop WHERE CONCAT(sMaLop , sTenLop ) LIKE '%" + x + "%' OR sMaKhoa LIKE '%" + x + "%'";
            ConnectSQL sQL = new ConnectSQL();
            sQL.ketnoi();
            dtGridLop.DataSource = sQL.getTable(sql);
        }

 */
