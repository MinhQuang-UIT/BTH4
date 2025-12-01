namespace BTH4_24521470_Bai06
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            bt_saochep = new Button();
            button2 = new Button();
            button1 = new Button();
            tb_thu_muc_dich = new TextBox();
            tb_thu_muc_nguon = new TextBox();
            label2 = new Label();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            groupBox2 = new GroupBox();
            progressBar1 = new ProgressBar();
            stt_trangthai = new StatusStrip();
            lb_trangthai = new ToolStripStatusLabel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            stt_trangthai.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bt_saochep);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(tb_thu_muc_dich);
            groupBox1.Controls.Add(tb_thu_muc_nguon);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(56, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(833, 224);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sao chép tập tin";
            // 
            // bt_saochep
            // 
            bt_saochep.BackColor = SystemColors.ControlLight;
            bt_saochep.FlatStyle = FlatStyle.Popup;
            bt_saochep.ForeColor = SystemColors.ControlText;
            bt_saochep.Location = new Point(259, 177);
            bt_saochep.Name = "bt_saochep";
            bt_saochep.Size = new Size(193, 29);
            bt_saochep.TabIndex = 6;
            bt_saochep.Text = "Sao Chép";
            bt_saochep.UseVisualStyleBackColor = false;
            bt_saochep.Click += bt_saochep_Click;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.HotTrack;
            button2.Location = new Point(761, 129);
            button2.Name = "button2";
            button2.Size = new Size(50, 29);
            button2.TabIndex = 5;
            button2.Text = "...";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.HotTrack;
            button1.Location = new Point(761, 61);
            button1.Name = "button1";
            button1.Size = new Size(50, 29);
            button1.TabIndex = 4;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tb_thu_muc_dich
            // 
            tb_thu_muc_dich.Location = new Point(259, 129);
            tb_thu_muc_dich.Name = "tb_thu_muc_dich";
            tb_thu_muc_dich.Size = new Size(496, 27);
            tb_thu_muc_dich.TabIndex = 3;
            // 
            // tb_thu_muc_nguon
            // 
            tb_thu_muc_nguon.Location = new Point(259, 61);
            tb_thu_muc_nguon.Name = "tb_thu_muc_nguon";
            tb_thu_muc_nguon.Size = new Size(496, 27);
            tb_thu_muc_nguon.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(32, 133);
            label2.Name = "label2";
            label2.Size = new Size(181, 20);
            label2.TabIndex = 1;
            label2.Text = "Đường Dẫn Thư Mục Đích";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(32, 61);
            label1.Name = "label1";
            label1.Size = new Size(196, 20);
            label1.TabIndex = 0;
            label1.Text = "Đường Dẫn Thư Mục Nguồn";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(progressBar1);
            groupBox2.ForeColor = SystemColors.HotTrack;
            groupBox2.Location = new Point(56, 297);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(825, 104);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tiến trình sao chép";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(44, 49);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(767, 29);
            progressBar1.TabIndex = 0;
            // 
            // stt_trangthai
            // 
            stt_trangthai.ImageScalingSize = new Size(20, 20);
            stt_trangthai.Items.AddRange(new ToolStripItem[] { lb_trangthai });
            stt_trangthai.Location = new Point(0, 406);
            stt_trangthai.Name = "stt_trangthai";
            stt_trangthai.Size = new Size(943, 26);
            stt_trangthai.TabIndex = 3;
            stt_trangthai.Text = "statusStrip1";
            // 
            // lb_trangthai
            // 
            lb_trangthai.Name = "lb_trangthai";
            lb_trangthai.Size = new Size(119, 20);
            lb_trangthai.Text = "Đang Sao Chép: ";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 432);
            Controls.Add(stt_trangthai);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Sao chép tập tin";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            stt_trangthai.ResumeLayout(false);
            stt_trangthai.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button bt_saochep;
        private Button button2;
        private Button button1;
        private TextBox tb_thu_muc_dich;
        private TextBox tb_thu_muc_nguon;
        private ToolTip toolTip1;
        private GroupBox groupBox2;
        private ProgressBar progressBar1;
        private StatusStrip stt_trangthai;
        private ToolStripStatusLabel lb_trangthai;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
