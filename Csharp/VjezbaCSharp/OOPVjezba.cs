using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.VjezbaKodKuce
{
    //OOP
    class Poruke
    {
        public static void Pozdrav()
        {
            Console.WriteLine("Dobro dosli u sustav.");
        }

        public static void Pricekajte()
        {
            Console.WriteLine("Pricekajte molim vas.");
        }

        public static void Kraj()
        {
            Console.WriteLine("Dovidenja.");
        }
    //---------------------------------------------------
    }
    
    //OOP sa konstruktorom
    class Human
    {
        public string name;
        public int age;

        public Human(string name, int age) //KONSTRUKTOR
        {
            this.name = name;
            this.age = age;
        }



        public void Hrana()
        {
            Console.WriteLine(name + " jede KRUM-PI-RE.");
        }

        public void Spavanje()
        {
            Console.WriteLine(name + " spava na tvrdom tlu sa Frodom.");
        }

        public void Starost()
        {
            Console.WriteLine("U Tolkienovim knjigama, " + name + " je imao " + age + " godina/e/u.");
        }

        public void Hrana2()
        {
            Console.WriteLine(name + " nije ništa jeo.");
        }

    }

    //Static modifier
    class Car
    {
        public string boja;
        public string marka;
        public string model;
        public int godina;
        public static int brojAuta; // <-- static

        public Car(string boja, string marka, string model, int godina)
        {
            this.boja = boja;
            this.marka = marka;
            this.model = model;
            this.godina = godina;
            brojAuta++; // <--
        }

        public void Izgled()
        {
            Console.WriteLine("Boja auta je " + boja);
            
        }
    }


    class Kuca
    {
        public int broj_ukucana;
        public string ulica;
        public int broj_kuce;

        

        public void Broj_Ljudi()
        {
            Console.WriteLine("U kuci zivi " + broj_ukucana + " ljudi" );
        }

        public void Ulica()
        {
            Console.WriteLine("Ulica je " + ulica + ".");
        }

        public void Broj_Kuce()
        {
            Console.WriteLine("Broj je " + broj_kuce + ".");
        }
    }
}
