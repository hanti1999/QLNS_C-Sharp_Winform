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
    public partial class UngLuong : Form
    {
        FillNhanVien fillCbb = new FillNhanVien();
        UngLuongController controller = new UngLuongController();

        public UngLuong()
        {
            InitializeComponent();
            FormLoad();
        }

        void FormLoad()
        {
            fillCbb.FillCbb(cbb_MaNV);
            bindingSource1.DataSource = controller.GetData();
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1;
            txt_MaUngLuong.ReadOnly = true;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _ = new DataGridViewRow();
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txt_MaUngLuong.Text = row.Cells["MaUngLuong"].Value.ToString();
            cbb_MaNV.Text = row.Cells["HoTen"].Value.ToString();
            dateTimePicker1.Text = row.Cells["NgayGhiPhieu"].Value.ToString();
            dateTimePicker2.Text = row.Cells["NgayUngLuong"].Value.ToString();
            rtxt_GhiChu.Text = row.Cells["GhiChu"].Value.ToString();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int MaUngLuong = int.Parse(txt_MaUngLuong.Text);

            bool result = controller.DeleteData(MaUngLuong);

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

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            int MaUngLuong = int.Parse(txt_MaUngLuong.Text);
            int MaNV = int.Parse(cbb_MaNV.SelectedValue.ToString());
            DateTime NgayGhiPhieu = dateTimePicker1.Value.Date;
            DateTime NgayUngLuong = dateTimePicker2.Value.Date;
            int SoTien = int.Parse(txt_SoTien.Text);
            string GhiChu = rtxt_GhiChu.Text;


        }
    }
}
