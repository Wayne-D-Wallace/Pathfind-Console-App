using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pathfinder_Character_Sheets_Server.Models;
using Pathfinder_Character_Sheets_Server.Exceptions;


namespace Pathfinder_Character_Sheets_Server.DAO
{
    internal class BaseDAO : IBaseDAO
    {
        public Base CreateCharacter(Base character)
        {
            throw new NotImplementedException();
        }

        public Base FindCharacterById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Base> FindCharacterByPlayer(string playerName)
        {
            throw new NotImplementedException();
        }

        public List<Base> GetAllCharacters()
        {
            throw new NotImplementedException();
        }

        public Base RemoveCharacterById(int id)
        {
            throw new NotImplementedException();
        }

        public Base UpdateCharacter(Base character)
        {
            throw new NotImplementedException();
        }
    }
}
