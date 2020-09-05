using OOP.KlasaAbstrakcyjna;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.KlasaAbstrakcyjna
{
    class Product : AbstractProduct
    {
        public Product(string name, double price) : base(name, price)
        {

        }
        public override void ShowPrice()
        {
            Console.WriteLine("cena = {0}", price);
        }
    }
}
