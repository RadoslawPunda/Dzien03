using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Figury
{
    class Kwadrat : Prostokat
    {
        public Kwadrat(double bok) : base(bok, bok)
        {
            Console.WriteLine("Konstruktor klasy kwadrat");
        }

        public int czyKwadrat()
        {
            //if (base.czyKwadrat())
            //{
            //    return 1;
            //}
            //else
            //{
            //    return 0;
            //}
            return base.czyKwadrat() ? 1 : 0; // operator trojmianowy
        }
    }
}
