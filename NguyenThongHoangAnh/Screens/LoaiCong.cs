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
    public partial class LoaiCong : Form
    {
        LoaiCongController controller = new LoaiCongController();
        public LoaiCong()
        {
            InitializeComponent();
            LoadForm();
            dataGridView1.CellEnter += DataGridView1_CellEnter;
        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _ = new DataGridViewRow();
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txt_MaLoaiCong.Text = row.Cells["MaLoaiCong"].Value.ToString();
            txt_TenLoaiCong.Text = row.Cells["TenLoaiCong"].Value.ToString();
            cbb_HeSo.Text = row.Cells["HeSo"].Value.ToString();
        }

        void LoadForm()
        {
            bindingSource1.DataSource = controller.GetData();
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1;
            txt_MaLoaiCong.ReadOnly = true;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int MaLoaiCong = int.Parse(txt_MaLoaiCong.Text);
            bool result = controller.DeleteData(MaLoaiCong);

            if (result)
            {
                LoadForm();
                MessageBox.Show("Xoá thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xóa không thành công!", "Lỗi");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            int MaLoaiCong = int.Parse(txt_MaLoaiCong.Text);
            string TenLoaiCong = txt_TenLoaiCong.Text;
            float HeSo = float.Parse(cbb_HeSo.SelectedValue.ToString());

            bool result = controller.EditData(MaLoaiCong, TenLoaiCong, HeSo);

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
    }
}
