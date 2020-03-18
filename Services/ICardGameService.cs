using StarWarsTopTrumps.Models;
using System.Threading.Tasks;

namespace StarWarsTopTrumps.Services
{
    public interface ICardGameService
    {
        public Task<StarshipCard> GetFirstCard();
        public Task<StarshipCard> GetNextCard();

    }
}
