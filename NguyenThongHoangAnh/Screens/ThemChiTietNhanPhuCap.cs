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
    public partial class ThemChiTietNhanPhuCap : Form
    {
        FillNhanVien fillCbb = new FillNhanVien();
        FillCombobox fillCombobox = new FillCombobox();
        ChiTietNhanPhuCapController controller = new ChiTietNhanPhuCapController();

        public ThemChiTietNhanPhuCap()
        {
            InitializeComponent();
            FormLoad();
        }

        public delegate void them(int MaNV, int MaChuCap, DateTime NgayGhiPhieu, DateTime NgayNhanPhuCap, string GhiChu);
        public event them themEvent;

        void FormLoad ()
        {
            fillCbb.FillCbb(cbb_MaNV);
            fillCombobox.FillCbb("SELECT * FROM PhuCap", "MaPhuCap", "TenPhuCap", cbb_MaPhuCap);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            int MaNV = int.Parse(cbb_MaNV.SelectedValue.ToString());
            int MaPhuCap = int.Parse(cbb_MaPhuCap.SelectedValue.ToString());
            DateTime NgayGhiPhieu = dateTimePicker1.Value.Date;
            DateTime NgayNhanPhuCap = dateTimePicker2.Value.Date;
            string GhiChu = rtxt_GhiChu.Text;
            themEvent(MaNV, MaPhuCap, NgayGhiPhieu, NgayNhanPhuCap, GhiChu);
            this.Close();
        }
    }
}
