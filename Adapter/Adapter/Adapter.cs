using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{

    class Adapter : Interfejs
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public string GetRequest(String Marka, String Model, String Kolor)

        {
            return $"Uzytkownik {this._adaptee.GetSpecificRequest()} posiada samochod o wartosciach: " + Marka + " " + Model + " " + Kolor;
        }
    }
}
