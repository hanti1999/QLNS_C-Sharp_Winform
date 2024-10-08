﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace NguyenThongHoangAnh.Controllers
{
    internal class HopDongController
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString);
        CheckResult checkResult = new CheckResult();
        public bool AddData(string SoHD, DateTime NgayKy, DateTime NgayBatDau, DateTime NgayKetThuc, int LanKy, double HeSoLuong, double LuongCoBan, string ThoiGian, string NoiDung, int MaNV)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO HopDong(SoHD, NgayKy, NgayBatDau, NgayKetThuc, LanKy, ThoiGian, HeSoLuong, LuongCoBan, NoiDung, MaNV) " +
                    "VALUES (@SoHD, @NgayKy, @NgayBatDau, @NgayKetThuc, @LanKy, @ThoiGian, @HeSoLuong, @LuongCoBan, @NoiDung, @MaNV)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SoHD", SoHD);
                cmd.Parameters.AddWithValue("@NgayKy", NgayKy);
                cmd.Parameters.AddWithValue("@NgayBatDau", NgayBatDau);
                cmd.Parameters.AddWithValue("@NgayKetThuc", NgayKetThuc);
                cmd.Parameters.AddWithValue("@LanKy", LanKy);
                cmd.Parameters.AddWithValue("@ThoiGian", ThoiGian);
                cmd.Parameters.AddWithValue("@HeSoLuong", HeSoLuong);
                cmd.Parameters.AddWithValue("@LuongCoBan", LuongCoBan);
                cmd.Parameters.AddWithValue("@NoiDung", NoiDung);
                cmd.Parameters.AddWithValue("@MaNV", MaNV);

                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch
            {
                return false;
            } finally
            {
                conn.Close();
            }
        }

        public DataTable GetHopDong ()
        {
            try
            {
                conn.Open();
                string query = "SELECT HD.SoHD, HD.NgayKy, HD.NgayBatDau, HD.NgayKetThuc, HD.LanKy, HD.ThoiGian, HD.HeSoLuong, HD.LuongCoBan, HD.NoiDung, NV.HoTen FROM HopDong HD INNER JOIN NhanVien NV ON NV.MaNV = HD.MaNV";
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
    }
}
