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
    public partial class TrinhDo : Form
    {
        TrinhDoController levelController;
        public TrinhDo()
        {
            InitializeComponent();
            levelController = new TrinhDoController();
        }

        private void LoadLevel ()
        {
            dataGridView1.DataSource = levelController.GetLevel();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string str = txt_TenTrinhDo.Text;

            bool result = levelController.AddLevel(str);

            if (result)
            {
                txt_TenTrinhDo.Clear();
                LoadLevel();
                MessageBox.Show("Đã thêm thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Lỗi cơ sở dữ liệu hoặc tên này đã tồn tại", "Lỗi");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult submit = MessageBox.Show("Bạn có chắc muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (submit == DialogResult.Yes)
            {
                string id = txt_MaTrinhDo.Text;

                bool result = levelController.DeleteLevel(id);

                if (result)
                {
                    LoadLevel();
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
            string id = txt_MaTrinhDo.Text;
            string str = txt_TenTrinhDo.Text;

            bool result = levelController.EditLevel(id, str);
            if (result)
            {
                LoadLevel();
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
            txt_MaTrinhDo.Text = Convert.ToString(row.Cells[0].Value);
            txt_TenTrinhDo.Text = Convert.ToString(row.Cells[1].Value);
        }

        private void Level_Load(object sender, EventArgs e)
        {
            LoadLevel();
            txt_MaTrinhDo.ReadOnly = true;
            txt_TenTrinhDo.Focus(); 
        }
    }
}
