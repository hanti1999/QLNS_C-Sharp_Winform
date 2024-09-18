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
    public partial class ThemLuanChuyen : Form
    {
        LuanChuyenController controller = new LuanChuyenController();
        FillCombobox FillCbb = new FillCombobox();
        public ThemLuanChuyen()
        {
            InitializeComponent();
            FormLoad();
            btn_them.Click += Btn_them_Click;
        }

        public delegate void them(int SoQD, DateTime NgayQD, int PBCu, int PBMoi, string LyDo, string GhiChu, int MaNV);
        public event them themEvent;

        private void Btn_them_Click(object sender, EventArgs e)
        {
            int SoQD = int.Parse(txt_soQD.Text);
            DateTime NgayQD = dateTimePicker1.Value.Date;
            int MaNV = int.Parse(cbb_nhanVien.SelectedValue.ToString());
            int PBCu = int.Parse(controller.GetOldPB(MaNV));
            int PBMoi = int.Parse(cbb_PBMoi.SelectedValue.ToString());
            string LyDo = rtxt_lyDo.Text;
            string GhiChu = rtxt_ghiChu.Text;
            themEvent(SoQD, NgayQD, PBCu, PBMoi, LyDo, GhiChu, MaNV);
            this.Close();
        }        

        void FormLoad()
        {
            FillCbb.FillCbb("SELECT * FROM NhanVien NV WHERE NV.MaNV NOT IN (SELECT TV.MaNV FROM ThoiViec TV)", "MaNV", "HoTen", cbb_nhanVien);
            FillCbb.FillCbb("SELECT * FROM PhongBan", "MaPB", "TenPB", cbb_PBMoi);
        }
    }
}
