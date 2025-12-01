using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH4_24521470_Bai05
{
    public partial class SinhVien : Form
    {
        private Form1 main_form; 
        private DatabaseHelper db;
        public SinhVien(Form1 f)
        {
            InitializeComponent();
            main_form = f;
            db = new DatabaseHelper();
        }

        // Kiểm tra tính hợp lệ của mã sinh viên
        private static bool Check_msv(string msv)
        {
            foreach (char c in msv)
            {
                if (!char.IsLetter(c) && !char.IsNumber(c))
                {
                    return false;
                }
            }
            return true;
        }

        // Kiểm tra tính hợp lệ của họ tên
        private static bool Check_hoten(string tensv)
        {
            foreach (char c in tensv)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    return false;
                }
            }
            string[] args = tensv.Split(' ');
            foreach (string s in args)
            {
                if (s.Length < 2)
                {
                    return false;
                }
            }
            return true;
        }

        // Kiểm tra tính hợp lệ của điểm tb
        private static bool Check_diemtb(string diemtb)
        {
            if ( double.TryParse(diemtb, out double d ))
            {
                return true;
            }
            return false;
                
        }

        //Kiểm tra tất cả thông tin đầu vào của sinh viên
        private bool Check_Input()
        {
            if (!Check_msv(tb_msv.Text))
            {
                MessageBox.Show("Mã số sinh viên chỉ bao gồm số và chữ!");
                return false;
            }
            if (!Check_hoten(tb_tsv.Text))
            {
                MessageBox.Show("Họ tên chỉ bao gồm từ và cách nhau bởi khoảng trắng, mỗi từ chỉ bao gồm chữ cái và có độ dài ít nhất là 2!");
                return false;
            }
            tb_diemtb.Text = tb_diemtb.Text.Replace('.', ',');
            if (!Check_diemtb(tb_diemtb.Text))
            {
                MessageBox.Show("Điểm trung bình phải có dạng số!");
                return false;
            }    
            return true;
        }

        //Cài đặt chức năng cho button Thêm Mới
        private void bt_them_moi_Click(object sender, EventArgs e)
        {
            if (Check_Input())
            {
                int stt = 0;
                int x = main_form.dtg_sinhvien.Rows.Count;
                if ( x == 1)
                {
                    stt = 1;
                }
                else
                {
                    stt = (int)main_form.dtg_sinhvien.Rows[x - 2].Cells[0].Value + 1;
                }
                    main_form.dtg_sinhvien.Rows.Add(stt, tb_msv.Text, tb_tsv.Text, cb_khoa.SelectedItem, tb_diemtb.Text);
                db.ThemSinhVien(tb_msv.Text, tb_tsv.Text, cb_khoa.SelectedItem.ToString(), Convert.ToDecimal(tb_diemtb.Text));
                tb_msv.Clear();
                tb_tsv.Clear();
                cb_khoa.SelectedItem = null;
                tb_diemtb.Clear();
            }
        }


        //Cài đặt chức năng cho button Thoát
        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
