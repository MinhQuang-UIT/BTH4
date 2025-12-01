namespace BTH4_24521470_Bai06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
        }


        // Cài đặt chức năng cho button ... ở đường dẫn thư mục nguồn
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                tb_thu_muc_nguon.Text = fbd.SelectedPath;
            }
        }


        // Cài đặt chức năng cho button ... ở đường dẫn thư mục đích
        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                tb_thu_muc_dich.Text = fbd.SelectedPath;
            }
        }


        //Cài đặt chức năng cho button Sao Chép
        private void bt_saochep_Click(object sender, EventArgs e)
        {

            lb_trangthai.Text = "Đang sao chép: " + tb_thu_muc_nguon.Text;

            progressBar1.Value = 0;

            backgroundWorker1.RunWorkerAsync();
        }


        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (tb_thu_muc_dich.Text == string.Empty || tb_thu_muc_nguon.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ đường dẫn thư mục nguồn và thư mục đích!");
                e.Cancel = true;
            }
            else
            {
                string source = tb_thu_muc_nguon.Text;
                string dest = tb_thu_muc_dich.Text;

                string[] files = Directory.GetFiles(source, "*.*", SearchOption.AllDirectories);
                int total = files.Length;

                for (int i = 0; i < total; i++)
                {
                    string file = files[i];
                    string destFile = Path.Combine(dest, Path.GetFileName(file));

                    File.Copy(file, destFile, true);

                    int percent = (int)((i + 1) * 100.0 / total);
                    backgroundWorker1.ReportProgress(percent, file);
                }
                e.Result = true;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lb_trangthai.Text = "Đang sao chép: " + (string)e.UserState;

            toolTip1.SetToolTip(progressBar1, e.UserState.ToString());

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if ( !e.Cancelled )
                MessageBox.Show("Sao chép hoàn tất!");
            
        }
    }
}
