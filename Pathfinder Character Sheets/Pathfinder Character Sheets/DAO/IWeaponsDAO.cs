using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pathfinder_Character_Sheets_Server.Models;

namespace Pathfinder_Character_Sheets_Server.DAO
{
    public interface IWeaponsDAO
    {
        Weapons FindWeaponsById(int id);
        List<Weapons> GetAllWeapons();
        List<Weapons> GetWeapons(int characterId);
        Weapons AddWeapons(Weapons weapons);
        Weapons UpdateWeapons(Weapons weapons);
        Weapons DeleteWeapons(int id);
    }
}
