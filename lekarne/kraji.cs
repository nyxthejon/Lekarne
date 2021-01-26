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
    public partial class kraji : Form
    {
        string[] sp;
        public kraji()
        {
            InitializeComponent();
            lol();
        }

        private void kraji_Load(object sender, EventArgs e)
        {

        }
        public void lol()
        {
            kimetext.Text = "Vnesi ime kraja";
            kposttext.Text = "Vnesi posto";
            listBox1.Items.Clear();
            List<string> kra = baza.kraji();
            foreach (string x in kra)
            {
                listBox1.Items.Add(x);
            }


        }
     

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updkraj.Visible = true;
            delkraj.Visible = true;
            sp = listBox1.SelectedItem.ToString().Split('|');
            kimetext.Text = sp[0];

            kposttext.Text = sp[1];
        }

        private void insertkraj_Click(object sender, EventArgs e)
        {
            bool ok = baza.insertkraj(kimetext.Text, kposttext.Text);
            if (ok == true)
            {
                MessageBox.Show("Kraj je bil uspešno vnešen");
                lol();

            }
            else
            {
                MessageBox.Show("Prišlo je do napake pri vnašanju kraja");
            }
        }

        private void kimetext_Click(object sender, EventArgs e)
        {
            if (kimetext.Text == "Vnesi ime kraja")
            {
                kimetext.Text = "";
            }
        }

        private void kposttext_Click(object sender, EventArgs e)
        {
            if (kposttext.Text == "Vnesi posto")
            {
                kposttext.Text = "";
            }
        }

        private void updkraj_Click(object sender, EventArgs e)
        {
            sp = listBox1.SelectedItem.ToString().Split('|');
            baza.updatekraj(kimetext.Text, kposttext.Text, sp[0], sp[1]);
        
            MessageBox.Show("Kraj je bil uspešno posodobljen");
            lol();

           
        }

        private void delkraj_Click(object sender, EventArgs e)
        {
            sp = listBox1.SelectedItem.ToString().Split('|');
            baza.deletekraj(sp[0], sp[1]);
            MessageBox.Show("Izbran kraj je bil izbrisan");
            lol();
        }
    }
}
