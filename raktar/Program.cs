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

        static List<Megrendeles> rendelesek = new List<Megrendeles>();
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

        static void BeolvasRendeles()
        {
            StreamReader rendeles = new StreamReader("rendeles.csv");
            while (!rendeles.EndOfStream)
            {
                string sor = rendeles.ReadLine();
                string[] adat = sor.Split(';');

                if (adat[0] == "M")
                {
                    rendelesek.Add(new Megrendeles(adat[1], (adat[2]), adat[3]));
                }

                else
                {
                   rendelesek[rendelesek.Count - 1].TetelHozzaad(adat[2], int.Parse(adat[3]));
                }

                
            }

            foreach (var m in rendelesek)
            {
                m.Szamolas(termekek);
            }

            rendeles.Close();
        }

        static void Main(string[] args)
        {

            BeolvasRaktar();

            foreach (var t in termekek)
            {
                Console.WriteLine(t.NEV);
            }

            BeolvasRendeles();

            Console.WriteLine("**********************************************");

            foreach (var t in rendelesek)
            {
                Console.Write("{0}\t {1}\t {2}\n", t.DATUM, t.ID, t.EMAIL);
            }

            Console.ReadKey();

        }
    }
}
