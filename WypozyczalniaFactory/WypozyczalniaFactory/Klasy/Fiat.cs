using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaFactory.Klasy
{
    internal class Fiat : Interfejs
    {
        public void Stan(String kolor, String model, String paliwo, int rocznik)
        {
            Console.WriteLine("Fiat w kolorze: " + kolor + " Model: " + model + " Paliwo: " + paliwo + " Rocznik: " + rocznik);
        }
    }
}
