using System;

namespace TypyGeneryczneZadanie1
{
    class Program
    {
        static void Main(string[] args)
        {

            Osoba<string, string, string>[] tab ={

                new Osoba<string, string, string>("Adam", "Krawczyk", "21/09/1978"),
                new Osoba<string, string, string>("Ola", "Krawczyk", "09/10/1988"),
                new Osoba<string, string, string>("Adam", "Kowalski", "10/08/1978"),
                new Osoba<string, string, string>("Alicja", "Trad", "11/06/1988"),
                new Osoba<string, string, string>("Stanislaw", "Gryf", "11/06/1978"),

            };

            Console.WriteLine("PRZED SORTOWANIEM");
            foreach (var i in tab)
            {
               Console.WriteLine(i.ToString());
            }

            Array.Sort(tab, Osoba<string, string, string>.Porownaj);

            Console.WriteLine("PO SORTOWANIU");
            foreach (var i in tab)
            {
                Console.WriteLine(i.ToString());
            }

        }
    }
}
