using System;

namespace OOPFeladatok.ITomb.Float
{
    public partial class FloatTomb : Tomb
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

        public void SajatFeltoltes()
        {
            Random rnd = new Random();

            for (int i = 0; i < this.Elemszam; i++)
            {
                this.TombF[i] = (float)((this.IntervallumVeg - this.IntervallumKezdo + 1) * rnd.NextDouble() + this.IntervallumKezdo);
            }
        }
    }
}
