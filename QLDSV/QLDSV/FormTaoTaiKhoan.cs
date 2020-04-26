using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class FormTaoTaiKhoan : Form
    {
        public FormTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void FormTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            Screen scr = Screen.PrimaryScreen;
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            //this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            // TODO: This line of code loads data into the 'qLDSVDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVDataSet.V_DS_PHANMANH);
            tENKHOAComboBox.SelectedIndex = 1;
            tENKHOAComboBox.SelectedIndex = 0;
            tENKHOAComboBox.SelectedIndex = Program.mchinhanh;
            
            
        }
        public void loadSinhvien()
        {
            if (Program.conn.State == ConnectionState.Closed)
            { Program.conn.Open(); }
            var cmd = new SqlCommand("Select * from Sinhvien ", Program.conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            comboBox1.DisplayMember = "MASV";
            comboBox1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tENKHOAComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tENKHOAComboBox.SelectedValue.ToString() != Program.servername)
            {
                Program.servername = tENKHOAComboBox.SelectedValue.ToString();
            }
            if (tENKHOAComboBox.SelectedIndex != Program.mchinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối với chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {
                if(tENKHOAComboBox.Text.Equals("KHOA CNTT"))
                {
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("KHOA_CNTT");
                    comboBox2.Items.Add("PGV");
                    comboBox2.Items.Add("USER");
                    comboBox2.SelectedIndex = 0;

                }
                else
                {

                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("KHOA_VT");
                    comboBox2.Items.Add("PGV");
                    comboBox2.Items.Add("USER");
                    comboBox2.SelectedIndex = 0;

                }
                //loadData();
                loadSinhvien();

            }
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập username");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Password");
            }
            else
            {
                
                try { 
                    SqlDataReader myReader;
                    if (Program.conn.State == ConnectionState.Closed)
                    { Program.conn.Open(); }
                    var cmd = new SqlCommand("sp_TaoTaiKhoan",Program.conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = textBox1.Text;
                    cmd.Parameters.Add("@Pass", SqlDbType.NVarChar).Value = textBox2.Text;
                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = comboBox1.Text;
                    cmd.Parameters.Add("@Role", SqlDbType.NVarChar).Value = comboBox2.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tạo Thành Công");
                    cmd.Dispose();
                    Program.conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tạo thất bại, tài khoản đã tồn tại");
                }
               
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FormTrangChu f = new FormTrangChu();
            f.Show();
            this.Hide();
        }
    }
}
