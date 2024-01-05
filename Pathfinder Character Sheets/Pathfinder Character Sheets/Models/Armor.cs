using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder_Character_Sheets_Server.Models
{
    public class Armor
    {
        public int ArmorId { get; set; }
        public string ArmorWeightClass {  get; set; }
        public string ArmorName { get; set; }
        public string ArmorDescription { get; set; }
        public bool IsMagical {  get; set; }
        public bool IsMasterwork { get; set; }
        public int MagicalModifier { get; set; }
        public int ArmorClass { get; set; }

    }
}
