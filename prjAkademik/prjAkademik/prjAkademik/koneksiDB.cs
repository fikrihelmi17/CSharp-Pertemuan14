using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient; //for SQL Server
using MySql.Data.MySqlClient; //for mysql


namespace prjAkademik
{
    class koneksiDB
    {
        //public SqlConnection conn = null;
        public MySqlConnection conn = null;
        public string connStr;

        public void koneksi()
        {
            connStr = "Server=localhost; Database=web_crud_tugas; Uid=root; Pwd=''";

            try
            {
                //conn = new SqlConnection(connStr);
                conn = new MySqlConnection(connStr);
                conn.Open();
                //MessageBox.Show("Connection open");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection" + ex.ToString());
            }
        }
    }
}
