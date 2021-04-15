using System;

namespace OOPFeladatok.ITomb.Float
{
    public partial class FloatTomb
    {
        public float OsszegSzamol()
        {
            float osszeg = 0.0F;

            foreach (float elem in this.TombF)
            {
                osszeg += elem;
            }

            return osszeg;
        }

        public double AtlagSzamol()
        {
            double atlag = (double)OsszegSzamol() / this.TombF.Length;

            return atlag;
        }

        public float MaxSzamol()
        {
            float max = Single.MinValue;

            foreach (float elem in this.TombF)
            {
                if (elem > max)
                {
                    max = elem;
                }
            }

            return max;
        }

        public float MinSzamol()
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
    }
}
