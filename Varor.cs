using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butik
{
    class Varor //Bas klass
    {
        public string Motiv;
        public int Pris;
        public double snittBetyg;

        public Varor(string motiv, int pris, double snittBetyg)
        {
            this.Motiv = motiv;
            this.Pris = pris;
            this.snittBetyg = snittBetyg;
        }
    }
}
