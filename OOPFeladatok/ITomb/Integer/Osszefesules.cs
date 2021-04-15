using System.Collections.Generic;

namespace OOPFeladatok.ITomb.Integer
{
    public partial class IntegerTomb
    {
        public IntegerTomb Atvetel(IntegerTomb tomb)
        {
            // A kezdő tömb és a hozzáadott tömb számításához, kezdetben üres.
            List<int> lista = new List<int>();

            // A kezdő tömb elemek listába töltése.
            foreach (int elem in this.TombI)
            {
                lista.Add(elem);
            }

            // A hozzáadott tömb elemeinek összehasonlítása a lista elemeivel, ha nincs közöttük, akkor hozzávesszük.
            foreach (int elem in tomb.TombI)
            {
                bool vanE = true;

                foreach (int item in lista)
                {
                    if (item == elem)
                    {
                        vanE = false;
                        break;
                    }
                }

                if (vanE)
                {
                    lista.Add(elem);
                }
            }

            // Lista segítségével létrehozok egy új intelligens tömböt. Itt használom a második konstruktort.
            IntegerTomb ujTomb = new IntegerTomb(lista.Count);

            for (int i = 0; i < lista.Count; i++)
            {
                ujTomb.TombI[i] = lista[i];
            }

            return ujTomb;
        }
    }
}
