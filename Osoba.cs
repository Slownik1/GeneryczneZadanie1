using System;
using System.Collections.Generic;
using System.Text;

namespace TypyGeneryczneZadanie1
{
    class Osoba<T, T1, T2>
    {

        private T imie;
        private T1 nazwisko;
        private T2 date;

        public Osoba(T imie, T1 nazwisko, T2 date)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.date = date;
        }

        public T Imie { get => imie; set => imie = value; }
        public T1 Nazwisko { get => nazwisko; set => nazwisko = value; }
        public T2 Date { get => date; set => date = value; }

        public override string ToString()
        {
            return $"Osoba: {Imie}, {Nazwisko}, {Date}";
        }

        public static int Porownaj(Osoba<T, T1,T2> o1, Osoba<T, T1, T2> o2)
        {
            if (o1 == null && o2 == null) return 0;
            else if (o1 == null) return -1;
            else if (o2 == null) return 1;

            if ((Convert.ToDateTime(o1.date))>(Convert.ToDateTime(o2.date))) return -1;
            else if ((Convert.ToDateTime(o1.date)) < (Convert.ToDateTime(o2.date))) return 1;
            else return 0;
        }

    }
}
