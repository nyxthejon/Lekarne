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
        string hash = "F@nct1onOV3rF0rm";


        public void kraji()
        {
            List<string> krajizp = baza.kraji();
            foreach(string x in krajizp)
            {
                comboBox1.Items.Add(x);
            }
        }
        public string enkript(string pass)
        {
            byte[] geslo = UTF8Encoding.UTF8.GetBytes(pass);
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
            private void regbut_Click(object sender, EventArgs e)
             {
           
            string[] k = comboBox1.SelectedItem.ToString().Split('|');
            string kraj = k[0];
            string email = mailtext.Text;
            string ime = imetext.Text;
            string geslo = enkript(geslotext.Text);
            string tel = telefontext.Text;
            bool prev = baza.registracija(email, geslo, ime, tel, kraj);
            switch(prev)
            {
                    case true:
                        MessageBox.Show("Uspešno");
                        this.Close();
                        break;
                    case false:
                        MessageBox.Show("Ni uspešno");
                    comboBox1.SelectedIndex = 0;
                    mailtext.Text = "";
                    imetext.Text = "";
                    geslotext.Text = "";
                    telefontext.Text = "";
                        break;
            }

            
             }

        private void registracija_Load(object sender, EventArgs e)
        {

        }

       
    }
}
