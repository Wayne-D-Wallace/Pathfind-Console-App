using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pathfinder_Character_Sheets_Server.Models;

namespace Pathfinder_Character_Sheets_Server.DAO
{
    public interface ISkillsDAO
    {
        Skills GetSkillsById (int id);
        List <Skills> GetSkillsByCharacterId (int characterId);
        List<Skills> GetAllSkills();

    }
}
