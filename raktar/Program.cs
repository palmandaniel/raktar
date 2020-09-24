using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace raktar
{
    class Program
    {
        static List<Termek> termekek = new List<Termek>();
        static void BeolvasRaktar()
        {
            StreamReader raktar = new StreamReader("raktar.csv");
            
            while (!raktar.EndOfStream)
            {
                //sor[0] kód
                //sor[1] név
                //sor[2] ár
                //sor[3] db

                string[] sor = raktar.ReadLine().Split(';');
                termekek.Add(new Termek(sor[0], sor[1], int.Parse(sor[2]), int.Parse(sor[3])));
                
            }


            raktar.Close();
        }

        static void Main(string[] args)
        {

            BeolvasRaktar();

            foreach (var t in termekek)
            {
                Console.WriteLine(t.NEV);
            }
            
            Console.ReadKey();

        }
    }
}
