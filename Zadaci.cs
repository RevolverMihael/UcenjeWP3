using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaKodKuce
{
    internal class Zadaci
    {
        

        public static void Izvedi()
        {
            //1. Prvi zadatak - Ime i Prezime
            Console.WriteLine("PRVI ZADATAK");
            Console.Write("\nUnesi ime: ");
            string ime = Console.ReadLine();
            Console.Write("Unesi prezime: ");
            string prezime = Console.ReadLine();
            Console.WriteLine(ime + " " + prezime);

            //2. Drugi zadatak - Zbroj dvaju brojeva
            Console.WriteLine("\nDRUGI ZADATAK");
            Console.Write("\nUnesi prvi broj: ");
            int Prvi = int.Parse(Console.ReadLine());
            Console.Write("Unesi drugi broj: ");
            int Drugi = int.Parse(Console.ReadLine());
            int zbroj = Prvi + Drugi;
            Console.WriteLine($"{Prvi} + {Drugi} = {zbroj}");

            //3.Treci zadatak - Kvadratna jednadzba
            Console.WriteLine("\nTRECI ZADATAK");
            Console.Write("a = ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("b = ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("c = ");
            float c = float.Parse(Console.ReadLine());

            KvadratnaJednadzba(a, b, c);

            //Cetvrti zadatak - Zbroj 10 brojeva
            Console.WriteLine("\nCETVRTI ZADATAK - ZBROJ 10 BROJEVA");
            Console.Write("Prvi broj: ");
            int PRV = int.Parse(Console.ReadLine());
            Console.Write("Drugi broj: ");
            int DRU = int.Parse(Console.ReadLine());
            Console.Write("Treci broj: ");
            int TRE = int.Parse(Console.ReadLine());
            Console.Write("Cetvrti broj: ");
            int CET = int.Parse(Console.ReadLine());
            Console.Write("Peti broj: ");
            int PET = int.Parse(Console.ReadLine());
            Console.Write("Sesti broj: ");
            int SES = int.Parse(Console.ReadLine());
            Console.Write("Sedmi broj: ");
            int SED = int.Parse(Console.ReadLine());
            Console.Write("Osmi broj: ");
            int OSM = int.Parse(Console.ReadLine());
            Console.Write("Deveti broj: ");
            int DEV = int.Parse(Console.ReadLine());
            Console.Write("Deseti broj: ");
            int DES = int.Parse(Console.ReadLine());
            
            zbroj = PRV + DRU + TRE + CET + PET + SES + SED + OSM + DEV + DES;
            Console.WriteLine(zbroj);

            //PETI ZADATAK
            Console.WriteLine("\nPETI ZADATAK - UMNOZAK");
            int umnozak;
            umnozak = PRV * DRU * TRE * CET * PET * SES * SED * OSM * DEV * DES;
            Console.WriteLine(umnozak);

            //SESTI ZADATAK




        }
        public static void KvadratnaJednadzba(float a, float b, float c)
        {
            double formula = Math.Sqrt(b * b - 4 * a * c);

            if(formula >= 0)
            {
                double x1 = (-b - formula) / 2 * a;
                double x2 = (-b + formula) / 2 * a;
                Console.WriteLine("x1 = " + x1 + " x2 = " + x2);
            }
            else
            {
                Console.WriteLine("NEMA RJESENJA");
            }
        }
    }
}
