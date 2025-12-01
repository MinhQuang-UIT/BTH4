using System.Drawing.Text;
using System.Text;

namespace BTH4_24521470_Bai04
{
    public partial class Form1 : Form
    {
        private string cur_filename = "";
        public Form1()
        {
            InitializeComponent();

            InstalledFontCollection installedFonts = new InstalledFontCollection();

            FontFamily[] fontFamilies = installedFonts.Families;

            cb_font.Text = "Tahoma";
            foreach (FontFamily family in fontFamilies)
            {
                cb_font.Items.Add(family.Name);
            }

            cb_size.Text = "14";
            rtb_noidung.Font = new Font("Tahoma", 14, FontStyle.Regular);
        }

        // Cài đặt chức năng cho button Định Dạng
        private void ĐịnhDạng_Click(object sender, EventArgs e)
        {
            FontDialog fdl = new FontDialog();
            fdl.ShowDialog();

            rtb_noidung.SelectionFont = fdl.Font;

            cb_font.SelectedItem = fdl.Font.Name;
            cb_size.SelectedItem = fdl.Font.Size.ToString();
        }

        // Cài đặt chức năng cho Sub Menu Tạo Văn Bản Mới
        private void TạoVănBảnMới_Click(object sender, EventArgs e)
        {
            rtb_noidung.Clear();
            cb_font.Text = "Tahoma";
            cb_size.Text = "14";
            cur_filename = "";

        }

        // Cài đặt chức năng cho button Tạo Văn Bản Mới trên ToolStrip
        private void TaoVBMoi_Click(object sender, EventArgs e)
        {
            rtb_noidung.Clear();
            cb_font.Text = "Tahoma";
            cb_size.Text = "14";
            cur_filename = "";
        }

        // Cài đặt chức năng cho Sub Menu Mở Tập Tin
        private void MởTậpTin_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Tập tin | *.txt; *.rtf";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                cur_filename = openFileDialog.FileName;
                if (cur_filename.EndsWith(".txt"))
                {
                    string text = File.ReadAllText(openFileDialog.FileName, Encoding.UTF8);
                    rtb_noidung.Text = text;
                }    
                else if (cur_filename.EndsWith(".rtf"))
                    rtb_noidung.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
            }
        }

        // Cài đặt chức năng cho Sub Menu Lưu nội dung văn bản
        private void LưuVănBản_Click(object sender, EventArgs e)
        {
            if (cur_filename == "")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.FileName = "Default.rtf";
                saveFileDialog.Filter = "Tệp văn bản | *.rtf";
                cur_filename = saveFileDialog.FileName;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rtb_noidung.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                }
            }
            else
            {
                rtb_noidung.SaveFile(cur_filename, RichTextBoxStreamType.RichText);
                MessageBox.Show("Lưu văn bản thành công", "Thông Báo", MessageBoxButtons.OK);
            }
        }


        // Cài đặt chức năng cho button Lưu văn bản trên ToolStrip
        private void bt_LưuVB_Click(object sender, EventArgs e)
        {
            if (cur_filename == "")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.FileName = "Default.rtf";
                saveFileDialog.Filter = "Tệp văn bản | *.rtf";
                cur_filename = saveFileDialog.FileName;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rtb_noidung.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                }
            }
            else
            {
                rtb_noidung.SaveFile(cur_filename, RichTextBoxStreamType.RichText);
                MessageBox.Show("Lưu văn bản thành công", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        //Cài đặt chức năng cho button B
        private void bt_Bold_Click(object sender, EventArgs e)
        {
            ChangeStyle(FontStyle.Bold);
        }

        //Cài đặt chức năng cho button I
        private void bt_Italic_Click(object sender, EventArgs e)
        {
            ChangeStyle(FontStyle.Italic);
        }

        //Cài đặt chức năng cho button U
        private void bt_underline_Click(object sender, EventArgs e)
        {
            ChangeStyle(FontStyle.Underline);
        }


        // Hàm định dạng lại FontStyle
        private void ChangeStyle(FontStyle style)
        {
            if ((rtb_noidung.SelectionLength == 0))
            {
                Font oldFont = rtb_noidung.SelectionFont ?? rtb_noidung.Font;
                FontStyle newStyle;
                if (oldFont.Style.HasFlag(style))
                    newStyle = oldFont.Style & ~style;
                else
                    newStyle = oldFont.Style | style;
                rtb_noidung.SelectionFont = new Font(oldFont.FontFamily, oldFont.Size, newStyle);
            }
            else
            {
                int start = rtb_noidung.SelectionStart;
                int end = start + rtb_noidung.SelectionLength;
                for ( int i = start; i < end; i++)
                {
                    rtb_noidung.SelectionStart = i;
                    rtb_noidung.SelectionLength = 1;
                    
                    Font oldFont = rtb_noidung.SelectionFont;

                    FontStyle newStyle;
                    if (oldFont.Style.HasFlag(style))
                        newStyle = oldFont.Style & ~style;
                    else
                        newStyle = oldFont.Style | style;

                    rtb_noidung.SelectionFont = new Font(oldFont.FontFamily, oldFont.Size, newStyle);

                }
                rtb_noidung.SelectionStart = start;
                rtb_noidung.SelectionLength = end - start;
            }
        }


        // Cài đặt chức năng cho ComboBox chọn Font
        private void cb_font_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font oldFont = rtb_noidung.SelectionFont ?? rtb_noidung.Font;
            rtb_noidung.SelectionFont = new Font(cb_font.Text, oldFont.Size, oldFont.Style);
        }


        // Cài đặt chức năng cho ComboBox chọn Size
        private void cb_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font oldFont = rtb_noidung.SelectionFont ?? rtb_noidung.Font;
            rtb_noidung.SelectionFont = new Font(oldFont.Name, Convert.ToInt32(cb_size.Text), oldFont.Style);
        }

        //Cài đặt chức năng cho Sub Menu Thoát
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
