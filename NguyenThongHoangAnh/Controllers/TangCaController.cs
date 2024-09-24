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
    internal class TangCaController
    {
        CheckResult checkResult = new CheckResult();
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString);

        public DataTable GetData()
        {
            try
            {
                conn.Open();
                string query = "SELECT TC.MaTangCa, TC.NgayTangCa, NV.MaNV, NV.HoTen, LC.TenLoaiCa, TC.SoGio, TC.HeSo, TC.SoTien, TC.GhiChu FROM TangCa TC JOIN NhanVien NV ON TC.MaNV = NV.MaNV JOIN LoaiCa LC ON TC.MaLoaiCa = LC.MaLoaiCa";
                SqlCommand cmd = new SqlCommand(query, conn);
                return checkResult.CheckDataTable(cmd);
            }
            catch { return null; }
            finally { conn.Close(); }
        }

        public string GetLuongHopDong (string MaNV)
        {
            try
            {
                conn.Open();
                string query = "SELECT LuongCoBan * HeSoLuong AS LuongHopDong FROM HopDong WHERE MaNV=@MaNV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", MaNV);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return reader["LuongHopDong"].ToString();
                }
                else
                {
                    return null;
                }
            }
            catch { return null; }
            finally { conn.Close(); }
        }

        public bool DeleteData(int id)
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM TangCa WHERE MaTangCa=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public bool EditData(int MaTangCa, DateTime NgayTangCa, int MaNV, int MaLoaiCa, double SoGio, double HeSo, double SoTien, string GhiChu)
        {
            try
            {
                conn.Open();
                string query = "UPDATE TangCa " +
                    "SET MaNV=@MaNV, NgayTangCa=@NgayTangCa, MaLoaiCa=@MaLoaiCa, SoGio=@SoGio, HeSo=@HeSo, SoTien=@SoTien, GhiChu=@GhiChu " +
                    "WHERE MaTangCa=@MaTangCa";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaTangCa", MaTangCa);
                cmd.Parameters.AddWithValue("@MaNV", MaNV);
                cmd.Parameters.AddWithValue("@NgayTangCa", NgayTangCa);
                cmd.Parameters.AddWithValue("@MaLoaiCa", MaLoaiCa);
                cmd.Parameters.AddWithValue("@SoGio", SoGio);
                cmd.Parameters.AddWithValue("@HeSo", HeSo);
                cmd.Parameters.AddWithValue("@SoTien", SoTien);
                cmd.Parameters.AddWithValue("@GhiChu", GhiChu);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public bool AddData(DateTime NgayTangCa, int MaNV, int MaLoaiCa, double SoGio, double HeSo, double SoTien, string GhiChu)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO TangCa (NgayTangCa, MaNV, MaLoaiCa, SoGio, HeSo, SoTien, GhiChu) " +
                    "VALUES (@NgayTangCa, @MaNV, @MaLoaiCa, @SoGio, @HeSo, @SoTien, @GhiChu)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", MaNV);
                cmd.Parameters.AddWithValue("@NgayTangCa", NgayTangCa);
                cmd.Parameters.AddWithValue("@MaLoaiCa", MaLoaiCa);
                cmd.Parameters.AddWithValue("@SoGio", SoGio);
                cmd.Parameters.AddWithValue("@HeSo", HeSo);
                cmd.Parameters.AddWithValue("@SoTien", SoTien);
                cmd.Parameters.AddWithValue("@GhiChu", GhiChu);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch { return false; }
            finally { conn.Close(); }
        }
    }
}
