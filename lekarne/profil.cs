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
using System.Security.Cryptography;

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
        string hash = "F@nct1onOV3rF0rm";

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

                emlab.Text = upo.email;
                paslab.Text = dekript(upo.pass);
                tellab.Text = upo.telefon;
                krlab.Text = upo.kraj;
                con.Close();
                
            }
        }

        public string dekript(string pass)
        {
            byte[] geslo = Convert.FromBase64String(pass);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(geslo, 0, geslo.Length);
                    string enk = UTF8Encoding.UTF8.GetString(results);
                    return enk;
                }
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

        private void kbutton_Click(object sender, EventArgs e)
        {
            kraji kr = new kraji();
            kr.Show();
        }

        private void nazajnaizpisbutton_Click(object sender, EventArgs e)
        {

            Form1 Izpis = new Form1(ajdi);
            Izpis.Show();
            this.Close();

        }

        private void odjavabutton_Click(object sender, EventArgs e)
        {
            Form1 Izpis = new Form1(0);
            Izpis.Show();
            this.Close();
        }

        private void delavecbutton_Click(object sender, EventArgs e)
        {
            spremembavdelavca delavec = new spremembavdelavca(ajdi);
            delavec.Show();

        }
    }
}
