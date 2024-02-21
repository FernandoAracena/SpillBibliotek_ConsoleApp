
namespace SpillBibliotek_ConsoleApp
{
    internal class Konsollspill : IKonsollspill
    {
        protected string KonsollType;
        protected List<Spill> SpillsListe = new List<Spill>();

        public Konsollspill(string konsollType)
        {
            KonsollType = konsollType;
        }
        public virtual void ShowKonsollspillInfo()
        {
            Console.WriteLine($"Games in the {KonsollType} List : ");
            for (int i = 0; i < SpillsListe.Count; i++)
            {
                Console.Write($"{i} - ");
                SpillsListe[i].GetSpillInfo();
            }
        }

        public virtual void ShowKonsollType()
        {
            Console.WriteLine($"KonsollType : {KonsollType}");
        }

        public virtual void TrekkeUtRandomSpill()
        {
            var rand = new Random();
            var randomIndex = rand.Next(0, SpillsListe.Count);
            Console.WriteLine($"Random Game from {KonsollType} konsoll :");
            SpillsListe[randomIndex].GetSpillInfo();
        }

        public virtual void LeggeTilSpill(Spill spill)
        {
            SpillsListe.Add(spill);
        }

        public virtual void FjerneSpill(int index)
        {
            Console.WriteLine();
            Console.WriteLine("Deleted Game : ");
            SpillsListe[index].GetSpillInfo();
            SpillsListe.RemoveAt(index);
        }
    }
}
