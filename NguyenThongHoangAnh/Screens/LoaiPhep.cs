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
    public partial class LoaiPhep : Form
    {
        LoaiPhepController controller = new LoaiPhepController();
        public LoaiPhep()
        {
            InitializeComponent();
            LoadForm();
        }

        void LoadForm()
        {
            bindingSource1.DataSource = controller.GetData();
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _ = new DataGridViewRow();
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txt_MaLoaiPhep.Text = row.Cells["MaLoaiPhep"].Value.ToString();
            txt_TenLoaiPhep.Text = row.Cells["TenLoaiPhep"].Value.ToString();
            txt_HeSo.Text = row.Cells["HeSo"].Value.ToString();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int MaLoaiPhep = int.Parse(txt_MaLoaiPhep.Text);
            bool result = controller.DeleteData(MaLoaiPhep);

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
            int MaLoaiPhep = int.Parse(txt_MaLoaiPhep.Text);
            string TenLoaiPhep = txt_TenLoaiPhep.Text;
            float HeSo = float.Parse(txt_HeSo.Text);

            bool result = controller.EditData(MaLoaiPhep, TenLoaiPhep, HeSo);

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

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ThemLoaiPhep them  = new ThemLoaiPhep();
            them.themEvent += Them_themEvent;
            them.ShowDialog();  
        }

        private void Them_themEvent(string TenLoaiPhep, float HeSo)
        {
            bool result = controller.AddData(TenLoaiPhep, HeSo);

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
    }
}
