namespace BTH4_24521470_Bai05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        //Cài đặt chức năng cho SubMenu Thêm Mới
        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SinhVien Them_SV = new SinhVien(this);
            Them_SV.Show();
        }


        //Cài đặt chức năng cho SubMenu Thoát
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Cài đặt chức năng cho ToolStrip Thêm Mới
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            SinhVien Them_SV = new SinhVien(this);
            Them_SV.Show();
        }

        //Cài đặt chức năng Tìm Kiếm Theo Tên
        private void tb_TK_Theo_Ten_TextChanged(object sender, EventArgs e)
        {
            string filterText = tb_TK_Theo_Ten.Text;

            foreach (DataGridViewRow row in dtg_sinhvien.Rows)
            {
                if (row.IsNewRow) continue;
                bool isVisible = string.IsNullOrEmpty(filterText) ||
                                  row.Cells["column_name"].Value.ToString().IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = isVisible;
            }
        }
    }
}
