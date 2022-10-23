using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModelServiceContract.CustomExceptions
{
    public class ODTimeException : Exception
    {
        public ODTimeException(DateTime departureDate,DateTime arrivalDate):base(departureDate.ToShortDateString()+" Is Greater than "+arrivalDate.ToShortDateString())
        {

        }
    }
}
