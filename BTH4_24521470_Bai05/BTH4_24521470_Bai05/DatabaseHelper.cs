using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH4_24521470_Bai05
{
    internal class DatabaseHelper
    {
        private readonly string connectionString;

        public DatabaseHelper()
        {
            connectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        }

        public void ThemSinhVien(string msv, string tensv, string khoa, decimal diemtb)
        {
            using (SqlConnection conn = new SqlConnection(connectionString)) 
            {
                conn.Open();
                string query = "INSERT INTO SINHVIEN (MASV, TENSV, KHOA, DIEMTB) " +
                           " VALUES ( @MASV, @TENSV, @KHOA, @DIEMTB)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlParameter[] parameters =
                    {
                       new SqlParameter("@MaSV", msv),
                       new SqlParameter("@TENSV", tensv),
                       new SqlParameter("@KHOA", khoa),
                       new SqlParameter("@DIEMTB", diemtb)
                    };
                    cmd.Parameters.AddRange(parameters);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
