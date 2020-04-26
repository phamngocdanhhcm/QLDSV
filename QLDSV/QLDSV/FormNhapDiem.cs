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
    public partial class FormNhapDiem : Form
    {
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loadMonHoc()
        {
            if (Program.conn.State == ConnectionState.Closed)
            { Program.conn.Open(); }
            var cmd = new SqlCommand("Select * from MonHoc", Program.conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cboMonHoc.DisplayMember = "TENMH";
            cboMonHoc.ValueMember = "MAMH";
            cboMonHoc.DataSource = dt;

           // Program.conn.Close();
        }
       
        /*
        void loadData()
        {
            command = Program.conn.CreateCommand();
            command.CommandText = "SELECT MASV,MAMH,LAN,DIEM FROM DIEM ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvDSGV.DataSource = table;
            dgvDSGV.Refresh();
            
            
        }
        */
        
        public FormNhapDiem()
        {
            InitializeComponent();
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

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void FormNhapDiem_Load(object sender, EventArgs e)
        {

            loadMonHoc();
            cboHocKi.Hide();
            mALOPComboBox.Hide();
            //loadLop();
            // TODO: This line of code loads data into the 'dS.DIEM' table. You can move, or remove it, as needed.

            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVDataSet.V_DS_PHANMANH);
            cboHocKi.SelectedIndex = 1;

            cboHocKi.SelectedIndex = 0;
           tENKHOAComboBox.SelectedIndex = 1;
           tENKHOAComboBox.SelectedIndex = 0;
            tENKHOAComboBox.SelectedIndex = Program.mchinhanh;
            if (Program.mGroup == "PGV")
                tENKHOAComboBox.Enabled = true;
            else
                tENKHOAComboBox.Enabled = false;
        }

        private void dgrDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
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
                // loadData();
                loadSinhvien();

            }
        }

        private void tENKHOALabel_Click(object sender, EventArgs e)
        {

        }

        private void cboMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void dIEMDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mALOPLabel_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
       /*
        private void dgvDSGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSV.Enabled = false;
            int i;
            i = dgvDSGV.CurrentRow.Index;
            txtMaSV.Text= dgvDSGV.Rows[i].Cells[0].Value.ToString();
            if (dgvDSGV.Rows[i].Cells[2].Value.ToString()=="1")
            {
                txtDiemThi1.Text= dgvDSGV.Rows[i].Cells[3].Value.ToString();
            }
            if(dgvDSGV.Rows[i].Cells[2].Value.ToString()=="2")
            {
                txtDiemTK.Text = dgvDSGV.Rows[i].Cells[3].Value.ToString();
            }
        }
       */
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void mALOPComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mALOPLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
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

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void mALOPComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtDiemThi1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hovaten;
            SqlDataReader myReader;
            string strLenh = "select Ho,Ten from Sinhvien where MASV= '" + comboBox1.Text + "'";
            /* myReader = Program.ExecSqlDataReader(strLenh);
             hovaten = myReader.GetString(0);
             myReader.Close();
             txtHoTen.Text = hovaten.ToString();
             Program.conn.Close();
             var dr = cmd.ExecuteReader();
             var dt = new DataTable();
             dt.Load(dr);
             dr.Dispose();
             mALOPComboBox.DisplayMember = "MALOP";
             mALOPComboBox.DataSource = dt;
             */
            if (Program.conn.State == ConnectionState.Closed)
            { Program.conn.Open(); }
            var cmd = new SqlCommand("select Ho,Ten from Sinhvien where MASV= '" + comboBox1.Text + "'", Program.conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            mALOPComboBox.DisplayMember = "Ho";
            mALOPComboBox.DataSource = dt;
            hovaten = mALOPComboBox.Text;
            mALOPComboBox.DisplayMember = "Ten";
            hovaten = hovaten + " " + mALOPComboBox.Text;
            txtHoTen.Text = hovaten.ToString();

            var cmd1 = new SqlCommand("Select diem from diem where MASV='" + comboBox1.Text + "' and lan=1 and MAMH='" + cboMonHoc.SelectedValue.ToString() + "'", Program.conn);
            var dr1 = cmd1.ExecuteReader();
            var dt1 = new DataTable();
            dt1.Load(dr1);
            dr1.Dispose();
            cboHocKi.DisplayMember = "Diem";
            cboHocKi.DataSource = dt1;
            comboBox2.Text = "";
            //comboBox1.SelectedIndex = int.Parse(mALOPComboBox.Text);
            if (cboHocKi.Text == "")
                comboBox2.SelectedIndex = 11;
            else comboBox2.Text = cboHocKi.Text;

            var cmd2 = new SqlCommand("Select diem from diem where MASV='" + comboBox1.Text + "' and lan=2 and MAMH='" + cboMonHoc.SelectedValue.ToString() + "'", Program.conn);
            var dr2 = cmd2.ExecuteReader();
            var dt2 = new DataTable();
            dt2.Load(dr2);
            dr2.Dispose();
            cboHocKi.DisplayMember = "Diem";
            cboHocKi.DataSource = dt2;
            if (cboHocKi.Text == "")
                comboBox3.SelectedIndex=11   ;
            else comboBox3.Text=cboHocKi.Text;

            
            
            if (comboBox2.Text == " " || comboBox3.Text==" ")
            {
                button1.Enabled = true;
            }
            else button1.Enabled = false;
            if(comboBox2.Text != " " || comboBox3.Text != " ")
            {
                button2.Enabled = true;
            } else button2.Enabled = false;

            if (comboBox2.Text != " " || comboBox3.Text != " ")
            {
                button3.Enabled = true;
            } else button3.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cmd1 = new SqlCommand("Select diem from diem where MASV='" + comboBox1.Text + "' and lan=1 and MAMH='" + cboMonHoc.SelectedValue.ToString() + "'", Program.conn);
            var dr1 = cmd1.ExecuteReader();
            var dt1 = new DataTable();
            dt1.Load(dr1);
            dr1.Dispose();
            cboHocKi.DisplayMember = "Diem";
            cboHocKi.DataSource = dt1;
            if(cboHocKi.Text=="")
            { 
            if(comboBox2.Text!=" ")
            {
                string sql = "Insert into Diem(MASV,MaMH,Lan,Diem) Values ('"+comboBox1.Text+"','"+cboMonHoc.SelectedValue.ToString()+"',1,"+comboBox2.Text+")";
                SqlCommand cmd = new SqlCommand(sql, Program.conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

            }
            else
                {
                    MessageBox.Show("Vui lòng nnhập điểm lần 1");
                }
            }
            var cmd2 = new SqlCommand("Select diem from diem where MASV='" + comboBox1.Text + "' and lan=2 and MAMH='" + cboMonHoc.SelectedValue.ToString() + "'", Program.conn);
            var dr2 = cmd2.ExecuteReader();
            var dt2 = new DataTable();
            dt2.Load(dr2);
            dr2.Dispose();
            cboHocKi.DisplayMember = "Diem";
            cboHocKi.DataSource = dt2;
            if (cboHocKi.Text == "")
            {
                if(comboBox2.Text==" ")
                {
                    MessageBox.Show("Vui lòng nhập điểm lần 1 rồi mới nhập điểm lần 2 được");
                }
                else if(comboBox3.Text!=" ")
                {
                    string sql3 = "Insert into Diem(MASV,MaMH,Lan,Diem) Values ('" + comboBox1.Text + "','" + cboMonHoc.SelectedValue.ToString() + "',2," + comboBox3.Text + ")";
                    SqlCommand cmd3 = new SqlCommand(sql3, Program.conn);
                    cmd3.ExecuteNonQuery();
                    cmd3.Dispose();
                    MessageBox.Show("Nhập điểm thành công");
                }

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cmd1 = new SqlCommand("Select diem from diem where MASV='" + comboBox1.Text + "' and lan=1 and MAMH='" + cboMonHoc.SelectedValue.ToString() + "'", Program.conn);
            var dr1 = cmd1.ExecuteReader();
            var dt1 = new DataTable();
            dt1.Load(dr1);
            dr1.Dispose();
            cboHocKi.DisplayMember = "Diem";
            cboHocKi.DataSource = dt1;
            if(cboHocKi.Text!="")
            {
                if(comboBox2.Text==" ")
                {
                    MessageBox.Show("Vui lòng chọn điểm lần 1 để sửa !");
                }
                else
                {
                    String sql = "update Diem set diem=" + comboBox2.Text + "where MASV='"+comboBox1.Text+"' and lan=1 and MAMH='"+ cboMonHoc.SelectedValue.ToString()+ "'";
                    SqlCommand cmd = new SqlCommand(sql, Program.conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công", "Thông báo!");
                    // Trả tài nguyên
                    cmd.Dispose();

                    var cmd2 = new SqlCommand("Select diem from diem where MASV='" + comboBox1.Text + "' and lan=2 and MAMH='" + cboMonHoc.SelectedValue.ToString() + "'", Program.conn);
                    var dr2 = cmd2.ExecuteReader();
                    var dt2 = new DataTable();
                    dt2.Load(dr2);
                    dr2.Dispose();
                    cboHocKi.DisplayMember = "Diem";
                    cboHocKi.DataSource = dt2;
                    if(cboHocKi.Text!="")
                    {
                        if(comboBox3.Text==" ")
                        {
                            MessageBox.Show("Vui lòng chọn điểm lần 2 để sửa !");
                        }
                        else
                        {
                            String sql3 = "update Diem set diem=" + comboBox3.Text + "where MASV='" + comboBox1.Text + "' and lan=2 and MAMH='" + cboMonHoc.SelectedValue.ToString() + "'";
                            SqlCommand cmd3 = new SqlCommand(sql3, Program.conn);
                            cmd3.ExecuteNonQuery();
                            MessageBox.Show("Sửa thành công", "Thông báo!");
                            // Trả tài nguyên
                            cmd3.Dispose();

                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormTrangChu f = new FormTrangChu();
            f.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string insert = "delete from Diem where MASV='" + comboBox1.Text + "' and lan=1 and MAMH='" + cboMonHoc.SelectedValue.ToString() + "'";
            string insert1 = "delete from Diem where MASV='" + comboBox1.Text + "' and lan=2 and MAMH='" + cboMonHoc.SelectedValue.ToString() + "'";
            string insert2 = "Select diem from DIEM where MASV='" + comboBox1.Text + "' and lan=1 and MAMH='" + cboMonHoc.SelectedValue.ToString() + "'";
            string insert3 = "Select diem from DIEM where MASV='" + comboBox1.Text + "' and lan=2 and MAMH='" + cboMonHoc.SelectedValue.ToString() + "'";
            var cmd2 = new SqlCommand("Select diem from diem where MASV='" + comboBox1.Text + "' and lan=1 and MAMH='" + cboMonHoc.SelectedValue.ToString() + "'", Program.conn);
            var dr2 = cmd2.ExecuteReader();
            var dt2 = new DataTable();
            dt2.Load(dr2);
            dr2.Dispose();
            cboHocKi.DisplayMember = "Diem";
            cboHocKi.DataSource = dt2;
            if(cboHocKi.Text!="")
            { 
            SqlCommand cmd1 = new SqlCommand(insert, Program.conn);
            cmd1.ExecuteNonQuery();
            cmd1.Dispose();
                comboBox2.SelectedIndex = 11;
            SqlCommand cmd3 = new SqlCommand(insert1, Program.conn);
            cmd3.ExecuteNonQuery();
            cmd3.Dispose();

                comboBox3.SelectedIndex = 11;
                MessageBox.Show("Xóa thành công", "Thông báo!");
            }
            else
            {

            }


        }
    }
}
