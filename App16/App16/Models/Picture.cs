using Newtonsoft.Json;

namespace App16.Models
{
    public class Picture
    {
        [JsonProperty("large")]
        public string Large { get; set; }
        [JsonProperty("medium")]
        public string Medium { get; set; }
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }
    }

}