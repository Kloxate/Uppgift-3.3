using System;

namespace School_work
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur länge will du hyra bilen? Skriv i antal timmar.");
            string timmar = Console.ReadLine();
            int antl_timmar = int.Parse(timmar);

            int resultat = antl_timmar * 80;

            if (resultat >= 950)
            {
                Console.WriteLine("Kostand för " + timmar + " timmar är 950kr.");
            }
            else
            {
                Console.WriteLine("Konstand för " + timmar + " timmar är " + resultat);
            }
        }
    }
}
