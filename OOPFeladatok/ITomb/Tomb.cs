using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFeladatok.ITomb
{
    class Tomb : IAdatokKezelese
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

        virtual public void SajatFeltoltes() { }
        virtual public void SajatAdatokKiirasa() { }
        virtual public dynamic OsszegSzamol()
        {
            dynamic t = 0;
            return t; 
        }

        virtual public double AtlagSzamol()
        {            
            double t = 0;
            return t;
        }

        virtual public dynamic MaxSzamol()
        {
            dynamic t = 0;
            return t;
        }

        virtual public dynamic MinSzamol()
        {
            dynamic t = 0;
            return t;
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
