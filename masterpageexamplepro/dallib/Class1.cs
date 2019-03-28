using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace dallib
{
    public class CustomerDAL
    {
        SqlConnection conn;
        SqlCommand cmdLogin;
        public CustomerDAL()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conLogin"].ConnectionString);
            cmdLogin = new SqlCommand("prologic", conn);
            cmdLogin.CommandType = CommandType.StoredProcedure;
            cmdLogin.Parameters.Add("@id", SqlDbType.VarChar, 20);
            cmdLogin.Parameters.Add("@pass", SqlDbType.VarChar, 20);
        }
        public string CheckLoginDb(string un, string pass)
        {
            string _role = null;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            cmdLogin.Parameters[0].Value = un;
            cmdLogin.Parameters[1].Value = pass;
            _role = cmdLogin.ExecuteScalar().ToString();
            return _role;
        }
    }


}
