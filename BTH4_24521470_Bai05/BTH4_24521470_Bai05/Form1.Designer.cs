namespace BTH4_24521470_Bai05
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            chứcNăngToolStripMenuItem = new ToolStripMenuItem();
            thêmMớiToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            tb_TK_Theo_Ten = new TextBox();
            dtg_sinhvien = new DataGridView();
            column_stt = new DataGridViewTextBoxColumn();
            column_MSSV = new DataGridViewTextBoxColumn();
            column_name = new DataGridViewTextBoxColumn();
            column_khoa = new DataGridViewTextBoxColumn();
            column_diemtb = new DataGridViewTextBoxColumn();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_sinhvien).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { chứcNăngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(774, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            chứcNăngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thêmMớiToolStripMenuItem, thoátToolStripMenuItem });
            chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            chứcNăngToolStripMenuItem.Size = new Size(93, 24);
            chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // thêmMớiToolStripMenuItem
            // 
            thêmMớiToolStripMenuItem.Image = (Image)resources.GetObject("thêmMớiToolStripMenuItem.Image");
            thêmMớiToolStripMenuItem.Name = "thêmMớiToolStripMenuItem";
            thêmMớiToolStripMenuItem.Size = new Size(224, 26);
            thêmMớiToolStripMenuItem.Text = "Thêm Mới";
            thêmMớiToolStripMenuItem.Click += thêmMớiToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(224, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(320, 35);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 1;
            label1.Text = "Tìm Kiếm Theo Tên";
            // 
            // tb_TK_Theo_Ten
            // 
            tb_TK_Theo_Ten.Location = new Point(476, 35);
            tb_TK_Theo_Ten.Name = "tb_TK_Theo_Ten";
            tb_TK_Theo_Ten.Size = new Size(298, 27);
            tb_TK_Theo_Ten.TabIndex = 2;
            tb_TK_Theo_Ten.TextChanged += tb_TK_Theo_Ten_TextChanged;
            // 
            // dtg_sinhvien
            // 
            dtg_sinhvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_sinhvien.Columns.AddRange(new DataGridViewColumn[] { column_stt, column_MSSV, column_name, column_khoa, column_diemtb });
            dtg_sinhvien.Location = new Point(0, 68);
            dtg_sinhvien.Name = "dtg_sinhvien";
            dtg_sinhvien.RowHeadersWidth = 51;
            dtg_sinhvien.Size = new Size(774, 442);
            dtg_sinhvien.TabIndex = 3;
            // 
            // column_stt
            // 
            column_stt.HeaderText = "Số TT";
            column_stt.MinimumWidth = 6;
            column_stt.Name = "column_stt";
            column_stt.Width = 125;
            // 
            // column_MSSV
            // 
            column_MSSV.HeaderText = "Mã Số SV";
            column_MSSV.MinimumWidth = 6;
            column_MSSV.Name = "column_MSSV";
            column_MSSV.Width = 125;
            // 
            // column_name
            // 
            column_name.HeaderText = "Tên Sinh Viên";
            column_name.MinimumWidth = 6;
            column_name.Name = "column_name";
            column_name.Width = 180;
            // 
            // column_khoa
            // 
            column_khoa.HeaderText = "Khoa";
            column_khoa.MinimumWidth = 6;
            column_khoa.Name = "column_khoa";
            column_khoa.Width = 180;
            // 
            // column_diemtb
            // 
            column_diemtb.HeaderText = "Điểm TB";
            column_diemtb.MinimumWidth = 6;
            column_diemtb.Name = "column_diemtb";
            column_diemtb.Width = 110;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(109, 25);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Image = Properties.Resources.icons8_add_male_user_group_1001;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(96, 22);
            toolStripLabel1.Text = "Thêm Mới";
            toolStripLabel1.Click += toolStripLabel1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 508);
            Controls.Add(toolStrip1);
            Controls.Add(dtg_sinhvien);
            Controls.Add(tb_TK_Theo_Ten);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Quản Lý Sinh Viên";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_sinhvien).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem chứcNăngToolStripMenuItem;
        private ToolStripMenuItem thêmMớiToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private Label label1;
        private TextBox tb_TK_Theo_Ten;
        internal DataGridView dtg_sinhvien;
        private DataGridViewTextBoxColumn column_stt;
        private DataGridViewTextBoxColumn column_MSSV;
        private DataGridViewTextBoxColumn column_name;
        private DataGridViewTextBoxColumn column_khoa;
        private DataGridViewTextBoxColumn column_diemtb;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
    }
}
