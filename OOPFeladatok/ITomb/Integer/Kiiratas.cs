using System;

namespace OOPFeladatok.ITomb.Integer
{
    public partial class IntegerTomb
    {
        public void SajatAdatokKiirasa()
        {
            foreach (int elem in this.TombI)
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
