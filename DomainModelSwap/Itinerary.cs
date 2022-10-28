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
        public int InfantCount { get; set; }
        public int Child { get; set; }
        public int AdultCount { get; set; }
        public int SeniorCitizenCount { get; set; }
        private readonly IItineraryDomainService _repo;
        public Itinerary(IItineraryDomainService repo, string originAirportCode
            , string arrivalAirportCode
            , DateTime departureDate, DateTime arrivalDate, string originCityCode
            , string arrivalCityCode, int infantCount,int seniorCitizenCount,
            int adultCount,int child)
        {
            if (originAirportCode == arrivalAirportCode)
            {
                throw new OriginArrivalAirportSameException(originAirportCode, arrivalAirportCode);
            }
            if (departureDate > arrivalDate)
            {
                throw new ODTimeException(departureDate, arrivalDate);
            }
            if (infantCount > seniorCitizenCount + adultCount + child)
            {
                throw new Exception("Too Many Infant");
            }
            if (infantCount + seniorCitizenCount + adultCount + child > 9)
            {
                throw new Exception("Too Many Passenger");
            }
            //Forbidden AirportList
            var forbiddenODS = repo.GetForbiddenODs();

            if(forbiddenODS.Any(x=>x.ArrivalAirportCode == arrivalAirportCode 
            && x.OriginAirportCode == originAirportCode) || 
            forbiddenODS.Any(x => x.ArrivalAirportCode == originAirportCode
            && x.OriginAirportCode == arrivalAirportCode))
            {
                throw new ForbiddenODException(originAirportCode,arrivalAirportCode);
            }
            
            OriginAirportCode = originAirportCode;
            ArrivalAirportCode = arrivalAirportCode;
            DepartureDate = departureDate;
            ArrivalDate = arrivalDate;
            OriginCityCode = originCityCode;
            ArrivalCityCode = arrivalCityCode;
            InfantCount = infantCount;
            AdultCount = adultCount;
            SeniorCitizenCount = seniorCitizenCount;
            Child = child;
            _repo = repo;
        }
    }
}
