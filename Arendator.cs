using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MySqlConnector;

namespace pk31
{
    public partial class Arendator : Form
    {
        public Arendator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newFamilyName = textBox1.Text.Trim();
            string newPasport = textBox2.Text.Trim();
            string newPhone = textBox3.Text.Trim();
            DateTime newDateOfBirth = dateTimePicker1.Value.Date;
            string mysqlDateOfBirth = newDateOfBirth.ToString("yyyy-MM-dd");
            //Debug.WriteLine($"{newFamilyName}, {newPasport}, {newPhone}, {newDateOfBirth}");
            using var connection = new MySqlConnection("Server=localhost;User ID=pk31;Password=123456;Database=pk31");
            connection.Open();
            using (var mysqlCommand = new MySqlCommand())
            {
                mysqlCommand.Connection = connection;
                mysqlCommand.CommandText = "INSERT INTO `arendator`" +
                    "(`FamilyName`, `Pasport`, `Phone`, `DateOfBirth`) " +
                    "VALUES (@FamilyName, @Pasport, @Phone, @DateOfBirth);";
                mysqlCommand.Parameters.AddWithValue("FamilyName", newFamilyName);
                mysqlCommand.Parameters.AddWithValue("Pasport", newPasport);
                mysqlCommand.Parameters.AddWithValue("Phone", newPhone);
                mysqlCommand.Parameters.AddWithValue("DateOfBirth", mysqlDateOfBirth);
                int rows = mysqlCommand.ExecuteNonQuery();
                if (rows > 0) 
                {
                    label6.Text = "Внесено успешно";
                } else
                {
                    label6.Text = "Проблемки";
                }
            }

        }
    }
}
