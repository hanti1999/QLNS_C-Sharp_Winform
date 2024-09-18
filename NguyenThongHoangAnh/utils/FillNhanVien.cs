using NguyenThongHoangAnh.Controllers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NguyenThongHoangAnh.utils
{
    internal class FillNhanVien
    {
        CheckResult checkResult = new CheckResult();
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString);

        public bool FillCbb(ComboBox cbo)
        {
            try
            {
                conn.Open();
                string sql = "SELECT MaNV, HoTen FROM NhanVien NV WHERE NV.MaNV NOT IN (SELECT TV.MaNV FROM ThoiViec TV)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cbo.DataSource = checkResult.CheckDataTable(cmd);
                cbo.DisplayMember = "HoTen";
                cbo.ValueMember = "MaNV";
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
    }
}
