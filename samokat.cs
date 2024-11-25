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
