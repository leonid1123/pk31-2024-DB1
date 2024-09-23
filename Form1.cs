using MySqlConnector;
using System.Diagnostics;

namespace pk31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using var connection = new MySqlConnection("Server=localhost;User ID=pk31;Password=123456;Database=pk31");
            connection.Open();

            using var command = new MySqlCommand("SELECT mark,nomer,probeg FROM samokat;", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
                Debug.WriteLine(reader.GetString(0));

        }
    }
}
