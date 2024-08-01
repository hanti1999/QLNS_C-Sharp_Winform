using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenThongHoangAnh.Controllers
{
    internal class ChucVuController
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString);
        CheckResult checkResult = new CheckResult();
        public DataTable GetPosition()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM ChucVu";
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

        public bool AddPosition (string str)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO ChucVu(TenCV) VALUES (@str)";
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

        public bool EditPositon (string id, string str)
        {
            try
            {
                conn.Open();
                string query = "UPDATE ChucVu SET TenCV=@str WHERE MaCV=@id";
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

        public bool DeletePositon (string id)
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM ChucVu WHERE MaCV=@id";
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
