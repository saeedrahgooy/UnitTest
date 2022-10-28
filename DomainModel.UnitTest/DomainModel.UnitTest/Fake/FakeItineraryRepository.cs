using DomainModelServiceContract.DomainService;
using DomainModelServiceContract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.UnitTest.Fake
{
    public class FakeItineraryRepository : IItineraryDomainService
    {
        public List<ForbiddenOD> GetForbiddenODs()
        {
            var forbiddenODS = new List<ForbiddenOD>();
            forbiddenODS.Add(new ForbiddenOD
            {
                OriginAirportCode = "IKA",
                ArrivalAirportCode = "LHR",
                ArrivalCityCode = "LON",
                OriginCityCode = "TEH",
            });
            //forbiddenODS.Add(new ForbiddenOD
            //{
            //    OriginAirportCode = "IKA",
            //    ArrivalAirportCode = "FRA",
            //    ArrivalCityCode = "FRN",
            //    OriginCityCode = "TEH",
            //});
            return forbiddenODS;
        }
    }
}
