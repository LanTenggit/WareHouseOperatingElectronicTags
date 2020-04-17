using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatingElectronicTags
{
  public   class DBHLper
    {
     public static string  constr = " Data Source =.; Initial Catalog = StorageDB; User ID = sa; Password=123456;";
        public static int count = 0;
        public static DataTable GetTable(string sqlstr)
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand com = new SqlCommand(sqlstr, conn);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static int GetExecuteNonQuery(string sqlstr)
        {
            int num=0;
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand com = new SqlCommand(sqlstr, conn);
            try
            {
               num = com.ExecuteNonQuery();
               conn.Close();
            }
            catch (Exception )
            {
                //Console.WriteLine(ex);
                num = 0;
              
            }
              return num;
           
        }

    }
}
