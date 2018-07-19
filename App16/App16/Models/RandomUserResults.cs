using System.Collections.Generic;
using Newtonsoft.Json;

namespace App16.Models
{
    public class RandomUserResults
    {
        [JsonProperty("results")]
        public List<RandomUserResult> Results { get; set; }
        [JsonProperty("info")]
        public RandomUserInfo Info { get; set; }
    }

}