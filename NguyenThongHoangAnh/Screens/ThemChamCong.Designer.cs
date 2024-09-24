namespace NguyenThongHoangAnh.Screens
{
    partial class ThemChamCong
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
            this.btn_Them = new System.Windows.Forms.Button();
            this.cb_KhoaCong = new System.Windows.Forms.CheckBox();
            this.cbb_Nam = new System.Windows.Forms.ComboBox();
            this.cbb_Thang = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NgayCongTrongThang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_NgayTinhCong = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaKyCong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(623, 42);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 41);
            this.btn_Them.TabIndex = 29;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // cb_KhoaCong
            // 
            this.cb_KhoaCong.AutoSize = true;
            this.cb_KhoaCong.Location = new System.Drawing.Point(623, 15);
            this.cb_KhoaCong.Name = "cb_KhoaCong";
            this.cb_KhoaCong.Size = new System.Drawing.Size(95, 23);
            this.cb_KhoaCong.TabIndex = 27;
            this.cb_KhoaCong.Text = "Khóa công";
            this.cb_KhoaCong.UseVisualStyleBackColor = true;
            // 
            // cbb_Nam
            // 
            this.cbb_Nam.FormattingEnabled = true;
            this.cbb_Nam.Items.AddRange(new object[] {
            "2024"});
            this.cbb_Nam.Location = new System.Drawing.Point(496, 11);
            this.cbb_Nam.Name = "cbb_Nam";
            this.cbb_Nam.Size = new System.Drawing.Size(121, 27);
            this.cbb_Nam.TabIndex = 26;
            this.cbb_Nam.Text = "2024";
            this.cbb_Nam.TextChanged += new System.EventHandler(this.cbb_Nam_TextChanged);
            // 
            // cbb_Thang
            // 
            this.cbb_Thang.FormattingEnabled = true;
            this.cbb_Thang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbb_Thang.Location = new System.Drawing.Point(322, 11);
            this.cbb_Thang.Name = "cbb_Thang";
            this.cbb_Thang.Size = new System.Drawing.Size(121, 27);
            this.cbb_Thang.TabIndex = 25;
            this.cbb_Thang.Text = "1";
            this.cbb_Thang.TextChanged += new System.EventHandler(this.cbb_Thang_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "Ngày công trong tháng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "Năm:";
            // 
            // txt_NgayCongTrongThang
            // 
            this.txt_NgayCongTrongThang.Location = new System.Drawing.Point(496, 57);
            this.txt_NgayCongTrongThang.Name = "txt_NgayCongTrongThang";
            this.txt_NgayCongTrongThang.Size = new System.Drawing.Size(121, 26);
            this.txt_NgayCongTrongThang.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tháng:";
            // 
            // dtp_NgayTinhCong
            // 
            this.dtp_NgayTinhCong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayTinhCong.Location = new System.Drawing.Point(146, 58);
            this.dtp_NgayTinhCong.Name = "dtp_NgayTinhCong";
            this.dtp_NgayTinhCong.Size = new System.Drawing.Size(115, 26);
            this.dtp_NgayTinhCong.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ngày tính công:";
            // 
            // txt_MaKyCong
            // 
            this.txt_MaKyCong.Location = new System.Drawing.Point(146, 12);
            this.txt_MaKyCong.Name = "txt_MaKyCong";
            this.txt_MaKyCong.Size = new System.Drawing.Size(115, 26);
            this.txt_MaKyCong.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã kỳ công:";
            // 
            // ThemChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 114);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.cb_KhoaCong);
            this.Controls.Add(this.cbb_Nam);
            this.Controls.Add(this.cbb_Thang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_NgayCongTrongThang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_NgayTinhCong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_MaKyCong);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThemChamCong";
            this.Text = "ThemChamCong";
            this.Load += new System.EventHandler(this.ThemChamCong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.CheckBox cb_KhoaCong;
        private System.Windows.Forms.ComboBox cbb_Nam;
        private System.Windows.Forms.ComboBox cbb_Thang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_NgayCongTrongThang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_NgayTinhCong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaKyCong;
        private System.Windows.Forms.Label label1;
    }
}