using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpillBibliotek_ConsoleApp
{
    internal class Playstation2 : Konsollspill
    {
        private List<Spill> Playstation2Liste = new List<Spill>
        {
            new Spill("The Witcher 3: Wild Hunt", "Action role-playing game set in an open world environment.", "Action RPG"),
            new Spill("Red Dead Redemption 2", "Action-adventure game set in an open world environment.", "Action Adventure")
        };
        public Playstation2(string konsollType) : base(konsollType)
        {
            SpillsListe = Playstation2Liste;
        }

    }
}
