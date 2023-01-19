using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Jgsp.Klase
{
    public class Profesor : Osoba
    {
        public Fakultet Fakultet { get; set; }
        public string Predmet { get; set; }
        public int GodineStaza { get; set; }



        public Profesor(string ime, string prezime, int godiste) : base(ime, prezime, godiste)
        {

        }

        public Profesor(string ime, string prezime, int godiste, Fakultet fakultet, string predmet, int godineStaza) : base(ime, prezime, godiste)
        {
            Fakultet = fakultet;
            Predmet = predmet;
            GodineStaza = godineStaza;
        }
    }
}
