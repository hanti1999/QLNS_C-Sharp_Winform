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
    internal class BangChamCongController
    {
        CheckResult checkResult = new CheckResult();
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString);

        public DataTable GetData()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM KyCong";
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
                string query = "DELETE FROM KyCong WHERE MaKyCong=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public bool EditData(int MaKyCong, int Thang, int Nam, DateTime NgayTinhCong, int NgayCongTrongThang, int KhoaCong)
        {
            try
            {
                conn.Open();
                string query = "UPDATE KyCong " +
                    "SET Thang=@Thang, Nam=@Nam, NgayTinhCong=@NgayTinhCong, NgayCongTrongThang=@NgayCongTrongThang, KhoaCong=@KhoaCong " +
                    "WHERE MaKyCong=@MaKyCong";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaKyCong", MaKyCong);
                cmd.Parameters.AddWithValue("@Thang", Thang);
                cmd.Parameters.AddWithValue("@Nam", Nam);
                cmd.Parameters.AddWithValue("@NgayTinhCong", NgayTinhCong);
                cmd.Parameters.AddWithValue("@NgayCongTrongThang", NgayCongTrongThang);
                cmd.Parameters.AddWithValue("@KhoaCong", KhoaCong);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public bool AddData(int MaKyCong, int Thang, int Nam, DateTime NgayTinhCong, int NgayCongTrongThang, int KhoaCong)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO KyCong " +
                    "VALUES (@MaKyCong, @Thang, @Nam, @NgayTinhCong, @NgayCongTrongThang, @KhoaCong)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaKyCong", MaKyCong);
                cmd.Parameters.AddWithValue("@Thang", Thang);
                cmd.Parameters.AddWithValue("@Nam", Nam);
                cmd.Parameters.AddWithValue("@NgayTinhCong", NgayTinhCong);
                cmd.Parameters.AddWithValue("@NgayCongTrongThang", NgayCongTrongThang);
                cmd.Parameters.AddWithValue("@KhoaCong", KhoaCong);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch { return false; }
            finally { conn.Close(); }
        }
    }
}
