using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekarne
{
    public class uporabnik
    {
        public string email { get; set; }
        public string pass { get; set; }
        public string telefon { get; set; }
        public string kraj { get; set; }
        public string ime { get; set; }
        public int Idlekarne { get; set; }



        public uporabnik(string mail,string pas, string tele, string kra, string im, int lekid)
        {
            email = mail;
            pass = pas;
            telefon = tele;
            kraj = kra;
            ime = im;
            Idlekarne = lekid;
        }
    }
}
