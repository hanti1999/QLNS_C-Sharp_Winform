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
    internal class LoaiCaController
    {
        CheckResult checkResult = new CheckResult();
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString);

        public DataTable GetData()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM LoaiCa";
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
                string query = "DELETE FROM LoaiCa WHERE MaLoaiCa=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public bool EditData(int MaLoaiCa, string TenLoaiCa, float HeSo)
        {
            try
            {
                conn.Open();
                string query = "UPDATE LoaiCa " +
                    "SET TenLoaiCa=@TenLoaiCa, HeSo=@HeSo " +
                    "WHERE MaLoaiCa=@MaLoaiCa";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaLoaiCa", MaLoaiCa);
                cmd.Parameters.AddWithValue("@TenLoaiCa", TenLoaiCa);
                cmd.Parameters.AddWithValue("@HeSo", HeSo);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public bool AddData(string TenLoaiCa, float HeSo)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO LoaiCa (TenLoaiCa, HeSo) " +
                    "VALUES (@TenLoaiCa, @HeSo)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenLoaiCa", TenLoaiCa);
                cmd.Parameters.AddWithValue("@HeSo", HeSo);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch { return false; }
            finally { conn.Close(); }
        }
    }
}
