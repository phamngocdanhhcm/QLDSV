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
 
    public partial class FormQuanLiMonHoc : Form
    {
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public FormQuanLiMonHoc()
        {
            InitializeComponent();

        }
        void loadMonHoc()
        {
            if (Program.conn.State == ConnectionState.Closed)
            { Program.conn.Open(); }
            command = Program.conn.CreateCommand();
            command.CommandText = "SELECT MAMH,TENMH from Monhoc";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgrMON.DataSource = table;
            dgrMON.Refresh();
            


            // Program.conn.Close();
        }


        private void FormQuanLiMonHoc_Load(object sender, EventArgs e)
        {


            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            loadMonHoc();

        }

        private void dgrMON_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i, j, k;
            i = dgrMON.CurrentRow.Index;
            txtMaMon.Text = dgrMON.Rows[i].Cells[0].Value.ToString();
            txtTenMon.Text = dgrMON.Rows[i].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTenMon.Text == "")
            {
                MessageBox.Show("VUi lòng nhập tên môn học!");
            }
            else if (txtMaMon.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã môn học");
            }
            else
            {
                SqlDataReader myReader1;
                string strLenh = "exec SP_KiemTraMaMonHocTonTai N'" + txtMaMon.Text + "'";
                myReader1 = Program.ExecSqlDataReader(strLenh);
                if (myReader1.Equals(null))
                {
                    MessageBox.Show("Không thêm mới thành công");
                    myReader1.Dispose();

                }
                else
                {
                    if (myReader1.Read().ToString() == "True")
                    {
                        MessageBox.Show("Bạn đã nhập trùng mã môn học ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaMon.Focus();
                        myReader1.Dispose();
                        // Thực hiện truy vấn

                    }
                    else
                    {
                        MessageBox.Show("Mã lớp không bị trùng");
                        myReader1.Dispose();
                        // Thực hiện truy vấn


                        string insert = "Insert Into Monhoc(MAMH,TenMH)" +
                                        "Values('" + txtMaMon.Text + "',N'" + txtTenMon.Text + "')";
                        SqlCommand cmd = new SqlCommand(insert, Program.conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm mới thành công", "Thông báo!");

                        // Trả tài nguyên
                        loadMonHoc();

                        cmd.Dispose();

                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtMaMon.Text == "")
            {
                MessageBox.Show("Mã môn học không để trống!");
            }
            else if (txtTenMon.Text == "")
            {
                MessageBox.Show("Tên môn học không để trống!");
            }
            else
            {
                SqlDataReader myReader1;
                string strLenh = "exec SP_KiemTraMaMonHocTonTai N'" + txtMaMon.Text + "'";
                myReader1 = Program.ExecSqlDataReader(strLenh);
                if (myReader1.Equals(null))
                {
                    MessageBox.Show("Update không thành công");
                    myReader1.Dispose();

                }
                else
                {
                    // myReader.Dispose();
                    if (myReader1.Read().ToString() == "True")
                    {
                        myReader1.Dispose();
                        // Thực hiện truy vấn


                        string insert = "Update MonHoc Set TenMH=N'" + txtTenMon.Text + "' where maMH='" + txtMaMon.Text + "'";
                        SqlCommand cmd = new SqlCommand(insert, Program.conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sửa thành công", "Thông báo!");

                        // Trả tài nguyên
                        loadMonHoc();

                        cmd.Dispose();

                    }
                    else
                    {
                        MessageBox.Show("Môn học không tồn tại");

                    }
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtMaMon.Text == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống mã lớp");
            }
            else
            {
                if (Program.conn.State == ConnectionState.Closed)
                { Program.conn.Open(); }
                string insert1 = "delete Diem where mamh='" + txtMaMon.Text + "'";
                SqlCommand cmd1 = new SqlCommand(insert1, Program.conn);
                cmd1.ExecuteNonQuery();
                cmd1.Dispose();


                string insert = "delete monhoc where mamh='" + txtMaMon.Text + "'";
                SqlCommand cmd = new SqlCommand(insert, Program.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công", "Thông báo!");

                // Trả tài nguyên
                loadMonHoc();

                cmd.Dispose();
                txtMaMon.Clear();
                txtTenMon.Clear();
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
