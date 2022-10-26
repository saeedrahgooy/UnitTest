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
        public void Same_Orgin_Arrival_Airport_Must_Throws_Exceptions()
        {
            //Arrange
            var itenarary = new Itinerary(null,"IKA","IKA",DateTime.Now
                ,DateTime.Now.AddDays(60),"TEH",
                "TEH",1,1,1,1);

            //Act
            //Assert
        }
    }
}
