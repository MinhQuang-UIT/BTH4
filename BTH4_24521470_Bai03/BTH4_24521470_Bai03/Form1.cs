using System.Windows.Forms;

namespace BTH4_24521470_Bai03
{
    public partial class Form1 : Form
    {
        private DateTime time = DateTime.Now;    // Khởi tạo biến thời gian
        private System.Windows.Forms.Timer tg = new System.Windows.Forms.Timer();    //Khởi tạo timer
        public Form1()
        {
            InitializeComponent();
            tg.Interval = 1000;     
            tg.Tick += Tg_Timer;
            tg.Start();
            
            toolStripStatusLabel1.Text = "Hôm nay là ngày " + time.ToString("dd/MM/yyyy") + " - Bây giờ là " + time.ToString("HH:mm:ss tt");
        }

        // Cài đặt sự kiện Tick
        private void Tg_Timer(object? sender, EventArgs e)
        {
            time = DateTime.Now;
            toolStripStatusLabel1.Text = "Hôm nay là ngày " + time.ToString("dd/MM/yyyy") + " - Bây giờ là " + time.ToString("HH:mm:ss tt");
        }

        // Cài đặt chức năng cho Sub Menu Open
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();

            opd.Filter = "Tập tin Audio và Video | *.avi; *.mpeg; *.wav; *.midi; *.mp4; *.mp3";

            if (opd.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = opd.FileName;

                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        // Cài đặt chức năng cho Sub Menu Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tg.Stop();
            this.Close();
        }
    }
}
