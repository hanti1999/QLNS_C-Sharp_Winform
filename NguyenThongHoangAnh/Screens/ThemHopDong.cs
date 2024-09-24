using NguyenThongHoangAnh.Controllers;
using NguyenThongHoangAnh.utils;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;


namespace NguyenThongHoangAnh.Screens
{
    public partial class ThemHopDong : Form
    {
        private bool isNew = false;
        FillNhanVien FillCbb = new FillNhanVien();
        public ThemHopDong()
        {
            InitializeComponent();
            LoadForm();
        }

        public delegate void them(string SoHD, DateTime NgayKy, DateTime NgayBatDau, DateTime NgayKetThuc, int LanKy, double HeSoLuong, double LuongCoBan, string ThoiGian, string NoiDung, int MaNV);
        public event them ThemEvent;

        #region Function
        void LoadForm()
        {
            rtxt_content.Text = "Hello world";
            rtxt_content.ReadOnly = true;
            rtxt_content.BackColor = Color.Gray;
            txt_NgayKy.Text = DateTime.Now.ToString();
            FillCbb.FillCbb(cbb_nv);
        }        

        void BoldText(RichTextBox rtxt)
        {
            Font newFont = new Font(rtxt.SelectionFont.FontFamily.Name, rtxt.SelectionFont.Size, FontStyle.Bold);
            rtxt.SelectionFont = newFont;
        }

        void ItalicText(RichTextBox rtxt)
        {
            Font newFont = new Font(rtxt.SelectionFont.FontFamily.Name, rtxt.SelectionFont.Size, FontStyle.Italic);
            rtxt.SelectionFont = newFont;
        }

        void NormalText(RichTextBox rtxt)
        {
            Font newFont = new Font(rtxt.SelectionFont.FontFamily.Name, rtxt.SelectionFont.Size, FontStyle.Regular);
            rtxt.SelectionFont = newFont;
        }

        void UnderlineText(RichTextBox rtxt)
        {
            Font newFont = new Font(rtxt.SelectionFont.FontFamily.Name, rtxt.SelectionFont.Size, FontStyle.Underline);
            rtxt.SelectionFont = newFont;
        }

        void ChangedSize(RichTextBox rtxt, int size)
        {
            Font newFont = new Font(rtxt.SelectionFont.FontFamily.Name, size, rtxt.SelectionFont.Style);
            rtxt.SelectionFont = newFont;
        }

        void ChangeFontFamily(RichTextBox rtxt, string font)
        {
            Font newFont = new Font(font, rtxt.SelectionFont.Size, rtxt.SelectionFont.Style);
            rtxt.SelectionFont = newFont;            
        }

        void ChangeColor(RichTextBox rtxt, Color color)
        {
            rtxt.SelectionColor = color;
        }

        void AlignLeft(RichTextBox rtxt)
        {
            rtxt.SelectionAlignment = HorizontalAlignment.Left;
        }

        void AlignCenter(RichTextBox rtxt)
        {
            rtxt.SelectionAlignment = HorizontalAlignment.Center;
        }

        void AlignRight (RichTextBox rtxt)
        {
            rtxt.SelectionAlignment = HorizontalAlignment.Right;
        }
        #endregion

        #region Event
        private void btn_new_Click(object sender, EventArgs e)
        {
            isNew = !isNew;
            if (isNew)
            {
                rtxt_content.ReadOnly = false;
                rtxt_content.BackColor = Color.White;
                rtxt_content.Focus();
            }
            else
            {
                rtxt_content.ReadOnly = true;
                rtxt_content.BackColor = Color.Gray;
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string SoHD = txt_SoHD.Text;
            DateTime NgayKy = DateTime.Now.Date;
            DateTime NgayBatDau = dateTimePicker1.Value.Date;
            DateTime NgayKetThuc = dateTimePicker2.Value.Date;
            int LanKy = int.Parse(cbb_LanKy.Text);
            double HeSoLuong = double.Parse(cbb_heSoLuong.Text);
            double LuongCoBan = double.Parse(txt_LuongCoBan.Text);
            string ThoiGian = cbb_ThoiGian.Text;
            string NoiDung = rtxt_content.Rtf;
            int MaNV =  int.Parse(cbb_nv.SelectedValue.ToString());
            ThemEvent(SoHD, NgayKy, NgayBatDau, NgayKetThuc, LanKy, HeSoLuong, LuongCoBan, ThoiGian, NoiDung, MaNV);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            isNew = false;
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Color selectedColorName = dlg.Color;
                ChangeColor(rtxt_content, selectedColorName);
                btn_color.BackColor = selectedColorName;
            }
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rtxt_content.Clear();
                rtxt_content.ReadOnly = false;
                rtxt_content.BackColor = Color.White;
                rtxt_content.Focus();
                Stream stream = openFileDialog.OpenFile();
                StreamReader streamReader = new StreamReader(stream);
                string line = streamReader.ReadLine();
                while (line != null)
                {
                    rtxt_content.Text += line;
                    rtxt_content.Text += "\n";
                    line = streamReader.ReadLine();
                }
                streamReader.Close();
            }
        }

        private void btn_bold_Click(object sender, EventArgs e)
        {
            BoldText(rtxt_content);
        }

        private void btn_italic_Click(object sender, EventArgs e)
        {
            ItalicText(rtxt_content);
        }

        private void btn_underline_Click(object sender, EventArgs e)
        {
            UnderlineText(rtxt_content);
        }

        private void btn_normal_Click(object sender, EventArgs e)
        {
            NormalText(rtxt_content);
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            AlignLeft(rtxt_content);
        }

        private void btn_center_Click(object sender, EventArgs e)
        {
            AlignCenter(rtxt_content);
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            AlignRight(rtxt_content);
        }

        private void cbb_fontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            string font = cbb_fontFamily.Text;
            ChangeFontFamily(rtxt_content, font);
        }

        private void cbb_fontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedSize = int.Parse(cbb_fontSize.Text);
            ChangedSize(rtxt_content, selectedSize);
        }
        #endregion

    }
}
