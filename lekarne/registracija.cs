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
    public partial class registracija : Form
    {
        public registracija()
        {
            InitializeComponent();
            kraji();
        }
        string connect = baza.connect();
        


        public void kraji()
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connect))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM krajizpis();", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while(reader.Read())
                {
                    string skp = reader.GetString(0) + "|" + reader.GetString(1);
                    comboBox1.Items.Add(skp);
                
                }
                con.Close();

              
            }
        }
        private void regbut_Click(object sender, EventArgs e)
        {
            string[] k = comboBox1.SelectedItem.ToString().Split('|');
            string email = mailtext.Text;
            string ime = imetext.Text;
            string geslo = geslotext.Text;
            string tel = telefontext.Text;
            using (NpgsqlConnection con = new NpgsqlConnection(connect))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT registracija('" + email + "','" + geslo + "','" +  ime + "','" + tel + "','" + k[0] + "');", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                reader.Read();
                bool prev = reader.GetBoolean(0);
                switch(prev)
                {
                    case true:
                        MessageBox.Show("Uspešno");
                        break;
                    case false:
                        MessageBox.Show("Ni uspešno");
                        break;
                }
                con.Close();


            }
        }

        private void registracija_Load(object sender, EventArgs e)
        {

        }
    }
}
