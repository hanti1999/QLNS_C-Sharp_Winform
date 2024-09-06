﻿using NguyenThongHoangAnh.Controllers;
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
    public partial class LuanChuyen : Form
    {
        LuanChuyenController controller = new LuanChuyenController();

        public LuanChuyen()
        {
            InitializeComponent();
            FormLoad();
        }

        void FormLoad()
        {
            controller.FillCombobox("SELECT * FROM NhanVien", "MaNV", "HoTen", cbb_nhanVien);
            controller.FillCombobox("SELECT * FROM PhongBan", "MaPB", "TenPB", cbb_PBMoi);
            bindingSource1.DataSource = controller.GetData();
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            ThemLuanChuyen them = new ThemLuanChuyen();
            them.themEvent += Them_themEvent;
            them.ShowDialog();
        }

        private void Them_themEvent(int SoQD, DateTime NgayQD, int PBCu, int PBMoi, string LyDo, string GhiChu, int MaNV)
        {
            bool result = controller.AddData(SoQD, NgayQD, PBCu, PBMoi, LyDo, GhiChu, MaNV);

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
            rtxt_lyDo.Clear();
            rtxt_ghiChu.Clear();
            _ = new DataGridViewRow();
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txt_soQD.Text = row.Cells["SoQD"].Value.ToString();
            dateTimePicker1.Text = row.Cells["NgayQD"].Value.ToString();
            cbb_nhanVien.Text = row.Cells["MaNV"].Value.ToString();
            cbb_PBMoi.Text = row.Cells["PBMoi"].Value.ToString();
            rtxt_ghiChu.Text = row.Cells["GhiChu"].Value.ToString();
            rtxt_lyDo.Text = row.Cells["LyDo"].Value.ToString();
        }
    }
}
