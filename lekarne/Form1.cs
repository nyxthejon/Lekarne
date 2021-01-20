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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            polnjenje();
            lol();
        }

        string connect = baza.connect();
        public  void lol()
        {
            listBox1.Items.Clear();
            List<string> kra = baza.kraji();
            foreach(string x in kra)
            {
                listBox1.Items.Add(x);
            }

           
        }
        
        public void polnjenje()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            using (NpgsqlConnection con = new NpgsqlConnection(connect))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM kratizpislekarn()", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while(reader.Read())
                {
                    dataGridView1.Rows.Add(new object[] {reader.GetString(1),reader.GetString(2),reader.GetString(3),reader.GetString(4),reader.GetString(5),"Oglej" + " " + reader.GetInt32(0),"Delete " + reader.GetInt32(0) });
                 
                }
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prreg pr = new prreg();
            pr.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if(e.ColumnIndex == 5)
            {
                string val = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                string[] lol = val.Split(' ');
                int id = Convert.ToInt32(lol[1]);
                OgledLekarne ogl = new OgledLekarne(id);
                ogl.Show();
            }
            if (e.ColumnIndex == 6)
            {
                string val = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                string[] lol = val.Split(' ');
                int id = Convert.ToInt32(lol[1]);
                baza.deletelekarno(id);

                // majhaps prozilec
               
                polnjenje();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updkraj.Visible = true;
            delkraj.Visible = true;
            string[] sp = listBox1.SelectedItem.ToString().Split('|');
            kimetext.Text = sp[0];
          
            kposttext.Text = sp[1];
        }

        private void delkraj_Click(object sender, EventArgs e)
        {
            string[] sp = listBox1.SelectedItem.ToString().Split('|');
            baza.deletekraj(sp[0], sp[1]);
            MessageBox.Show("Izbran kraj je bil izbrisan");
            lol();
            polnjenje();
        }

        private void updkraj_Click(object sender, EventArgs e)
        {
            string[] sp = listBox1.SelectedItem.ToString().Split('|');
            bool ok = baza.updatekraj(kimetext.Text, kposttext.Text, sp[0], sp[1]);
            if(ok == true)
            {
                MessageBox.Show("Kraj je bil uspešno posodobljen");
                lol();
                polnjenje();
            }
            else
            {
                MessageBox.Show("Prišlo je do napake pri posodabljanju kraja");
            }
        }

        private void insertkraj_Click(object sender, EventArgs e)
        {
            bool ok = baza.insertkraj(kimetext.Text, kposttext.Text);
            if (ok == true)
            {
                MessageBox.Show("Kraj je bil uspešno vnešen");
                lol();
                polnjenje();
            }
            else
            {
                MessageBox.Show("Prišlo je do napake pri vnašanju kraja");
            }
        }

        private void kimetext_Click(object sender, EventArgs e)
        {
            if(kimetext.Text == "Vnesi ime kraja")
            {
                kimetext.Text = "";
            }
           
        }

        private void kposttext_Click(object sender, EventArgs e)
        {
            if(kposttext.Text == "Vnesi posto" )
            {
                kposttext.Text = "";
            }
           
        }
    }
}
