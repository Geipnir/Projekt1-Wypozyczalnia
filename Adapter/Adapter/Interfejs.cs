using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    // The Target defines the domain-specific interface used by the client code.

    public interface Interfejs
    {
        string GetRequest(String Marka, String Model, String Kolor);
    }
}
