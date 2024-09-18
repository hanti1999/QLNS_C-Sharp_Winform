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
    public partial class LoaiCa : Form
    {
        LoaiCaController controller = new LoaiCaController();
        FillCombobox FillCbb = new FillCombobox();

        public LoaiCa()
        {
            InitializeComponent();
            LoadForm();
            dataGridView1.CellEnter += DataGridView1_CellEnter;
        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _ = new DataGridViewRow();
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txt_MaLoaiCa.Text = row.Cells["MaLoaiCa"].Value.ToString();
            txt_TenLoaiCa.Text = row.Cells["TenLoaiCa"].Value.ToString();
            cbb_HeSo.Text = row.Cells["HeSo"].Value.ToString();
        }

        void LoadForm()
        {
            bindingSource1.DataSource = controller.GetData();
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1;
            FillCbb.FillCbb("SELECT HeSo FROM LoaiCa", "HeSo", "HeSo", cbb_HeSo);
            txt_MaLoaiCa.ReadOnly = true;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int MaLoaiCa = int.Parse(txt_MaLoaiCa.Text);
            bool result = controller.DeleteData(MaLoaiCa);

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
            int MaLoaiCa = int.Parse(txt_MaLoaiCa.Text);
            string TenLoaiCa = txt_TenLoaiCa.Text;
            float HeSo = float.Parse(cbb_HeSo.SelectedValue.ToString());

            bool result = controller.EditData(MaLoaiCa, TenLoaiCa, HeSo);

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
            ThemLoaiCa them = new ThemLoaiCa();
            them.themEvent += Them_themEvent;
            them.Show();
        }

        private void Them_themEvent(string TenLoaiCa, float HeSo)
        {
            bool result = controller.AddData(TenLoaiCa, HeSo);

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
