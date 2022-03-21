using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaFactory.Klasy
{
    abstract class Factory
    {
        public abstract Interfejs GetSamochod(String Samochod);
    }
}
