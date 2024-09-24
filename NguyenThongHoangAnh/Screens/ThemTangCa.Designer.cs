namespace NguyenThongHoangAnh.Screens
{
    partial class ThemTangCa
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbb_HeSo = new System.Windows.Forms.ComboBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_SoTien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_SoGio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_MaLoaiCa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_MaNV = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 107);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbb_HeSo);
            this.panel2.Controls.Add(this.btn_Them);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txt_SoTien);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_SoGio);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbb_MaLoaiCa);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbb_MaNV);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 99);
            this.panel2.TabIndex = 0;
            // 
            // cbb_HeSo
            // 
            this.cbb_HeSo.FormattingEnabled = true;
            this.cbb_HeSo.Items.AddRange(new object[] {
            "1",
            "1.1",
            "1.2",
            "1.3",
            "1.4",
            "1.5",
            "1.6",
            "1.7",
            "1.8",
            "1.9",
            "2"});
            this.cbb_HeSo.Location = new System.Drawing.Point(343, 67);
            this.cbb_HeSo.Name = "cbb_HeSo";
            this.cbb_HeSo.Size = new System.Drawing.Size(110, 27);
            this.cbb_HeSo.TabIndex = 17;
            this.cbb_HeSo.Text = "1";
            this.cbb_HeSo.SelectedIndexChanged += new System.EventHandler(this.cbb_HeSo_SelectedIndexChanged);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(3, 4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 32);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(548, 35);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(300, 59);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(469, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ghi chú:";
            // 
            // txt_SoTien
            // 
            this.txt_SoTien.Location = new System.Drawing.Point(548, 3);
            this.txt_SoTien.Name = "txt_SoTien";
            this.txt_SoTien.Size = new System.Drawing.Size(110, 26);
            this.txt_SoTien.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(469, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Số tiền:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Hệ số:";
            // 
            // txt_SoGio
            // 
            this.txt_SoGio.Location = new System.Drawing.Point(343, 3);
            this.txt_SoGio.Name = "txt_SoGio";
            this.txt_SoGio.Size = new System.Drawing.Size(110, 26);
            this.txt_SoGio.TabIndex = 9;
            this.txt_SoGio.Text = "1";
            this.txt_SoGio.TextChanged += new System.EventHandler(this.txt_SoGio_TextChanged);
            this.txt_SoGio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoGio_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số giờ:";
            // 
            // cbb_MaLoaiCa
            // 
            this.cbb_MaLoaiCa.FormattingEnabled = true;
            this.cbb_MaLoaiCa.Location = new System.Drawing.Point(343, 35);
            this.cbb_MaLoaiCa.Name = "cbb_MaLoaiCa";
            this.cbb_MaLoaiCa.Size = new System.Drawing.Size(110, 27);
            this.cbb_MaLoaiCa.TabIndex = 7;
            this.cbb_MaLoaiCa.SelectedIndexChanged += new System.EventHandler(this.cbb_MaLoaiCa_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Loại ca:";
            // 
            // cbb_MaNV
            // 
            this.cbb_MaNV.FormattingEnabled = true;
            this.cbb_MaNV.Location = new System.Drawing.Point(89, 67);
            this.cbb_MaNV.Name = "cbb_MaNV";
            this.cbb_MaNV.Size = new System.Drawing.Size(153, 27);
            this.cbb_MaNV.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhân viên:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(89, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 26);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày:";
            // 
            // ThemTangCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 132);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThemTangCa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemTangCa";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_SoGio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_MaLoaiCa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_MaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SoTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbb_HeSo;
    }
}