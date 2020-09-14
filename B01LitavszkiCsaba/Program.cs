using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace B01LitavszkiCsaba
{
    class Program
    {
        static int[] adatok = new int[1000];
        static void Beolvasas()
        {
            StreamReader sr = new StreamReader("adatok.dat");
            string[] atmeneti = sr.ReadLine().Split();
            
                for (int i = 0; i < adatok.Length; i++)
                {
                adatok[i] = 3 * int.Parse(atmeneti[i]);
                Console.WriteLine(adatok[i]);
                }
            
            
            sr.Close();
        }
        static void Minimumertek()
        {
            int min = adatok[0];
            for (int i = 0; i < adatok.Length; i++)
            {
                if (adatok[i] < min)
                {
                    min = adatok[i];
                }
            }
            Console.WriteLine("A minimum: {0}", Minimumertek());

        }
        static void Egyediek()
        {
            int db = 0;
            for (int i = 0; i < adatok.Length; i++)
            {
                if (adatok[i] % 5 == 0 && adatok[i] !% 4 == 0)
                {
                    db++;
                }
            }
            Console.WriteLine("5 osztható de 4 nem oszthatóak száma: {0}", Egyediek());
        }

        static void Main(string[] args)
        {
            Beolvasas();
            Minimumertek();
            Egyediek();
            Console.ReadKey();
        }

        
    }
}
