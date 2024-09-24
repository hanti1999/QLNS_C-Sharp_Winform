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
    public partial class BangChamCong : Form
    {
        BangChamCongController controller = new BangChamCongController();
        private int khoaCong;
        public BangChamCong()
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

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int MaKyCong = int.Parse(txt_MaKyCong.Text);
            bool result = controller.DeleteData(MaKyCong);

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

        private void btn_sua_Click(object sender, EventArgs e)
        {
            int MaKyCong = int.Parse(txt_MaKyCong.Text);
            DateTime NgayTinhCong = dtp_NgayTinhCong.Value.Date;
            int Thang = int.Parse(cbb_Thang.SelectedValue.ToString());
            int Nam = int.Parse(cbb_Nam.SelectedValue.ToString());
            int NgayCongTrongThang = int.Parse(txt_NgayCongTrongThang.Text);
            if (cb_KhoaCong.Checked == true)
            {
                khoaCong = 1;
            } else if (cb_KhoaCong.Checked == false) {
                khoaCong = 0;
            }


            bool result = controller.EditData(MaKyCong, Thang, Nam, NgayTinhCong, NgayCongTrongThang, khoaCong);

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

        private void btn_them_Click(object sender, EventArgs e)
        {
            ThemChamCong them = new ThemChamCong();
            them.themEvent += Them_themEvent;
            them.ShowDialog();
        }

        private void Them_themEvent(int MaKyCong, int Thang, int Nam, DateTime NgayTinhCong, int NgayCongTrongThang, int khoaCong)
        {
            bool result = controller.AddData(MaKyCong, Thang, Nam, NgayTinhCong, NgayCongTrongThang, khoaCong);

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
            _ = new DataGridViewRow();
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txt_MaKyCong.Text = row.Cells["MaKyCong"].Value.ToString();
            dtp_NgayTinhCong.Text = row.Cells["NgayTinhCong"].Value.ToString();
            cbb_Thang.Text = row.Cells["Thang"].Value.ToString();
            cbb_Nam.Text = row.Cells["Nam"].Value.ToString();
            txt_NgayCongTrongThang.Text = row.Cells["NgayCongTrongThang"].Value.ToString();
            string state = row.Cells["KhoaCong"].Value.ToString();
            if (state == "1")
            {
                cb_KhoaCong.Checked = true;
            } else if (state == "0")
            {
                cb_KhoaCong.Checked = false;
            }
        }
    }
}
