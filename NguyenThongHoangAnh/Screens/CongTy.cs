using NguyenThongHoangAnh.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenThongHoangAnh.Screens
{
    public partial class CongTy : Form
    {
        CongTyController companyController;
        public CongTy()
        {
            InitializeComponent();
            companyController = new CongTyController();
        }

        private void LoadData()
        {
            dataGridView1.DataSource = companyController.GetCompany();
        }

        private void Company_Load(object sender, EventArgs e)
        {
            txt_MaCTY.ReadOnly = true;
            txt_TenCTY.Focus();
            LoadData();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            txt_MaCTY.Text = Convert.ToString(row.Cells[0].Value);
            txt_TenCTY.Text = Convert.ToString(row.Cells[1].Value);
            txt_DienThoai.Text = Convert.ToString(row.Cells[2].Value);
            txt_email.Text = Convert.ToString(row.Cells[3].Value);
            txt_DiaChi.Text = Convert.ToString(row.Cells[4].Value);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string str = txt_TenCTY.Text;
            string str2 = txt_DienThoai.Text;
            string str3 = txt_email.Text;
            string str4 = txt_DiaChi.Text;

            bool result = companyController.AddCompany(str, str2, str3, str4);
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult submit = MessageBox.Show("Bạn có chắc muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (submit == DialogResult.Yes)
            {
                string id = txt_MaCTY.Text;

                bool result = companyController.DeleteCompany(id);
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
            string id = txt_MaCTY.Text;
            string str = txt_TenCTY.Text;
            string str2 = txt_DienThoai.Text;
            string str3 = txt_email.Text;
            string str4 = txt_DiaChi.Text;

            bool result = companyController.EditCompany(id, str, str2, str3, str4);

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
    }
}
