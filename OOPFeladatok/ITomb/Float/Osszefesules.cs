using System.Collections.Generic;

namespace OOPFeladatok.ITomb.Float
{
    public partial class FloatTomb
    {
        public FloatTomb Atvetel(FloatTomb tomb)
        {
            // A kezdő tömb és a hozzáadott tömb számításához, kezdetben üres.
            List<float> lista = new List<float>();

            // A kezdő tömb elemek listába töltése.
            foreach (float elem in this.TombF)
            {
                lista.Add(elem);
            }

            // A hozzáadott tömb elemeinek összehasonlítása a lista elemeivel, ha nincs közöttük, akkor hozzávesszük.
            foreach (float elem in tomb.TombF)
            {
                bool vanE = true;

                foreach (float item in lista)
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
            FloatTomb ujTomb = new FloatTomb(lista.Count);

            for (int i = 0; i < lista.Count; i++)
            {
                ujTomb.TombF[i] = lista[i];
            }

            return ujTomb;
        }
    }
}
