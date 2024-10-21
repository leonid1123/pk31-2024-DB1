using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pk31
{
    static class DB
    {
        static MySqlConnection conn;
        static MySqlCommand cmd;
        static MySqlDataReader reader;

        static MySqlConnection Connect()
        {
            conn = new MySqlConnection("Server=localhost;User ID=pk31;Password=123456;Database=pk31");
            conn.Open();
            return conn;
        }
        static void Close()
        {
            conn.Close();
        }

        static MySqlCommand SQLQuerry()
        {
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            return cmd;
        }

        static MySqlDataReader DBRead()
        {
            reader = cmd.ExecuteReader();
            return reader;
        }

    }
}
