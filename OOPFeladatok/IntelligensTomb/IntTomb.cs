using System;
using System.Collections.Generic;

namespace OOPFeladatok.IntelligensTomb
{
    class IntTomb
    {
        public int[] IntegerTomb { get; set; }
        public int Elemszam { get; set; }
        public int IntervallumKezdo { get; set; }
        public int IntervallumVeg { get; set; }

        public IntTomb(int elemszam, int intervallumKezdo, int intervallumVeg)
        {
            this.Elemszam = elemszam;
            this.IntervallumKezdo = intervallumKezdo;
            this.IntervallumVeg = intervallumVeg;
            this.IntegerTomb = new int[this.Elemszam];
            SajatFeltoltes();
        }

        // Atvetel() metódusban szükség lesz rá.
        public IntTomb(int elemszam)
        {
            this.IntegerTomb = new int[elemszam];
        }

        public void SajatFeltoltes()
        {
            Random rnd = new Random();
            for (int i = 0; i < this.Elemszam; i++)
            {
                this.IntegerTomb[i] = rnd.Next(this.IntervallumKezdo, this.IntervallumVeg + 1);
            }
        }

        public void SajatAdatokKiirasa()
        {
            foreach (int elem in this.IntegerTomb)
            {
                Console.WriteLine(elem);
            }
        }

        public int OsszegSzamol()
        {
            int osszeg = 0;

            foreach (int elem in this.IntegerTomb)
            {
                osszeg += elem;
            }

            return osszeg;
        }

        public double AtlagSzamol()
        {
            double atlag = (double)OsszegSzamol() / this.IntegerTomb.Length;

            return atlag;
        }

        public int MaxSzamol()
        {
            int max = Int32.MinValue;

            foreach (int elem in this.IntegerTomb)
            {
                if (elem > max)
                {
                    max = elem;
                }
            }

            return max;
        }

        public int MinSzamol()
        {
            int min = Int32.MaxValue;

            foreach (int elem in this.IntegerTomb)
            {
                if (elem < min)
                {
                    min = elem;
                }
            }

            return min;
        }

        public void Kiir()
        {
            Console.WriteLine("\nA tömb számított értékei: ");
            Console.WriteLine($"A tömbelemek összege: {OsszegSzamol()}");
            Console.WriteLine($"A tömbelemek átlaga: {AtlagSzamol()}");
            Console.WriteLine($"A tömbelemek maximuma: {MaxSzamol()}");
            Console.WriteLine($"A tömbelemek minimuma: {MinSzamol()}");
            Console.WriteLine();
        }

        public IntTomb Atvetel(IntTomb tomb)
        {
            // A kezdő tömb és a hozzáadott tömb számításához, kezdetben üres.
            List<int> lista = new List<int>();

            // A kezdő tömb elemek listába töltése.
            foreach (int elem in this.IntegerTomb)
            {
                lista.Add(elem);
            }

            // A hozzáadott tömb elemeinek összehasonlítása a lista elemeivel, ha nincs közöttük, akkor hozzávesszük.
            foreach (int elem in tomb.IntegerTomb)
            {
                bool vanE = true;

                foreach (int item in lista)
                {
                    if (item == elem)
                    {
                        vanE = false;
                        break;
                    }
                }

                if (vanE)
                {
                    lista.Add(elem);
                }
            }

            // Lista segítségével létrehozok egy új intelligens tömböt.
            IntTomb ujTomb = new IntTomb(lista.Count);

            for (int i = 0; i < lista.Count; i++)
            {
                ujTomb.IntegerTomb[i] = lista[i];
            }

            return ujTomb;
        }
    }
}
