using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModelServiceContract.DTO
{
    public class ForbiddenOD
    {
        public string OriginAirportCode { get; set; }
        public string ArrivalAirportCode { get; set; }
        public string OriginCityCode { get; set; }
        public string ArrivalCityCode { get; set; }
    }
}
