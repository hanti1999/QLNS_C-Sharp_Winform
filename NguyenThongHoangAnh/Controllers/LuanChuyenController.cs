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
    internal class LuanChuyenController
    {
        CheckResult checkResult = new CheckResult();
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString);

        public bool FillCombobox(string sqlString, string Ma, string Ten, ComboBox cbo)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                cbo.DataSource = checkResult.CheckDataTable(cmd);
                cbo.DisplayMember = Ten;
                cbo.ValueMember = Ma;
                if (cbo.Items.Count > 0)
                {
                    cbo.SelectedIndex = -1;
                    cbo.SelectedText = "------Chọn------";
                }
                return true;
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public string GetOldPB (int MaNV)
        {
            try
            {
                conn.Open();
                string query = "SELECT MaPB FROM NhanVien WHERE MANV=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", MaNV);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return reader["MaPB"].ToString();
                }
                else
                {
                    return null;
                }
            }
            catch { return null; }
            finally { conn.Close(); }
        }

        public bool UpdateNV (int MaPB, int MaNV)
        {
            try
            {
                conn.Open();
                string query = "UPDATE NhanVien SET MaPB=@MaPB WHERE MaNV=@MaNV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPB", MaPB);
                cmd.Parameters.AddWithValue("@MaNV", MaNV);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public DataTable GetData()
        {
            try
            {
                conn.Open();
                string query = "SELECT lc.SoQD, lc.NgayQD, nv.MaNV, nv.HoTen, pbCu.TenPB AS PBCu, pbMoi.TenPB AS PBMoi, lc.LyDo, lc.GhiChu " +
                    "FROM LuanChuyen lc " +
                    "JOIN NhanVien nv ON lc.MaNV = nv.MaNV " +
                    "JOIN PhongBan pbCu ON lc.PBCu = pbCu.MaPB " +
                    "JOIN PhongBan pbMoi ON lc.PBMoi = pbMoi.MaPB";
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
                string query = "DELETE FROM LuanChuyen WHERE SoQD=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public bool EditData(int SoQD, DateTime NgayQD, int PBMoi, string LyDo, string GhiChu, int MaNV)
        {
            try
            {
                conn.Open();
                string query = "UPDATE LuanChuyen " +
                    "SET NgayQD=@NgayQD,PBMoi=@PBMoi, LyDo=@LyDo, GhiChu=@GhiChu, MaNV=@MaNV " +
                    "WHERE SoQD=@SoQD";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SoQD", SoQD);
                cmd.Parameters.AddWithValue("@NgayQD", NgayQD);
                cmd.Parameters.AddWithValue("@PBMoi", PBMoi);
                cmd.Parameters.AddWithValue("@LyDo", LyDo);
                cmd.Parameters.AddWithValue("@GhiChu", GhiChu);
                cmd.Parameters.AddWithValue("@MaNV", MaNV);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public bool AddData(int SoQD, DateTime NgayQD, int PBCu, int PBMoi, string LyDo, string GhiChu, int MaNV)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO LuanChuyen " +
                    "VALUES (@SoQD, @NgayQD, @MaNV, @PBCu, @PBMoi, @LyDo, @GhiChu)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SoQD", SoQD);
                cmd.Parameters.AddWithValue("@NgayQD", NgayQD);
                cmd.Parameters.AddWithValue("@PBCu", PBCu);
                cmd.Parameters.AddWithValue("@PBMoi", PBMoi);
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
