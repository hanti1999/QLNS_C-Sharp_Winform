using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenThongHoangAnh.Controllers
{
    internal class NhanVienController
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString);
        CheckResult checkResult = new CheckResult();

        public DataTable GetStaff()
        {
            try
            {
                conn.Open();
                string query = "SELECT NV.MaNV, DT.TenDT, TG.TenTG, TD.TenTD, PB.TenPB, CV.TenCV, CTY.TenCTY, NV.HoTen, NV.GioiTinh, NV.NgaySinh, NV.DiaChi, NV.CCCD, NV.QueQuan, NV.NoiOHienTai, NV.DienThoai, NV.HinhAnh  " +
                    "FROM NhanVien NV " +
                    "INNER JOIN DanToc DT ON NV.MaDT = DT.MaDT " +
                    "INNER JOIN TonGiao TG ON NV.MaTG = TG.MaTG " +
                    "INNER JOIN TrinhDo TD ON NV.MaTD = TD.MaTD " +
                    "INNER JOIN PhongBan PB ON NV.MaPB = PB.MaPB " +
                    "INNER JOIN ChucVu CV ON NV.MaCV = CV.MaCV " +
                    "INNER JOIN CongTy CTY ON NV.MaCTY = CTY.MaCTY";
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
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool AddStaff (int MaDT, int MaTG, int MaTD, int MaPB, int MaCV, int MaCTY, string HoTen, int GioiTinh, DateTime NgaySinh, string DiaChi, string CCCD, string QueQuan, string NoiOHienTai, string DienThoai, byte[] HinhAnh)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO NhanVien(MaDT, MaTG, MaTD, MaPB, MaCV, MaCTY, HoTen, GioiTinh, NgaySinh, DiaChi, CCCD, QueQuan, NoiOHienTai, DienThoai, HinhAnh) " +
                    "VALUES (@MaDT, @MaTG, @MaTD, @MaPB, @MaCV, @MaCTY, @HoTen, @GioiTinh, @NgaySinh, @DiaChi, @CCCD, @QueQuan, @NoiOHienTai, @DienThoai, @HinhAnh)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaDT", MaDT);
                cmd.Parameters.AddWithValue("@MaTG", MaTG);
                cmd.Parameters.AddWithValue("@MaTD", MaTD);
                cmd.Parameters.AddWithValue("@MaPB", MaPB);
                cmd.Parameters.AddWithValue("@MaCV", MaCV);
                cmd.Parameters.AddWithValue("@MaCTY", MaCTY);
                cmd.Parameters.AddWithValue("@HoTen", HoTen);
                cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
                cmd.Parameters.AddWithValue("@CCCD", CCCD);
                cmd.Parameters.AddWithValue("@QueQuan", QueQuan);
                cmd.Parameters.AddWithValue("@NoiOHienTai", NoiOHienTai);
                cmd.Parameters.AddWithValue("@DienThoai", DienThoai);
                cmd.Parameters.AddWithValue("@HinhAnh", HinhAnh);

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

        public bool DeleteStaff (string id)
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM NhanVien WHERE MaNV=@id";
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
                conn.Close ();
            }
        }

        public bool EditStaff (int MaNV, int MaDT, int MaTG, int MaTD, int MaPB, int MaCV, int MaCTY, string HoTen, int GioiTinh, DateTime NgaySinh, string DiaChi, string CCCD, string QueQuan, string NoiOHienTai, string DienThoai, byte[] HinhAnh) {
            try
            {
                conn.Open();
                string query = "UPDATE NhanVien " +
                    "SET MaDT=@MaDT, MaTG=@MaTG, MaTD=@MaTD, MaPB=@MaPB, MaCV=@MaCV,MaCTY=@MaCTY, HoTen=@HoTen, GioiTinh=@GioiTinh, NgaySinh=@NgaySinh, DiaChi=@DiaChi, CCCD=@CCCD, QueQuan=@QueQuan, NoiOHienTai=@NoiOHienTai, DienThoai=@DienThoai, HinhAnh=@HinhAnh " +
                    "WHERE MaNV=@MaNV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", MaNV);
                cmd.Parameters.AddWithValue("@MaDT", MaDT);
                cmd.Parameters.AddWithValue("@MaTG", MaTG);
                cmd.Parameters.AddWithValue("@MaTD", MaTD);
                cmd.Parameters.AddWithValue("@MaPB", MaPB);
                cmd.Parameters.AddWithValue("@MaCV", MaCV);
                cmd.Parameters.AddWithValue("@MaCTY", MaCTY);
                cmd.Parameters.AddWithValue("@HoTen", HoTen);
                cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
                cmd.Parameters.AddWithValue("@CCCD", CCCD);
                cmd.Parameters.AddWithValue("@QueQuan", QueQuan);
                cmd.Parameters.AddWithValue("@NoiOHienTai", NoiOHienTai);
                cmd.Parameters.AddWithValue("@DienThoai", DienThoai);
                cmd.Parameters.AddWithValue("@HinhAnh", HinhAnh);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch { return false; }
            finally { conn.Close(); }
        }
    }
}
