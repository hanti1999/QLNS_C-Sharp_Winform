using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NguyenThongHoangAnh.Controllers
{
    internal class KyLuatController
    {
        CheckResult checkResult = new CheckResult();
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString);
        public DataTable GetData()
        {
            try
            {
                conn.Open();
                string query = "SELECT NV.HoTen, KL.SoQD, KL.NgayQD, KL.NgayKetThuc, KL.LyDo, KL.NoiDung FROM kyLuat KL INNER JOIN NhanVien NV ON NV.MaNV = KL.MaNV";
                SqlCommand cmd = new SqlCommand(query, conn);
                return checkResult.CheckDataTable(cmd);
            }
            catch { return null; }
            finally { conn.Close(); }
        }

        public bool AddData(int SoQD, DateTime NgayQD, DateTime NgayKetThuc, string LyDo, string NoiDung, int MaNV)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO kyLuat " +
                    "VALUES (@SoQD, @NgayQD, @NgayKetThuc, @LyDo, @NoiDung, @MaNV)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SoQD", SoQD);
                cmd.Parameters.AddWithValue("@NgayQD", NgayQD);
                cmd.Parameters.AddWithValue("@NgayKetThuc", NgayKetThuc);
                cmd.Parameters.AddWithValue("@LyDo", LyDo);
                cmd.Parameters.AddWithValue("@NoiDung", NoiDung);
                cmd.Parameters.AddWithValue("@MaNV", MaNV);

                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public bool DeleteData(string id)
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM kyLuat WHERE SoQD=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public bool EditData(int SoQD, DateTime NgayQD, DateTime NgayKetThuc, string LyDo, string NoiDung, int MaNV)
        {
            try
            {
                conn.Open();
                string query = "UPDATE kyLuat " +
                    "SET NgayQD=@NgayQD, NgayKetThuc=@NgayKetThuc, LyDo=@LyDo, NoiDung=@NoiDung, MaNV=@MaNV " +
                    "WHERE SoQD=@SoQD";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SoQD", SoQD);
                cmd.Parameters.AddWithValue("@NgayQD", NgayQD);
                cmd.Parameters.AddWithValue("@NgayKetThuc", NgayKetThuc);
                cmd.Parameters.AddWithValue("@LyDo", LyDo);
                cmd.Parameters.AddWithValue("@NoiDung", NoiDung);
                cmd.Parameters.AddWithValue("@MaNV", MaNV);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch { return false; }
            finally { conn.Close(); }
        }
    }
}
