using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModelServiceContract.CustomExceptions
{
    public class OriginArrivalAirportSameException : Exception
    {
        public OriginArrivalAirportSameException(string originAirportCode,string arrivalAirportCode):base(originAirportCode + "Airport is Same : "+arrivalAirportCode)
        {

        }
    }
}
