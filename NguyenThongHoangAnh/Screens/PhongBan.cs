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
    public partial class PhongBan : Form
    {
        PhongBanController dep;
        public PhongBan()
        {
            InitializeComponent();
            dep = new PhongBanController();
        }

        private void LoadData()
        {
            dataGridView1.DataSource = dep.GetDepartment();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string str = txt_TenPB.Text;

            bool result = dep.AddDepartment(str);
            if (result)
            {
                LoadData();
                MessageBox.Show("Thêm thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm không thành công!", "Lỗi");
            }
        }

        private void Department_Load(object sender, EventArgs e)
        {
            LoadData();
            txt_MaPB.ReadOnly = true;
            txt_TenPB.Focus();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult submit = MessageBox.Show("Bạn có chắc muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (submit == DialogResult.Yes)
            {
                string id = txt_MaPB.Text;

                bool result = dep.DeleteDepartment(id);
                if (result)
                {
                    LoadData();
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
            string id = txt_MaPB.Text;
            string str = txt_TenPB.Text;

            bool result = dep.EditDepartment(id, str);

            if (result)
            {
                LoadData();
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
            txt_MaPB.Text = Convert.ToString(row.Cells[0].Value);
            txt_TenPB.Text = Convert.ToString(row.Cells[1].Value);
        }
    }
}
