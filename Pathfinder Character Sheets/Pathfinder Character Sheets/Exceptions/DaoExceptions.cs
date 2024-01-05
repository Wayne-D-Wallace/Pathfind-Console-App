using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder_Character_Sheets_Server.Exceptions
{
    public class DaoException : Exception
    {
        public DaoException() : base() { }
        public DaoException(string message) : base(message) { }
        public DaoException(string message, Exception inner) : base(message, inner) { }
    }

}
