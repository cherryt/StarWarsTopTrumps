using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using StarWarsTopTrumps.Services;

namespace StarWarsTopTrumps.Tests.Services
{
    [TestClass]
    public class StarshipCardServiceTest
    {

        public StarshipCardService starshipCardService = new StarshipCardService(new Mock<IConfiguration>().Object);

        public async void TestGetCardGivenCardIdReturnStarshipCard()
        {
            var cardId = 1;
            var result = await starshipCardService.GetCard(cardId);

            StringAssert.Equals(result.Name , "testname");
        }
    }
}
