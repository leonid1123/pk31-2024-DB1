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
                var sqlString = $"�������:{reader1.GetString(0)}, �������:{reader1.GetString(1)}, �������:{reader1.GetString(2)}, ���� ��������:{reader1.GetDateOnly(3)}";
                listBox1.Items.Add(sqlString);
            }
            connection.Close();
            connection.Open();
            using var command2 = new MySqlCommand("SELECT mark,nomer,probeg FROM samokat;", connection);
            using var reader2 = command2.ExecuteReader();
            listBox2.Items.Clear();
            while (reader2.Read())
            {
                var sqlString = $"�����:{reader2.GetString(0)}, �����:{reader2.GetString(1)}, ������:{reader2.GetInt32(2)}";
                listBox2.Items.Add(sqlString);
            }
            connection.Close();
            connection.Open();
            using var command3 = new MySqlCommand("SELECT  `arendator`.`FamilyName`,`samokat`.`mark`, `arenda`.`arendaStart`, `arenda`.`arendaStop` FROM `arenda` INNER JOIN `arendator` ON `arenda`.`idArendatora`=`arendator`.`id` INNER JOIN `samokat` ON `arenda`.`idSamokata`=`samokat`.`id`",connection);
            using var reader3 = command3.ExecuteReader();
            listBox3.Items.Clear();
            while (reader3.Read())
            {
                var sqlString = $"�������: {reader3.GetString(0)}, �����:{reader3.GetString(1)}, ������ ������:{reader3.GetDateTime(2)}, ����� ������:{reader3.GetDateTime(3)}";
                listBox3.Items.Add(sqlString);
            }
            connection.Close();
        }
    }
}
