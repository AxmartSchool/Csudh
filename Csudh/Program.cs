using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csudh
{
    class Program
    {

        static List<Domain> Domainek;

        static void Main(string[] args)
        {

           Domainek = Domain.Beolvasas();

            DomainekSzama();
            ElsoDomainFelepites();

            Console.ReadKey();

        }

        private static void ElsoDomainFelepites()
        {

            Console.WriteLine("5. feladat: Az elso domain felepitese:");
            Console.WriteLine($"\t1. szint : {Domainek[0].DomainFelepites(1)}");
            Console.WriteLine($"\t2. szint : {Domainek[0].DomainFelepites(2)}");
            Console.WriteLine($"\t3. szint : {Domainek[0].DomainFelepites(3)}");
            Console.WriteLine($"\t4. szint : {Domainek[0].DomainFelepites(4)}");
            Console.WriteLine($"\t5. szint : {Domainek[0].DomainFelepites(5)}");

        }

        private static void DomainekSzama()
        {

            Console.WriteLine("3. Feladat: Domainek szama: "+Domainek.Count());


        }
    }
}
