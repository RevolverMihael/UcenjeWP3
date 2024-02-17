using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaKodKuce
{
    internal class CiklicnaMatrica
    {
        public static void Izvedi()
        {
            int brojRedova = 5;
            int brojStupaca = 5;

            int[,] ciklicnaMatrica = KreirajCiklicnuMatricu(brojRedova, brojStupaca);

            IspisiMatricu(ciklicnaMatrica, brojRedova, brojStupaca);
            
            
        }

        static int[,] KreirajCiklicnuMatricu(int brojRedova, int brojStupaca)
        {
            int[,] matrica = new int[brojRedova, brojStupaca];

            int brojac = 1;
            matrica[2, 2] = 25;

            for (int krug = 0; krug < Math.Min(brojRedova, brojStupaca) / 2; krug++)
            {
                // Popuni vrh kruga
                for (int j = brojStupaca - krug - 1; j>= krug; j--)
                    matrica[brojRedova - krug - 1, j] = brojac++;

                for (int i = brojRedova - krug - 2; i > krug; i--)
                {
                    matrica[i, krug] = brojac++;
                }

                for (int j = krug; j < brojStupaca - krug - 1; j++)
                {
                    matrica[krug, j] = brojac++;
                }

                for (int i = krug; i < brojRedova - krug - 1; i++)
                {
                    matrica[i,brojStupaca-krug-1] = brojac++;

                }
            }

            return matrica;
        }

        static void IspisiMatricu(int[,] matrica, int brojRedova, int brojStupaca)
        {
            Console.WriteLine("Ciklicna matrica:");

            for (int i = 0; i < brojRedova; i++)
            {
                for (int j = 0; j < brojStupaca; j++)
                {
                    Console.Write(matrica[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }

}

