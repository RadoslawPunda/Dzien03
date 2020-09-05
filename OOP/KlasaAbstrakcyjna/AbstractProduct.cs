using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.KlasaAbstrakcyjna
{
    abstract class AbstractProduct
    {
        protected string name;
        protected double price;

        public AbstractProduct(string n, double p)
        {
            name = n;
            price = p;
        }

        public void ShowInfo()
        {
            Console.WriteLine("info o produkcie: {0} - {1}" ,name, price);
        }

        public abstract void ShowPrice();
    }
}
