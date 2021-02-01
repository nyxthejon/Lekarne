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
using Microsoft.Office.Core;
using Microsoft.Office.Interop;
using Excel = Microsoft.Office.Interop.Excel;



namespace lekarne
{
    public partial class Form1 : Form
    {
        int id = 0;
        Excel.Application oXL;
        Excel._Workbook oWB;
        Excel._Worksheet oSheet;

        public Form1(int idu)
        {
            InitializeComponent();
            id = idu;
            prikazgumba();
            polnjenje();
        }

        string connect = baza.connect();


        public void polnjenje()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            using (NpgsqlConnection con = new NpgsqlConnection(connect))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM kratizpislekarn()", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(new object[] { reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), "Oglej" , "Delete", reader.GetInt32(0) });

                }
                con.Close();
            }
        }

        public void prikazgumba()
        {
            if (id != 0)
            {
                pributton.Visible = false;
                ogledprofilabutton.Visible = true;
            }
            else
            {
                pributton.Visible = true;
                ogledprofilabutton.Visible = false;
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id  = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value;
            if (e.ColumnIndex == 5)
            {
                OgledLekarne ogl = new OgledLekarne(id);
                ogl.Show();
            }
            if (e.ColumnIndex == 6)
            {
                baza.deletelekarno(id);
                polnjenje();
            }
        }

        private void pributton_Click(object sender, EventArgs e)
        {
            prreg pr = new prreg();
            pr.Show();
            this.Hide();
        }

        private void ogledprofilabutton_Click(object sender, EventArgs e)
        {
            profil prof = new profil(id);
            prof.Show();
            this.Close();
        }

        private void izvozpodatkovbutton_Click(object sender, EventArgs e)
        {
            oXL = new Excel.Application();
            oWB = (Excel.Workbook)oXL.Workbooks.Add();
            oSheet = (Excel._Worksheet)oWB.ActiveSheet;

            oSheet.Cells[1, 1] = "Ime Lekarne";
            oSheet.Cells[1, 2] = "Telefon";
            oSheet.Cells[1, 3] = "Delovni Čas";
            oSheet.Cells[1, 4] = "Naslov";
            oSheet.Cells[1, 5] = "Kraj";
            oSheet.Cells[1, 6] = "Število Delavcev";

            oSheet.get_Range("A1", "F1").Font.Bold = true;
            oSheet.get_Range("A1", "F1").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            polnjenjeexcel();
            oWB.Application.ActiveWorkbook.SaveAs(@"C:\Users\Jon\Desktop\Excel\" + imeexceltext.Text + ".xlsx");
        }

        public void polnjenjeexcel()
        {
            int naprej = 2;
            string connection = baza.connect();
            using (NpgsqlConnection con = new NpgsqlConnection(connection))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * From kratizpislekarn();", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    oSheet.Cells[naprej, 1] = reader.GetString(1);
                    oSheet.Cells[naprej, 2] = reader.GetString(2);
                    oSheet.Cells[naprej, 3] = reader.GetString(3);
                    oSheet.Cells[naprej, 4] = reader.GetString(4);
                    oSheet.Cells[naprej, 5] = reader.GetString(5);
                    oSheet.Cells[naprej, 6] = reader.GetInt32(6);
                    naprej++;
                }
                con.Close();
            }


        }
    }
}
