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
    public partial class QLCTDiem : Form
    {
        string  masv;
        string tk = "", mk = "", quyen = "";
        public QLCTDiem(  string masv1 , string tk, string mk, string quyen)
        {
            InitializeComponent();
            masv = masv1;
            this.tk = tk;
            this.mk = mk;
            this.quyen = quyen;
        }

        private void QLDiem_Load(object sender, EventArgs e)
        {
            laydataGridCTDiem();
           // layMonHoc();
           // laySinhVien();

        }


        public void laydataGridCTDiem()
        {
            
            string sql = "SELECT sMaSV AS N'Mã sinh viên' , sMaMH AS N'Mã môn học', dNgayHoc AS N'Ngày học' , fDiemCC AS N'Điểm chuyên cần' " +
                    ", fDiemBK AS N'Điểm giữa kì' , fDiemHK AS N'Điểm cuối kì' ,  fDiemTK AS N'Điểm tổng kết' FROM vw_dtgridCTDiem WHERE sMaSV = '" + masv + "'";
            ConnectSQL connect = new ConnectSQL();
            connect.ketnoi();
            dataGridCTDiem.DataSource = connect.getTable(sql);
        }

        public static void themCTDiem(string maSV, string maMH, string ngayhoc , float diemCC, float diemGK , float diemHK )
        {
            
            string sql = "INSERT INTO tblCTDiem (sMaSV , sMaMH , dNgayHoc , fDiemCC , fDiemBK , fDiemHK) " +
                "VALUES( '" + maSV + "' , '" + maMH + "' , '" + ngayhoc + "' , "  + diemCC + " , " + diemGK + " , "+ diemHK +")";
            ConnectSQL connectSQL = new ConnectSQL();
            connectSQL.ketnoi();
            connectSQL.QueryData(sql);
        }

        private void btn_themCTDiem_Click(object sender, EventArgs e)
        {
            if (quyen == "Admin" || quyen == "Giảng viên")
            {
                themCTDiem(Convert.ToString(mask_maSv.Text), Convert.ToString(mask_maMh.Text) , Convert.ToString(mask_ngayHoc.Text) , float.Parse(mask_diemCC.Text), float.Parse(mask_diemGK.Text), float.Parse(mask_diemCK.Text));
                laydataGridCTDiem();
            }
            else
                MessageBox.Show("Bạn không có quyền thêm điểm", "Thông báo");
            
        }

        private void btn_suaCTDiem_Click(object sender, EventArgs e)
        {
            if (quyen == "Admin" || quyen == "Giảng viên")
            {
                suaCTDiem(Convert.ToString(mask_maSv.Text), mask_maMh.Text.ToString(), float.Parse(mask_diemCC.Text));
           //     mask_maMh.Enabled = true;
             //   mask_maSv.Enabled = true;
                laydataGridCTDiem();
            }
            else
                MessageBox.Show("Bạn không có quyền sửa điểm", "Thông báo" );
        }


        public static void suaCTDiem(string maSV , string maMh , float diemCC)
        {
            ConnectSQL connectSQL = new ConnectSQL();
            string sql = "Update tblCTDiem SET fDiemCC = " + diemCC + " WHERE sMaSV = '" + maSV + "' AND sMaMH = '" + maMh + "'" ;
            connectSQL.ketnoi();
            connectSQL.QueryData(sql);
        }

        private void dataGridCTDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mask_maSv.Text = dataGridCTDiem.CurrentRow.Cells["Mã sinh Viên"].Value.ToString();
            mask_diemCC.Text = dataGridCTDiem.CurrentRow.Cells["Điểm chuyên cần"].Value.ToString();
            mask_maMh.Text = dataGridCTDiem.CurrentRow.Cells["Mã môn học"].Value.ToString();
        //    cb_maSv.Enabled = false;
          //  cb_maMh.Enabled = false;
        }



      

        public static void xoaaCTDiem(string maSV , string maMH )
        {
            string sql = "DELETE FROM tblCTDiem WHERE sMaSV = '" + maSV + "' AND sMaMH = '" + maMH + "' ";
            ConnectSQL connectSQL = new ConnectSQL();
            connectSQL.ketnoi();
            connectSQL.QueryData(sql);

        }

        private void dataGridCTDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void btn_xoaCTDiem_Click(object sender, EventArgs e)
        {
            if (quyen == "Admin" || quyen == "Giảng viên")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa điểm này ??", "Thông báo ", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    xoaaCTDiem(Convert.ToString(mask_maSv.Text), Convert.ToString(mask_maMh.Text));
                    laydataGridCTDiem();
                }
            }
            else
                MessageBox.Show("Bạn không có quyền xóa điểm", "Thông báo");
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
            string sql = "SELECT * FROM tblCTDiem WHERE CONCAT(sMaSV , sMaMH ) LIKE '%"  + x + "%'";
            ConnectSQL connectSQL = new ConnectSQL();
            connectSQL.ketnoi();
            dataGridCTDiem.DataSource = connectSQL.getTable(sql);
        }









  private void laySinhVien()
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblSinhVien", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("SinhVien");
                        ad.Fill(tb);
                        cb_maSv.DataSource = tb;
                        cb_maSv.DisplayMember = "sMaSV";
                        cb_maSv.ValueMember = "sTenSV";
                    }
                }
            }
        }









private void layMonHoc()
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblMonHoc", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("MonHoc");
                        ad.Fill(tb);
                        cb_maMh.DataSource = tb;
                        cb_maMh.DisplayMember = "sMaMH";
                        cb_maMh.ValueMember = "sTenMH";
                    }
                }
            }
        }




if (quyen == "Admin" || quyen == "Giảng viên")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa điểm này ??", "Thông báo ", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    xoaaCTDiem(Convert.ToString(mask_maSv.Text), Convert.ToString(mask_maMh.Text));
                    laydataGridCTDiem();
                }
            }
            else
                MessageBox.Show("Bạn không có quyền xóa điểm", "Thông báo");
        */