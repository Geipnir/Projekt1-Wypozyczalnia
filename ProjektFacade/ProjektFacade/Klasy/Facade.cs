using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace ProjektFacade.Klasy
{
    internal class Facade
    {
        public ArrayList lista = new ArrayList();
        Imie imie;
        Nazwisko nazwisko;
        Pesel pesel;

        public Facade()
        {
            imie = new Imie();
            nazwisko = new Nazwisko();
            pesel = new Pesel();
        }

        public void WpisUzytkownika()
        {
            Console.WriteLine("Zapisywanie uzytkownika. Podaj Imie");
            String zmiennaimie = Convert.ToString(Console.ReadLine());
            imie.SetImie(zmiennaimie);
            lista.Add(zmiennaimie);
            Console.WriteLine("Podaj nazwisko");
            String zmiennanazwisko = Convert.ToString(Console.ReadLine());
            nazwisko.SetNazwisko(zmiennanazwisko);
            lista.Add(zmiennanazwisko);
            Console.WriteLine("Podaj pesel");
            double zmiennapesel = Convert.ToDouble(Console.ReadLine());
            if (zmiennapesel < 100000000000 && zmiennapesel > 9999999999)
            {
                pesel.SetPesel(zmiennapesel);
                lista.Add(zmiennapesel);
                Console.WriteLine("Zapisano uzytkownika");
            } else 
            { 
                Console.WriteLine("wpisano zly pesel");
                Console.ReadLine();
                Environment.Exit(0);
            }
            PrintValues(lista);
        }
        public static void PrintValues(IEnumerable mojalista)
        {
            foreach (Object objekt in mojalista)
                Console.Write("   {0}", objekt);
            Console.WriteLine();
        }
    }
}
