using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using StarWarsTopTrumps.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace StarWarsTopTrumps.Services
{
    public class CardGameService : ICardGameService
    {
        private readonly IConfiguration _config;
        private readonly IStarshipCardService _starshipCardService;
        private static Cards _cards= null;

        private static readonly HttpClient client = new HttpClient();

        public CardGameService(IConfiguration config, IStarshipCardService starshipCardService)
        {
            _config = config;
            _starshipCardService = starshipCardService;
        }
        private async Task<Cards> GetCards()
        {
            var response = await client.GetAsync(_config.GetValue<String>("SwapiUrl"));
            return new Cards(await response.Content.ReadAsStringAsync());
        }

        public async Task<StarshipCard> GetFirstCard()
        {
            _cards = await GetCards();
            return await GetNextCard();
        }

        public async Task<StarshipCard> GetNextCard()
        {
            var randomNumber = (new Random()).Next(0, _cards.ids.Count - 1);
            var result = await _starshipCardService.GetCard(_cards.ids[randomNumber]);
            _cards.ids.RemoveAt(randomNumber);
            return result;
        }

    }
}
