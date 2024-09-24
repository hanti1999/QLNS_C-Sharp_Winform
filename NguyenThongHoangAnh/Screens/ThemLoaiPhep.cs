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
    public partial class ThemLoaiPhep : Form
    {
        public ThemLoaiPhep()
        {
            InitializeComponent();
        }

        public delegate void them(string TenLoaiPhep, float HeSo);
        public event them themEvent;

        private void btn_add_Click(object sender, EventArgs e)
        {
            string LoaiPhep = txt_TenLoaiPhep.Text;
            float HeSo = float.Parse(txt_HeSo.Text);
            themEvent(LoaiPhep, HeSo);
        }

        private void txt_HeSo_KeyPress(object sender, KeyPressEventArgs e)
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
