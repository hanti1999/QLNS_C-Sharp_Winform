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
    public partial class ThoiViec : Form
    {
        ThoiViecController controller = new ThoiViecController();
        FillCombobox fillCbb = new FillCombobox();

        public ThoiViec()
        {
            InitializeComponent();
            dataGridView1.CellEnter += DataGridView1_CellEnter;
            FormLoad();
        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            rtxt_lyDo.Clear();
            rtxt_ghiChu.Clear();
            _ = new DataGridViewRow();
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txt_soQD.Text = row.Cells["SoQD"].Value.ToString();
            dateTimePicker1.Text = row.Cells["NgayNopDon"].Value.ToString();
            dateTimePicker2.Text = row.Cells["NgayNghi"].Value.ToString();
            cbb_nhanVien.Text = row.Cells["HoTen"].Value.ToString();
            rtxt_ghiChu.Text = row.Cells["GhiChu"].Value.ToString();
            rtxt_lyDo.Text = row.Cells["LyDo"].Value.ToString();
        }

        void FormLoad ()
        {
            fillCbb.FillCbb("SELECT * FROM NhanVien NV WHERE NV.MaNV NOT IN (SELECT TV.MaNV FROM ThoiViec TV)", "MaNV", "HoTen", cbb_nhanVien);
            txt_soQD.ReadOnly = true;
            bindingSource1.DataSource = controller.GetData();
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            int SoQD = int.Parse(txt_soQD.Text);
            DateTime NgayNopDon = dateTimePicker1.Value.Date;
            DateTime NgayNghi = dateTimePicker2.Value.Date;
            int MaNV = int.Parse(cbb_nhanVien.SelectedValue.ToString());
            string LyDo = rtxt_lyDo.Text;
            string GhiChu = rtxt_ghiChu.Text;

            bool result = controller.EditData(SoQD, NgayNopDon, NgayNghi, LyDo, GhiChu, MaNV);

            if (result)
            {
                FormLoad();
                MessageBox.Show("Sửa thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Sửa không thành công!", "Lỗi");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
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

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ThemThoiViec them = new ThemThoiViec();
            them.themEvent += Them_themEvent;
            them.Show();
        }

        private void Them_themEvent(int SoQD, DateTime NgayNopDon, DateTime NgayNghi, string LyDo, string GhiChu, int MaNV)
        {
            bool result = controller.AddData(SoQD, NgayNopDon, NgayNghi, LyDo, GhiChu, MaNV);

            if (result)
            {
                FormLoad();
                MessageBox.Show("Thêm thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm không thành công!", "Lỗi");
            }
        }
    }
}
