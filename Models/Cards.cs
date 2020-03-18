using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StarWarsTopTrumps.Models
{
    public class Cards
    {
        public List<int> ids;

        public Cards(string json)
        {
            ids = new List<int>();
            JObject jObject = JObject.Parse(json);
            foreach (var jStarship in jObject["results"])
            {
                int id = Int16.Parse(jStarship["url"].ToString().Split("/")[5]);
                ids.Add(id);
            }

        }
    }
}
