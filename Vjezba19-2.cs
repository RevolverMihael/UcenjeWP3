using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaKodKuce
{
    internal class Vjezba19_2
    {
        //Rekurzije
        public static void Izvedi()
        {
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Zbir je {0}", Sum(n));

            Pisi(7);
        }

        public static int Sum(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return n + Sum(n - 1);
            }

        }

        internal static void Pisi(int i)
        {
            if(i>=1)
            {
                Console.WriteLine(i);
                Pisi(i-1);
                
            }
        }

        
    }
}
