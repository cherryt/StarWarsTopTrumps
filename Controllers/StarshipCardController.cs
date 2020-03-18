using Microsoft.AspNetCore.Mvc;
using StarWarsTopTrumps.Models;
using StarWarsTopTrumps.Services;
using System.Threading.Tasks;

namespace StarWarsTopTrumps.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StarshipCardController : ControllerBase
    {

        private readonly ICardGameService _cardGameService;

        public StarshipCardController(ICardGameService cardGameService)
        {
            _cardGameService = cardGameService;
        }

        [HttpGet]
        [Route("FirstCard")]
        public async Task<StarshipCard> GetFirstCard()
        {
            return await _cardGameService.GetFirstCard();
        }

        [HttpGet]
        [Route("NextCard")]
        public async Task<StarshipCard> GetNextCard()
        {
            return await _cardGameService.GetNextCard();
        }
    }
}
