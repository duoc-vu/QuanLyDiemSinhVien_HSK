using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_2023_c
{
    class ConnectSQL
    {
        public string str = ConfigurationManager.ConnectionStrings["btl_c#"].ConnectionString;
        public SqlConnection cnn = new SqlConnection();
        public bool ketnoi()
        {
            try
            {
                if (cnn.State == ConnectionState.Open) cnn.Close();
                cnn.ConnectionString = str;
                cnn.Open();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối CSDL", "Thông báo", MessageBoxButtons.YesNo);
                return false;
            }

            return true;
        }

        public DataTable getTable(string sql)
        {
            SqlDataAdapter ad = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        public bool QueryData(string sql)
        {
            string counter = ConfigurationManager.ConnectionStrings["btl_C#"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(counter))
            {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        cnn.Close();
                        return i > 0;
                    }
            }
        }

        
    }
}
