using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.VjezbaKodKuce
{
    internal class test
    {
        public static void Izvedi()
        {
            Console.Write("\n\n Rekurzija : Ispisi prvih n cijelih brojeva : \n");
            Console.Write("----------------------------------------------------");
            Console.Write(" Koliko brojeva zelis ispisati?: ");
            int ctr = int.Parse(Console.ReadLine());
            printNatural(1, ctr);
            Console.Write("\n\n");
        }

        static int printNatural(int stval, int ctr)
        {
            if (ctr < 1)
            {
                return stval;
            }
            ctr--;

            Console.WriteLine(" {0} ", stval);
            return printNatural(stval + 1, ctr);
        }
    }
}
