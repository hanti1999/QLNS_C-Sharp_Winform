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
    public partial class ThemKyLuat : Form
    {
        KyLuatController controller = new KyLuatController();

        public ThemKyLuat()
        {
            InitializeComponent();
            FormLoad();
        }

        public delegate void them(int SoQD, DateTime NgayQD, DateTime NgayKetThuc, string LyDo, string NoiDung, int MaNV);
        public event them themEvent;

        void FormLoad()
        {
            controller.FillCombobox("SELECT * FROM NhanVien", "MaNV", "HoTen", cbb_NV);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            int SoQD = int.Parse(txt_SoQD.Text);
            DateTime NgayQD = dtp_ngayQD.Value.Date;
            DateTime NgayKetThuc = dtp_ngayKT.Value.Date;
            string LyDo = rtxt_LyDo.Text;
            string NoiDung = rtxt_NoiDung.Text;
            int MaNV = int.Parse(cbb_NV.SelectedValue.ToString());
            themEvent(SoQD, NgayQD, NgayKetThuc, LyDo, NoiDung, MaNV);
            this.Close();
        }
    }
}
