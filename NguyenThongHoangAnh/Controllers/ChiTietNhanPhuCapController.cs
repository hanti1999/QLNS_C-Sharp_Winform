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
    internal class ChiTietNhanPhuCapController
    {
        CheckResult checkResult = new CheckResult();
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString);

        public DataTable GetData()
        {
            try
            {
                conn.Open();
                string query = "SELECT CT.MaCTPC, NV.MaNV, NV.HoTen, PC.TenPhuCap, PC.SoTien, CT.NgayGhiPhieu, CT.NgayNhanPhuCap, CT.GhiChu FROM ChiTietNhanPhuCap CT JOIN NhanVien NV ON CT.MaNV = NV.MaNV JOIN PhuCap PC ON CT.MaPhuCap = PC.MaPhuCap";
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
                string query = "DELETE FROM ChiTietNhanPhuCap WHERE MaCTPC=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public bool EditData(int MaCTPC, int MaNV, int MaPhuCap, DateTime NgayGhiPhieu, DateTime NgayNhanPhuCap, string GhiChu)
        {
            try
            {
                conn.Open();
                string query = "UPDATE ChiTietNhanPhuCap " +
                    "SET MaNV=@MaNV, MaPhuCap=@MaPhuCap, NgayGhiPhieu=@NgayGhiPhieu, @NgayNhanPhuCap=@NgayNhanPhuCap, GhiChu=@GhiChu " +
                    "WHERE MaCTPC=@MaCTPC";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaCTPC", MaCTPC);
                cmd.Parameters.AddWithValue("@MaNV", MaNV);
                cmd.Parameters.AddWithValue("@MaPhuCap", MaPhuCap);
                cmd.Parameters.AddWithValue("@NgayGhiPhieu", NgayGhiPhieu);
                cmd.Parameters.AddWithValue("@NgayNhanPhuCap", NgayNhanPhuCap);
                cmd.Parameters.AddWithValue("@GhiChu", GhiChu);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public bool AddData(int MaNV, int MaPhuCap, DateTime NgayGhiPhieu, DateTime NgayNhanPhuCap, string GhiChu)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO ChiTietNhanPhuCap " +
                    "VALUES (@MaNV, @MaPhuCap, @NgayGhiPhieu, @NgayNhanPhuCap, @GhiChu)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", MaNV);
                cmd.Parameters.AddWithValue("@MaPhuCap", MaPhuCap);
                cmd.Parameters.AddWithValue("@NgayGhiPhieu", NgayGhiPhieu);
                cmd.Parameters.AddWithValue("@NgayNhanPhuCap", NgayNhanPhuCap);
                cmd.Parameters.AddWithValue("@GhiChu", GhiChu);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch { return false; }
            finally { conn.Close(); }
        }
    }
}
