using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pathfinder_Character_Sheets_Server.Models;

namespace Pathfinder_Character_Sheets_Server.DAO
{
    public interface IBaseDAO
    {
        Base FindCharacterById (int id);
        List<Base> FindCharacterByPlayer (string playerName);
        List<Base> GetAllCharacters();
        Base CreateCharacter (Base character);
        Base UpdateCharacter (Base character);
        Base RemoveCharacterById (int id);


    }
}
