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
    internal class UngLuongController
    {
        CheckResult checkResult = new CheckResult();
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString);

        public DataTable GetData()
        {
            try
            {
                conn.Open();
                string query = "SELECT UL.MaUngLuong, NV.MaNV, NV.HoTen, UL.NgayGhiPhieu, UL.NgayUngLuong, UL.SoTien, UL.GhiChu FROM UngLuong UL JOIN NhanVien NV ON UL.MaNV = NV.MaNV";
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
                string query = "DELETE FROM UngLuong WHERE MaUngLuong=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public bool EditData(int MaUngLuong, int MaNV, DateTime NgayGhiPhieu, DateTime NgayUngLuong, int SoTien, string GhiChu)
        {
            try
            {
                conn.Open();
                string query = "UPDATE ChiTietNhanPhuCap " +
                    "SET MaNV=@MaNV, NgayGhiPhieu=@NgayGhiPhieu, @NgayUngLuong=@NgayUngLuong, SoTien=@SoTien, GhiChu=@GhiChu " +
                    "WHERE MaUngLuong=@MaUngLuong";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaUngLuong", MaUngLuong);
                cmd.Parameters.AddWithValue("@MaNV", MaNV);
                cmd.Parameters.AddWithValue("@NgayGhiPhieu", NgayGhiPhieu);
                cmd.Parameters.AddWithValue("@NgayUngLuong", NgayUngLuong);
                cmd.Parameters.AddWithValue("@SoTien", SoTien);
                cmd.Parameters.AddWithValue("@GhiChu", GhiChu);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public bool AddData(int MaNV, DateTime NgayGhiPhieu, DateTime NgayUngLuong, int SoTien, string GhiChu)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO ChiTietNhanPhuCap " +
                    "VALUES (@MaNV, @NgayGhiPhieu, @NgayUngLuong, @SoTien, @GhiChu)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", MaNV);
                cmd.Parameters.AddWithValue("@NgayGhiPhieu", NgayGhiPhieu);
                cmd.Parameters.AddWithValue("@NgayUngLuong", NgayUngLuong);
                cmd.Parameters.AddWithValue("@SoTien", SoTien);
                cmd.Parameters.AddWithValue("@GhiChu", GhiChu);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch { return false; }
            finally { conn.Close(); }
        }
    }
}
