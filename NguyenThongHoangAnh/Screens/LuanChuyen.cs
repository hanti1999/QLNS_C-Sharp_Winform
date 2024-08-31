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
    public partial class LuanChuyen : Form
    {
        LuanChuyenController controller = new LuanChuyenController();

        public LuanChuyen()
        {
            InitializeComponent();
            FormLoad();
        }

        void FormLoad()
        {
            controller.FillCombobox("SELECT * FROM NhanVien", "MaNV", "HoTen", cbb_nhanVien);
            controller.FillCombobox("SELECT * FROM PhongBan", "MaPB", "TenPB", cbb_PBMoi);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            ThemLuanChuyen them = new ThemLuanChuyen();
            them.themEvent += Them_themEvent;
            them.ShowDialog();
        }

        private void Them_themEvent(int SoQD, DateTime NgayQD, int MaNV, int PBCu, int PBMoi, string LyDo, string GhiChu)
        {
            throw new NotImplementedException();
        }               
    }
}
