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
    public partial class OgledLekarne : Form
    {
        int idl;
        public OgledLekarne(int id)
        {
            InitializeComponent();
            
            idl = id;
            izpis();
        }
        

        public void izpis()
        {
            List<string> izp = baza.IzpisLekarne(idl);
            imetext.Text = izp[0];
            teltext.Text = izp[1];
            dcastext.Text = izp[2];
            nastext.Text = izp[3];
            krajtext.Text = izp[4];
            pictureBox1.Image = "C:\Users\Jon\Source\Repos\Lekarne\lekarne\slike\celjske-lekarne-november-2014-2-800x445.jpg";
            opistext.Text = izp[6];
        }
    }
}
