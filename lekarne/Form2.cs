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
    public partial class updateuporanbik : Form
    {
        int id = 0;
        string hash = "F@nct1onOV3rF0rm";
        public updateuporanbik(uporabnik upo)
        {
            InitializeComponent();
            imetext.Text = upo.ime;
            emailtext.Text = upo.email;

            passtext.Text = dekript(upo.pass);
            telefontext.Text = upo.telefon;
            kraj();
            krajcombo.SelectedIndex = krajcombo.FindString(upo.kraj);
            id = baza.iduporabnika(upo.email, upo.pass);
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
        public void kraj()
        {
            List<string> kr = baza.kraji();
            foreach(string x in kr)
            {
                krajcombo.Items.Add(x);
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateuporanbik_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] k = krajcombo.SelectedItem.ToString().Split('|');
            bool ok = baza.updateuser(emailtext.Text, passtext.Text, telefontext.Text, k[0].ToString(), imetext.Text, id);
            if(ok == true)
            {
                MessageBox.Show("Uspešno posodobljen uporabnik");
                this.Close();
            }
            else
            {
                MessageBox.Show("Nekaj je šlo narobe pri posodabljanju");

            }
        }
    }
}
