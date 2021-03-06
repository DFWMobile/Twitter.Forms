﻿using Newtonsoft.Json;

namespace App16.Models
{
    public class RandomUserInfo
    {
        [JsonProperty("seed")]
        public string Seed { get; set; }
        [JsonProperty("results")]
        public int Results { get; set; }
        [JsonProperty("page")]
        public int Page { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
    }

}