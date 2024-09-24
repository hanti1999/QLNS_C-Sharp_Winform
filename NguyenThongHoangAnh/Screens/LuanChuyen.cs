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
    public partial class LuanChuyen : Form
    {
        LuanChuyenController controller = new LuanChuyenController();
        FillCombobox FillCbb = new FillCombobox();

        public LuanChuyen()
        {
            InitializeComponent();
            FormLoad();
        }

        void FormLoad()
        {
            FillCbb.FillCbb("SELECT * FROM NhanVien NV WHERE NV.MaNV NOT IN (SELECT TV.MaNV FROM ThoiViec TV)", "MaNV", "HoTen", cbb_nhanVien);
            FillCbb.FillCbb("SELECT * FROM PhongBan", "MaPB", "TenPB", cbb_PBMoi);
            FillCbb.FillCbb("SELECT * FROM PhongBan", "MaPB", "TenPB", cbb_PBCu);
            bindingSource1.DataSource = controller.GetData();
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1;
            cbb_PBCu.Enabled = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            ThemLuanChuyen them = new ThemLuanChuyen();
            them.themEvent += Them_themEvent;
            them.ShowDialog();
        }

        private void Them_themEvent(int SoQD, DateTime NgayQD, int PBCu, int PBMoi, string LyDo, string GhiChu, int MaNV)
        {
            bool result = controller.AddData(SoQD, NgayQD, PBCu, PBMoi, LyDo, GhiChu, MaNV);

            if (result)
            {
                FormLoad();
                MessageBox.Show("Thêm thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm không thành công!", "Lỗi");
            }

            bool update = controller.UpdateNV(PBMoi, MaNV);

            if (update)
            {
                FormLoad();
                MessageBox.Show("Thay đổi thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thay đổi không thành công!", "Lỗi");
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            rtxt_lyDo.Clear();
            rtxt_ghiChu.Clear();
            _ = new DataGridViewRow();
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txt_soQD.Text = row.Cells["SoQD"].Value.ToString();
            dateTimePicker1.Text = row.Cells["NgayQD"].Value.ToString();
            cbb_nhanVien.Text = row.Cells["HoTen"].Value.ToString();
            cbb_PBCu.Text = row.Cells["PBCu"].Value.ToString();
            cbb_PBMoi.Text = row.Cells["PBMoi"].Value.ToString();
            rtxt_ghiChu.Text = row.Cells["GhiChu"].Value.ToString();
            rtxt_lyDo.Text = row.Cells["LyDo"].Value.ToString();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int MaNV = int.Parse(cbb_nhanVien.SelectedValue.ToString());
            int PBCu = int.Parse(cbb_PBCu.SelectedValue.ToString());
            bool update = controller.UpdateNV(PBCu, MaNV);

            if (update)
            {
                FormLoad();
                MessageBox.Show("Thay đổi thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thay đổi không thành công!", "Lỗi");
            }
            //
            int SoQD = int.Parse(txt_soQD.Text);
            bool result = controller.DeleteData(SoQD);

            if (result)
            {
                FormLoad();
                MessageBox.Show("Xoá thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xóa không thành công!", "Lỗi");
            }            
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            int SoQD = int.Parse(txt_soQD.Text);
            DateTime NgayQD = dateTimePicker1.Value.Date;
            int PBMoi = int.Parse(cbb_PBMoi.SelectedValue.ToString());
            int MaNV = int.Parse(cbb_nhanVien.SelectedValue.ToString());
            string LyDo = rtxt_lyDo.Text;
            string GhiChu = rtxt_ghiChu.Text;

            bool result = controller.EditData(SoQD, NgayQD, PBMoi, LyDo, GhiChu, MaNV);
            if (result)
            {
                FormLoad();
                MessageBox.Show("Sửa thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Sửa không thành công!", "Lỗi");
            }

            bool update = controller.UpdateNV(PBMoi, MaNV);

            if (update)
            {
                FormLoad();
                MessageBox.Show("Thay đổi thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thay đổi không thành công!", "Lỗi");
            }
        }
    }
}