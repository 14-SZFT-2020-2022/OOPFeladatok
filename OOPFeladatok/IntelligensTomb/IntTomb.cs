using System;
using System.Collections.Generic;

namespace OOPFeladatok.IntelligensTomb
{
    class IntTomb<T>
    {
        public int[] IntegerTomb { get; set; }
        public float[] FloatTomb { get; set; }
        public int Elemszam { get; set; }
        public int IntervallumKezdo { get; set; }
        public int IntervallumVeg { get; set; }

        public IntTomb(int elemszam, int intervallumKezdo, int intervallumVeg)
        {
            this.Elemszam = elemszam;
            this.IntervallumKezdo = intervallumKezdo;
            this.IntervallumVeg = intervallumVeg;
            if (typeof(T) == typeof(int))
            {
                this.IntegerTomb = new int[this.Elemszam];
            }
            else
            {
                this.FloatTomb = new float[this.Elemszam];
            }
            SajatFeltoltes();
        }

        // Atvetel() metódusban szükség lesz rá.
        public IntTomb(int elemszam)
        {
            if (typeof(T) == typeof(int))
            {
                this.IntegerTomb = new int[elemszam];
            }
            else
            {
                this.FloatTomb = new float[elemszam];
            }
        }

        public void SajatFeltoltes()
        {
            Random rnd = new Random();

            if (typeof(T) == typeof(int))
            {
                // Integer tömb feltöltése
                for (int i = 0; i < this.Elemszam; i++)
                {
                    this.IntegerTomb[i] = rnd.Next(this.IntervallumKezdo, this.IntervallumVeg + 1);
                }
            }
            else
            {
                // Float tömb feltöltése
                for (int i = 0; i < this.Elemszam; i++)
                {
                    this.FloatTomb[i] = (float)((this.IntervallumVeg - this.IntervallumKezdo + 1) * rnd.NextDouble() + this.IntervallumKezdo);
                }
            }
        }

        public void SajatAdatokKiirasa()
        {
            if (typeof(T) == typeof(int))
            {
                foreach (int elem in this.IntegerTomb)
                {
                    Console.WriteLine(elem);
                }
            }
            else
            {
                foreach (float elem in this.FloatTomb)
                {
                    Console.WriteLine(elem);
                }
            }
        }

        public dynamic OsszegSzamol()
        {
            if (typeof(T) == typeof(int))
            {
                int osszeg = 0;

                foreach (int elem in this.IntegerTomb)
                {
                    osszeg += elem;
                }

                return osszeg;
            }
            else
            {
                float osszeg = 0.0F;

                foreach (float elem in this.FloatTomb)
                {
                    osszeg += elem;
                }

                return osszeg;
            }
        }

        public double AtlagSzamol()
        {
            if (typeof(T) == typeof(int))
            {
                double atlag = (double)OsszegSzamol() / this.IntegerTomb.Length;

                return atlag;
            }
            else
            {
                double atlag = (double)OsszegSzamol() / this.FloatTomb.Length;

                return atlag;
            }
        }

        public dynamic MaxSzamol()
        {
            if (typeof(T) == typeof(int))
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
            else
            {
                float max = System.Single.MinValue;

                foreach (float elem in this.FloatTomb)
                {
                    if (elem > max)
                    {
                        max = elem;
                    }
                }

                return max;
            }
        }

        public dynamic MinSzamol()
        {
            if (typeof(T) == typeof(int))
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
            else
            {
                float min = System.Single.MaxValue;

                foreach (float elem in this.FloatTomb)
                {
                    if (elem < min)
                    {
                        min = elem;
                    }
                }

                return min;
            }
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

        public IntTomb<T> Atvetel(IntTomb<T> tomb)
        {
            if (typeof(T) == typeof(int))
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

                // Lista segítségével létrehozok egy új intelligens tömböt. Itt használom a második konstruktort.
                IntTomb<T> ujTomb = new IntTomb<T>(lista.Count);

                for (int i = 0; i < lista.Count; i++)
                {
                    ujTomb.IntegerTomb[i] = lista[i];
                }

                return ujTomb;
            }
            else
            {
                // A kezdő tömb és a hozzáadott tömb számításához, kezdetben üres.
                List<float> lista = new List<float>();

                // A kezdő tömb elemek listába töltése.
                foreach (float elem in this.FloatTomb)
                {
                    lista.Add(elem);
                }

                // A hozzáadott tömb elemeinek összehasonlítása a lista elemeivel, ha nincs közöttük, akkor hozzávesszük.
                foreach (float elem in tomb.FloatTomb)
                {
                    bool vanE = true;

                    foreach (float item in lista)
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

                // Lista segítségével létrehozok egy új intelligens tömböt. Itt használom a második konstruktort.
                IntTomb<T> ujTomb = new IntTomb<T>(lista.Count);

                for (int i = 0; i < lista.Count; i++)
                {
                    ujTomb.FloatTomb[i] = lista[i];
                }

                return ujTomb;
            }
        }
    }
}
