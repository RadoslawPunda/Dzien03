using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Figury
{
    class Prostokat : Figura, IFigura
    {
        private double bokA;
        private double bokB;

        public Prostokat( double a, double b)
        {
            bokA = a; bokB = b;
            liczbaBokow = 4;
        }

        public bool czyKwadrat()
        {
            return bokA == bokB;
        }
        public double ObliczObwod()
        {
            return 2 * bokA + 2 * bokB;
            
        }

        public double ObliczPole()
        {
            return bokA * bokB;
        }
    }
}
