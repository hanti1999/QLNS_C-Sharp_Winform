using NguyenThongHoangAnh.Controllers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenThongHoangAnh.Screens
{
    public partial class NhanVien : Form
    {
        NhanVienController staffController = new NhanVienController();
        private int GioiTinh;
        public NhanVien()
        {
            InitializeComponent();
        }

        private void btn_uploadPic_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.png)|*.jpg; *.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = openFileDialog.FileName;
                    pictureBox1.ImageLocation = selectedImagePath;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void LoadData()
        {
            dataGridView1.DataSource = staffController.GetStaff();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            staffController.FillCombobox("SELECT * FROM TonGiao", "MaTG", "TenTG", cb_tonGiao);
            staffController.FillCombobox("SELECT * FROM DanToc", "MaDT", "TenDT", cb_danToc);
            staffController.FillCombobox("SELECT * FROM ChucVu", "MaCV", "TenCV", cb_chucVu);
            staffController.FillCombobox("SELECT * FROM TrinhDo", "MaTD", "TenTD", cb_trinhDo);
            staffController.FillCombobox("SELECT * FROM PhongBan", "MaPB", "TenPB", cb_phongBan);
            staffController.FillCombobox("SELECT MaCTY,TenCTY FROM CongTy", "MaCTY", "TenCTY", cb_congTy);
            LoadData();
            txt_MaNV.ReadOnly = true;

            txt_ten.Text = "Nguyễn Thông Hoàng Anh";
            txt_cccd.Text = "0986359498";
            txt_diaChi.Text = "An Phước, Long Thành, Đồng Nai";
            txt_dienThoai.Text = "0986359498";
            txt_noiO.Text = "An Phước, Long Thành, Đồng Nai";
            txt_queQuan.Text = "An Phước, Long Thành, Đồng Nai";

            DateTime selectedDate = new DateTime(1999, 12, 22);
            dateTimePicker1.Value = selectedDate;
            rbtn_Nam.Checked = true;
        }

        private byte[] GetImage ()
        {
            Image img = pictureBox1.Image;
            byte[] imageBytes;
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return imageBytes = ms.ToArray();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {            
            int MaDT = int.Parse(cb_danToc.SelectedValue.ToString());
            int MaTG = int.Parse(cb_tonGiao.SelectedValue.ToString());
            int MaTD = int.Parse(cb_trinhDo.SelectedValue.ToString());
            int MaPB = int.Parse(cb_phongBan.SelectedValue.ToString());
            int MaCV = int.Parse(cb_chucVu.SelectedValue.ToString());
            int MaCTY = int.Parse(cb_congTy.SelectedValue.ToString());
            string HoTen = txt_ten.Text;            
            if (rbtn_Nam.Checked)
            {
                GioiTinh = 1;
            } else if (rbtn_Nu.Checked) {
                GioiTinh = 0;
            }
            DateTime NgaySinh = dateTimePicker1.Value.Date;
            string DiaChi = txt_diaChi.Text;
            string CCCD = txt_cccd.Text;
            string QueQuan = txt_queQuan.Text;
            string NoiOHienTai = txt_noiO.Text;
            string DienThoai = txt_dienThoai.Text;
            byte[] HinhAnh = GetImage();

            bool result = staffController.AddStaff(MaDT, MaTG, MaTD, MaPB, MaCV, MaCTY, HoTen, GioiTinh, NgaySinh, DiaChi, CCCD, QueQuan, NoiOHienTai, DienThoai, HinhAnh);

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _ = new DataGridViewRow();
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txt_MaNV.Text = Convert.ToString(row.Cells["MaNV"].Value);
            cb_danToc.Text = Convert.ToString(row.Cells["TenDT"].Value);
            cb_tonGiao.Text = Convert.ToString(row.Cells["TenTG"].Value);
            cb_trinhDo.Text = Convert.ToString(row.Cells["TenTD"].Value);
            cb_phongBan.Text = Convert.ToString(row.Cells["TenPB"].Value);
            cb_chucVu.Text = Convert.ToString(row.Cells["TenCV"].Value);
            cb_congTy.Text = Convert.ToString(row.Cells["TenCTY"].Value);
            txt_ten.Text = Convert.ToString(row.Cells["HoTen"].Value);
            if (Convert.ToString(row.Cells["GioiTinh1"].Value) == "True")
            {
                rbtn_Nam.Checked = true;
            }
            else if (Convert.ToString(row.Cells["GioiTinh1"].Value) == "False")
            {
                rbtn_Nu.Checked = true;
            }
            txt_diaChi.Text = Convert.ToString(row.Cells["DiaChi"].Value);
            txt_cccd.Text = Convert.ToString(row.Cells["CCCD"].Value);
            txt_queQuan.Text = Convert.ToString(row.Cells["QueQuan"].Value);
            txt_noiO.Text = Convert.ToString(row.Cells["NoiOHienTai"].Value);
            txt_dienThoai.Text = Convert.ToString(row.Cells["DienThoai"].Value);
            byte[] imageBytes = (byte[])row.Cells["HinhAnh"].Value;
            MemoryStream stream = new MemoryStream(imageBytes);
            pictureBox1.Image = Image.FromStream(stream);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string MaNV = txt_MaNV.Text;

            bool result = staffController.DeleteStaff(MaNV);
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

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int MaNV = int.Parse(txt_MaNV.Text);
            int MaDT = int.Parse(cb_danToc.SelectedValue.ToString());
            int MaTG = int.Parse(cb_tonGiao.SelectedValue.ToString());
            int MaTD = int.Parse(cb_trinhDo.SelectedValue.ToString());
            int MaPB = int.Parse(cb_phongBan.SelectedValue.ToString());
            int MaCV = int.Parse(cb_chucVu.SelectedValue.ToString());
            int MaCTY = int.Parse(cb_congTy.SelectedValue.ToString());
            string HoTen = txt_ten.Text;
            if (rbtn_Nam.Checked)
            {
                GioiTinh = 1;
            }
            else if (rbtn_Nu.Checked)
            {
                GioiTinh = 0;
            }
            DateTime NgaySinh = dateTimePicker1.Value.Date;
            string DiaChi = txt_diaChi.Text;
            string CCCD = txt_cccd.Text;
            string QueQuan = txt_queQuan.Text;
            string NoiOHienTai = txt_noiO.Text;
            string DienThoai = txt_dienThoai.Text;
            byte[] HinhAnh = GetImage();

            bool result = staffController.EditStaff(MaNV, MaDT, MaTG, MaTD, MaPB, MaCV, MaCTY, HoTen, GioiTinh, NgaySinh, DiaChi, CCCD, QueQuan, NoiOHienTai, DienThoai, HinhAnh);

            if (result)
            {
                LoadData();
                MessageBox.Show("Sửa thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Sửa không thành công!", "Lỗi");
            }
        }
    }
}
