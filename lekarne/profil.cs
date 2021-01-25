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
using System.Configuration;

namespace lekarne
{
    public partial class profil : Form
    {
        int ajdi;

        uporabnik upo;
        public profil(int id)
        {
            InitializeComponent();
            ajdi = id;
            podatki();
        }

        public void podatki()
        {
            string connection = baza.connect();

            using (NpgsqlConnection con = new NpgsqlConnection(connection))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand(" SELECT * FROM izpisuporabnika(" + ajdi +");", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                reader.Read();
                upo = new uporabnik(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));

                ime.Text = "Pozdravljen " + upo.ime;
                
                con.Close();
                
            }
        }
    

        private void dodlekarnebutton_Click(object sender, EventArgs e)
        {
            dodlekarne dod = new dodlekarne();
            dod.Show();

        }

        private void izblekbutton_Click(object sender, EventArgs e)
        {
            
            updateuporanbik lol = new updateuporanbik(upo);
            lol.Show();
        }

        private void deluporabnika_Click(object sender, EventArgs e)
        {
            baza.deluser(ajdi);
            prreg pr = new prreg();
            MessageBox.Show("Uspešno izbrisan uporabnik");
            pr.Show();
            this.Close();
           

        }

        private void profil_Load(object sender, EventArgs e)
        {

        }
    }
}
