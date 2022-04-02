using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
   // The Adaptee contains some useful behavior, but its interface is
   // incompatoble with the existing client code.

    class Adaptee
    {
        public string GetSpecificRequest()
        {
            String imie = "Heniek";
            String nazwisko = "Kopytko";
            return imie +" "+ nazwisko;
        }
    }
}
