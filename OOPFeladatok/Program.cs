using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPFeladatok.IntelligensTomb;

namespace OOPFeladatok
{
    class Program
    {
        static void Main(string[] args)
        {
            IntTomb it = new IntTomb(5, 10, 20);
            it.SajatAdatokKiirasa();

            Console.ReadKey(true);
        }
    }
}
