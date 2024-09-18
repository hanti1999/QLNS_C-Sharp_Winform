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
    public partial class ThemPhuCap : Form
    {
        public ThemPhuCap()
        {
            InitializeComponent();
        }

        public delegate void them(string TenPhuCap, float SoTien);
        public event them themEvent;

        private void btn_add_Click(object sender, EventArgs e)
        {
            string TenPhuCap = txt_TenPhuCap.Text;
            float SoTien = float.Parse(txt_SoTien.Text);
            themEvent(TenPhuCap, SoTien);
        }

        private void txt_SoTien_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
