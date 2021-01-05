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
    }
}
