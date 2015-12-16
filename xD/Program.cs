using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xD
{
    class Program
    {
        static void Main(string[] args)
        {
            var inimesed = new List<Inimene>();

            var joosep = new Inimene();
            joosep.Nimi = "Joosep";
            joosep.Pikkus = 180;

            var taavi = new Inimene();
            taavi.Nimi = "Taavi";
            taavi.Pikkus = 185;

            var tiina = new Inimene();
            tiina.Nimi = "Tiina";
            tiina.Pikkus = 168;

            var lauri = new Inimene();
            lauri.Nimi = "Lauri";
            lauri.Pikkus = 176;

            var sandra = new Inimene();
            sandra.Nimi = "Sandra";
            sandra.Pikkus = 178;

            inimesed.Add(joosep);
            inimesed.Add(taavi);
            inimesed.Add(lauri);
            inimesed.Add(tiina);
            inimesed.Add(sandra);


            // nimed
            var eesnimed = inimesed.Select(m => new { nimi = m.Nimi });

            foreach(var inimene in eesnimed)
            {
                Console.WriteLine(inimene.nimi);
            }
            Console.WriteLine();

            //pikkus < 180
            var lyhemadKui180 = from inimene in inimesed
                                where inimene.Pikkus < 180
                                select inimene;

            foreach(var inimene in lyhemadKui180)
            {
                Console.WriteLine(inimene.Nimi);
            }
            Console.WriteLine();

            //pikkuse järjekorras
            var pikkuseJ2rjekorras = from inimene in inimesed
                                orderby inimene.Pikkus ascending
                                select inimene;

            foreach(var inimene in pikkuseJ2rjekorras)
            {
                Console.WriteLine(inimene.Nimi + " " + inimene.Pikkus);
            }

        }
    }
}
