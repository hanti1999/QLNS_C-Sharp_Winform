using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NguyenThongHoangAnh.Controllers
{
    internal class AuthController
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString);
        CheckResult checkResult = new CheckResult();
        public bool Login(string user, string password)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TaiKhoan WHERE TaiKhoan=@username AND MatKhau=@password", conn);
                cmd.Parameters.AddWithValue("@Username", user);
                cmd.Parameters.AddWithValue("@Password", password);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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

        public bool Register(string user, string password)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO TaiKhoan VALUES(@user, @password)", conn);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@user", user);
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

        public bool ResetPass(string user, string newPass)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE TaiKhoan SET MatKhau = @newPass WHERE TaiKhoan = @user", conn);
                cmd.Parameters.AddWithValue("@newPass", newPass);
                cmd.Parameters.AddWithValue("@user", user);
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
    }
}
