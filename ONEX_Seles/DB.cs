using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.IO;
namespace ONEX_Seles
{
    class DB
    {
        public static SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Enterprise !! (Projects)\C#\Part6\ONEX_Seles\ONEX_Seles\MySalesMain.mdf;Integrated Security=True;Connect Timeout=30");
        public static SqlCommand cmd = new SqlCommand("", conn);
        public static void ChangeDBFileName(string NewPathWithFileName)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+ NewPathWithFileName + "; Initial Catalog=MySalesMain ;Integrated Security=True";
            }
        }
        public static void Open()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public static void Close()
        {
            if (conn.State == ConnectionState.Closed) conn.Close();
        }

        public static DataTable DBGetData(string Select)
        {
            DataTable tbl = new DataTable();
            cmd.CommandText = Select;
            tbl.Load(cmd.ExecuteReader());
            return tbl;

        }
        public static void Run(string SQL)
        {
            cmd.CommandText = SQL;
            cmd.ExecuteNonQuery();
        }







    }
}
