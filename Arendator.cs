﻿using MySqlConnector;

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
            MySqlCommand tmp = DB.SQLQuerry("SELECT * FROM arendator");
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
