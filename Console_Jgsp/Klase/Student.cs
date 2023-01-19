using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Jgsp.Klase
{
    public class Student : Osoba
    {
        public Fakultet Fakultet { get; set; }
        public int GodinaStudije { get; set; }

        public Student(string ime, string prezime, int godiste) : base(ime, prezime, godiste)
        {

        }

        public Student(string ime, string prezime, int godiste, Fakultet fakultet, int godinaStudije) : base(ime, prezime, godiste)
        {
            Fakultet = fakultet;
            GodinaStudije = godinaStudije;
        }
    }
}
