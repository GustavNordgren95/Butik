using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Butik
{
    internal class Generera 
    {
        public static string[] motivList = new string[] { "Abstract", "WWF", "Delfin", "AIK", "Djurgården",
            "Vampyrer", "Ahlgrens-Bilar", "Bamse", "Final Fantasy", "'LAHEE'", "Baldur's Gate", "Hav", "Natur", "Transformers",
            "LGBTQ+", "Samojed", "Schäffer", "Husky", "Dachund", "Pug", "Malamut", "Shiba-Inu", "Golden-Retriever", "St-Bernard", "Svensk-Vallhund",
            "Finsk-Lapphund", "In-Flames", "Eluveitie", "Lacuna Coil", "Billie Eilish" };

        public static string[] tshirtStorlek = new string[] { "S", "M", "L", "XL" };

        public static string[] material = new string[] { "Ull", "Polyester", "Bomull" };

        public static string[] muggTyp = new string[] { "Camping Mugg", "Porslin Kopp", "Snapp Kopp" };

        public static double RandomBetyg()
        {
            Random roll = new Random();
            double d = roll.NextDouble();
            double b = Convert.ToDouble(d * roll.Next(1, 10));
            b = Math.Round(b, 1);
            return b;
        }

        public static int RandomPris()
        {
            Random roll = new Random();
            int rollValue = roll.Next(1, 5);
            int[] weight = new int[] { 149, 179, 199, 249, 599 };
            int p = (int)weight[rollValue - 1];
            return p;
        }

        public static string RandomMaterial()
        {
            Random rnd = new Random();
            string[] m = material.OrderBy(x => rnd.Next()).ToArray();
            return m[0];
        }

        public static string RandomMotiv()
        {
            Random rnd = new Random();
            string[] rMotiv = motivList.OrderBy(x => rnd.Next()).ToArray();
            return rMotiv[0];
        }

         public static string RandomStorlek()
        {
            Random rnd = new Random();
            string[] s = tshirtStorlek.OrderBy(x => rnd.Next()).ToArray();
            return s[0];
        }

        public static string RandomMuggTyp()
        {
            Random rnd = new Random();
            string[] t = muggTyp.OrderBy(x => rnd.Next()).ToArray();
            return t[0];
        }
    }
}
