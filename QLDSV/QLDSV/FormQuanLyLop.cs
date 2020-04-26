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
    public partial class FormQuanLyLop : Form
    {
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string makhoa;
        public FormQuanLyLop()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        void loadData()
        {
            command = Program.conn.CreateCommand();
            command.CommandText = "SELECT Malop,makh,tenlop FROM LOP ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgrLop.DataSource = table;
            dgrLop.Refresh();


        }


        private void FormQuanLyLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVDataSet.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'dS.KHOA' table. You can move, or remove it, as needed.
            //loadData();
            tENKHOAComboBox.SelectedIndex = 1;
            tENKHOAComboBox.SelectedIndex = 0;
            tENKHOAComboBox.SelectedIndex = Program.mchinhanh;
            if (Program.mGroup == "PGV")
                tENKHOAComboBox.Enabled = true;
            else
                tENKHOAComboBox.Enabled = false;

        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void tENKHOAComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tENKHOAComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
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
                loadData();
                if (tENKHOAComboBox.SelectedIndex == 0)
                {
                    makhoa = "KH000001";
                }
                else if (tENKHOAComboBox.SelectedIndex == 1)
                {
                    makhoa = "KH000002";
                }
                //loadSinhvien();


            }
        }

        private void dgrLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgrLop.CurrentRow.Index;
            txtMaLop.Text = dgrLop.Rows[i].Cells[0].Value.ToString();
            txtTenlop.Text = dgrLop.Rows[i].Cells[2].Value.ToString();
            button1.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtMaLop.Clear();
            txtTenlop.Clear();
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text == "")
            {
                MessageBox.Show("Mã lớp không để trống!");
            }
            else if (txtTenlop.Text == "")
            {
                MessageBox.Show("Tên lớp không để trống!");
            }
            else
            {
                SqlDataReader myReader1;
                string strLenh = "exec SP_KiemTraMaLopTonTai N'" + txtMaLop.Text + "'";
                myReader1 = Program.ExecSqlDataReader(strLenh);
                if (myReader1.Equals(null))
                {
                    MessageBox.Show("a");
                    myReader1.Dispose();

                }
                else
                {
                    // myReader.Dispose();
                    if (myReader1.Read().ToString() == "True")
                    {
                        MessageBox.Show("Bạn đã nhập trùng mã Lớp ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaLop.Focus();
                        myReader1.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Mã lớp không bị trùng");
                        myReader1.Dispose();
                        // Thực hiện truy vấn


                        string insert = "Insert Into Lop(MALop,MAkh,Tenlop)" +
                                        "Values('" + txtMaLop.Text + "','" + makhoa + "','" + txtTenlop.Text + "')";
                        SqlCommand cmd = new SqlCommand(insert, Program.conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm mới thành công", "Thông báo!");

                        // Trả tài nguyên
                        loadData();
                        cmd.Dispose();

                    }

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text == "")
            {
                MessageBox.Show("Mã lớp không để trống!");
            }
            else if (txtTenlop.Text == "")
            {
                MessageBox.Show("Tên lớp không để trống!");
            }
            else
            {
                SqlDataReader myReader1;
                string strLenh = "exec SP_KiemTraMaLopTonTai N'" + txtMaLop.Text + "'";
                myReader1 = Program.ExecSqlDataReader(strLenh);
                if (myReader1.Equals(null))
                {
                    MessageBox.Show("a");
                    myReader1.Dispose();

                }
                else
                {
                    // myReader.Dispose();
                    if (myReader1.Read().ToString() == "True")
                    {
                       
                        myReader1.Dispose();
                        // Thực hiện truy vấn


                        string insert = "Update Lop Set Tenlop='" + txtTenlop.Text + "' where malop='" + txtMaLop.Text + "'";
                        SqlCommand cmd = new SqlCommand(insert, Program.conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sửa thành công", "Thông báo!");

                        // Trả tài nguyên
                        loadData();
                        cmd.Dispose();

                    }
                    else
                    {
                        MessageBox.Show("Lớp không tồn tại");

                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống mã lớp");
            }
            else {
                String insert2 = "delete Diem where masv=(select masv from Sinhvien where Malop='"+txtMaLop.Text+"')";
                SqlCommand cmd2 = new SqlCommand(insert2, Program.conn);
                cmd2.ExecuteNonQuery();
                cmd2.Dispose();

                String insert1 = "delete Sinhvien where malop='" + txtMaLop.Text + "'";
                SqlCommand cmd1 = new SqlCommand(insert1, Program.conn);
                cmd1.ExecuteNonQuery();
               
                cmd1.Dispose();
                string insert = "delete Lop  where malop='" + txtMaLop.Text + "'";
            SqlCommand cmd = new SqlCommand(insert, Program.conn);
            cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("Xóa thành công", "Thông báo!"); // Trả tài nguyên
                loadData();
            cmd.Dispose();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormTrangChu f = new FormTrangChu();
            f.Show();
            this.Hide();
        }
    }
}
