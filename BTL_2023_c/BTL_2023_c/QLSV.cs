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
    public partial class QLSV : Form
    {
        private string masvv;
        string tk = "", mk = "", quyen = "";
        public QLSV(string tk, string mk, string quyen)
        {
            InitializeComponent();
            this.tk = tk;
            this.mk = mk;
            this.quyen = quyen;
        }
        private void QLSV_Load(object sender, EventArgs e)
        {
            
            laydataGrid();
            //layLop();
        }
       

        public static void themSv(string masv, string hoten, string ngaysinh, string gt , string quequan , string malop)
        {
            string sql = "INSERT INTO tblSinhVien (sMaSv , sTenSV, sGT , sQueQuan , dNgaysinh , sMalop) " +
                "VALUES( '" + masv + "' , N'" + hoten + "' , N'" + gt + "' , N'" + quequan + "' , '"+ ngaysinh +"','"+ malop +"')";
            ConnectSQL sQL = new ConnectSQL();
            sQL.ketnoi();
            sQL.QueryData(sql);
        }

        public void laydataGrid()
        {
            string couter = ConfigurationManager.ConnectionStrings["btl_c#"].ConnectionString;
            
            using (SqlConnection cnn = new SqlConnection(couter))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT sMaSV 'Mã sinh viên' ,sTenSV 'Tên sinh viên' , sGT 'Giới tính' , sQueQuan 'Quê quán' ," +
                    "dNgaySinh AS 'Ngày sinh' , sMaLop AS 'Mã lớp'   FROM vw_dtgridSV", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("tb_SV");
                        ad.Fill(tb);
                        dtGridSV.DataSource = tb;
                    }
                }
            }
        }

        

        public static void suaSv(string masv, string hoten)
        {
            
            string sql = "Update tblSinhVien SET sTenSV = N'" + hoten + "' WHERE sMaSV = '" + masv + "'  ";

            ConnectSQL sQL = new ConnectSQL();
            sQL.ketnoi();

            sQL.QueryData(sql);

        }

        public static void xoaaSv(String masv)
        {
            
            string sqlInsert = "DELETE FROM tblSinhVien WHERE sMaSV = '" + masv + " '  ";
            ConnectSQL sQL = new ConnectSQL();
            sQL.ketnoi();

            sQL.QueryData(sqlInsert);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (quyen == "Admin" || quyen == "Giảng viên")
            {
                themSv(Convert.ToString(mask_maSV.Text), Convert.ToString(mask_tenSv.Text), Convert.ToString(mask_ngaySinh.Text), Convert.ToString(mask_GT.Text), Convert.ToString(mask_queQuan.Text), Convert.ToString(mask_maLop.Text));
                laydataGrid();
            }
            else
                MessageBox.Show("Bạn không có quyền thêm sinh viên", "Thông báo");
        }

        

        private void dtGridSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mask_maSV.Text = dtGridSV.CurrentRow.Cells["Mã sinh viên"].Value.ToString();
            mask_tenSv.Text = dtGridSV.CurrentRow.Cells["Tên sinh viên"].Value.ToString();
         //   mask_maSV.Enabled = false;
            masvv = mask_maSV.Text.ToString();
        }

       

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            
            if (quyen == "Admin" || quyen == "Giảng viên")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa sinh viên này ??", "Thông báo ", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    xoaaSv(Convert.ToString(mask_maSV.Text));
                    laydataGrid();
                   // mask_maSV.Enabled = true;
                }
                
            }
            else
                MessageBox.Show("Bạn không có quyền xóa sinh viên", "Thông báo");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            
            if (quyen == "Admin" || quyen == "Giảng viên")
            {
                suaSv(Convert.ToString(mask_maSV.Text), Convert.ToString(mask_tenSv.Text));
                laydataGrid();
            //    mask_maSV.Enabled = true;
            }
            else
                MessageBox.Show("Bạn không có quyền sửa sinh viên", "Thông báo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dsNV ds = new dsNV( mask_maSV.Text );
            ds.Show();
        }

        private void btnInDSSV_Click(object sender, EventArgs e)
        {
            THI2 dssv = new THI2();
            dssv.Show();
        }

        private void mask_queQuan_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        



        private void btn_xemct_Click(object sender, EventArgs e)
        {
            QLCTDiem qLCTDiem = new QLCTDiem(masvv , tk ,mk ,quyen);
            qLCTDiem.Show();
        }


        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            search_textbox(tb_search.Text);
        }


        private void search_textbox(string x)
        {
            string sql = "SELECT sMaSV 'Mã sinh viên' ,sTenSV 'Tên sinh viên' , sGT 'Giới tính' , sQueQuan 'Quê quán' ," +
                    "dNgaySinh AS 'Ngày sinh' , sMaLop AS 'Mã lớp' FROM tblSinhVien WHERE CONCAT(sTenSV , sGT ) LIKE '%" + x + "%'";
            ConnectSQL sQL = new ConnectSQL();
            sQL.ketnoi();
            dtGridSV.DataSource = sQL.getTable(sql);
        }
    }
}




























/*




 private void layLop()
        {
            string constr = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblLop", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("Lop");
                        ad.Fill(tb);
                        combo_malop.DataSource = tb;
                        combo_malop.DisplayMember = "sMaLop";
                        combo_malop.ValueMember = "sTenLop";
                    }
                }
            }
        }

 */