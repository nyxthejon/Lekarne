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
    public partial class pozabljenogeslo : Form
    {
        string hash = "F@nct1onOV3rF0rm";
        public pozabljenogeslo()
        {
            InitializeComponent();
            passpanel.Visible = false;
            empanel.Visible = true;
        }

        private void prevmail_Click(object sender, EventArgs e)
        {
            bool ok = baza.checkmail(emailtext.Text);
            if(ok == true)
            {
                MessageBox.Show("Prosim izberite si novo geslo");
                passpanel.Visible = true;
                empanel.Visible = false;
            }
            else
            {
                MessageBox.Show("Uporabnik s tem E-naslovom ne obstaja");
                emailtext.Text = "";
            }
        }

        private void geslobuton_Click(object sender, EventArgs e)
        {
            string geslo = enkript(passtext.Text);
            baza.zamenjajgeslo(emailtext.Text, geslo);
            this.Close();
        }
        public string enkript(string pass)
        {
            byte[] geslo = UTF8Encoding.UTF8.GetBytes(pass);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (System.Security.Cryptography.TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(geslo, 0, geslo.Length);
                    string enk = Convert.ToBase64String(results, 0, results.Length);
                    return enk;
                }
            }
        }
    }
}
