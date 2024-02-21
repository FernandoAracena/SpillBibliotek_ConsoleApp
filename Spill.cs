using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpillBibliotek_ConsoleApp
{
    internal class Spill
    {
        private string SpillName;
        private string SpillDescription;
        private string SpillType;

        public Spill(string spillName, string spillDescription, string spillType)
        {
            SpillName = spillName;
            SpillDescription = spillDescription;
            SpillType = spillType;
        }
        public void GetSpillInfo()
        {
            Console.WriteLine($"SpillName : {SpillName} - SpillDescription : {SpillDescription} - SpillType : {SpillType}");
        }
    }
}
