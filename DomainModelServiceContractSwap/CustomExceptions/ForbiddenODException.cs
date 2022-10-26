using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModelServiceContract.CustomExceptions
{
    public class ForbiddenODException : Exception
    {
        public ForbiddenODException(string o, string d):base("Ticketting between "+ o + " And "+d+" is Forbidden")
        {

        }
    }
}
