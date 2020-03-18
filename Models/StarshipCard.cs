using Newtonsoft.Json.Linq;
using System;
using System.Linq;

namespace StarWarsTopTrumps.Models
{
    public class StarshipCard
    {
        public String Name { get; set; }
        public String MaxSpeed { get; set; }
        public String CostInCredits { get; set; }
        public int? NumberOfPassengers { get; set; }
        public int NumberOfFilms { get; set; }
        public String Url { get; set; }

        public StarshipCard(string json)
        {
            JObject jStarship = JObject.Parse(json);
            Name = (String) jStarship["name"];
            MaxSpeed = (String) jStarship["max_atmosphering_speed"];
            CostInCredits = (String) jStarship["cost_in_credits"];
            NumberOfPassengers = (int?) jStarship["passengers"];
            NumberOfFilms = jStarship["films"].Count();
            Url = (String) jStarship["url"];
        }
    }
}
