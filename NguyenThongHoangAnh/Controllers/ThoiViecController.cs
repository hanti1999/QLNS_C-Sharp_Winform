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
    internal class ThoiViecController
    {
        CheckResult checkResult = new CheckResult();
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString);

        public DataTable GetData()
        {
            try
            {
                conn.Open();
                string query = "SELECT tv.SoQD, tv.NgayNopDon, tv.NgayNghi, nv.MaNV, nv.HoTen, tv.LyDo, tv.GhiChu FROM ThoiViec tv JOIN NhanVien nv ON tv.MaNV = nv.MaNV";
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
                string query = "DELETE FROM ThoiViec WHERE SoQD=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public bool EditData(int SoQD, DateTime NgayNopDon, DateTime NgayNghi, string LyDo, string GhiChu, int MaNV)
        {
            try
            {
                conn.Open();
                string query = "UPDATE ThoiViec " +
                    "SET NgayNopDon=@NgayNopDon, NgayNghi=@NgayNghi, LyDo=@LyDo, GhiChu=@GhiChu, MaNV=@MaNV " +
                    "WHERE SoQD=@SoQD";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SoQD", SoQD);
                cmd.Parameters.AddWithValue("@NgayNopDon", NgayNopDon);
                cmd.Parameters.AddWithValue("@NgayNghi", NgayNghi);
                cmd.Parameters.AddWithValue("@LyDo", LyDo);
                cmd.Parameters.AddWithValue("@GhiChu", GhiChu);
                cmd.Parameters.AddWithValue("@MaNV", MaNV);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public bool AddData(int SoQD, DateTime NgayNopDon, DateTime NgayNghi, string LyDo, string GhiChu, int MaNV)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO ThoiViec " +
                    "VALUES (@SoQD, @NgayNopDon, @NgayNghi, @MaNV, @LyDo, @GhiChu)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SoQD", SoQD);
                cmd.Parameters.AddWithValue("@NgayNopDon", NgayNopDon);
                cmd.Parameters.AddWithValue("@NgayNghi", NgayNghi);
                cmd.Parameters.AddWithValue("@LyDo", LyDo);
                cmd.Parameters.AddWithValue("@GhiChu", GhiChu);
                cmd.Parameters.AddWithValue("@MaNV", MaNV);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch { return false; }
            finally { conn.Close(); }
        }
    }
}
