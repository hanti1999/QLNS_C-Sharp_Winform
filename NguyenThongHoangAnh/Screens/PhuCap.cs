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
    public partial class PhuCap : Form
    {
        public PhuCap()
        {
            InitializeComponent();
            LoadForm();
        }

        PhuCapController controller = new PhuCapController();

        void LoadForm()
        {
            bindingSource1.DataSource = controller.GetData();
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1;
            txt_MaPhuCap.ReadOnly = true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ThemPhuCap them = new ThemPhuCap();
            them.themEvent += Them_themEvent;
            them.Show();
        }

        private void Them_themEvent(string TenPhuCap, float SoTien)
        {
            bool result = controller.AddData(TenPhuCap, SoTien);

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

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int MaPhuCap = int.Parse(txt_MaPhuCap.Text);
            bool result = controller.DeleteData(MaPhuCap);

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
            int MaPhuCap = int.Parse(txt_MaPhuCap.Text);
            string TenPhuCap = txt_TenPhuCap.Text;
            float SoTien = float.Parse(txt_SoTien.Text);

            bool result = controller.EditData(MaPhuCap, TenPhuCap, SoTien);

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

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _ = new DataGridViewRow();
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txt_MaPhuCap.Text = row.Cells["MaPhuCap"].Value.ToString();
            txt_TenPhuCap.Text = row.Cells["TenPhuCap"].Value.ToString();
            txt_SoTien.Text = row.Cells["SoTien"].Value.ToString();
        }

        private void txt_SoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }   
}
