using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pk31
{
    public partial class samokat : Form
    {
        public samokat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string marka = textBox1.Text.Trim();
            string nomer = textBox2.Text.Trim();
            int probeg = (int)numericUpDown1.Value;
            if (marka.Length > 3 & nomer.Length == 5)
            {
                MySqlCommand tmp = DB.SQLQuerry("INSERT INTO samokat(mark,nomer,probeg) VALUES (@mark,@nomer,@probeg)");
                tmp.Parameters.Clear();
                tmp.Parameters.AddWithValue("mark", marka);
                tmp.Parameters.AddWithValue("nomer", nomer);
                tmp.Parameters.AddWithValue("probeg", probeg);
                int res = tmp.ExecuteNonQuery();
                if (res == 0) 
                {
                    MessageBox.Show("Запрос на добавление ПОТРАЧЕН");
                } else
                {
                    MessageBox.Show("Новый самокат добавлен");
                }
                DB.Close();
                tmp = DB.SQLQuerry("SELECT * FROM samokat");
                MySqlDataReader rdr = tmp.ExecuteReader();
                listBox1.Items.Clear();
                while (rdr.Read())
                {
                    listBox1.Items.Add(rdr.GetString(1));
                }
                DB.Close();
            }
        }

        private void samokat_Load(object sender, EventArgs e)
        {
            MySqlCommand tmp = DB.SQLQuerry("SELECT * FROM samokat");
            MySqlDataReader rdr = tmp.ExecuteReader();
            listBox1.Items.Clear();
            while (rdr.Read())
            {
                listBox1.Items.Add(rdr.GetString(1));
            }
            DB.Close();
        }
    }
}
