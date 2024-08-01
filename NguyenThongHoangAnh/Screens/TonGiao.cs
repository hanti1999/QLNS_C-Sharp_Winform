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
    public partial class TonGiao : Form
    {
        private TonGiaoController reli;
        public TonGiao()
        {
            InitializeComponent();
            reli = new TonGiaoController();
        }

        private void LoadReligion()
        {
            dataGridView1.DataSource = reli.GetReligion();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string str = txt_TenTG.Text;

            bool result = reli.AddReligion(str);

            if (result)
            {
                LoadReligion();
                MessageBox.Show("Đã thêm thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Lỗi cơ sở dữ liệu hoặc tôn giáo này đã tồn tại", "Lỗi");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult submit = MessageBox.Show("Bạn có chắc muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (submit == DialogResult.Yes)
            {
                string id = txt_MaTG.Text;

                bool result = reli.DeleteReligion(id);

                if (result)
                {
                    if (result)
                    {
                        LoadReligion();
                        MessageBox.Show("Đã xóa thành công!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!", "Lỗi");
                    }
                }
            }
            else
            {
                return;
            }

        }

        private void AddReligion_Load(object sender, EventArgs e)
        {
            LoadReligion();
            txt_TenTG.Focus();
            txt_MaTG.ReadOnly = true;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            txt_MaTG.Text = Convert.ToString(row.Cells[0].Value);
            txt_TenTG.Text = Convert.ToString(row.Cells[1].Value);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string id = txt_MaTG.Text;
            string str = txt_TenTG.Text;

            bool result = reli.EditReligion(id, str);
            if (result)
            {
                LoadReligion();
                MessageBox.Show("Đã sửa thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Sửa không thành công!", "Lỗi");
            }
        }
    }
}
