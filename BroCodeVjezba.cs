using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaKodKuce
{
    internal class BroCodeVjezba
    {
        public static void Izvedi()
        {

            // do while
            Console.WriteLine("Enter the upper border number n: ");
            int n = int.Parse(Console.ReadLine());

            int sum = 2;
            int startingNumber = 4;

            do
            {
                sum = sum + startingNumber;
                startingNumber += 2;
            }
            while (startingNumber <= n);
            Console.WriteLine(sum);


            string name = "";

            while (name == "")
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();

            }
            Console.WriteLine("Your name is: " + name);

            int[] niz = { 1, 2, 3, 4, 5, 6, };
            
            for (int i = 6; i > 0; i--) 
            {
                Console.WriteLine(i);
            }

            
            Console.Write("Koliko redova zelis? ");
            int rows = int.Parse((string)Console.ReadLine());
            Console.Write("Koliko stupaca zelis? ");
            int columns = int.Parse((string)Console.ReadLine());
            Console.Write("Napisi simbol: ");
            string symbol = Console.ReadLine();


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);

                }
                Console.WriteLine();
            }
            

            
        }
    }
}
