using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaKodKuce
{
    internal class VjezbaPetak
    {
        public static void Izvedi()
        {
            //CIKLUSI VJEZBA


            //int[] niz = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //for (int i = 0; i < niz.Length; i++)
            //{
            //    if (niz[i] %2 == 1)
            //    {
            //        Console.WriteLine(niz[i]);
            //    }

            //}

            Console.Write("Unesi broj: ");
            int n = int.Parse(Console.ReadLine());
            int s = 0;
            for (int i = 1;i <= n; i++) 
            {
                if (i % 2 == 1)
                {
                    s = s + i;
                    Console.WriteLine("Dodajem {0} i zbir je {1}", i, s);
                }

            }
            Console.WriteLine("Zbir brojeva od 1 do " + n + " je " + s);


        }
    }
}
