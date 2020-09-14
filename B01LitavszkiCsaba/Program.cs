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
                adatok[i] = int.Parse(atmeneti[i]);
                Console.WriteLine(adatok[i]);
                }
            
            
            sr.Close();
        }
       
        

        static void Main(string[] args)
        {
            Beolvasas();
           
          
            Console.ReadKey();
        }

        
    }
}
