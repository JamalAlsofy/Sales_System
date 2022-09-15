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
    class DB1
    {
        public static SqlConnection conn1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Enterprise !! (Projects)\C#\Part6\ONEX_Seles\ONEX_Seles\MySalesMain.mdf;Integrated Security=True;");
        public static SqlCommand cmd1 = new SqlCommand("", conn1);
       
        public static void ChangeDBFileName1(string NewPathWithFileName)
        {
            if (conn1.State == ConnectionState.Closed)
            {
                conn1.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+ NewPathWithFileName + ";Initial Catalog=MySalesMain;Integrated Security=True";
            }
        }
        public static void Open1()
        {
            if (conn1.State == ConnectionState.Closed)
            {
                conn1.Open();
            }
        }
        public static void Close1()
        {
            if (conn1.State == ConnectionState.Closed) conn1.Close();
        }

        public static DataTable DBGetData1(string Select)
        {
            DataTable tbl = new DataTable();
            cmd1.CommandText = Select;
            tbl.Load(cmd1.ExecuteReader());
            return tbl;

        }
        public static void Run1(string SQL)
        {
            cmd1.CommandText = SQL;
            cmd1.ExecuteNonQuery();
        }






    }
}
