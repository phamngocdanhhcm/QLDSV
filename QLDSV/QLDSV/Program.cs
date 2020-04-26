using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QLDSV
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;

        public static String servername = "";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";

        public static String database = "QLDSV";
        public static String remotelogin = "HOTROKETNOI";
        public static String remotepassword = "123456";
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static int mchinhanh = 0;

        public static BindingSource bds_dspm = new BindingSource();

        public static int KetNoi()
        {
            if(Program.conn!=null && Program.conn.State == ConnectionState.Open)
            {
                Program.conn.Close();
            }
            try {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                    Program.database + ";User ID=" +
                    Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\n Bạn xem lại username và password.\n "+e.Message,"",MessageBoxButtons.OK);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLeng)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLeng,Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600;
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch(Exception e)
            {
                Program.conn.Close();
                MessageBox.Show(e.Message);
                return null;
            }
            
        }
        public static DataTable ExecSqlDataTable(string cmd,string connstr)
        {
            DataTable dt = new DataTable();
            if(Program.conn.State==ConnectionState.Closed)
            {
                Program.conn.Open();
            }   
            SqlDataAdapter da = new SqlDataAdapter(cmd,conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static int ExecSqlNonQuery(string strLenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strLenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (Exception e)
            {
                if (e.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format Cell tại cột ");
                else MessageBox.Show(e.Message);
                conn.Close();
                return 0;
            }
        }


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormDangNhap());
        }
    }
}
