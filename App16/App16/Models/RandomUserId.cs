using Newtonsoft.Json;

namespace App16.Models
{
    public class RandomUserId
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
    }

}