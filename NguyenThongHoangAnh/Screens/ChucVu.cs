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
    public partial class ChucVu : Form
    {
        ChucVuController positionController;
        public ChucVu()
        {
            InitializeComponent();
            positionController = new ChucVuController();
        }

        private void LoadPosition ()
        {
            dataGridView1.DataSource = positionController.GetPosition();
        }

        private void Positon_Load(object sender, EventArgs e)
        {
            txt_MaCV.ReadOnly = true;
            txt_TenCV.Focus();
            LoadPosition();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string str = txt_TenCV.Text;

            bool result = positionController.AddPosition(str);
            if (result)
            {
                LoadPosition();
                MessageBox.Show("Thêm thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm không thành công!", "Lỗi");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult submit = MessageBox.Show("Bạn có chắc muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (submit == DialogResult.Yes)
            {
                string id = txt_MaCV.Text;

                bool result = positionController.DeletePositon(id);
                if (result)
                {
                    LoadPosition();
                    MessageBox.Show("Đã xóa thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!", "Lỗi");
                }
            }
            else
            {
                return;
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string id = txt_MaCV.Text;
            string str = txt_TenCV.Text;

            bool result = positionController.EditPositon(id, str);

            if (result)
            {
                LoadPosition();
                MessageBox.Show("Đã sửa thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Sửa không thành công!", "Lỗi");
            }

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            txt_MaCV.Text = Convert.ToString(row.Cells[0].Value);
            txt_TenCV.Text = Convert.ToString(row.Cells[1].Value);
        }
    }
}
