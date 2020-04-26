using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QLDSV
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.KHOA' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'qLDSVDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVDataSet.V_DS_PHANMANH);
            tENKHOAComboBox.SelectedIndex = 1;
            tENKHOAComboBox.SelectedIndex = 0;


        }

        private void tENKHOAComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.servername = tENKHOAComboBox.SelectedValue.ToString();
           
        }

        private void DSPM_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            FormDangNhap_Load(sender, e);
            if (username.Text.Trim() == "")
            { 
                MessageBox.Show("Vui lòng nhập username","Báo lỗi đăng nhập",MessageBoxButtons.OK);
                username.Focus();
                return;
            }
            Program.mlogin = username.Text;
            Program.password = txtpassword.Text;
            if (Program.KetNoi() == 0)
            {
                return;
            }
            MessageBox.Show("Đăng nhập thành công","",MessageBoxButtons.OK);
            SqlDataReader myReader;
            string strLenh = "exec SP_DANGNHAP '" + username.Text + "'";
            myReader = Program.ExecSqlDataReader(strLenh);
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            if(myReader==null)
            {
                return;
            }
            myReader.Read();
            Program.username = myReader.GetString(0);
            if(Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không hợp lệ để truy cập dữ liệu");
                return;
            }
            Program.mHoten = myReader.GetString(1);
            Program.mGroup = myReader.GetString(2);
            myReader.Close();
            Program.conn.Close();
            FormTrangChu f = new FormTrangChu();
            f.Show();
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (username.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập username", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                username.Focus();
                return;
            }
            Program.mlogin = username.Text;
            Program.password = txtpassword.Text;
            if (Program.KetNoi() == 0)
            {
                return;
            }
            MessageBox.Show("Đăng nhập thành công", "", MessageBoxButtons.OK);
            SqlDataReader myReader;
            Program.mchinhanh = tENKHOAComboBox.SelectedIndex;
            string strLenh = "exec SP_DANGNHAP '" + username.Text + "'";
            
            myReader = Program.ExecSqlDataReader(strLenh);
            if (myReader == null)
            {
                return;
            }
            myReader.Read();
            Program.username = myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không hợp lệ để truy cập dữ liệu");
                return;
            }
            Program.mHoten = myReader.GetString(1);
            Program.mGroup = myReader.GetString(2);
            Program.mloginDN = username.Text;
            Program.passwordDN = txtpassword.Text;
            myReader.Close();
            Program.conn.Close();
            FormTrangChu f = new FormTrangChu();
            f.Show();
            this.Hide();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
