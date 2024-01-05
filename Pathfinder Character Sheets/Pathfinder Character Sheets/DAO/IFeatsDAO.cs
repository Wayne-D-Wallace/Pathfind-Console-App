using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pathfinder_Character_Sheets_Server.Models;

namespace Pathfinder_Character_Sheets_Server.DAO
{
    public interface IFeatsDAO
    {
        Feats GetFeatsById (int id);
        List<Feats> GetAllFeats ();
        Feats AddFeats (Feats feats);   
        Feats RemoveFeats (int id);

    }
}
