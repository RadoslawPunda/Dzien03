using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy
{
    public class Samochod
    {
        private String marka;
        private int predkoscMax;

        // deklaracja property (wlasciwosci)
        public int PredkoscMax {
            get { return predkoscMax; }
            set {
                if (value <= 0)
                {
                    Console.WriteLine("Cos chyba nie tak");
                }
                else
                {
                    predkoscMax = value;
                }
            }
        }


        public Samochod(String marka, int predkoscMax)
        {
            this.marka = marka;
            this.predkoscMax = predkoscMax;
        }
        public Samochod(String marka)
        {
            this.marka = marka;
            predkoscMax = 100;
        }


        /// <summary>
        /// Metoda zmienia predkosc maksymalną
        /// </summary>
        /// <param name="nowaPredkoscMax">nowa predkosc jako int32</param>
        public void UstawPredkoscMax(int nowaPredkoscMax)
        {
            predkoscMax = nowaPredkoscMax;
        }

        public int PobierzPredkoscMax()
        {
            return predkoscMax;
        }
        public void Print()
        {
            Console.WriteLine(String.Format("Marka={0}, predkosc max={1}", marka, predkoscMax ));
        }
    }
}
