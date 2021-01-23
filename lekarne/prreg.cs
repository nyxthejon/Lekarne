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
    public partial class prreg : Form
    {
        public prreg()
        {
            InitializeComponent();
        }

        private void prreg_Load(object sender, EventArgs e)
        {

        }

        private void regbutton_Click(object sender, EventArgs e)
        {
            registracija reg = new registracija();
            reg.Show();
           
        }

        private void pributton_Click(object sender, EventArgs e)
        {
            string email = emailtext.Text;
            string pass = passtext.Text;
            bool prev = baza.prijava(email, pass);
            switch(prev)
            {
                case true:
                    MessageBox.Show("Uspešna prijava");
                    this.Hide();
                    int id = baza.iduporabnika(email, pass);
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
