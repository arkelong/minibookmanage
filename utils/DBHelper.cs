using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.BC;

namespace WindowsFormsApp1.utils
{
    class DBHelper
    {
        private string connString = @"Database=bookdatabase;Data Source=127.0.0.1;User Id=root;Password=long;pooling=false;CharSet=utf8;port=3306";

        private MySqlConnection connection;

        public MySqlConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    connection = new MySqlConnection(connString);
                }
                return connection;
            }
        }


        public void OpenConnection()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }else if (Connection.State == ConnectionState.Broken)
            {
                Connection.Close();
                Connection.Open();
            }
            
        }

        public void CloseConnection()
        {
            if (Connection.State == ConnectionState.Open || Connection.State == ConnectionState.Broken)
            {
                Connection.Close();
            }
        }





    }
}
