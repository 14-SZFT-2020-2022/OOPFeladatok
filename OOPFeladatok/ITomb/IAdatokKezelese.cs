using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFeladatok.ITomb
{
    interface IAdatokKezelese
    {
        void SajatFeltoltes();
        void SajatAdatokKiirasa();
        dynamic OsszegSzamol();
        double AtlagSzamol();
        dynamic MaxSzamol();
        dynamic MinSzamol();
    }
}
