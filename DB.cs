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
        

        static void Connect()
        {
            conn = new MySqlConnection("Server=localhost;User ID=pk31;Password=123456;Database=pk31");
            conn.Open();
        }
        static public void Close()
        {
            conn.Close();
        }

        static public MySqlCommand SQLQuerry(string _SQLText)
        {
            DB.Connect();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = _SQLText;
            return cmd;
        }
    }
}
