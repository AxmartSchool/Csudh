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

            Console.ReadKey();

        }

        private static void DomainekSzama()
        {

            Console.WriteLine("3. Feladat: Domainek szama: "+Domainek.Count());


        }
    }
}
