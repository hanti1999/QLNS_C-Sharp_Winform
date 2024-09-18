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
    public partial class KhenThuong : Form
    {
        KhenThuongController khenThuong = new KhenThuongController();
        FillCombobox FillCbb = new FillCombobox();

        public KhenThuong()
        {
            InitializeComponent();
            LoadForm();
        }

        void LoadForm()
        {
            FillCbb.FillCbb("SELECT * FROM NhanVien NV WHERE NV.MaNV NOT IN (SELECT TV.MaNV FROM ThoiViec TV)", "MaNV", "HoTen", cbb_NV);
            bindingSource1.DataSource = khenThuong.GetData();
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            ThemKhenThuong themKT = new ThemKhenThuong();
            themKT.themEvent += ThemKT_themEvent;
            themKT.ShowDialog();
        }

        private void ThemKT_themEvent(int SoQD, DateTime NgayQD, string LyDo, string NoiDung, int MaNV)
        {
            bool result = khenThuong.AddData(SoQD, NgayQD, LyDo, NoiDung, MaNV);

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
            rtxt_LyDo.Clear();
            rtxt_NoiDung.Clear();
            _ = new DataGridViewRow();
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txt_SoQD.Text = row.Cells["SoQD"].Value.ToString();
            dateTimePicker1.Text = row.Cells["NgayQD"].Value.ToString();
            cbb_NV.Text = row.Cells["HoTen"].Value.ToString();
            rtxt_LyDo.Text = row.Cells["LyDo"].Value.ToString();
            rtxt_NoiDung.Text = row.Cells["NoiDung"].Value.ToString();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            int SoQD = int.Parse(txt_SoQD.Text);
            DateTime NgayQD = dateTimePicker1.Value.Date;
            string LyDo = rtxt_LyDo.Text;
            string NoiDung = rtxt_NoiDung.Text;
            int MaNV = int.Parse(cbb_NV.SelectedValue.ToString());

            bool result = khenThuong.EditData(SoQD, NgayQD, LyDo, NoiDung, MaNV);

            if (result)
            {
                LoadForm();
                MessageBox.Show("Sửa thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Sửa không thành công!", "Lỗi");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string SoQD = txt_SoQD.Text;

            bool result = khenThuong.DeleteData(SoQD);
            if (result)
            {
                LoadForm();
                MessageBox.Show("Đã xóa thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xóa không thành công!", "Lỗi");
            }
        }
    }
}
