using NguyenThongHoangAnh.Controllers;
using NguyenThongHoangAnh.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenThongHoangAnh.Screens
{
    public partial class TangCa : Form
    {
        FillNhanVien fillCbb = new FillNhanVien();
        FillCombobox fillCombobox = new FillCombobox();
        TangCaController controller = new TangCaController();
        public TangCa()
        {
            InitializeComponent();
            FormLoad();
        }

        void FormLoad()
        {
            fillCbb.FillCbb(cbb_MaNV);
            fillCombobox.FillCbb("SELECT * FROM LoaiCa", "MaLoaiCa", "TenLoaiCa", cbb_MaLoaiCa);
            txt_MaTangCa.ReadOnly = true;
            bindingSource1.DataSource = controller.GetData();
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int MaTangCa = int.Parse(txt_MaTangCa.Text);

            bool result = controller.DeleteData(MaTangCa);

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
            int MaTangCa = int.Parse(txt_MaTangCa.Text);
            DateTime NgayTangCa = dateTimePicker1.Value.Date;
            int MaNV = int.Parse(cbb_MaNV.SelectedValue.ToString());
            int MaLoaiCa = int.Parse(cbb_MaLoaiCa.SelectedValue.ToString());
            double SoGio = double.Parse(txt_SoGio.Text);
            double HeSo = double.Parse(cbb_HeSo.SelectedValue.ToString());
            double SoTien = double.Parse(txt_SoTien.Text);
            string GhiChu = richTextBox1.Text;

            bool result = controller.EditData(MaTangCa, NgayTangCa, MaNV, MaLoaiCa, SoGio, HeSo, SoTien, GhiChu);

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
            ThemTangCa them = new ThemTangCa();
            them.themEvent += Them_themEvent;
            them.ShowDialog();
        }

        private void Them_themEvent(DateTime NgayTangCa, int MaNV, int MaLoaiCa, double SoGio, double HeSo, double SoTien, string GhiChu)
        {
            bool result = controller.AddData(NgayTangCa, MaNV, MaLoaiCa, SoGio, HeSo, SoTien, GhiChu);

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
            txt_MaTangCa.Text = row.Cells["MaTangCa"].Value.ToString();
            dateTimePicker1.Text = row.Cells["NgayTangCa"].Value.ToString();
            cbb_MaNV.Text = row.Cells["HoTen"].Value.ToString();
            cbb_MaLoaiCa.Text = row.Cells["TenLoaiCa"].Value.ToString();
            txt_SoGio.Text = row.Cells["SoGio"].Value.ToString();
            cbb_HeSo.Text = row.Cells["HeSo"].Value.ToString();
            txt_SoTien.Text = row.Cells["SoTien"].Value.ToString();
            richTextBox1.Text = row.Cells["GhiChu"].Value.ToString();
        }

        void AntiText (object sender, KeyPressEventArgs e)
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

        private void txt_SoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            AntiText(sender, e);
        }

        private void txt_SoGio_KeyPress(object sender, KeyPressEventArgs e)
        {
            AntiText(sender, e);
        }
    }
}
