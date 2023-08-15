using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_2023_c
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Dk_Click(object sender, EventArgs e)
        {
            try
            {
                themTK(tb_TK.Text.ToString(), tb_mk.Text.ToString(), comboBox1.Text.ToString());
                this.Close();
                MessageBox.Show("Đăng kí thành công");
            }
            catch ( Exception q)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông báo", MessageBoxButtons.YesNo);
            }
            
        }

        public static void themTK(string tk, string mk, string quyen)
        {

            string sqlInsert = "INSERT INTO username " +
                "VALUES( '" + tk + "' , N'" + mk + "' , '" + quyen + "' )";
            ConnectSQL sQL = new ConnectSQL();
            sQL.ketnoi();
            sQL.QueryData(sqlInsert);
        }

        private void tb_TK_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
