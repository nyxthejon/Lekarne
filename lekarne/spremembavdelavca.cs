using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lekarne
{
    public partial class spremembavdelavca : Form
    {
        int ajdi = 0;
        public spremembavdelavca(int id)
        {
            InitializeComponent();
            polnjenjecombo();
            ajdi = id;
            prevpanel.Visible = true;
            dodpanel.Visible = false;
        }

        public void polnjenjecombo()
        {
            List<string> lekarne = baza.izpislekarn();
            foreach(string x in lekarne)
            {
                lekarnecombo.Items.Add(x);
            }    
        }
        private void prevbutton_Click(object sender, EventArgs e)
        {
            if (prevtext.Text == "Sevedasemdelavec")
            {
                prevpanel.Visible = false;
                dodpanel.Visible = true;
            }
            else
            {
                MessageBox.Show("Niste delavec");
            }
        }

        private void doddelbutton_Click(object sender, EventArgs e)
        {
            string[] ok = lekarnecombo.SelectedItem.ToString().Split('|');
            baza.sprememba_delavca(ajdi, ok[0], ok[1]);
            MessageBox.Show("Uporabnik je bil uspešno spremenjen v delavca");
            this.Close();
            profil profi = new profil(ajdi);
            profi.Show();
            this.Close();

        }
    }
}
