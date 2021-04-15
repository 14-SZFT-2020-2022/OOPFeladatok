using System;

namespace OOPFeladatok.ITomb.Integer
{
    public partial class IntegerTomb
    {
        public int OsszegSzamol()
        {
            int osszeg = 0;

            foreach (int elem in this.TombI)
            {
                osszeg += elem;
            }

            return osszeg;
        }

        public double AtlagSzamol()
        {
            double atlag = (double)OsszegSzamol() / this.TombI.Length;

            return atlag;
        }

        public int MaxSzamol()
        {
            int max = Int32.MinValue;

            foreach (int elem in this.TombI)
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

            foreach (int elem in this.TombI)
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
