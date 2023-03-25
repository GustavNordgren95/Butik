using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butik
{
    class TShirts : Varor // Ärver från klassen Varor som bas
    {
        public string Material;
        public string Storlek;

        public TShirts(string Motiv, int Pris, string material, double snittBetyg, string storlek) : base(Motiv, Pris, snittBetyg) //Konstruktor för t-shirts med följande parametrar
        {
            this.Material = material;
            this.snittBetyg = snittBetyg;
            this.Storlek = storlek;
        }

        public void UtskriftShirt() 
        {
            Console.WriteLine("Motiv: " + this.Motiv + " // " + "Pris: " + this.Pris + ' ' + "// Typ: " + this.Material + " // Storlek: " + this.Storlek + " // " + "Betyg: " + this.snittBetyg);
        }
    }
}
