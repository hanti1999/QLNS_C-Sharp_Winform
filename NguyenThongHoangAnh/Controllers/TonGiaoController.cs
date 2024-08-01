using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace NguyenThongHoangAnh.Controllers
{
    internal class TonGiaoController
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString);
        CheckResult checkResult = new CheckResult();
        public DataTable GetReligion()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TonGiao", conn);
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

        public bool AddReligion(string str)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO TonGiao(TenTG) VALUES (@str)";
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

        public bool EditReligion(string id, string str)
        {
            try
            {
                conn.Open();
                string query = "UPDATE TonGiao SET TenTG=@str WHERE MaTG=@id";
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

        public bool DeleteReligion(string id)
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM TonGiao WHERE MaTG=@id";
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
