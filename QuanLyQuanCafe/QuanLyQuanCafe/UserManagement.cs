using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe
{
    public class UserManagement
    {
        public int Check_Config()
        {
            if (Properties.Settings.Default.dbQLQCFConn == string.Empty)
            {
                return 1; //Chuỗi cấu hình không tồn tại
            }
            SqlConnection sqlConn = new SqlConnection(Properties.Settings.Default.dbQLQCFConn);
            try
            {
                if (sqlConn.State == System.Data.ConnectionState.Closed)
                    sqlConn.Open();
                return 0; //Kết nối thành công chuỗi cấu hình hợp lệ
            }
            catch (Exception)
            {
                return 2; //Chuỗi cấu hình không phù hợp
            }
        }
        public int Check_User(string strUsername, string strPassword)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("SELECT * FROM tbl_Account WHERE userName = '" + strUsername + "' AND passWord = '" + strPassword + "'", Properties.Settings.Default.dbQLQCFConn);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
                return 0; //User không tồn tại
            //else if (dt.Rows[0][2] == null || dt.Rows[0][2].ToString() == "False")
            //{
            //    return 1; //Không hoạt động
            //}
            return 2; //Đăng nhập thành công
        }
        public DataTable GetServerName()
        {
            DataTable dt = new DataTable();
            dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            return dt;
        }
        public DataTable GetDBName(string strServer, string strUsername, string strPassword)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT NAME FROM sys.Databases", "Data Source=" + strServer + ";Initial Catalog=master;User ID=" + strUsername + ";Password=" + strPassword + "");
            da.Fill(dt);
            return dt;
        }
        public void SaveConfig(string strServer, string strUsername, string strPassword, string strDBName)
        {
            QuanLyQuanCafe.Properties.Settings.Default.dbQLQCFConn = "Data Source=" + strServer + ";Initial Catalog=" + strDBName + ";User ID=" + strUsername + ";Password=" + strPassword + "";
            QuanLyQuanCafe.Properties.Settings.Default.Save();
        }
    }
}
