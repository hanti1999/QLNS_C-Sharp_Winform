using NguyenThongHoangAnh.Controllers;
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
        public ThemLuanChuyen()
        {
            InitializeComponent();
            FormLoad();
            btn_them.Click += Btn_them_Click;
        }

        public delegate void them(int SoQD, DateTime NgayQD, int MaNV, int PBCu, int PBMoi, string LyDo, string GhiChu);
        public event them themEvent;

        private void Btn_them_Click(object sender, EventArgs e)
        {
            int SoQD = int.Parse(txt_soQD.Text);
            DateTime NgayQD = dateTimePicker1.Value.Date;
            int MaNV = int.Parse(cbb_nhanVien.SelectedValue.ToString());
            int PBCu = int.Parse(txt_PBCu.Text);
            int PBMoi = int.Parse(cbb_PBMoi.SelectedValue.ToString());
            string LyDo = rtxt_lyDo.Text;
            string GhiChu = rtxt_ghiChu.Text;
            themEvent(SoQD, NgayQD, MaNV, PBCu, PBMoi, LyDo, GhiChu);
            this.Close();
        }        

        void FormLoad()
        {
            controller.FillCombobox("SELECT * FROM NhanVien", "MaNV", "HoTen", cbb_nhanVien);
            controller.FillCombobox("SELECT * FROM PhongBan", "MaPB", "TenPB", cbb_PBMoi);
        }
    }
}
