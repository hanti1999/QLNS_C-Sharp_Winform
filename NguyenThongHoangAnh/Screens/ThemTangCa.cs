using NguyenThongHoangAnh.Controllers;
using NguyenThongHoangAnh.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenThongHoangAnh.Screens
{
    public partial class ThemTangCa : Form
    {
        FillNhanVien fillCbb = new FillNhanVien();
        FillCombobox fillCombobox = new FillCombobox();
        TangCaController controller = new TangCaController();
        private double SoTien;
        public ThemTangCa()
        {
            InitializeComponent();
            FormLoad();
        }

        public delegate void them(DateTime NgayTangCa, int MaNV, int MaLoaiCa, double SoGio, double HeSo, double SoTien, string GhiChu);
        public event them themEvent;

        void FormLoad ()
        {
            fillCbb.FillCbb(cbb_MaNV);
            fillCombobox.FillCbb("SELECT * FROM LoaiCa", "MaLoaiCa", "TenLoaiCa", cbb_MaLoaiCa);
            txt_SoTien.ReadOnly = true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DateTime NgayTangCa = dateTimePicker1.Value.Date;
            int MaNV = int.Parse(cbb_MaNV.SelectedValue.ToString());
            int MaLoaiCa = int.Parse(cbb_MaLoaiCa.SelectedValue.ToString());
            double SoGio = double.Parse(txt_SoGio.Text);
            double HeSo = double.Parse(cbb_HeSo.Text);
            string GhiChu = richTextBox1.Text;
            themEvent(NgayTangCa, MaNV, MaLoaiCa, SoGio, HeSo, SoTien, GhiChu);
            this.Close();
        }

        void AntiText(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_SoGio_KeyPress(object sender, KeyPressEventArgs e)
        {
            AntiText(sender, e);
        }

        private int LuongThucNhan()
        {
            try
            {
                string a = controller.GetLuongHopDong(cbb_MaNV?.SelectedValue.ToString());
                return int.Parse(a) + 1000000;
            } catch
            {
                MessageBox.Show("Vui lòng chọn nhân viên");
                return 0;
            }
                
        }

        private int SoNgayCong (int year, int month)
        {
            int ngayCong = 0;
            DateTime firstDay = new DateTime(year, month, 1);
            DateTime lastDay = firstDay.AddMonths(1).AddDays(-1);

            for (DateTime ngay = firstDay; ngay < lastDay; ngay = ngay.AddDays(1))
            {
                if(ngay.DayOfWeek != DayOfWeek.Saturday && ngay.DayOfWeek != DayOfWeek.Sunday)
                {
                    ngayCong++;
                }
            }
            return ngayCong;
        }

        private void Calculator ()
        {
            int soNgayCong = SoNgayCong(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month);
            int soGio = int.Parse(txt_SoGio.Text);
            double heSo = double.Parse(cbb_HeSo.Text);
            switch (cbb_MaLoaiCa.Text)
            {
                case "Ca sáng":
                    double luongCaSang = LuongThucNhan() / soNgayCong; // Lương theo ngày
                    SoTien = (soGio * ((luongCaSang / 8) * heSo)); // Lương theo giờ
                    txt_SoTien.Text = SoTien.ToString();
                    break;
                case "Ca chiều":
                    double luongCaChieu = LuongThucNhan() / soNgayCong;
                    SoTien = (soGio * ((luongCaChieu / 8) * heSo));
                    txt_SoTien.Text = SoTien.ToString();
                    break;
                case "Ca đêm":
                    double luongCaToi = LuongThucNhan() / soNgayCong * 1.5;
                    SoTien = (soGio * ((luongCaToi / 8) * heSo));
                    txt_SoTien.Text = SoTien.ToString();
                    break;
                default:
                    break;
            }
        }

        private void cbb_MaLoaiCa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculator();
        }

        private void cbb_HeSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculator();
        }

        private void txt_SoGio_TextChanged(object sender, EventArgs e)
        {
            Calculator();
        }
    }
}
