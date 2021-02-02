using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace lekarne
{
    public partial class dodlekarne : Form
    {
        public dodlekarne()
        {
            InitializeComponent();
            kraji();
        }
        public void kraji()
        {
            List<string> krajizp = baza.kraji();
            foreach (string x in krajizp)
            {
                krajcombo.Items.Add(x);
            }
        }

        private void konbutton_Click(object sender, EventArgs e)
        {

            string imel = imelektext.Text;
            string tel = teltext.Text;

            DateTime odpiralni = o_cas.Value;
            DateTime zapiralni = z_cas.Value;
            if(odpiralni > zapiralni)
            {
                DateTime temp = odpiralni;
                odpiralni = zapiralni;
                zapiralni = temp;
            }
            string dcas = odpiralni.ToString("t") + " - " + zapiralni.ToString("t");

            string naslov = naslovtext.Text;
            string[] k = krajcombo.SelectedItem.ToString().Split('|');
            string kraj = k[0];
            string slika = slikabutton.Text;
            string opis = opistext.Text;
            bool ok = baza.vnoslekarne(imel, tel, dcas, naslov, kraj, slika, opis);
            if (ok == true)
            {
                MessageBox.Show("Vnos je bil uspešen");
                this.Close();
            }
            else
            {
                MessageBox.Show("Vnos ni bil uspešen");
                imelektext.Text = "";
                teltext.Text = "";
                naslovtext.Text = "";
                krajcombo.SelectedIndex = 0;
                slikabutton.Text = "Dodaj sliko";
                opistext.Text = "";
            }

        }

        private void slikabutton_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fileend = @"C:\Users\Jon\Source\Repos\Lekarne\lekarne\slike";
                    string filepath = openFileDialog1.FileName;
                    string[] lol = filepath.Split('\\');
                    int fin = lol.Length - 1;
                    string filename = lol[fin];
                    fileend = fileend + "\\" + filename;
                    System.IO.File.Copy(filepath, fileend, true);
                    slikabutton.Text = fileend;
                   
                  

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }
    }
}
