using StarWarsTopTrumps.Models;
using System.Threading.Tasks;

namespace StarWarsTopTrumps.Services
{
    public interface IStarshipCardService
    {
        public Task<StarshipCard> GetCard(int id);
    }
}
