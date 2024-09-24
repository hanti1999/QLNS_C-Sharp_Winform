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
    internal class LoaiPhepController
    {
        CheckResult checkResult = new CheckResult();
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString);

        public DataTable GetData()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM LoaiPhep";
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
                string query = "DELETE FROM LoaiPhep WHERE MaLoaiPhep=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public bool EditData(int MaLoaiPhep, string TenLoaiPhep, float HeSo)
        {
            try
            {
                conn.Open();
                string query = "UPDATE LoaiPhep " +
                    "SET TenLoaiPhep=@TenLoaiPhep, HeSo=@HeSo " +
                    "WHERE MaLoaiPhep=@MaLoaiPhep";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaLoaiPhep", MaLoaiPhep);
                cmd.Parameters.AddWithValue("@TenLoaiPhep", TenLoaiPhep);
                cmd.Parameters.AddWithValue("@HeSo", HeSo);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public bool AddData(string TenLoaiPhep, float HeSo)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO LoaiPhep (TenLoaiPhep, HeSo) " +
                    "VALUES (@TenLoaiPhep, @HeSo)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenLoaiPhep", TenLoaiPhep);
                cmd.Parameters.AddWithValue("@HeSo", HeSo);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch { return false; }
            finally { conn.Close(); }
        }
    }
}
