using NguyenThongHoangAnh.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenThongHoangAnh.Screens
{
    public partial class ResetPass : Form
    {
        private AuthController auth;
        string user;
        string password;
        public ResetPass(string user, string password)
        {
            InitializeComponent();
            this.user = user;
            this.password = password;
            auth = new AuthController();
        }

        private void ResetPass_Load(object sender, EventArgs e)
        {
            lb_error.Visible = false;
            txt_user.Text = user;
            txt_password.Text = "Mật khẩu cũ";
            txt_newPass.Text = "Mật khẩu mới";
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            string user = txt_user.Text;
            string password = txt_password.Text;
            string newPass = txt_newPass.Text;

            if(password != this.password)
            {
                lb_error.Visible = true;
                lb_error.Text = "Mật khẩu cũ không đúng";
                return;
            }

            bool result = auth.ResetPass(user, newPass);

            if (result)
            {
                MessageBox.Show("Đổi mật khẩu thành công! vui lòng đăng nhập lại", "Thông báo");
                Application.Exit();
            } else
            {
                lb_error.Visible = true;
                lb_error.Text = "Lỗi! vui lòng thử lại";
            }
        }

        private void picB_showPass_Click(object sender, EventArgs e)
        {
            txt_password.PasswordChar = txt_password.PasswordChar == '*' ? '\0' : '*';
        }

        private void picB_showPass2_Click(object sender, EventArgs e)
        {
            txt_newPass.PasswordChar = txt_newPass.PasswordChar == '*' ? '\0' : '*';
        }
    }
}
