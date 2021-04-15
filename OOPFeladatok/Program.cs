using System;
using System.Threading;
using OOPFeladatok.IntelligensTomb;

namespace OOPFeladatok
{
    class Program
    {
        static void Main(string[] args)
        {
            IntTomb<float> it = new IntTomb<float>(5, 10, 20);
            it.SajatAdatokKiirasa();
            it.Kiir();
            Thread.Sleep(1000);
            IntTomb<float> it2 = new IntTomb<float>(5, 10, 20);
            it2.SajatAdatokKiirasa();
            it2.Kiir();
            IntTomb<float> it3 = it.Atvetel(it2);
            it3.SajatAdatokKiirasa();
            it3.Kiir();

            Console.ReadKey(true);
        }
    }
}
