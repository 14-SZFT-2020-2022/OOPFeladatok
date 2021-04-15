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

            if (beker == "int")
            {
                IntegerTomb it = new IntegerTomb(5, 10, 20);
                it.SajatAdatokKiirasa();
            }

            Console.ReadKey(true);
        }
    }
}
