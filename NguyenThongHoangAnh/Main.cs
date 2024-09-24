using NguyenThongHoangAnh.Controllers;
using NguyenThongHoangAnh.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenThongHoangAnh
{
    public partial class Main : Form
    {
        string user;
        string password;
        DanTocController eth;
        TonGiaoController religion;
        TrinhDoController level;
        ChucVuController position;
        public Main(string user, string password)
        {
            InitializeComponent();
            this.password = password;
            this.user = user;
            eth = new DanTocController();
            religion = new TonGiaoController();
            level = new TrinhDoController();
            position = new ChucVuController();
        }        

        private void Main_Load(object sender, EventArgs e)
        {
            if (user == null)
            {
                Login lg = new Login();
                lg.ShowDialog();
            } else
            {
                this.Text = $"Chào mừng {user}";
            }

            LoadEthnicities();
            LoadReligion();
            LoadPosition();
            LoadLevel();
        }

        private void ts_resetPass_Click(object sender, EventArgs e)
        {
            ResetPass rsp = new ResetPass(user, password);
            rsp.Show();
        }

        private void LoadEthnicities()
        {
            dataGridView1.DataSource = eth.GetEthnicities();
        }

        private void LoadReligion ()
        {
            dataGridView2.DataSource  = religion.GetReligion();
        }

        private void LoadPosition ()
        {
            dataGridView3.DataSource = position.GetPosition();
        }

        private void LoadLevel ()
        {
            dataGridView4.DataSource = level.GetLevel();
        }

        private void ts_refresh_Click(object sender, EventArgs e)
        {
            LoadEthnicities();
            LoadReligion();
            LoadPosition();
            LoadLevel();
        }

        private void ts_religion_Click(object sender, EventArgs e)
        {
            TonGiao addReligion = new TonGiao();
            addReligion.Show();
        }

        private void ts_ethnicities_Click(object sender, EventArgs e)
        {
            DanToc dl = new DanToc();
            dl.Show();
        }

        private void ts_level_Click(object sender, EventArgs e)
        {
            TrinhDo lv = new TrinhDo();
            lv.Show();
        }

        private void tx_position_Click(object sender, EventArgs e)
        {
            ChucVu ps = new ChucVu();
            ps.Show();
        }

        private void ts_department_Click(object sender, EventArgs e)
        {
            PhongBan department = new PhongBan();
            department.Show();
        }

        private void ts_company_Click(object sender, EventArgs e)
        {
            CongTy company = new CongTy();
            company.Show();
        }

        private void ts_staff_Click(object sender, EventArgs e)
        {
            NhanVien staff = new NhanVien();
            staff.Show();
        }

        private void ts_HopDong_Click(object sender, EventArgs e)
        {
            HopDong hd = new HopDong();
            hd.Show();
        }

        private void ts_KhenThuong_Click(object sender, EventArgs e)
        {
            KhenThuong khenThuong = new KhenThuong();
            khenThuong.Show();
        }

        private void ts_kyLuat_Click(object sender, EventArgs e)
        {
            KyLuat kl = new KyLuat();
            kl.Show();
        }

        private void ts_luanCHuyen_Click(object sender, EventArgs e)
        {
            LuanChuyen lc = new LuanChuyen();
            lc.Show();
        }

        private void ts_thoiviec_Click(object sender, EventArgs e)
        {
            ThoiViec tv = new ThoiViec();
            tv.Show();
        }

        private void ts_LoaiCa_Click(object sender, EventArgs e)
        {
            LoaiCa lc = new LoaiCa();
            lc.Show();
        }

        private void ts_LoaiCong_Click(object sender, EventArgs e)
        {
            LoaiCong lc = new LoaiCong();
            lc.Show();
        }

        private void ts_PhuCap_Click(object sender, EventArgs e)
        {
            PhuCap pc = new PhuCap();
            pc.Show();
        }

        private void ts_CTPC_Click(object sender, EventArgs e)
        {
            ChiTietNhanPhuCap form = new ChiTietNhanPhuCap();
            form.Show();
        }

        private void ts_TangCa_Click(object sender, EventArgs e)
        {
            TangCa form = new TangCa();
            form.Show();
        }

        private void ts_LoaiPhep_Click(object sender, EventArgs e)
        {
            LoaiPhep lc = new LoaiPhep();
            lc.Show();
        }

        private void tts_ChamCong_Click(object sender, EventArgs e)
        {
            BangChamCong form = new BangChamCong();
            form.Show();
        }
    }
}
