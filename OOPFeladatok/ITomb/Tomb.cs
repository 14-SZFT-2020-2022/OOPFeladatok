namespace OOPFeladatok.ITomb
{
    public class Tomb
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
    }
}
