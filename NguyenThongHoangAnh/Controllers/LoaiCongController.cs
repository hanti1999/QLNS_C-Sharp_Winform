using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThongHoangAnh.Controllers
{
    internal class LoaiCongController
    {
        CheckResult checkResult = new CheckResult();
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString);

        public DataTable GetData()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM loaiCong";
                SqlCommand cmd = new SqlCommand(query, conn);
                return checkResult.CheckDataTable(cmd);
            }
            catch { return null; }
            finally { conn.Close(); }
        }

        public bool DeleteData(int id)
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM LoaiCong WHERE MaLoaiCong=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public bool EditData(int MaLoaiCong, string TenLoaiCong, float HeSo)
        {
            try
            {
                conn.Open();
                string query = "UPDATE LoaiCong " +
                    "SET TenLoaiCong=@TenLoaiCong, HeSo=@HeSo " +
                    "WHERE MaLoaiCong=@MaLoaiCong";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaLoaiCong", MaLoaiCong);
                cmd.Parameters.AddWithValue("@TenLoaiCong", TenLoaiCong);
                cmd.Parameters.AddWithValue("@HeSo", HeSo);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public bool AddData(string TenLoaiCong, float HeSo)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO LoaiCong (TenLoaiCong, HeSo) " +
                    "VALUES (@TenLoaiCong, @HeSo)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenLoaiCong", TenLoaiCong);
                cmd.Parameters.AddWithValue("@HeSo", HeSo);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch { return false; }
            finally { conn.Close(); }
        }
    }
}
