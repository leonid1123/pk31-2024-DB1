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
            MySqlCommand tmp =  DB.SQLQuerry("SELECT * FROM samokat");
            MySqlDataReader rdr =  tmp.ExecuteReader();
            listBox2.Items.Clear();
            while (rdr.Read()) 
            {
                listBox2.Items.Add(rdr.GetString(1));
            }
            DB.Close();
            tmp = DB.SQLQuerry("SELECT * FROM arendator");
            rdr = tmp.ExecuteReader();
            listBox1.Items.Clear();
            while (rdr.Read())
            {
                listBox1.Items.Add(rdr.GetString(1));
            }
            DB.Close();

            string bigSQL =
                "SELECT samokat.nomer, arendator.FamilyName, " +
                "arenda.arendaStart, arenda.arendaStop FROM arenda " +
                "INNER JOIN samokat " +
                "ON arenda.idSamokata = samokat.id " +
                "INNER JOIN arendator " +
                "ON arenda.idArendatora = arendator.id";

            tmp = DB.SQLQuerry(bigSQL);
            rdr = tmp.ExecuteReader();
            listBox3.Items.Clear();
            while (rdr.Read())
            {
                listBox3.Items.Add($"{ rdr.GetString(0)}, " +
                    $"{ rdr.GetString(1)}, " +
                    $"{ rdr.GetDateOnly(2)}, " +
                    $"{ rdr.GetDateOnly(3)} " );
            }
            DB.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Arendator arendator = new Arendator();
            arendator.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            samokat samokat = new samokat();
            samokat.Show();
        }
    }
}
