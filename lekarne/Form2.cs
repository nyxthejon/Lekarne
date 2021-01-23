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
        public updateuporanbik(uporabnik upo)
        {
            InitializeComponent();
            imetext.Text = upo.ime;
            emailtext.Text = upo.email;

            passtext.Text = upo.pass;
            telefontext.Text = upo.telefon;
            krajtext.Text = upo.kraj;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateuporanbik_Load(object sender, EventArgs e)
        {

        }
    }
}
