using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.VjezbaKodKuce
{
    internal class RekurzijaParniINeparni
    {
        public static void Izvedi()
        {
            Console.Write("Unesi broj kojim zavrsava niz: ");
            int kraj = int.Parse(Console.ReadLine());

            Console.WriteLine("Svi parni brojevi od 1 do {0} su: ", kraj);
            ParniINeparni(2, kraj);
            Console.WriteLine("Svi neparni brojevi od 1 do {0} su: ", kraj);
            ParniINeparni(1,kraj);

            return;
        }

        public static void ParniINeparni(int pocetniBr, int kraj)
        {
            if(pocetniBr > kraj) 
            {
                return;
            }

            Console.WriteLine(pocetniBr);

            ParniINeparni(pocetniBr + 2, kraj);
        }
    }
}
