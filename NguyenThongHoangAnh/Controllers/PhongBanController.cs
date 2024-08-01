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
    internal class PhongBanController
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString);
        CheckResult checkResult = new CheckResult();
        public DataTable GetDepartment()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM PhongBan";
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

        public bool AddDepartment(string str)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO PhongBan(TenPB) VALUES (@str)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@str", str);
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

        public bool EditDepartment(string id, string str)
        {
            try
            {
                conn.Open();
                string query = "UPDATE PhongBan SET TenPB=@str WHERE MaPB=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@str", str);
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

        public bool DeleteDepartment(string id)
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM PhongBan WHERE MaPB=@id";
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
