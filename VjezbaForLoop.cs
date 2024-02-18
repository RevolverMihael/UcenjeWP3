using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaKodKuce
{
    internal class VjezbaForLoop
    {
        public static void Izvedi()
        {
            //"2.Write a C# Sharp program to find the sum of the first 10 natural numbers."
            int i, suma = 0;


            for (i = 1; i <= 10; i++)
            {
                suma += i;
                Console.Write(i + "\t");
                
            }
            Console.WriteLine("\n" + suma);

            //3.Write a C# Sharp program that displays the sum of n natural numbers.
            int j, suma2 = 0;
            for(j = 1; j <= 7; j++)
            {
                suma2 += j;
                Console.Write(j + "\t");
            }
            Console.WriteLine(suma2);

            //10.Write a program in C# Sharp to display a pattern like a right angle triangle with a number.
            Console.WriteLine("Unesi broj redova: ");
            int a, b, rows;
            rows = int.Parse(Console.ReadLine());
            for(a = 1; a <= rows; a++)
            {
                for(b= 1; b <= a; b++)
                {
                    Console.Write(b);
                }
                Console.WriteLine();
            }

            //11.Write a program in C# Sharp to make such a pattern like a right angle triangle with a number which repeats a number in a row.
            Console.WriteLine("Unesi broj redova: ");
            int c, d, rows2;
            rows2 = int.Parse(Console.ReadLine()); 
            for(c = 1; c <= rows2;c++)
            {
                for(d = 1; d <= c; d++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }




        }
    }
}
