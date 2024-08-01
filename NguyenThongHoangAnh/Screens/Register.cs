using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using NguyenThongHoangAnh.Controllers;

namespace NguyenThongHoangAnh.Screens
{
    public partial class Register : Form
    {
        private AuthController auth;
        public Register()
        {
            InitializeComponent();
            auth = new AuthController();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }

        private void picB_showPass_Click(object sender, EventArgs e)
        {
            txt_password.PasswordChar = txt_password.PasswordChar == '*' ? '\0' : '*';
        }

        private void picB_showPass2_Click(object sender, EventArgs e)
        {
            txt_confirmPass.PasswordChar = txt_confirmPass.PasswordChar == '*' ? '\0' : '*';
        }

        private void btn_resgister_Click(object sender, EventArgs e)
        {
            string user = txt_user.Text;
            string password = txt_password.Text;
            string confirm = txt_confirmPass.Text;

            if (password != confirm) {
                lb_error.Visible = true;
                lb_error.Text = "Mật khẩu không trùng khớp";
                return;
            }

            bool result = auth.Register(user, password);

            if (result)
            {
                Login lg = new Login();
                this.Hide();
                lg.Show();
            } else
            {
                lb_error.Visible = true;
                lb_error.Text = "Lỗi! vui lòng thử lại";
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            lb_error.Visible = false;
        }
    }
}
