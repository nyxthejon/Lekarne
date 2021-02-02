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
            leklabel.Visible = false;
            lekizpis.Visible = false;
            delavecbutton.Visible = true;
            odstranidelavcabutton.Visible = false;
            
            upo = baza.izpis_uporabnika(ajdi);

                ime.Text = "Pozdravljen " + upo.ime;

                emlab.Text = upo.email;
                paslab.Text = dekript(upo.pass);
                tellab.Text = upo.telefon;
                krlab.Text = upo.kraj;
            
            
            if(upo.Idlekarne != 0)
            {
                string lekarna = baza.ime_lek(upo.Idlekarne);
                lekizpis.Visible = true;
                leklabel.Visible = true;
                delavecbutton.Visible = false;
                odstranidelavcabutton.Visible = true;

                lekizpis.Text = lekarna;

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
            this.Hide();
            delavec.Show();
         

        }

        private void odstranidelavcabutton_Click(object sender, EventArgs e)
        {
            baza.odstranitev_delavca(ajdi);
            MessageBox.Show("Uporabnik ni več delavec");
            podatki();
        }
    }
}
