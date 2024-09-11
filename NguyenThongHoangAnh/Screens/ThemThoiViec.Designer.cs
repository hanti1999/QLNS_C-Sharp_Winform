namespace NguyenThongHoangAnh.Screens
{
    partial class ThemThoiViec
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
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cbb_nhanVien = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_soQD = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rtxt_ghiChu = new System.Windows.Forms.RichTextBox();
            this.rtxt_lyDo = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ngày nghỉ:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(132, 68);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker2.TabIndex = 20;
            // 
            // cbb_nhanVien
            // 
            this.cbb_nhanVien.FormattingEnabled = true;
            this.cbb_nhanVien.Location = new System.Drawing.Point(544, 4);
            this.cbb_nhanVien.Name = "cbb_nhanVien";
            this.cbb_nhanVien.Size = new System.Drawing.Size(200, 27);
            this.cbb_nhanVien.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ngày nộp đơn:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nhân viên:";
            // 
            // txt_soQD
            // 
            this.txt_soQD.Location = new System.Drawing.Point(132, 4);
            this.txt_soQD.Name = "txt_soQD";
            this.txt_soQD.Size = new System.Drawing.Size(200, 26);
            this.txt_soQD.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rtxt_ghiChu);
            this.panel3.Controls.Add(this.rtxt_lyDo);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(0, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(855, 409);
            this.panel3.TabIndex = 3;
            // 
            // rtxt_ghiChu
            // 
            this.rtxt_ghiChu.Location = new System.Drawing.Point(7, 236);
            this.rtxt_ghiChu.Name = "rtxt_ghiChu";
            this.rtxt_ghiChu.Size = new System.Drawing.Size(845, 170);
            this.rtxt_ghiChu.TabIndex = 13;
            this.rtxt_ghiChu.Text = "";
            // 
            // rtxt_lyDo
            // 
            this.rtxt_lyDo.Location = new System.Drawing.Point(7, 35);
            this.rtxt_lyDo.Name = "rtxt_lyDo";
            this.rtxt_lyDo.Size = new System.Drawing.Size(845, 170);
            this.rtxt_lyDo.TabIndex = 12;
            this.rtxt_lyDo.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ghi chú:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Lý do:";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(409, 68);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 26);
            this.btn_Them.TabIndex = 22;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Số quyết định:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Them);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.cbb_nhanVien);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_soQD);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 99);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 524);
            this.panel1.TabIndex = 3;
            // 
            // ThemThoiViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 546);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThemThoiViec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemThoiViec";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox cbb_nhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_soQD;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox rtxt_ghiChu;
        private System.Windows.Forms.RichTextBox rtxt_lyDo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}