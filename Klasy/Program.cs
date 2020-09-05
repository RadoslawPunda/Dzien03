using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod = new Samochod("FIAT", 180);
            //samochod.UstawPredkoscMax(199);
            samochod.PredkoscMax = -32;
            samochod.Print();

            //int predkosc = samochod.PobierzPredkoscMax();
            Console.WriteLine(samochod.PredkoscMax);

            // kolejkna instancja obkjektu
            Samochod samochod1 = new Samochod("Audi");
            samochod1.Print();
            Console.ReadLine();
        }
    }
}
