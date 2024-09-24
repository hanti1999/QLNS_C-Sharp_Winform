using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenThongHoangAnh.Screens
{
    public partial class ThemChamCong : Form
    {
        public ThemChamCong()
        {
            InitializeComponent();
        }
        private int khoaCong = 0;

        public delegate void them(int MaKyCong, int Thang, int Nam, DateTime NgayTinhCong, int NgayCongTrongThang, int khoaCong);
        public event them themEvent;

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string MaKyCong = cbb_Thang.Text.ToString() + cbb_Nam.Text.ToString();
            DateTime NgayTinhCong = dtp_NgayTinhCong.Value.Date;
            int Thang = int.Parse(cbb_Thang.Text);
            int Nam = int.Parse(cbb_Nam.Text);
            int NgayCongTrongThang = int.Parse(txt_NgayCongTrongThang.Text);
            if (cb_KhoaCong.Checked == true)
            {
                khoaCong = 1;
            }
            else if (cb_KhoaCong.Checked == false)
            {
                khoaCong = 0;
            }

            themEvent(int.Parse(MaKyCong), Thang, Nam, NgayTinhCong, NgayCongTrongThang, khoaCong);
            this.Close();
        }

        private int SoNgayCong(int year, int month)
        {
            int ngayCong = 0;
            DateTime firstDay = new DateTime(year, month, 1);
            DateTime lastDay = firstDay.AddMonths(1).AddDays(-1);

            for (DateTime ngay = firstDay; ngay < lastDay; ngay = ngay.AddDays(1))
            {
                if (ngay.DayOfWeek != DayOfWeek.Sunday)
                {
                    ngayCong++;
                }
            }
            return ngayCong;
        }

        private void Calculate ()
        {
            int year = int.Parse(cbb_Nam.Text);
            int month = int.Parse(cbb_Thang.Text);
            int SoNgay = SoNgayCong(year, month);
            txt_NgayCongTrongThang.Text = SoNgay.ToString();
        }

        private void cbb_Thang_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void ThemChamCong_Load(object sender, EventArgs e)
        {
            txt_MaKyCong.ReadOnly = true;
            Calculate();
        }

        private void cbb_Nam_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
