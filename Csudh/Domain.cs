using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csudh
{
    class Domain
    {

        public string Nev { get; set; }
        public string IpCim { get; set; }


        public static List<Domain> Beolvasas()
        {
            var output = new List<Domain>();

            var sr = new StreamReader(@"..\..\csudh.txt", Encoding.UTF8);
            sr.ReadLine();
            string[] temptomb;
            while (!sr.EndOfStream)
            {

                temptomb = sr.ReadLine().Split(';');
                output.Add(new Domain() { Nev = temptomb[0], IpCim = temptomb[1] });

            }


            return output;


        }


    }
}
