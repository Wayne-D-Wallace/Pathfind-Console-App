using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder_Character_Sheets_Server.Models
{
    public class Skills
    {
        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public string SkillDescription { get; set; }
        public string SkillClass { get; set; }
        public int SkillRanks { get; set; }
        public int SkillModifier { get; set; }

    }
}
