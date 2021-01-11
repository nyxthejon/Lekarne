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
    public partial class profil : Form
    {
        public profil()
        {
            InitializeComponent();
        }

        private void dodlekarnebutton_Click(object sender, EventArgs e)
        {
            dodlekarne dod = new dodlekarne();
            dod.Show();

        }
    }
}
