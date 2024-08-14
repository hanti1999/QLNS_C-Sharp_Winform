namespace NguyenThongHoangAnh.Screens
{
    partial class HopDong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_them = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtxt_content = new System.Windows.Forms.RichTextBox();
            this.SoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LanKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(558, 26);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(113, 45);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoHD,
            this.NgayKy,
            this.NgayBatDau,
            this.NgayKetThuc,
            this.LanKy,
            this.ThoiGian,
            this.HeSoLuong,
            this.HoTen,
            this.NoiDung});
            this.dataGridView1.Location = new System.Drawing.Point(12, 504);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1240, 163);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.rtxt_content);
            this.panel2.Location = new System.Drawing.Point(13, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8);
            this.panel2.Size = new System.Drawing.Size(1240, 405);
            this.panel2.TabIndex = 6;
            // 
            // rtxt_content
            // 
            this.rtxt_content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxt_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxt_content.Font = new System.Drawing.Font("Times New Roman", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_content.Location = new System.Drawing.Point(8, 8);
            this.rtxt_content.Name = "rtxt_content";
            this.rtxt_content.Size = new System.Drawing.Size(1224, 389);
            this.rtxt_content.TabIndex = 4;
            this.rtxt_content.Text = "";
            // 
            // SoHD
            // 
            this.SoHD.DataPropertyName = "SoHD";
            this.SoHD.HeaderText = "Mã hợp đồng";
            this.SoHD.MinimumWidth = 6;
            this.SoHD.Name = "SoHD";
            this.SoHD.ReadOnly = true;
            this.SoHD.Width = 137;
            // 
            // NgayKy
            // 
            this.NgayKy.DataPropertyName = "NgayKy";
            this.NgayKy.HeaderText = "Ngày ký";
            this.NgayKy.MinimumWidth = 6;
            this.NgayKy.Name = "NgayKy";
            this.NgayKy.ReadOnly = true;
            this.NgayKy.Width = 98;
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.DataPropertyName = "NgayBatDau";
            this.NgayBatDau.HeaderText = "Ngày bắt đầu";
            this.NgayBatDau.MinimumWidth = 6;
            this.NgayBatDau.Name = "NgayBatDau";
            this.NgayBatDau.ReadOnly = true;
            this.NgayBatDau.Width = 108;
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.DataPropertyName = "NgayKetThuc";
            this.NgayKetThuc.HeaderText = "Ngày kết thúc";
            this.NgayKetThuc.MinimumWidth = 6;
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.ReadOnly = true;
            this.NgayKetThuc.Width = 108;
            // 
            // LanKy
            // 
            this.LanKy.DataPropertyName = "LanKy";
            this.LanKy.HeaderText = "Lần ký";
            this.LanKy.MinimumWidth = 6;
            this.LanKy.Name = "LanKy";
            this.LanKy.ReadOnly = true;
            this.LanKy.Width = 70;
            // 
            // ThoiGian
            // 
            this.ThoiGian.DataPropertyName = "ThoiGian";
            this.ThoiGian.HeaderText = "Thời gian";
            this.ThoiGian.MinimumWidth = 6;
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.ReadOnly = true;
            this.ThoiGian.Width = 109;
            // 
            // HeSoLuong
            // 
            this.HeSoLuong.DataPropertyName = "HeSoLuong";
            this.HeSoLuong.HeaderText = "Hệ số lương";
            this.HeSoLuong.MinimumWidth = 6;
            this.HeSoLuong.Name = "HeSoLuong";
            this.HeSoLuong.ReadOnly = true;
            this.HeSoLuong.Width = 128;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 65;
            // 
            // NoiDung
            // 
            this.NoiDung.DataPropertyName = "NoiDung";
            this.NoiDung.HeaderText = "Nội dung";
            this.NoiDung.MinimumWidth = 6;
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.ReadOnly = true;
            this.NoiDung.Width = 108;
            // 
            // HopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 679);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_them);
            this.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "HopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HopDong";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rtxt_content;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn LanKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
    }
}