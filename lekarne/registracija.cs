using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace lekarne
{
    public partial class registracija : Form
    {
        public registracija()
        {
            InitializeComponent();
            kraji();
        }
        string connect = baza.connect();
        


        public void kraji()
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connect))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM krajizpis();", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while(reader.Read())
                {
                    string skp = reader.GetString(0) + "|" + reader.GetString(1);
                    comboBox1.Items.Add(skp);
                
                }
                con.Close();

              
            }
        }
        private void regbut_Click(object sender, EventArgs e)
        {
            string[] k = comboBox1.SelectedItem.ToString().Split('|');
            string kraj = k[0];
            string email = mailtext.Text;
            string ime = imetext.Text;
            string geslo = geslotext.Text;
            string tel = telefontext.Text;
            bool prev = baza.registracija(email, geslo, ime, tel, kraj);
            switch(prev)
            {
                    case true:
                        MessageBox.Show("Uspešno");
                        this.Close();
                        break;
                    case false:
                        MessageBox.Show("Ni uspešno");
                    comboBox1.SelectedIndex = 0;
                    mailtext.Text = "";
                    imetext.Text = "";
                    geslotext.Text = "";
                    telefontext.Text = "";
                        break;
            }

            
        }

        private void registracija_Load(object sender, EventArgs e)
        {

        }
    }
}
