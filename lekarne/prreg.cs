using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lekarne
{
    public partial class prreg : Form
    {
        public prreg()
        {
            InitializeComponent();
        }
        string hash = "F@nct1onOV3rF0rm";

   

        private void regbutton_Click(object sender, EventArgs e)
        {
            registracija reg = new registracija();
            reg.Show();
           
        }

        public string enkript(string pass)
        {
            byte[] geslo = UTF8Encoding.UTF8.GetBytes(passtext.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(geslo, 0, geslo.Length);
                    string enk = Convert.ToBase64String(results, 0, results.Length);
                    return enk;
                }
            }
        }

      

        private void pributton_Click(object sender, EventArgs e)
        {
            string eka = enkript(passtext.Text);
           
            string email = emailtext.Text;
            
            bool prev = baza.prijava(email, eka);
            switch(prev)
            {
                case true:
                    MessageBox.Show("Uspešna prijava");
                    this.Hide();
                    int id = baza.iduporabnika(email, eka);
                    profil profi = new profil(id);
                    profi.Show();
                    break;
                case false:
                    MessageBox.Show("Prijava neuspešna");
                    emailtext.Text = "";
                    passtext.Text = "";
                    break;
            }
        }

        private void pozb_Click(object sender, EventArgs e)
        {
            pozabljenogeslo poz = new pozabljenogeslo();
            poz.Show();
        }
    }
}
