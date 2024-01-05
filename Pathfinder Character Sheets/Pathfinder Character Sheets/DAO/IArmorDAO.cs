using Pathfinder_Character_Sheets_Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder_Character_Sheets_Server.DAO
{
    public interface IArmorDAO
    {
        Armor FindArmorById(int id);
        List<Armor> GetAllArmors();
        List<Armor> GetArmors(int characterId);
        Armor AddArmor (Armor armor);
        Armor UpdateArmor (Armor armor);
        Armor DeleteArmor (int id);

    }
}
