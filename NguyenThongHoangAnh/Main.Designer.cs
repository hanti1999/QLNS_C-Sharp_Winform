namespace NguyenThongHoangAnh
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_resetPass = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.dânTộcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_ethnicities = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_religion = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_level = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_department = new System.Windows.Forms.ToolStripMenuItem();
            this.tx_position = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_company = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.ts_staff = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.dânTộcToolStripMenuItem,
            this.ts_refresh});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_resetPass,
            this.ts_logout});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // ts_resetPass
            // 
            this.ts_resetPass.Name = "ts_resetPass";
            this.ts_resetPass.Size = new System.Drawing.Size(145, 22);
            this.ts_resetPass.Text = "Đổi mật khẩu";
            this.ts_resetPass.Click += new System.EventHandler(this.ts_resetPass_Click);
            // 
            // ts_logout
            // 
            this.ts_logout.Name = "ts_logout";
            this.ts_logout.Size = new System.Drawing.Size(145, 22);
            this.ts_logout.Text = "Đăng xuất";
            // 
            // dânTộcToolStripMenuItem
            // 
            this.dânTộcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_ethnicities,
            this.ts_religion,
            this.ts_level,
            this.ts_department,
            this.tx_position,
            this.ts_company,
            this.ts_staff});
            this.dânTộcToolStripMenuItem.Name = "dânTộcToolStripMenuItem";
            this.dânTộcToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.dânTộcToolStripMenuItem.Text = "Danh mục";
            // 
            // ts_ethnicities
            // 
            this.ts_ethnicities.Name = "ts_ethnicities";
            this.ts_ethnicities.Size = new System.Drawing.Size(180, 22);
            this.ts_ethnicities.Text = "Dân tộc";
            this.ts_ethnicities.Click += new System.EventHandler(this.ts_ethnicities_Click);
            // 
            // ts_religion
            // 
            this.ts_religion.Name = "ts_religion";
            this.ts_religion.Size = new System.Drawing.Size(180, 22);
            this.ts_religion.Text = "Tôn giáo";
            this.ts_religion.Click += new System.EventHandler(this.ts_religion_Click);
            // 
            // ts_level
            // 
            this.ts_level.Name = "ts_level";
            this.ts_level.Size = new System.Drawing.Size(180, 22);
            this.ts_level.Text = "Trình độ";
            this.ts_level.Click += new System.EventHandler(this.ts_level_Click);
            // 
            // ts_department
            // 
            this.ts_department.Name = "ts_department";
            this.ts_department.Size = new System.Drawing.Size(180, 22);
            this.ts_department.Text = "Phòng ban";
            this.ts_department.Click += new System.EventHandler(this.ts_department_Click);
            // 
            // tx_position
            // 
            this.tx_position.Name = "tx_position";
            this.tx_position.Size = new System.Drawing.Size(180, 22);
            this.tx_position.Text = "Chức vụ";
            this.tx_position.Click += new System.EventHandler(this.tx_position_Click);
            // 
            // ts_company
            // 
            this.ts_company.Name = "ts_company";
            this.ts_company.Size = new System.Drawing.Size(180, 22);
            this.ts_company.Text = "Công ty";
            this.ts_company.Click += new System.EventHandler(this.ts_company_Click);
            // 
            // ts_refresh
            // 
            this.ts_refresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_refresh.Name = "ts_refresh";
            this.ts_refresh.Size = new System.Drawing.Size(105, 20);
            this.ts_refresh.Text = "làm mới dữ liệu";
            this.ts_refresh.Click += new System.EventHandler(this.ts_refresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(299, 277);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh sách dân tộc";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(881, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 306);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(568, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 306);
            this.panel2.TabIndex = 6;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(299, 277);
            this.dataGridView2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Danh sách tôn giáo";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView3);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(568, 361);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 306);
            this.panel3.TabIndex = 7;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(3, 25);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(299, 277);
            this.dataGridView3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Danh sách phòng ban";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView4);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(881, 361);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(307, 306);
            this.panel4.TabIndex = 8;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(3, 25);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(299, 277);
            this.dataGridView4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Danh sách chức vụ";
            // 
            // ts_staff
            // 
            this.ts_staff.Name = "ts_staff";
            this.ts_staff.Size = new System.Drawing.Size(180, 22);
            this.ts_staff.Text = "Nhân viên";
            this.ts_staff.Click += new System.EventHandler(this.ts_staff_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân sự";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ts_resetPass;
        private System.Windows.Forms.ToolStripMenuItem ts_logout;
        private System.Windows.Forms.ToolStripMenuItem dânTộcToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem ts_refresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem ts_ethnicities;
        private System.Windows.Forms.ToolStripMenuItem ts_religion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem ts_level;
        private System.Windows.Forms.ToolStripMenuItem ts_department;
        private System.Windows.Forms.ToolStripMenuItem tx_position;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem ts_company;
        private System.Windows.Forms.ToolStripMenuItem ts_staff;
    }
}

