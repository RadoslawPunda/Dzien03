using OOP.Dziedziczenie;
using OOP.Figury;
using OOP.KlasaAbstrakcyjna;
using OOP.KlasaStatyczna;
using OOP.KlasaStatyczna;
using OOP.Operatory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pojazd pojazd = new Pojazd();
            //pojazd.Uruchom();
            //Samochod samochod = new Samochod();
            //samochod.Uruchom();
            //SamochodElektryczny se = new SamochodElektryczny();
            //se.Uruchom();

            //Prostokat prostokat = new Prostokat(2.5, 5);
            //Console.WriteLine(prostokat.czyKwadrat());
            //Console.WriteLine(prostokat.ObliczPole());
            //Console.WriteLine(prostokat.ObliczObwod());
            //Kwadrat kwadrat = new Kwadrat(5);
            //Console.WriteLine(kwadrat.czyKwadrat());
            //Console.WriteLine(kwadrat.ObliczPole());
            //Console.WriteLine(kwadrat.ObliczObwod());

            //Utils.hostname = "127.0.0.1";
            //Console.WriteLine(Utils.GetMaxValue(-10, 1, 10, 100));

            //Product product = new Product("mleko", 2.99);
            //product.ShowInfo();
            //product.ShowPrice();

            Wektor wektor1 = new Wektor(1, -2);
            Wektor wektor2 = new Wektor(-4, 10);
            Wektor suma = wektor1 + wektor2; //wektor1.Add(wektor2);
            suma.Print();
            suma = wektor1 + 10;
            suma.Print();

            

            Console.ReadLine();
        }
    }
}
