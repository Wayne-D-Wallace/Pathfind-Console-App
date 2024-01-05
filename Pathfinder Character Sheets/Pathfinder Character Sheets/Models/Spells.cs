using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder_Character_Sheets_Server.Models
{
    public class Spells
    {
        public int SpellId { get; set; }
        public string SpellType { get; set; }
        public string SpellName { get; set; }
        public string SpellDescription { get; set; }
        public int SpellLevel { get; set; }
        public int SpellDc {  get; set; }

    }
}
