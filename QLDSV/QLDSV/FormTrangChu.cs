using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class FormTrangChu : Form
    {
        
        public FormTrangChu()
        {
            InitializeComponent();
        }
       
        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            Screen scr = Screen.PrimaryScreen;
            button3.Hide();
            label2.Text = Program.mHoten;
            if(Program.mGroup.Equals("PGV"))
            {
                button3.Show();
            }
        }

        private void btl5_Click(object sender, EventArgs e)
        {
            FormQuanLyLop f = new FormQuanLyLop();
            f.Show();
            this.Hide();
        }

        private void mnuItemQuanli_Click(object sender, EventArgs e)
        {

        }

        private void mnuSV_Click(object sender, EventArgs e)
        {

        }

        private void mnuItemThongKe_Click(object sender, EventArgs e)
        {

        }

        private void btl3_Click(object sender, EventArgs e)
        {

        }

        private void btl1_Click(object sender, EventArgs e)
        {
            FormQuanLySinhVien f = new FormQuanLySinhVien();
            f.Show();
            this.Hide();
        }

        private void btl4_Click(object sender, EventArgs e)
        {
            FormNhapDiem f = new FormNhapDiem();
            f.Show();
            this.Hide();
        }

        private void btl6_Click(object sender, EventArgs e)
        {
            FormQuanLiMonHoc f = new FormQuanLiMonHoc();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormQuanLyDiem f = new FormQuanLyDiem();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormTaoTaiKhoan f = new FormTaoTaiKhoan();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDangNhap f = new FormDangNhap();
            f.Show();
            this.Hide();
        }
    }
}
