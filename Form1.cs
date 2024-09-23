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

            using var command1 = new MySqlCommand("SELECT FamilyName,Pasport,Phone,DateOfBirth FROM arendator;", connection);
            using var reader1 = command1.ExecuteReader();
            listBox1.Items.Clear();
            while (reader1.Read())
            {
                var sqlString = $"Фамилия:{reader1.GetString(0)}, Паспорт:{reader1.GetString(1)}, Телефон:{reader1.GetString(2)}, Дата рождения:{reader1.GetDateOnly(3)}";
                listBox1.Items.Add(sqlString);
            }
            connection.Close();
            connection.Open();
            using var command2 = new MySqlCommand("SELECT mark,nomer,probeg FROM samokat;", connection);
            using var reader2 = command2.ExecuteReader();
            listBox2.Items.Clear();
            while (reader2.Read())
            {
                var sqlString = $"Марка:{reader2.GetString(0)}, Номер:{reader2.GetString(1)}, Пробег:{reader2.GetInt32(2)}";
                listBox2.Items.Add(sqlString);
            }
        }
    }
}
