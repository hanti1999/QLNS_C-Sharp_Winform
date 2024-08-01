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
    internal class CongTyController
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString);
        CheckResult checkResult = new CheckResult();
        public DataTable GetCompany ()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM CongTy";
                SqlCommand cmd = new SqlCommand(query, conn);
                return checkResult.CheckDataTable(cmd);
            }
            catch
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool AddCompany (string str, string str2, string str3, string str4)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO CongTy(TenCTY, DienThoai, Email, DiaChi) VALUES (@str, @str2, @str3, @str4)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@str", str);
                cmd.Parameters.AddWithValue("@str2", str2);
                cmd.Parameters.AddWithValue("@str3", str3);
                cmd.Parameters.AddWithValue("@str4", str4);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool EditCompany (string id, string str, string str2, string str3, string str4)
        {
            try
            {
                conn.Open();
                string query = "UPDATE CongTy SET TenCTY=@str, DienThoai=@str2, Email=@str3, DiaChi=@str4 WHERE MaCTY=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@str", str);
                cmd.Parameters.AddWithValue("@str2", str2);
                cmd.Parameters.AddWithValue("@str3", str3);
                cmd.Parameters.AddWithValue("@str4", str4);
                cmd.Parameters.AddWithValue("@id", id);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool DeleteCompany (string id)
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM CongTy WHERE MaCTY=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
