using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFeladatok.ITomb
{
    class Tomb
    {
        public int Elemszam { get; set; }
        public int IntervallumKezdo { get; set; }
        public int IntervallumVeg { get; set; }

        public Tomb(int elemszam, int intervallumKezdo, int intervallumVeg)
        {
            this.Elemszam = elemszam;
            this.IntervallumKezdo = intervallumKezdo;
            this.IntervallumVeg = intervallumVeg;
        }

        public Tomb()
        {

        }
        /*
        public void SajatFeltoltes() { }
        public void SajatAdatokKiirasa() { }
        public dynamic OsszegSzamol() { }
        public double AtlagSzamol() { }
        public dynamic MaxSzamol() { }
        public dynamic MinSzamol() { }

        public void Kiir()
        {
            Console.WriteLine("\nA tömb számított értékei: ");
            Console.WriteLine($"A tömbelemek összege: {OsszegSzamol()}");
            Console.WriteLine($"A tömbelemek átlaga: {AtlagSzamol()}");
            Console.WriteLine($"A tömbelemek maximuma: {MaxSzamol()}");
            Console.WriteLine($"A tömbelemek minimuma: {MinSzamol()}");
            Console.WriteLine();
        }
        */
    }
}
