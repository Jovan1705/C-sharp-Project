using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Jgsp.Klase
{
    public class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Godiste { get; set; }


        public Osoba(string ime, string prezime, int godiste)
        {
            Ime = ime;
            Prezime = prezime;
            Godiste = godiste;
        }

        public string VratiImeIPrezime()
        {
            return Ime + " " + Prezime;
        }
    }
}
