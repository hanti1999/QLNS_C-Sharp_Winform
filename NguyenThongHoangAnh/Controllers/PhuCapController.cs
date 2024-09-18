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
    internal class PhuCapController
    {
        CheckResult checkResult = new CheckResult();
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString);

        public DataTable GetData()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM PhuCap";
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
                string query = "DELETE FROM PhuCap WHERE MaPhuCap=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public bool EditData(int MaPhuCap, string TenPhuCap, float SoTien)
        {
            try
            {
                conn.Open();
                string query = "UPDATE PhuCap " +
                    "SET TenPhuCap=@TenPhuCap, SoTien=@SoTien " +
                    "WHERE MaPhuCap=@MaPhuCap";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPhuCap", MaPhuCap);
                cmd.Parameters.AddWithValue("@TenPhuCap", TenPhuCap);
                cmd.Parameters.AddWithValue("@SoTien", SoTien);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public bool AddData(string TenPhuCap, float SoTien)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO PhuCap (TenPhuCap, SoTien) " +
                    "VALUES (@TenPhuCap, @SoTien)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenPhuCap", TenPhuCap);
                cmd.Parameters.AddWithValue("@SoTien", SoTien);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch { return false; }
            finally { conn.Close(); }
        }
    }
}
