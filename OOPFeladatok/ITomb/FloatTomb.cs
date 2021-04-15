using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFeladatok.ITomb
{
    class FloatTomb : Tomb, IAdatokKezelese
    {
        public float[] TombF { get; set; }

        public FloatTomb(int elemszam, int intervallumKezdo, int intervallumVeg) : base(elemszam, intervallumKezdo, intervallumVeg)
        {
            this.TombF = new float[this.Elemszam];
            SajatFeltoltes();
        }

        public FloatTomb(int elemszam)
        {
            this.TombF = new float[elemszam];
        }

        override public void SajatFeltoltes()
        {
            Random rnd = new Random();

            for (int i = 0; i < this.Elemszam; i++)
            {
                this.TombF[i] = (float)((this.IntervallumVeg - this.IntervallumKezdo + 1) * rnd.NextDouble() + this.IntervallumKezdo);
            }
        }

        override public void SajatAdatokKiirasa()
        {
            foreach (float elem in this.TombF)
            {
                Console.WriteLine(elem);
            }
        }

        override public dynamic OsszegSzamol()
        {
            float osszeg = 0.0F;

            foreach (float elem in this.TombF)
            {
                osszeg += elem;
            }

            return osszeg;
        }

        override public double AtlagSzamol()
        {
            double atlag = (double)OsszegSzamol() / this.TombF.Length;

            return atlag;
        }

        override public dynamic MaxSzamol()
        {
            float max = System.Single.MinValue;

            foreach (float elem in this.TombF)
            {
                if (elem > max)
                {
                    max = elem;
                }
            }

            return max;
        }

        override public dynamic MinSzamol()
        {
            float min = System.Single.MaxValue;

            foreach (float elem in this.TombF)
            {
                if (elem < min)
                {
                    min = elem;
                }
            }

            return min;
        }

        public FloatTomb Atvetel(FloatTomb tomb)
        {
            // A kezdő tömb és a hozzáadott tömb számításához, kezdetben üres.
            List<float> lista = new List<float>();

            // A kezdő tömb elemek listába töltése.
            foreach (float elem in this.TombF)
            {
                lista.Add(elem);
            }

            // A hozzáadott tömb elemeinek összehasonlítása a lista elemeivel, ha nincs közöttük, akkor hozzávesszük.
            foreach (float elem in tomb.TombF)
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
            FloatTomb ujTomb = new FloatTomb(lista.Count);

            for (int i = 0; i < lista.Count; i++)
            {
                ujTomb.TombF[i] = lista[i];
            }

            return ujTomb;
        }
    }
}
