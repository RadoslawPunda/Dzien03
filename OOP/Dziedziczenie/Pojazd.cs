using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Dziedziczenie
{
    public class Pojazd : IPojazd
    {
        protected int liczbaKol;
        protected int liczbaDrzwi;
        protected int predkoscMax;
        protected bool czySilnikowy;

        public void Uruchom()
        {
            Console.WriteLine("pojazd - uruchom");
        }

        public void Zatankuj()
        {
            Console.WriteLine("pojazd - zatankuj");
        }

        public void Zatrzymaj()
        {
            Console.WriteLine("pojazd - zatrzymaj");
        }
    }
}
