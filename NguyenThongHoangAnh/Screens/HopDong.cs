using NguyenThongHoangAnh.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace NguyenThongHoangAnh.Screens
{
    public partial class HopDong : Form
    {
        HopDongController controller = new HopDongController();

        public HopDong()
        {
            InitializeComponent();
            LoadForm();
        }

        void LoadForm()
        {
            bindingSource1.DataSource = controller.GetHopDong();
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1;
            rtxt_content.ReadOnly = true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            ThemHopDong themHopDong = new ThemHopDong();
            themHopDong.ThemEvent += ThemHopDong_ThemEvent;
            themHopDong.ShowDialog();
        }

        private void ThemHopDong_ThemEvent(string SoHD, DateTime NgayKy, DateTime NgayBatDau, DateTime NgayKetThuc, int LanKy, double HeSoLuong, string ThoiGian, string NoiDung, int MaNV)
        {
            bool result = controller.AddData(SoHD, NgayKy, NgayBatDau, NgayKetThuc, LanKy, HeSoLuong, ThoiGian, NoiDung, MaNV);
            if (result)
            {
                LoadForm();
                MessageBox.Show("Thêm thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm không thành công!", "Lỗi");
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            rtxt_content.Clear();
            _ = new DataGridViewRow();
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            // Đưa xml lên richtextbox
            rtxt_content.Rtf = row.Cells["NoiDung"].Value.ToString();
            txt_SoHD.Text = row.Cells["SoHD"].Value.ToString();
            txt_NgayKy.Text = row.Cells["NgayKy"].Value.ToString();
            dateTimePicker1.Text = row.Cells["NgayBatDau"].Value.ToString();
            dateTimePicker2.Text = row.Cells["NgayKetThuc"].Value.ToString();
            cbb_LanKy.Text = row.Cells["LanKy"].Value.ToString();
            cbb_ThoiGian.Text = row.Cells["ThoiGian"].Value.ToString();
            cbb_heSoLuong.Text = row.Cells["HeSoLuong"].Value.ToString();
            cbb_nv.Text = row.Cells["HoTen"].Value.ToString();
        }
    }
}
