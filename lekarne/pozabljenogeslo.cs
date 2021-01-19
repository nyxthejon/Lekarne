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
    public partial class pozabljenogeslo : Form
    {
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
            baza.zamenjajgeslo(emailtext.Text, passtext.Text);
            this.Close();
        }
    }
}
