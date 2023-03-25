using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butik
{
    class Mugg : Varor
    {
        public string Typ;

        public Mugg(string Motiv, int Pris, string Typ, double snittBetyg) : base(Motiv, Pris, snittBetyg)
        {
            this.Motiv = Motiv;
            this.Pris = Pris;
            this.Typ = Typ;
            this.snittBetyg = snittBetyg;

        }

        public void UtskriftMugg()
        {
            Console.WriteLine("Motiv: " + this.Motiv + " // " + "Pris: " + this.Pris + ' ' + "// Typ: " + this.Typ + " // " + "Betyg: " + this.snittBetyg);
        }
    }
}
