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
    public partial class FormQuanLySinhVien : Form
    {
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public void loadSinhvien()
        {
            if (Program.conn.State == ConnectionState.Closed)
            { Program.conn.Open(); }
            var cmd = new SqlCommand("Select MALOP from LOP ", Program.conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            mALOPComboBox.DisplayMember = "MALOP";
            mALOPComboBox.DataSource = dt;

            comboBox1.DisplayMember = "MALOP";
            comboBox1.DataSource = dt;
        }
        void loadData()
        {
            command = Program.conn.CreateCommand();
            command.CommandText = "SELECT MASV,MAlop,ho,ten,phai,ngaysinh,noisinh,diachi,nghihoc FROM Sinhvien where Malop='"+mALOPComboBox.Text+"'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgrDSSV.DataSource = table;
            dgrDSSV.Refresh();

        }
            public FormQuanLySinhVien()
        {
            InitializeComponent();
        }
        

        private void FormQuanLySinhVien_Load(object sender, EventArgs e)
        {
            if(Program.mGroup.Equals("USER"))
            {
                btnXuat.Hide();
            }
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVDataSet.V_DS_PHANMANH); 
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            loadSinhvien();
            mALOPComboBox.SelectedIndex = 1;
            mALOPComboBox.SelectedIndex = 0;
            loadData();
            tENKHOAComboBox.SelectedIndex = 1;
            tENKHOAComboBox.SelectedIndex = 0;
            tENKHOAComboBox.SelectedIndex = Program.mchinhanh;
            if (Program.mGroup == "PGV")
                tENKHOAComboBox.Enabled = true;
            else
                tENKHOAComboBox.Enabled = false;

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void tENKHOAComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (tENKHOAComboBox.SelectedValue.ToString()!= Program.servername)
            {
                Program.servername = tENKHOAComboBox.SelectedValue.ToString();
            }
            if(tENKHOAComboBox.SelectedIndex !=Program.mchinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            
            if(Program.KetNoi()==0)
            {
                MessageBox.Show("Lỗi kết nối với chi nhánh mới","",MessageBoxButtons.OK);
            }
            else
            {
                loadSinhvien();
                loadData();
                if (Program.mGroup.Equals("USER"))
                {
                    btnXuat.Hide();
                }
                if (Program.mGroup.Equals("User"))
                {
                    btnXuat.Hide();
                }
            }
        }
        

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            
            //Kiem tra trung ten MaSV
             //Program.conn.ConnectionString = Program.connstr;
            //Program.conn.Open();
            if (mASVTextBox.Text == "")
            {
               MessageBox.Show( "Mã sinh viên không để trống!");
            }
            else 
            {
                SqlDataReader myReader;
                string strLenh = "exec SP_KiemTraMaSinhVienTonTai '" + mASVTextBox.Text + "'";
                myReader = Program.ExecSqlDataReader(strLenh);
                if (myReader.Equals(null)) {
                    MessageBox.Show("a");
                    myReader.Dispose();

                }
                else {
                   // myReader.Dispose();
                    if (myReader.Read().ToString()=="True")
                    {
                        MessageBox.Show("Bạn đã nhập trùng mã sinh viên ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        mASVTextBox.Focus();
                        myReader.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Mã sinh viên không bị trùng");
                        myReader.Dispose();
                        // Thực hiện truy vấn
                        int u = 0, i = 0;
                        if (pHAICheckBox.Checked)
                        {
                            u = 1;
                        }
                        if (nGHIHOCCheckBox.Checked)
                        {
                            i = 1;
                        }

                        string insert = "Insert Into SINHVIEN(MASV,MALOP,HO,TEN,PHAI,NGAYSINH,NOISINH,DIACHI,NGHIHOC)" +
                                        "Values('" + mASVTextBox.Text + "',N'" + mALOPComboBox.Text + "',N'" +
                                        hOTextBox.Text + "',N'" + tENTextBox.Text + "','" + u + "','" +
                                        nGAYSINHDateTimePicker.Value.Date.ToString("yyyy - MM - dd HH: mm:ss") + "',N'" + nOISINHTextBox.Text + "',N'" + dIACHITextBox.Text + "','" + i + "')";
                        SqlCommand cmd = new SqlCommand(insert, Program.conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm mới thành công", "Thông báo!");

                        // Trả tài nguyên
                        loadData();
                        cmd.Dispose();
                       
                    }
                
                }
               
            }
            // Trả tài nguyên

            //myReader.Dispose();
            //Load lai du lieu
            loadData();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            mASVTextBox.Clear();
            comboBox1.SelectedIndex = 0;
            hOTextBox.Clear();
            tENTextBox.Clear();
            pHAICheckBox.Checked = false;
            nOISINHTextBox.Clear();
            dIACHITextBox.Clear();
            nGHIHOCCheckBox.Checked = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int u = 0, i = 0;
            if (pHAICheckBox.Checked)
            {
                u = 1;
            }
            if (nGHIHOCCheckBox.Checked)
            {
                i = 1;
            }

            string insert = "Update SINHVIEN Set MALOP='" + mALOPComboBox.Text + "',HO=N'" + hOTextBox.Text + "',TEN=N'" + tENTextBox.Text + "'," +
                "PHAI='" + u + "',NGAYSINH='" + nGAYSINHDateTimePicker.Value.Date.ToString("yyyy - MM - dd HH: mm:ss") + "'," +
                "NOISINH=N'" + nOISINHTextBox.Text + "',DIACHI=N'" + dIACHITextBox.Text + "',NGHIHOC=" + i + " Where MASV='" + mASVTextBox.Text+"'";

            SqlCommand cmd = new SqlCommand(insert, Program.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sửa thành công", "Thông báo!");

            // Trả tài nguyên

            cmd.Dispose();
           
            loadData();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlDataReader myReader;
            string insert = "delete from SinhVien where MASV='" + mASVTextBox.Text + "'";
            string insert1 = "delete from Diem where MASV='" + mASVTextBox.Text + "'";
            string insert2 = "Select MASV from DIEM where MASV='"+mASVTextBox.Text+"'";
            myReader = Program.ExecSqlDataReader(insert2);
            if(myReader==null)
            {
                myReader.Close();
                SqlCommand cmd1 = new SqlCommand(insert, Program.conn);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công", "Thông báo!");
                loadData();
                mASVTextBox.Clear();
                comboBox1.SelectedIndex = 0;
                hOTextBox.Clear();
                tENTextBox.Clear();
                pHAICheckBox.Checked = false;
                nOISINHTextBox.Clear();
                dIACHITextBox.Clear();
                nGHIHOCCheckBox.Checked = false;

            }
            else
            {
                myReader.Close();
                SqlCommand cmd = new SqlCommand(insert1, Program.conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                myReader.Close();
                SqlCommand cmd1 = new SqlCommand(insert, Program.conn);
                cmd1.ExecuteNonQuery();
                cmd1.Dispose();
                loadData();
                mASVTextBox.Clear();
                comboBox1.SelectedIndex = 0;
                hOTextBox.Clear();
                tENTextBox.Clear();
                pHAICheckBox.Checked = false;
                nOISINHTextBox.Clear();
                dIACHITextBox.Clear();
                nGHIHOCCheckBox.Checked = false;

            }
    
    
        }

        private void dgrDSSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i, j,k;
            i = dgrDSSV.CurrentRow.Index;
            mASVTextBox.Text = dgrDSSV.Rows[i].Cells[0].Value.ToString();
            comboBox1.Text = dgrDSSV.Rows[i].Cells[1].Value.ToString();
            hOTextBox.Text =dgrDSSV.Rows[i].Cells[2].Value.ToString();
            tENTextBox.Text  = dgrDSSV.Rows[i].Cells[3].Value.ToString();
            if (dgrDSSV.Rows[i].Cells[4].Value.Equals(true))
            {
                pHAICheckBox.CheckState = CheckState.Checked;
            }
            else pHAICheckBox.CheckState = CheckState.Unchecked;
           // MessageBox.Show(dgrDSSV.Rows[i].Cells[4].Value.ToString());
            nGAYSINHDateTimePicker.Text= dgrDSSV.Rows[i].Cells[5].Value.ToString();
            nOISINHTextBox.Text = dgrDSSV.Rows[i].Cells[6].Value.ToString();
            dIACHITextBox.Text = dgrDSSV.Rows[i].Cells[7].Value.ToString();
            if (dgrDSSV.Rows[i].Cells[8].Value.Equals(true))
            {
                nGHIHOCCheckBox.CheckState = CheckState.Checked;
            }
            else nGHIHOCCheckBox.CheckState = CheckState.Unchecked;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FormTrangChu f = new FormTrangChu();
            f.Show();
            this.Hide();
        }

        private void mALOPComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            app.Visible = true;
            worksheet.Cells[1, 1] = "Bảng danh sách sinh viên ";
            worksheet.Cells[3, 1] = "Lớp " + mALOPComboBox.Text + "";
            worksheet.Cells[5, 1] = "STT";
            worksheet.Cells[5, 2] = "Mã Sinh Viên";
            worksheet.Cells[5, 3] = "Mã Lớp";
            worksheet.Cells[5, 4] = "Họ";
            worksheet.Cells[5, 5] = "Tên";
            worksheet.Cells[5, 6] = "Phái";
            worksheet.Cells[5, 7] = "Ngày sinh";
            worksheet.Cells[5, 8] = "Nơi sinh";
            worksheet.Cells[5, 9] = "Địa chỉ";
            worksheet.Cells[5, 10] = "Nghỉ học";

            for(int i=0;i<dgrDSSV.RowCount ; i++)
            {
                for(int j=0;j<9;j++)
                {
                    worksheet.Cells[i + 6, 1] = i + 1;
                    worksheet.Cells[i + 6, j + 2] = dgrDSSV.Rows[i].Cells[j].Value;
                }
            }
        }
    }
}
