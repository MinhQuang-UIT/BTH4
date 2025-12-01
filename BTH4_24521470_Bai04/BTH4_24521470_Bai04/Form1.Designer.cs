using System.Windows.Forms;

namespace BTH4_24521470_Bai04
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
            rtb_noidung = new RichTextBox();
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            Item_TaoVBMoi = new ToolStripMenuItem();
            Item_MoTapTin = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            Item_LưuVănBản = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            bt_ĐịnhDạng = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            bt_TaoVBMoi = new ToolStripButton();
            bt_LưuVB = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            cb_font = new ToolStripComboBox();
            cb_size = new ToolStripComboBox();
            bt_Bold = new ToolStripButton();
            bt_Italic = new ToolStripButton();
            bt_Underline = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // rtb_noidung
            // 
            rtb_noidung.Location = new Point(0, 59);
            rtb_noidung.Name = "rtb_noidung";
            rtb_noidung.Size = new Size(644, 407);
            rtb_noidung.TabIndex = 0;
            rtb_noidung.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, bt_ĐịnhDạng });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(644, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Item_TaoVBMoi, Item_MoTapTin, toolStripSeparator3, Item_LưuVănBản, thoátToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(85, 24);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // Item_TaoVBMoi
            // 
            Item_TaoVBMoi.Image = Properties.Resources.Gemini_Generated_Image_ghk95dghk95dghk9;
            Item_TaoVBMoi.Name = "Item_TaoVBMoi";
            Item_TaoVBMoi.Size = new Size(299, 26);
            Item_TaoVBMoi.Text = "Tạo văn bản mới             Ctrl+N";
            Item_TaoVBMoi.Click += TạoVănBảnMới_Click;
            // 
            // Item_MoTapTin
            // 
            Item_MoTapTin.Image = Properties.Resources.icons8_opened_folder_100;
            Item_MoTapTin.Name = "Item_MoTapTin";
            Item_MoTapTin.Size = new Size(299, 26);
            Item_MoTapTin.Text = "Mở tập tin";
            Item_MoTapTin.Click += MởTậpTin_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(296, 6);
            // 
            // Item_LưuVănBản
            // 
            Item_LưuVănBản.Image = Properties.Resources.save_icon;
            Item_LưuVănBản.Name = "Item_LưuVănBản";
            Item_LưuVănBản.Size = new Size(299, 26);
            Item_LưuVănBản.Text = "Lưu nội dung văn bản     Ctrl+S";
            Item_LưuVănBản.Click += LưuVănBản_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(299, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // bt_ĐịnhDạng
            // 
            bt_ĐịnhDạng.Name = "bt_ĐịnhDạng";
            bt_ĐịnhDạng.Size = new Size(92, 24);
            bt_ĐịnhDạng.Text = "Định dạng";
            bt_ĐịnhDạng.Click += ĐịnhDạng_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.InactiveCaption;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { bt_TaoVBMoi, bt_LưuVB, toolStripSeparator1, cb_font, cb_size, bt_Bold, bt_Italic, bt_Underline, toolStripSeparator2 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(644, 28);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // bt_TaoVBMoi
            // 
            bt_TaoVBMoi.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bt_TaoVBMoi.ForeColor = SystemColors.ActiveBorder;
            bt_TaoVBMoi.Image = (Image)resources.GetObject("bt_TaoVBMoi.Image");
            bt_TaoVBMoi.ImageTransparentColor = SystemColors.ActiveBorder;
            bt_TaoVBMoi.Name = "bt_TaoVBMoi";
            bt_TaoVBMoi.Size = new Size(29, 25);
            bt_TaoVBMoi.Text = "toolStripButton1";
            bt_TaoVBMoi.Click += TaoVBMoi_Click;
            // 
            // bt_LưuVB
            // 
            bt_LưuVB.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bt_LưuVB.Image = (Image)resources.GetObject("bt_LưuVB.Image");
            bt_LưuVB.ImageTransparentColor = Color.Magenta;
            bt_LưuVB.Name = "bt_LưuVB";
            bt_LưuVB.Size = new Size(29, 25);
            bt_LưuVB.Text = "toolStripButton2";
            bt_LưuVB.Click += bt_LưuVB_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // cb_font
            // 
            cb_font.Name = "cb_font";
            cb_font.Size = new Size(121, 28);
            cb_font.SelectedIndexChanged += cb_font_SelectedIndexChanged;
            // 
            // cb_size
            // 
            cb_size.Items.AddRange(new object[] { "8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72" });
            cb_size.Name = "cb_size";
            cb_size.Size = new Size(121, 28);
            cb_size.SelectedIndexChanged += cb_size_SelectedIndexChanged;
            // 
            // bt_Bold
            // 
            bt_Bold.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bt_Bold.Image = (Image)resources.GetObject("bt_Bold.Image");
            bt_Bold.ImageTransparentColor = Color.Magenta;
            bt_Bold.Name = "bt_Bold";
            bt_Bold.Size = new Size(29, 25);
            bt_Bold.Text = "toolStripButton3";
            bt_Bold.Click += bt_Bold_Click;
            // 
            // bt_Italic
            // 
            bt_Italic.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bt_Italic.Image = (Image)resources.GetObject("bt_Italic.Image");
            bt_Italic.ImageTransparentColor = Color.Magenta;
            bt_Italic.Name = "bt_Italic";
            bt_Italic.Size = new Size(29, 25);
            bt_Italic.Text = "toolStripButton4";
            bt_Italic.Click += bt_Italic_Click;
            // 
            // bt_Underline
            // 
            bt_Underline.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bt_Underline.Image = (Image)resources.GetObject("bt_Underline.Image");
            bt_Underline.ImageTransparentColor = Color.Magenta;
            bt_Underline.Name = "bt_Underline";
            bt_Underline.Size = new Size(29, 25);
            bt_Underline.Text = "toolStripButton5";
            bt_Underline.Click += bt_underline_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 28);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 463);
            Controls.Add(toolStrip1);
            Controls.Add(rtb_noidung);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Soạn thảo văn bản";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtb_noidung;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem bt_ĐịnhDạng;
        private ToolStrip toolStrip1;
        private ToolStripButton bt_TaoVBMoi;
        private ToolStripButton bt_LưuVB;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripComboBox cb_font;
        private ToolStripComboBox cb_size;
        private ToolStripButton bt_Bold;
        private ToolStripButton bt_Italic;
        private ToolStripButton bt_Underline;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem Item_TaoVBMoi;
        private ToolStripMenuItem Item_MoTapTin;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem Item_LưuVănBản;
        private ToolStripMenuItem thoátToolStripMenuItem;
    }
}
