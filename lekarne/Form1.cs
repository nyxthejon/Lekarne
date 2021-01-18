﻿using System;
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
            using (NpgsqlConnection con = new NpgsqlConnection(connect))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM kraji", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while(reader.Read())
                {
                    string k = reader.GetString(1);
                    string p = reader.GetString(2);
                    listBox1.Items.Add(k);
                   
                    listBox1.Items.Add(p);
                }
                 
                con.Close();
            }

           
        }
        
        public void polnjenje()
        {
            using(NpgsqlConnection con = new NpgsqlConnection(connect))
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
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                polnjenje();
            }
        }
    }
}
