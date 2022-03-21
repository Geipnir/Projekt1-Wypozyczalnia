using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaFactory.Klasy
{
    internal class Sprawdzanie : Factory
    {
        public override Interfejs GetSamochod(String Samochod)
        {
            switch (Samochod)
            {
                case "BMW":
                    return new BMW();
                case "Mercedes":
                    return new Mercedes();
                case "Audi":
                    return new Audi();
                case "Fiat":
                    return new Fiat();
                default:
                    throw new ApplicationException(String.Format("tak", Samochod));
            }
        }
    }
}
