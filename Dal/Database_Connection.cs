//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Data.SqlClient;
//using System.Configuration;
//using System.Data;

using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
namespace Dal
{
    public class Database_Connection
    {
        //SqlConnection con;
        public SqlConnection con;
        //clsEncDecPassword ObjEncDec = new clsEncDecPassword();
        public void CreateConnection()
        {
            if (con == null)
            {
                con = new SqlConnection(ConfigurationSettings.AppSettings["connectionstring"]);

            }
        }
        public void OpenConnection()
        {
            if (con == null)
            {
                CreateConnection();
            }
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
