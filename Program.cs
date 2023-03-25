using Butik;

internal class Program
{
    class program
    {
        private static void Main(string[] args)
        {
            List<Mugg> muggLista = new List<Mugg>();

            for (int i = 1; i < 30; i++) //Skapar lista
            {
                muggLista.Add(new Mugg(Generera.RandomMotiv(), Generera.RandomPris(), Generera.RandomMuggTyp(), Generera.RandomBetyg()));
                muggLista.Sort((x, y) => x.snittBetyg.CompareTo(y.snittBetyg)); //Jämnför snittbetyg och sorterar i stigande ordning
            }

            List<TShirts> tshirtLista = new List<TShirts>();

            for (int i = 1; i < 30; i++)
            {
                tshirtLista.Add(new TShirts(Generera.RandomMotiv(), Generera.RandomPris(), Generera.RandomMaterial(), Generera.RandomBetyg(), Generera.RandomStorlek()));
                tshirtLista.Sort((x, y) => y.snittBetyg.CompareTo(x.snittBetyg)); //Samma som ovan men fallande ordning
            }

            string input = "0";
            do
            {
                Console.Clear();
                Console.WriteLine("Välkommen till Norrland Yard! Varsågod och kika på vårt sortiment!");
                Console.WriteLine();
                Console.WriteLine("Skriv in 1 eller 2 för att välja vad du vill få en lista på och 0 för att avsluta programmet.");
                Console.WriteLine();
                Console.WriteLine("Du hittar oss också hos Lilla Villekullan för faktuering" +
                      "\n1 - Se Muggar"
                    + "\n2 - Se T-Shirts"
                    + "\n0 - Lämna Butiken");


                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Clear();

                        foreach (Mugg e in muggLista)
                        {
                            e.UtskriftMugg();
                        }
                        Console.WriteLine();
                        Console.WriteLine("Tryck på valfri knapp för att fortsätta...");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.Clear();
                        foreach (TShirts t in tshirtLista)
                        {
                            t.UtskriftShirt();
                        }
                        Console.WriteLine();
                        Console.WriteLine("Tryck på valfri knapp för att fortsätta...");
                        Console.ReadKey();
                        break;

                    case "0":
                        Console.Clear();
                        Console.WriteLine("Ses nästa gång!");
                        Console.ReadKey();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Felaktig input, välj mellan 0 till 2");
                        Console.WriteLine();
                        Console.WriteLine("Tryck på valfri knapp för att fortsätta...");
                        Console.ReadKey();
                        break;
                }
            } while (input != "0");            
        }
    }
}