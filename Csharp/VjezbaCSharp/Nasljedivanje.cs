using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.VjezbaKodKuce
{
    internal class Nasljedivanje
    {
        public static void Izvedi()
        {
            Auto auto = new Auto();
            Moped moped = new Moped();
            Camac camac = new Camac();
            Muscle muscle = new Muscle();

            Console.WriteLine("Auto ima " + auto.gume + " gume.");
            Console.WriteLine("Brzina mu je " + auto.brzina + " km/h.");
            auto.Pokret();
            Console.WriteLine("\nMoped ima " + moped.gume + " gume.");
            Console.WriteLine("Brzina mu je " + moped.brzina + " km/h.");
            moped.Pokret();
            Console.WriteLine("\nCamac nema gume.");
            Console.WriteLine("Brzina mu je " + camac.brzina + " km/h.");
            camac.Pokret();

            Console.WriteLine(" ");
            muscle.Truba();
            Console.WriteLine(muscle.boja + " " + muscle.marka + " " + muscle.model + " prolazi!");


        }

    }

    class Vozilo
    {
        public int brzina = 0;
        public string marka = "Ford";
        
        
        public void Pokret()
        {

            Console.WriteLine("Ovo vozilo nije u pokretu.");
        }

        public void Truba()
        {
            Console.WriteLine("Bip bip!");
        }
    }

    class Auto: Vozilo
    {
        public int gume = 4;
        
    }

    class Moped : Vozilo
    {
        public int gume = 2;
    }

    class Camac : Vozilo
    {
        public int gume = 0;
    }

    class Muscle : Vozilo
    {
        public string boja = "Crveni";
        public string model = "Mustang";
    }
    
}
