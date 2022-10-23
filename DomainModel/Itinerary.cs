using DomainModelServiceContract.CustomExceptions;
using DomainModelServiceContract.DomainService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Itinerary
    {
        public string OriginAirportCode { get; private set; }
        public string ArrivalAirportCode { get; private set; }
        public DateTime DepartureDate { get; private set; }
        public DateTime ArrivalDate { get; private set; }
        public string OriginCityCode { get; private set; }
        public string ArrivalCityCode { get; private set; }
        private readonly IItineraryDomainService _repo;
        public Itinerary(string originAirportCode, string arrivalAirportCode
            , DateTime departureDate, DateTime arrivalDate, string originCityCode
            , string arrivalCityCode, IItineraryDomainService repo)
        {
            if (originAirportCode == arrivalAirportCode)
            {
                throw new OriginArrivalAirportSameException(originAirportCode, arrivalAirportCode);
            }
            if (departureDate > arrivalDate)
            {
                throw new ODTimeException(departureDate, arrivalDate);
            }
            var forbiddenODS = repo.GetForbiddenODs();
            OriginAirportCode = originAirportCode;
            ArrivalAirportCode = arrivalAirportCode;
            DepartureDate = departureDate;
            ArrivalDate = arrivalDate;
            OriginCityCode = originCityCode;
            ArrivalCityCode = arrivalCityCode;
            _repo = repo;
        }
    }
}
