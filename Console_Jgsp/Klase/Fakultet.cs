using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Jgsp.Klase
{
    public class Fakultet
    {
        private string ImeFakulteta { get; set; }
        public int GodinaOsnivanja { get; set; } = 1950;

        public Fakultet(string imeFakulteta)
        {
            ImeFakulteta = imeFakulteta;
        }

        public void PromeniImeFakulteta(string novoIme)
        {
            ImeFakulteta = novoIme;
        }

        public string VratiImeFakulteta()
        {
            return ImeFakulteta;
        }
    }
}
