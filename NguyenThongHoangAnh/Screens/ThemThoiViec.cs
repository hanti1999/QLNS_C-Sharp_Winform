using NguyenThongHoangAnh.Controllers;
using NguyenThongHoangAnh.utils;
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
    public partial class ThemThoiViec : Form
    {
        ThoiViecController controller = new ThoiViecController();
        FillCombobox fillCbb = new FillCombobox();

        public ThemThoiViec()
        {
            InitializeComponent();
            FormLoad();
            btn_Them.Click += Btn_Them_Click;
        }

        private void Btn_Them_Click(object sender, EventArgs e)
        {
            int SoQD = int.Parse(txt_soQD.Text);
            DateTime NgayNopDon = dateTimePicker1.Value.Date;
            DateTime NgayNghi = dateTimePicker2.Value.Date;
            int MaNV = int.Parse(cbb_nhanVien.SelectedValue.ToString());
            string LyDo = rtxt_lyDo.Text;
            string GhiChu = rtxt_ghiChu.Text;
            themEvent(SoQD, NgayNopDon, NgayNghi, LyDo, GhiChu, MaNV);
            this.Close();
        }

        public delegate void them(int SoQD, DateTime NgayNopDon, DateTime NgayNghi, string LyDo, string GhiChu, int MaNV);
        public event them themEvent;

        void FormLoad ()
        {
            fillCbb.FillCbb("SELECT * FROM NhanVien NV WHERE NV.MaNV NOT IN (SELECT TV.MaNV FROM ThoiViec TV)", "MaNV", "HoTen", cbb_nhanVien);
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(45);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(45);
        }
    }
}
