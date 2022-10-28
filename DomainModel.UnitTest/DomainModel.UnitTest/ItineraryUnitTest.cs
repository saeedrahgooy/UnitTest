using DomainModel.UnitTest.Fake;
using DomainModelServiceContract.CustomExceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DomainModel.UnitTest
{
    [TestClass]
    public class ItineraryUnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(OriginArrivalAirportSameException))]
        public void Same_Orgin_Arrival_Airport_Must_Throws_Exception()
        {
            //Arrange
            var itenarary = new Itinerary(null,"IKA","IKA",DateTime.Now
                ,DateTime.Now.AddDays(60),"TEH",
                "TEH",1,1,1,1);

            //Act
            //Assert
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void InfantCount_Is_GreatherThan_Others_Passenger_Throws_Exception()
        {
            var itinerary = new Itinerary(null, "IKA", "LHR", DateTime.Now, DateTime.Now.AddDays(36)
                , "TEH", "LON", 4, 1, 0, 0);
        }
        [TestMethod]
        [ExpectedException(typeof(ForbiddenODException))]
        public void Search_Request_Between_Forbidden_Cities_Throws_ForbiddenODException()
        {
            //Arrange
            var repo = new FakeItineraryRepository();
            var itinerary = new Itinerary(repo, "IKA", "LHR", DateTime.Now, DateTime.Now.AddDays(36)
                , "TEH", "LON", 1, 1, 0, 0);
        }
    }
}
