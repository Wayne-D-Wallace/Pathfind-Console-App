using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pathfinder_Character_Sheets_Server.Models;

namespace Pathfinder_Character_Sheets_Server.DAO
{
    public interface ISpellsDAO
    {
        Spells GetSpellById(int spellId);
        List<Spells> GetAllSpells();
        List<Spells> GetSpellsByCharacterId(int characterId);
        Spells AddSpells(Spells spell);
        Spells UpdateSpells(Spells spell);
        Spells RemoveSpell(int spellId);
    }
}
