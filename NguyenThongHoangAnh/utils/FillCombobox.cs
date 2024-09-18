using NguyenThongHoangAnh.Controllers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenThongHoangAnh.utils
{
    internal class FillCombobox
    {
        CheckResult checkResult = new CheckResult();
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString);

        public bool FillCbb(string sqlString, string Ma, string Ten, ComboBox cbo)
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
    }
}
