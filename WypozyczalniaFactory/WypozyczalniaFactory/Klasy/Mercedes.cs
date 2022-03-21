using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaFactory.Klasy
{
    internal class Mercedes : Interfejs
    {
        public void Stan(String kolor, String model, String paliwo, int rocznik)
        {
            Console.WriteLine("Mercedes w kolorze: " + kolor + " Model: " + model + " Paliwo: " + paliwo + " Rocznik: " + rocznik);
        }
    }
}
