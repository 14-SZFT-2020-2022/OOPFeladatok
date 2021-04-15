using System;
using System.Threading;
using OOPFeladatok.IntelligensTomb;
using OOPFeladatok.ITomb;

namespace OOPFeladatok
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            IntTomb<int> it = new IntTomb<int>(5, 10, 20);
            it.SajatAdatokKiirasa();
            it.Kiir();
            Thread.Sleep(1000);
            IntTomb<int> it2 = new IntTomb<int>(5, 10, 20);
            it2.SajatAdatokKiirasa();
            it2.Kiir();
            IntTomb<int> it3 = it.Atvetel(it2);
            it3.SajatAdatokKiirasa();
            it3.Kiir();
            */

            Console.Write("Milyen típussal dolgozzak (int/float): ");
            string beker = Console.ReadLine();
            Console.Write("Hány elemű legyen az intelligens tömb: ");
            int elemszam = Int32.Parse(Console.ReadLine());
            Console.Write("Az intervallum kezdőpontja: ");
            int intervallumKezdo = Int32.Parse(Console.ReadLine());
            Console.Write("Az intervallum végpontja: ");
            int intervallumVeg = Int32.Parse(Console.ReadLine());

            if (beker == "int")
            {
                IntegerTomb it = new IntegerTomb(elemszam, intervallumKezdo, intervallumVeg);
                it.SajatAdatokKiirasa();
                it.Kiir();
                Thread.Sleep(1000);
                IntegerTomb it1 = new IntegerTomb(elemszam, intervallumKezdo, intervallumVeg);
                it1.SajatAdatokKiirasa();
                it1.Kiir();
                IntegerTomb it2 = it.Atvetel(it1);
                it2.SajatAdatokKiirasa();
                it2.Kiir();
            }
            else if (beker == "float")
            {
                FloatTomb ft = new FloatTomb(elemszam, intervallumKezdo, intervallumVeg);
                ft.SajatAdatokKiirasa();
                ft.Kiir();
                Thread.Sleep(1000);
                FloatTomb ft1 = new FloatTomb(elemszam, intervallumKezdo, intervallumVeg);
                ft1.SajatAdatokKiirasa();
                ft1.Kiir();
                FloatTomb ft2 = ft.Atvetel(ft1);
                ft2.SajatAdatokKiirasa();
                ft2.Kiir();
            }

            Console.ReadKey(true);
        }
    }
}
