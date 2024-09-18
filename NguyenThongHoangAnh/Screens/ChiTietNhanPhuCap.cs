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
    public partial class ChiTietNhanPhuCap : Form
    {
        FillNhanVien fillCbb = new FillNhanVien();
        FillCombobox fillCombobox = new FillCombobox();
        ChiTietNhanPhuCapController controller = new ChiTietNhanPhuCapController();
        public ChiTietNhanPhuCap()
        {
            InitializeComponent();
            FormLoad();
        }

        void FormLoad ()
        {
            fillCbb.FillCbb(cbb_MaNV);
            fillCombobox.FillCbb("SELECT * FROM PhuCap", "MaPhuCap", "TenPhuCap", cbb_MaPhuCap);
            bindingSource1.DataSource = controller.GetData();
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1;
            txt_MaCTPC.ReadOnly = true;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int MaCTPC = int.Parse(txt_MaCTPC.Text);

            bool result = controller.DeleteData(MaCTPC);

            if (result)
            {
                FormLoad();
                MessageBox.Show("Xoá thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xóa không thành công!", "Lỗi");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            int MaCTPC = int.Parse(txt_MaCTPC.Text);
            int MaNV = int.Parse(cbb_MaNV.SelectedValue.ToString());
            int MaPhuCap = int.Parse(cbb_MaPhuCap.SelectedValue.ToString());
            DateTime NgayGhiPhieu = dateTimePicker1.Value.Date;
            DateTime NgayNhanPhuCap = dateTimePicker2.Value.Date;
            string GhiChu = rtxt_GhiChu.Text;

            bool result = controller.EditData(MaCTPC, MaNV, MaPhuCap, NgayGhiPhieu, NgayNhanPhuCap, GhiChu);

            if (result)
            {
                FormLoad();
                MessageBox.Show("Sửa thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Sửa không thành công!", "Lỗi");
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ThemChiTietNhanPhuCap them = new ThemChiTietNhanPhuCap();
            them.themEvent += Them_themEvent;
            them.ShowDialog();
        }

        private void Them_themEvent(int MaNV, int MaChuCap, DateTime NgayGhiPhieu, DateTime NgayNhanPhuCap, string GhiChu)
        {
            bool result = controller.AddData(MaNV, MaChuCap, NgayGhiPhieu, NgayNhanPhuCap, GhiChu);

            if (result)
            {
                FormLoad();
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
            txt_MaCTPC.Text = row.Cells["MaCTPC"].Value.ToString();
            cbb_MaNV.Text = row.Cells["HoTen"].Value.ToString();
            cbb_MaPhuCap.Text = row.Cells["TenPhuCap"].Value.ToString();
            dateTimePicker1.Text = row.Cells["NgayGhiPhieu"].Value.ToString();
            dateTimePicker2.Text = row.Cells["NgayNhanPhuCap"].Value.ToString();
            rtxt_GhiChu.Text = row.Cells["GhiChu"].Value.ToString();
        }
    }
}
