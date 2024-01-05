using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pathfinder_Character_Sheets_Server.Models;

namespace Pathfinder_Character_Sheets_Server.DAO
{
    public interface ISpecialAbilities
    {
        SpecialAbilities GetSpecialAbilitiesById(int id);
        List<SpecialAbilities> GetAllSpecialAbilities();
        List<SpecialAbilities> GetSpecialAbilitiesByCharacterId(int characterId);
        SpecialAbilities AddSpecialAbility(SpecialAbilities specialAbilities);
        SpecialAbilities RemoveSpecialAbilityById(int id);

    }
}
