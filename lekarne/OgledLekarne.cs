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
using Npgsql;
namespace lekarne
{
    public partial class OgledLekarne : Form
    {
        int idl;
        string urlslike = "";
        public OgledLekarne(int id)
        {
            InitializeComponent();
            kraji();
            confirmbutton.Visible = false;
            updatebutton.Visible = true;
            updatesliko.Visible = false;
            idl = id;
            delavci();
            izpis();
        }

        public void kraji()
        {
            List<string> krajizp = baza.kraji();
            foreach (string x in krajizp)
            {
                krajcombo.Items.Add(x);
            }
        }

        public void izpis()
        {
            lekarna lek = baza.IzpisLekarne(idl);
            imetext.Text = lek.Ime_lekarne;
            teltext.Text = lek.Telefon;
            dcastext.Text = lek.DelovniCas;
            nastext.Text = lek.Naslov;
            krajcombo.Text = lek.Ime_kraja;

            pictureBox1.ImageLocation = lek.Pot_slike;
            urlslike = lek.Pot_slike;
            opistext.Text = lek.Opis_slike;
            stdelavcev.Text = lek.Stevilo_Delavcev.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            imetext.ReadOnly = false;
            teltext.ReadOnly = false;
            dcastext.ReadOnly = false;
            nastext.ReadOnly = false;
            krajcombo.Enabled = true;
            opistext.ReadOnly = false;

            updatebutton.Visible = false;
            updatesliko.Visible = true;
            confirmbutton.Visible = true;
        }

        private void confirmbutton_Click(object sender, EventArgs e)
        {
            string pot = "";
            if (updatesliko.Text.Equals("Posodobi sliko"))
            {

                pot = urlslike;
            }
            else
            {

                pot = updatesliko.Text;
            }
            string[] kr = krajcombo.Text.ToString().Split('|');
            MessageBox.Show(kr[0]);
            string mes = baza.updatelekarne(idl, imetext.Text, teltext.Text, dcastext.Text, nastext.Text, kr[0], pot, opistext.Text);
            MessageBox.Show(mes);
            updatesliko.Text = "Posodobi sliko";
            updatesliko.Visible = false;
            confirmbutton.Visible = false;
            updatebutton.Visible = true;

            imetext.ReadOnly = true;
            teltext.ReadOnly = true;
            dcastext.ReadOnly = true;
            nastext.ReadOnly = true;
            opistext.ReadOnly = true;
            krajcombo.Enabled = false;
            izpis();
        }

        public void delavci()
        {
            string connection = baza.connect();
            using (NpgsqlConnection con = new NpgsqlConnection(connection))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand(" SELECT * FROM delavciizpis("+ idl + ");", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while(reader.Read())
                {
                    delavcidatagrid.Rows.Add(new object[] { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3)});
                }
              
                con.Close();
            }
        }
    

        private void updatesliko_Click(object sender, EventArgs e)
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
                    updatesliko.Text = fileend;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
