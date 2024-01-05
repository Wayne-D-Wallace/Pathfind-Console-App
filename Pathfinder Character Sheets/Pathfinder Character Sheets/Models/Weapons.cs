using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder_Character_Sheets_Server.Models
{
    public class Weapons
    {
        public int WeaponId { get; set; }
        public string WeaponSize { get; set; }
        public string WeaponName { get; set; }
        public bool IsMelee { get; set; }
        public bool IsRanged { get; set; }
        public bool IsPiercing { get; set; }
        public bool IsSlashing { get; set; }
        public bool IsBludgeoning { get; set; }
        public bool IsMagical { get; set; }
        public bool IsMasterwork { get; set; }
        public int MagicalModifier { get; set; }
        public string WeaponDamage { get; set; }

    }
}
