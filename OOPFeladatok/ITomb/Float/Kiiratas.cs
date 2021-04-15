using System;

namespace OOPFeladatok.ITomb.Float
{
    public partial class FloatTomb
    {
        public void SajatAdatokKiirasa()
        {
            foreach (int elem in this.TombF)
            {
                Console.WriteLine(elem);
            }
        }

        public void Kiir()
        {
            Console.WriteLine("\nA tömb számított értékei: ");
            Console.WriteLine($"A tömbelemek összege: {this.OsszegSzamol()}");
            Console.WriteLine($"A tömbelemek átlaga: {this.AtlagSzamol()}");
            Console.WriteLine($"A tömbelemek maximuma: {this.MaxSzamol()}");
            Console.WriteLine($"A tömbelemek minimuma: {this.MinSzamol()}");
            Console.WriteLine();
        }
    }
}
