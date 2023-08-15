using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace BTL_2023_c
{
    public partial class QLBangDiem : Form
    {
        string masv;
        string tk = "", mk = "", quyen = "";
        public QLBangDiem(string tk, string mk, string quyen)
        {
            InitializeComponent();
            this.tk = tk;
            this.mk = mk;
            this.quyen = quyen;
        }

        private void dataGridBangDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mask_maSv.Text = dataGridBangDiem.CurrentRow.Cells["Mã sinh Viên"].Value.ToString();
            mask_diemCC.Text = dataGridBangDiem.CurrentRow.Cells["Điểm chuyên cần"].Value.ToString();
            mask_maMH.Text = dataGridBangDiem.CurrentRow.Cells["Mã môn học"].Value.ToString();
            mask_ngayHoc.Text = dataGridBangDiem.CurrentRow.Cells["Ngày học"].Value.ToString();
 //           cb_maSv.Enabled = false;
   //         cb_maMh.Enabled = false;
        }

        private void QLBangDiem_Load(object sender, EventArgs e)
        {
            laydataGridBangDiem();

        }

        public void laydataGridBangDiem()
        {

            string sql = "SELECT sMaSV AS N'Mã sinh viên' , sMaMH AS N'Mã môn học' , dNgayHoc AS N'Ngày học' , fDiemCC AS N'Điểm chuyên cần' " +
                    ", fDiemBK AS N'Điểm giữa kì' , fDiemHK AS N'Điểm cuối kì' ,  fDiemTK AS N'Điểm tổng kết' FROM vw_dtgridCTDiem";
            ConnectSQL connect = new ConnectSQL();
            connect.ketnoi();
            dataGridBangDiem.DataSource = connect.getTable(sql);
        }

        public static void themBangDiem(string maSV, string maMH, string ngayhoc ,float diemCC, float diemGK, float diemHK)
        {
            string sql = "INSERT INTO tblCTDiem (sMaSV , sMaMH , dNgayHoc , fDiemCC , fDiemBK , fDiemHK) " +
                "VALUES( '" + maSV + "' , '" + maMH + "' , '" +  ngayhoc + "' ," + diemCC + " , " + diemGK + " , " + diemHK + ")";
            ConnectSQL connectSQL = new ConnectSQL();
            connectSQL.ketnoi();
            connectSQL.QueryData(sql);
        }

        private void btn_themBangDiem_Click(object sender, EventArgs e)
        {
            if (quyen == "Admin" || quyen == "Giảng viên")
            {
                themBangDiem(Convert.ToString(mask_maSv.Text), Convert.ToString(mask_maMH.Text), Convert.ToString(mask_ngayHoc.Text) , float.Parse(mask_diemCC.Text), float.Parse(mask_diemGK.Text), float.Parse(mask_diemCK.Text));
                laydataGridBangDiem();
            }
            else
                MessageBox.Show("Bạn không có quyền thêm điểm", "Thông báo");

        }

        private void btn_suaBangDiem_Click(object sender, EventArgs e)
        {
            if (quyen == "Admin" || quyen == "Giảng viên")
            {
                suaBangDiem(Convert.ToString(mask_maSv.Text), mask_maMH.Text.ToString(), float.Parse(mask_diemCC.Text));
    //            mask_maSv.Enabled = true;
      //          mask_maMH.Enabled = true;
                laydataGridBangDiem();
            }
            else
                MessageBox.Show("Bạn không có quyền sửa điểm", "Thông báo");
        }
        public static void suaBangDiem(string maSV, string maMh, float diemCC)
        {
            ConnectSQL connectSQL = new ConnectSQL();
            string sql = "Update tblCTDiem SET fDiemCC = " + diemCC + " WHERE sMaSV = '" + maSV + "' AND sMaMH = '" + maMh + "'";
            connectSQL.ketnoi();
            connectSQL.QueryData(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hienDSDiem hds = new hienDSDiem();
            hds.Show();
        }

        public static void xoaaBangDiem(string maSV, string maMH)
        {
            string sql = "DELETE FROM tblCTDiem WHERE sMaSV = '" + maSV + "' AND sMaMH = '" + maMH + "' ";
            ConnectSQL connectSQL = new ConnectSQL();
            connectSQL.ketnoi();
            connectSQL.QueryData(sql);
        }

        private void btn_xoaBangDiem_Click(object sender, EventArgs e)
        {
            if (quyen == "Admin" || quyen == "Giảng viên")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa điểm này ??", "Thông báo ", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    xoaaBangDiem(Convert.ToString(mask_maSv.Text), Convert.ToString(mask_maMH.Text));
                    laydataGridBangDiem();
                }
            }
            else
                MessageBox.Show("Bạn không có quyền xóa điểm", "Thông báo");
        }
    }
}




















































/*
 do
        {
            System.out.print("Hãy nhập một số vào : ");

            str = Nhap.nextLine();

            Pattern pattern = Pattern.compile("\\d*");
            Matcher matcher = pattern.matcher(str);
            if (matcher.matches()) {
                soA = Integer.parseInt(str);
                t = 1;
            } else
            {
                System.out.println("Bạn vừa nhập vào không phải số, vui lòng nhập lại !");
            }
        } while(t != 1);






   if (mask_diemCC.Text.GetType().ToString() == "float")
            {
                themBangDiem(Convert.ToString(mask_maSv.Text), Convert.ToString(mask_maMH.Text), Convert.ToString(mask_ngayHoc.Text) , float.Parse(mask_diemCC.Text), float.Parse(mask_diemGK.Text), float.Parse(mask_diemCK.Text));
                laydataGridBangDiem();
            }
            else
                MessageBox.Show("Bạn không có quyền thêm điểm", "Thông báo");


 */
