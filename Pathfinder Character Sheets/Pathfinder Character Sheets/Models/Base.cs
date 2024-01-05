using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder_Character_Sheets_Server.Models
{
    public class Base
    {
        public int CharacterId { get; set; }
        public string PlayerName { get; set; }
        public string CharacterBackstory { get; set; }
        public int HitPoints { get; set; }
        public string CharacterName { get; set; }
        public string CharacterSize { get; set; }
        public int Level { get; set; }
        public string Race { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

    }
}
