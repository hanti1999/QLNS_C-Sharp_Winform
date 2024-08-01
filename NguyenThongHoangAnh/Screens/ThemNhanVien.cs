using NguyenThongHoangAnh.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenThongHoangAnh.Screens
{
    public partial class ThemNhanVien : Form
    {
        NhanVienController staffController = new NhanVienController();
        private int GioiTinh;

        public ThemNhanVien()
        {
            InitializeComponent();
        }

        public delegate void them(int MaDT, int MaTG, int MaTD, int MaPB, int MaCV, int MaCTY, string HoTen, int GioiTinh, DateTime NgaySinh, string DiaChi, string CCCD, string QueQuan, string NoiOHienTai, string DienThoai,byte[] HinhAnh);
        public event them themEvent;

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

        private void ThemNhanVien_Load(object sender, EventArgs e)
        {
            staffController.FillCombobox("SELECT * FROM TonGiao", "MaTG", "TenTG", cb_tonGiao);
            staffController.FillCombobox("SELECT * FROM DanToc", "MaDT", "TenDT", cb_danToc);
            staffController.FillCombobox("SELECT * FROM ChucVu", "MaCV", "TenCV", cb_chucVu);
            staffController.FillCombobox("SELECT * FROM TrinhDo", "MaTD", "TenTD", cb_trinhDo);
            staffController.FillCombobox("SELECT * FROM PhongBan", "MaPB", "TenPB", cb_phongBan);
            staffController.FillCombobox("SELECT MaCTY,TenCTY FROM CongTy", "MaCTY", "TenCTY", cb_congTy);
            
        }

        private byte[] GetImage()
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
            themEvent(MaDT, MaTG, MaTD, MaPB, MaCV, MaCTY, HoTen, GioiTinh, NgaySinh, DiaChi, CCCD, QueQuan, NoiOHienTai, DienThoai, HinhAnh);
            this.Close();
        }
    }
}
