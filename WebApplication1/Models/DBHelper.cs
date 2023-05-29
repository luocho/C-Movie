using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DBHelper
    {
        public static string constr = "server=gz-cynosdbmysql-grp-j73nphjz.sql.tencentcdb.com;port=24123;user=root;password=Lcy1810205634;database=hospital;";
        public DataTable GetDataSet(string sql)
        {
            MySqlConnection connection = new MySqlConnection(constr);
            MySqlDataAdapter dap = new MySqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            return ds.Tables[0];
        }
        public int zsg(string sql)
        {
            MySqlConnection connection = new MySqlConnection(constr);
            connection.Open();
            MySqlCommand command = new MySqlCommand(sql, connection);
            int x = command.ExecuteNonQuery();
            connection.Close();
            return x;
        }

        public MySqlDataReader reader(string sql)
        {
            MySqlConnection connection = new MySqlConnection(constr);
            connection.Open();
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader dr=command.ExecuteReader();
            return dr;  
        }
    }
}
