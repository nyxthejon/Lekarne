using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace lekarne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lol();
        }

        string connect = baza.connect();
        public  void lol()
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connect))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM kraji", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while(reader.Read())
                {
                    string k = reader.GetString(1);
                    string p = reader.GetString(2);
                    listBox1.Items.Add(k);
                    listBox1.Items.Add(p);
                }
                 
                con.Close();
            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prreg pr = new prreg();
            pr.Show();
            this.Hide();
        }
    }
}
