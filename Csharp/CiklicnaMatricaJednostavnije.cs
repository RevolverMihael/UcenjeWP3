using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaKodKuce
{
    internal class CiklicnaMatricaJednostavnije
    {
        public static void Izvedi()
        {
            Console.WriteLine("CIKLICNA MATRICA");
            // DIMENZIJE
            

            int[,] Matrica = new int[5, 5] {
                {  9, 10, 11, 12, 13 },
                {  8, 21, 22, 23, 14 },
                {  7, 20, 25, 24, 15 },
                {  6, 19, 18, 17, 16 },
                {  5,  4,  3,  2,  1 }
            };
            

            int redovi = Matrica.GetLength(0);
            int stupci = Matrica.GetLength(1);

            for(int i = 0; i < redovi; i++)
            {
                for(int j = 0; j < stupci; j++)
                {
                    Console.Write("\t{0} ", Matrica[i, j]);
                }
                Console.WriteLine();
            }
            

        }
       

       

        

            


        


    }
}

      

       









