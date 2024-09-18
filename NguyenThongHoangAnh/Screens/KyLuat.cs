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
    public partial class KyLuat : Form
    {
        KyLuatController KyLuatController = new KyLuatController();
        FillCombobox FillCbb = new FillCombobox();
        public KyLuat()
        {
            InitializeComponent();
            LoadForm();
            dataGridView1.CellEnter += DataGridView1_CellEnter;
        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            rtxt_LyDo.Clear();
            rtxt_NoiDung.Clear();
            _ = new DataGridViewRow();
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txt_SoQD.Text = row.Cells["SoQD"].Value.ToString();
            dtp_ngayQD.Text = row.Cells["NgayQD"].Value.ToString();
            dtp_ngayKT.Text = row.Cells["NgayKetThuc"].Value.ToString();
            cbb_NV.Text = row.Cells["HoTen"].Value.ToString();
            rtxt_LyDo.Text = row.Cells["LyDo"].Value.ToString();
            rtxt_NoiDung.Text = row.Cells["NoiDung"].Value.ToString();
        }

        void LoadForm()
        {
            FillCbb.FillCbb("SELECT * FROM NhanVien NV WHERE NV.MaNV NOT IN (SELECT TV.MaNV FROM ThoiViec TV)", "MaNV", "HoTen", cbb_NV);
            bindingSource1.DataSource = KyLuatController.GetData();
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1;
        }


        private void btn_them_Click(object sender, EventArgs e)
        {
            ThemKyLuat th = new ThemKyLuat();
            th.themEvent += Th_themEvent;
            th.ShowDialog();
        }

        private void Th_themEvent(int SoQD, DateTime NgayQD, DateTime NgayKetThuc, string LyDo, string NoiDung, int MaNV)
        {
            bool result = KyLuatController.AddData(SoQD, NgayQD, NgayKetThuc, LyDo, NoiDung, MaNV);

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

        private void btn_sua_Click(object sender, EventArgs e)
        {
            int SoQD = int.Parse(txt_SoQD.Text);
            DateTime NgayQD = dtp_ngayQD.Value.Date;
            DateTime NgayKetThuc = dtp_ngayKT.Value.Date;
            string LyDo = rtxt_LyDo.Text;
            string NoiDung = rtxt_NoiDung.Text;
            int MaNV = int.Parse(cbb_NV.SelectedValue.ToString());

            bool result = KyLuatController.EditData(SoQD, NgayQD, NgayKetThuc, LyDo, NoiDung, MaNV);

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

            bool result = KyLuatController.DeleteData(SoQD);
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
