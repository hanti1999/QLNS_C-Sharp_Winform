using NguyenThongHoangAnh.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace NguyenThongHoangAnh.Screens
{
    public partial class HopDong : Form
    {
        HopDongController controller = new HopDongController();

        public HopDong()
        {
            InitializeComponent();
            LoadForm();
        }

        void LoadForm()
        {
            dataGridView1.DataSource = controller.GetHopDong();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            ThemHopDong themHopDong = new ThemHopDong();
            themHopDong.ThemEvent += ThemHopDong_ThemEvent;
            themHopDong.ShowDialog();
        }

        private void ThemHopDong_ThemEvent(string SoHD, DateTime NgayKy, DateTime NgayBatDau, DateTime NgayKetThuc, int LanKy, double HeSoLuong, string ThoiGian, string NoiDung, int MaNV)
        {
            bool result = controller.AddData(SoHD, NgayKy, NgayBatDau, NgayKetThuc, LanKy, HeSoLuong, ThoiGian, NoiDung, MaNV);
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
            rtxt_content.Clear();
            _ = new DataGridViewRow();
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(row.Cells[7].Value.ToString());

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                string style = node.Attributes["style"]?.Value;

                if (!string.IsNullOrEmpty(style))
                {
                    string[] styleParts = style.Split(';');
                    foreach (string part in styleParts)
                    {
                        string[] kv = part.Split(':');
                        if (kv[0].Trim().Equals("color", StringComparison.OrdinalIgnoreCase))
                        {
                            rtxt_content.ForeColor = System.Drawing.Color.FromName(kv[1].Trim());
                        }
                    }
                }

                rtxt_content.AppendText(node.InnerText + "\n");
            }
        }
    }
}
