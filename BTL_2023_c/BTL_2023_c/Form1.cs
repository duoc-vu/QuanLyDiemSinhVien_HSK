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
    public partial class Form1 : Form
    {
        string tk = "", mk = "", quyen = "";
        public Form1( string v ,string tk , string mk ,string quyen)
        {
            InitializeComponent();
            label1.Text = "Welcom to sever " + v;
            this.tk = tk;
            this.mk = mk;
            this.quyen = quyen;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình ??", "Thông báo ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Close();
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLSV qlsv = new QLSV(tk , mk , quyen);
            qlsv.Show();
        }

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLLop qll = new QLLop(tk, mk, quyen);
            qll.Show();
        }

        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLKhoa qlk = new QLKhoa(tk, mk, quyen);
            qlk.Show();
        }

        

        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLMH qlmh = new QLMH(tk, mk, quyen);
            this.Hide();
            qlmh.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýBangDIemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (quyen == "Admin")
            {
                QLBangDiem qlbd = new QLBangDiem(tk, mk, quyen);
                qlbd.Show();
            }
            else MessageBox.Show("Ban khong co quyen xem ", "Thong bao");

        }
    }
}
