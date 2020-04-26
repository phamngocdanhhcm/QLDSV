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
    public partial class FormQuanLyDiem : Form
    {
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public FormQuanLyDiem()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        void loadData()
        {
            command = Program.conn.CreateCommand();
            command.CommandText = "SELECT MASV,MAMH,Lan,Diem FROM DIEM where MaMH='" + cboMonHoc.SelectedValue.ToString() + "' and Lan='"+comboBox2.Text+"'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgrLop.DataSource = table;
            dgrLop.Refresh();
            loadSinhvien();
        }
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

        public float loadData1()
        {
            command = Program.conn.CreateCommand();
            command.CommandText = "SELECT MASV,MAMH,Lan,Diem FROM DIEM where MaMH='" + cboMonHoc.SelectedValue.ToString() + "' and MASV='"+comboBox1.Text+"'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgrLop.DataSource = table;
            dgrLop.Refresh();
            float diem1=0 ;
            for(int k=0;k< dgrLop.RowCount-1;k++)
            {
               float i = float.Parse(dgrLop.Rows[k].Cells[3].Value.ToString());
                if (i>diem1)
                {
                    diem1 = float.Parse(dgrLop.Rows[k].Cells[3].Value.ToString());
                }
            }
            loadData();
            return diem1;
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
               loadData();
                //  loadSinhvien()
                if (Program.mGroup.Equals("USER"))
                {
                    button1.Hide();
                    btnXuat.Hide();
                }
                if (Program.mGroup.Equals("User"))
                {
                    button1.Hide();
                    btnXuat.Hide();
                }
            }

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



        private void FormQuanLyDiem_Load(object sender, EventArgs e)
        {
            if (Program.mGroup.Equals("USER"))
            {
                button1.Hide();
                btnXuat.Hide();
            }
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            loadMonHoc();
            // TODO: This line of code loads data into the 'dS.DIEM' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'qLDSVDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVDataSet.V_DS_PHANMANH);
            comboBox2.SelectedIndex = 0;

            cboMonHoc.SelectedIndex = 1;
            cboMonHoc.SelectedIndex = 0;
            tENKHOAComboBox.SelectedIndex = 1;
            tENKHOAComboBox.SelectedIndex = 0;
            tENKHOAComboBox.SelectedIndex = Program.mchinhanh;
            if (Program.mGroup == "PGV")
                tENKHOAComboBox.Enabled = true;
            else
                tENKHOAComboBox.Enabled = false;
            loadData();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormTrangChu f = new FormTrangChu();
            f.Show();
            this.Hide();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            app.Visible = true;
            worksheet.Cells[1, 1] = "Quản lý điểm theo môn học ";
            worksheet.Cells[3, 1] = "Môn học: " + cboMonHoc.Text + "";
            worksheet.Cells[5, 1] = "STT";
            worksheet.Cells[5, 2] = "Mã Sinh Viên";
            worksheet.Cells[5, 3] = "Mã Môn Học";
            worksheet.Cells[5, 4] = "Lần "+comboBox2.Text;
            worksheet.Cells[5, 5] = "Điểm";
            
            for (int i = 0; i < dgrLop.RowCount -1; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                     
                    worksheet.Cells[i + 6, 1] = i + 1;
                    worksheet.Cells[i + 6, j + 2] = dgrLop.Rows[i].Cells[j].Value;
                    
                }
            }
        }

        private void cboMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            worksheet = workbook.Sheets["Sheet1"];
            app.Visible = true;
            worksheet.Cells[1, 1] = "Quản lý điểm theo sinh viên ";
            worksheet.Cells[3, 1] = "Môn học :" + cboMonHoc.Text + "";
            worksheet.Cells[3, 2] = "Mã Sinh viên :" + comboBox1.Text + "";

            float diem = loadData1();
            worksheet.Cells[5, 1] = "STT";
            worksheet.Cells[5, 2] = "Tên Môn học";
            worksheet.Cells[5, 3] = "Điểm";
           
            
            worksheet.Cells[6, 2] = ""+cboMonHoc.Text;
            worksheet.Cells[6, 3] = ""+diem.ToString();
            worksheet.Cells[6, 1] = 1;


        }
    }
}
