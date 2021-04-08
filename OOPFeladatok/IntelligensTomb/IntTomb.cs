using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public int Osszegszamol()
        {
            int osszeg = 0;

            foreach (int elem in this.IntegerTomb)
            {
                osszeg += elem;
            }

            return osszeg;
        }

        public double Atlagszamol()
        {
            double atlag = (double)Osszegszamol() / this.Elemszam;

            return atlag;
        }
    }
}
