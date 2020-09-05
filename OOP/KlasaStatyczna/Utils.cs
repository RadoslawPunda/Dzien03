using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.KlasaStatyczna
{
    static public class Utils
    {
        public static readonly string hostname = "192.168.0.1";
        public static int portNumber = 8080;

        public static int GetMaxValue(params int[] args)
        {
            return args.Max();
        }
    }
}
