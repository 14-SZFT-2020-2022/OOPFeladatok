using System;

namespace OOPFeladatok.ITomb.Integer
{
    public partial class IntegerTomb : Tomb
    {
        public int[] TombI { get; set; }

        public IntegerTomb(int elemszam, int intervallumKezdo, int intervallumVeg) : base(elemszam, intervallumKezdo, intervallumVeg)
        {
            this.TombI = new int[this.Elemszam];
            SajatFeltoltes();
        }

        public IntegerTomb(int elemszam)
        {
            this.TombI = new int[elemszam];
        }

        public void SajatFeltoltes()
        {
            Random rnd = new Random();

            for (int i = 0; i < this.Elemszam; i++)
            {
                this.TombI[i] = rnd.Next(this.IntervallumKezdo, this.IntervallumVeg + 1);
            }
        }
    }
}
