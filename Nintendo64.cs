using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpillBibliotek_ConsoleApp
{
    internal class Nintendo64 : Konsollspill
    {
        private List<Spill> Nintendo64Liste = new List<Spill>
        {
            new Spill("The Legend of Zelda: Breath of the Wild", "Action-adventure game with an emphasis on exploration.", "Action Adventure"),
            new Spill("Grand Theft Auto V", "Action-adventure game played from either a first-person or third-person view.", "Action Adventure"),
            new Spill("God of War", "Action-adventure game that follows Kratos, a former Greek god who embarks on a quest.", "Action Adventure"),
            new Spill("Dark Souls III", "Action role-playing game known for its challenging gameplay.", "Action RPG")
        };
        public Nintendo64(string konsollType) : base(konsollType)
        {
            SpillsListe = Nintendo64Liste;
        }
    }
}
