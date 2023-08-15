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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        
        public static void ktraTK(string sql , string taikhoan)
        {
            string couter = ConfigurationManager.ConnectionStrings["btl_c#"].ConnectionString;

            using (SqlConnection cnn = new SqlConnection(couter))
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("tbl_tk");
                        ad.Fill(tb);
                        if (tb.Rows.Count == 0)
                            MessageBox.Show("Bạn đã nhập sai tài khoản ", "Thong bao", MessageBoxButtons.YesNo);

                        else
                        {
                            Form1 f1 = new Form1(taikhoan , tb.Rows[0][0].ToString() , tb.Rows[0][1].ToString() , tb.Rows[0][2].ToString());
                            f1.Show();
                        }
                    }
                }
            }
        }
        private void btn_Dn_Click(object sender, EventArgs e)
        {
            string sqlTK = "SELECT * FROM username WHERE sTenTK = '" + tb_TK.Text + "' AND sMK = '" + tb_mk.Text + "'";
            string couter = ConfigurationManager.ConnectionStrings["btl_c#"].ConnectionString;

            ktraTK(sqlTK , tb_TK.Text.ToString());
            using (SqlConnection cnn = new SqlConnection(couter))
            {
                using (SqlCommand cmd = new SqlCommand(sqlTK, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("tb_Lop");
                        ad.Fill(tb);

                    }
                }
            }
        }

        private void btn_Dk_Click(object sender, EventArgs e)
        {
            Register rg = new Register();
            rg.Show();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}
