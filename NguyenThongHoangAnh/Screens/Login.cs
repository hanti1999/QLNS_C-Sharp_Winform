using NguyenThongHoangAnh.Screens;
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
using System.Net.Http.Headers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using NguyenThongHoangAnh.Controllers;

namespace NguyenThongHoangAnh
{
    public partial class Login : Form
    {
        private AuthController auth;
        public Login()
        {
            InitializeComponent();
            auth = new AuthController();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register rs = new Register();
            this.Hide();
            rs.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string user = txt_user.Text;
            string password = txt_password.Text;
            bool result = auth.Login(user, password);

            if (result)
            {
                Main main = new Main(user, password);
                main.Show();
                this.Hide();
            } else
            {
                lb_error.Visible = true;
                lb_error.Text = "Lỗi! vui lòng thử lại";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txt_password.PasswordChar = txt_password.PasswordChar == '*' ? '\0' : '*' ;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lb_error.Visible = false;
            txt_user.Text = "admin";
            txt_password.Text = "admin";
        }
    }
}
