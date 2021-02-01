using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekarne
{
    public class lekarna
    {
        public string Ime_lekarne { get; set; }
        public string Telefon { get; set; }
        public string DelovniCas { get; set; }
        public string Naslov { get; set; }
        public string Ime_kraja { get; set; }
        public string Pot_slike { get; set; }
        public string Opis_slike { get; set; }
        public int Stevilo_Delavcev { get; set; }


        public lekarna(string ime, string tel, string dcas, string naslov, string imek, string pots, string ops, int std)
        {
            Ime_lekarne = ime;
            Telefon = tel;
            DelovniCas = dcas;
            Naslov = naslov;
            Ime_kraja = imek;
            Pot_slike = pots;
            Opis_slike = ops;
            Stevilo_Delavcev = std;

        }
    }
}
