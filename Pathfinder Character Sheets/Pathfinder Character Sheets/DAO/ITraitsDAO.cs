using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pathfinder_Character_Sheets_Server.Models;

namespace Pathfinder_Character_Sheets_Server.DAO
{
    public interface ITraitsDAO
    {
        Traits GetTraits(int id);
        List<Traits> GetTraitsList(int CharacterId);
        List<Traits> GetAllTraits();
        Traits AddTraits(Traits traits);
        Traits RemoveTraits(Traits traits);

    }
}
