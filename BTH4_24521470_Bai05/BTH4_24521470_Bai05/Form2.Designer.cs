namespace BTH4_24521470_Bai05
{
    partial class SinhVien
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
            lb_mssv = new Label();
            lb_tensv = new Label();
            lb_khoa = new Label();
            lb_diemtb = new Label();
            tb_msv = new TextBox();
            tb_tsv = new TextBox();
            tb_diemtb = new TextBox();
            cb_khoa = new ComboBox();
            bt_them_moi = new Button();
            bt_thoat = new Button();
            SuspendLayout();
            // 
            // lb_mssv
            // 
            lb_mssv.AutoSize = true;
            lb_mssv.Location = new Point(52, 53);
            lb_mssv.Name = "lb_mssv";
            lb_mssv.Size = new Size(116, 20);
            lb_mssv.TabIndex = 0;
            lb_mssv.Text = "Mã Số Sinh Viên";
            // 
            // lb_tensv
            // 
            lb_tensv.AutoSize = true;
            lb_tensv.Location = new Point(52, 101);
            lb_tensv.Name = "lb_tensv";
            lb_tensv.Size = new Size(97, 20);
            lb_tensv.TabIndex = 1;
            lb_tensv.Text = "Tên Sinh Viên";
            // 
            // lb_khoa
            // 
            lb_khoa.AutoSize = true;
            lb_khoa.Location = new Point(52, 143);
            lb_khoa.Name = "lb_khoa";
            lb_khoa.Size = new Size(43, 20);
            lb_khoa.TabIndex = 2;
            lb_khoa.Text = "Khoa";
            // 
            // lb_diemtb
            // 
            lb_diemtb.AutoSize = true;
            lb_diemtb.Location = new Point(52, 186);
            lb_diemtb.Name = "lb_diemtb";
            lb_diemtb.Size = new Size(66, 20);
            lb_diemtb.TabIndex = 3;
            lb_diemtb.Text = "Điểm TB";
            // 
            // tb_msv
            // 
            tb_msv.Location = new Point(174, 50);
            tb_msv.Name = "tb_msv";
            tb_msv.Size = new Size(276, 27);
            tb_msv.TabIndex = 4;
            // 
            // tb_tsv
            // 
            tb_tsv.Location = new Point(174, 94);
            tb_tsv.Name = "tb_tsv";
            tb_tsv.Size = new Size(381, 27);
            tb_tsv.TabIndex = 5;
            // 
            // tb_diemtb
            // 
            tb_diemtb.Location = new Point(174, 186);
            tb_diemtb.Name = "tb_diemtb";
            tb_diemtb.Size = new Size(125, 27);
            tb_diemtb.TabIndex = 6;
            // 
            // cb_khoa
            // 
            cb_khoa.BackColor = SystemColors.ScrollBar;
            cb_khoa.FormattingEnabled = true;
            cb_khoa.Items.AddRange(new object[] { "Khoa Học Máy Tính", "Công Nghệ Phần Mềm", "Hệ Thống Thông Tin", "Mạng máy tính và truyền thông", "Công nghệ thông tin" });
            cb_khoa.Location = new Point(174, 143);
            cb_khoa.Name = "cb_khoa";
            cb_khoa.Size = new Size(381, 28);
            cb_khoa.TabIndex = 7;
            // 
            // bt_them_moi
            // 
            bt_them_moi.BackColor = Color.DarkSeaGreen;
            bt_them_moi.Location = new Point(331, 239);
            bt_them_moi.Name = "bt_them_moi";
            bt_them_moi.Size = new Size(94, 29);
            bt_them_moi.TabIndex = 8;
            bt_them_moi.Text = "Thêm Mới";
            bt_them_moi.UseVisualStyleBackColor = false;
            bt_them_moi.Click += bt_them_moi_Click;
            // 
            // bt_thoat
            // 
            bt_thoat.BackColor = Color.Coral;
            bt_thoat.Location = new Point(461, 239);
            bt_thoat.Name = "bt_thoat";
            bt_thoat.Size = new Size(94, 29);
            bt_thoat.TabIndex = 9;
            bt_thoat.Text = "Thoát";
            bt_thoat.UseVisualStyleBackColor = false;
            bt_thoat.Click += bt_thoat_Click;
            // 
            // SinhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 286);
            Controls.Add(bt_thoat);
            Controls.Add(bt_them_moi);
            Controls.Add(cb_khoa);
            Controls.Add(tb_diemtb);
            Controls.Add(tb_tsv);
            Controls.Add(tb_msv);
            Controls.Add(lb_diemtb);
            Controls.Add(lb_khoa);
            Controls.Add(lb_tensv);
            Controls.Add(lb_mssv);
            Name = "SinhVien";
            Text = "Thêm Sinh Viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_mssv;
        private Label lb_tensv;
        private Label lb_khoa;
        private Label lb_diemtb;
        private TextBox tb_msv;
        private TextBox tb_tsv;
        private TextBox tb_diemtb;
        private ComboBox cb_khoa;
        private Button bt_them_moi;
        private Button bt_thoat;
    }
}