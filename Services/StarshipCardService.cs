using Microsoft.Extensions.Configuration;
using StarWarsTopTrumps.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace StarWarsTopTrumps.Services
{
    public class StarshipCardService : IStarshipCardService
    {
        private readonly IConfiguration _config;
        private static readonly HttpClient client = new HttpClient();

        public StarshipCardService(IConfiguration config)
        {
            _config = config;
        }

        public async Task<StarshipCard> GetCard(int id)
        {
            var url = $"{_config.GetValue<String>("SwapiUrl")}/{id}";
            var response = await client.GetAsync(url);
            return new StarshipCard(await response.Content.ReadAsStringAsync());
        }
    }
}
