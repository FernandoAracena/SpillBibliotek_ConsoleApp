using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpillBibliotek_ConsoleApp
{
    internal class GameCube : Konsollspill
    {
        private List<Spill> GameCubeListe = new List<Spill>
            {
                new Spill("Horizon Zero Dawn", "Action role-playing game set in a post-apocalyptic world.", "Action RPG"),
                new Spill("Persona 5", "Role-playing game set in modern-day Tokyo.", "RPG"),
                new Spill("Final Fantasy XV", "Action role-playing game set in an open world environment.", "Action RPG")
            };
        public GameCube(string konsollType) : base(konsollType)
        {
            SpillsListe = GameCubeListe;
        }
    }
}
