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
    internal class KhenThuongController
    {
        CheckResult checkResult = new CheckResult();
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString);
        public DataTable GetData()
        {
            try
            {
                conn.Open();
                string query = "SELECT NV.HoTen, KT.SoQD, KT.NgayQD, KT.LyDo, KT.NoiDung FROM KhenThuong KT INNER JOIN NhanVien NV ON NV.MaNV = KT.MaNV";
                SqlCommand cmd = new SqlCommand(query, conn);
                return checkResult.CheckDataTable(cmd);
            }
            catch { return null; }
            finally { conn.Close(); }
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
            catch { return false; }
            finally { conn.Close(); }
        }

        public bool AddData(int SoQD, DateTime NgayQD, string LyDo, string NoiDung, int MaNV)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO KhenThuong(SoQD, NgayQD, LyDo, NoiDung, MaNV) " +
                    "VALUES (@SoQD, @NgayQD, @LyDo, @NoiDung, @MaNV)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SoQD", SoQD);
                cmd.Parameters.AddWithValue("@NgayQD", NgayQD);
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
                string query = "DELETE FROM KhenThuong WHERE SoQD=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                return checkResult.CheckExecuteNonQuery(cmd);
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public bool EditData(int SoQD, DateTime NgayQD, string LyDo, string NoiDung, int MaNV)
        {
            try
            {
                conn.Open();
                string query = "UPDATE KhenThuong " +
                    "SET NgayQD=@NgayQD, LyDo=@LyDo, NoiDung=@NoiDung, MaNV=@MaNV " +
                    "WHERE SoQD=@SoQD";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SoQD", SoQD);
                cmd.Parameters.AddWithValue("@NgayQD", NgayQD);
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
