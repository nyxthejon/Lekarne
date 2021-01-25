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
    public partial class updateuporanbik : Form
    {
        int id = 0;
        public updateuporanbik(uporabnik upo)
        {
            InitializeComponent();
            imetext.Text = upo.ime;
            emailtext.Text = upo.email;

            passtext.Text = upo.pass;
            telefontext.Text = upo.telefon;
            kraj();
            krajcombo.SelectedIndex = krajcombo.FindString(upo.kraj);
            id = baza.iduporabnika(upo.email, upo.pass);
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
