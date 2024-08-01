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
    public partial class DanToc : Form
    {
        private DanTocController ethnicities;
        public DanToc()
        {
            InitializeComponent();
            ethnicities = new DanTocController();
        }
        private void LoadEthnicities()
        {
            dataGridView1.DataSource = ethnicities.GetEthnicities();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string str = txt_TenDT.Text;

            bool result = ethnicities.AddEthnicities(str);

            if(result)
            {
                LoadEthnicities();
                MessageBox.Show("Đã thêm thành công!", "Thông báo");
            } else
            {
                MessageBox.Show("Lỗi cơ sở dữ liệu hoặc dân tộc này đã tồn tại", "Lỗi");
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            txt_MaDT.Text = Convert.ToString(row.Cells[0].Value);
            txt_TenDT.Text = Convert.ToString(row.Cells[1].Value);
        }

        private void Ethnicities_Load(object sender, EventArgs e)
        {
            LoadEthnicities();
            txt_MaDT.ReadOnly = true;
            txt_TenDT.Focus();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult submit = MessageBox.Show("Bạn có chắc muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (submit == DialogResult.Yes)
            {
                string id = txt_MaDT.Text;

                bool result = ethnicities.DeleteEthnicities(id);

                if (result)
                {
                    LoadEthnicities();
                    MessageBox.Show("Đã xóa thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!", "Lỗi");
                }
            } else
            {
                return;
            }            
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string id = txt_MaDT.Text;
            string str = txt_TenDT.Text;

            bool result = ethnicities.EditEthnicities(id, str);
            if (result)
            {
                LoadEthnicities();
                MessageBox.Show("Đã sửa thành công!", "Thông báo");
            } else
            {
                MessageBox.Show("Sửa không thành công!", "Lỗi");
            }
        }
    }
}
