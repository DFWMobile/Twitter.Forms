using Newtonsoft.Json;

namespace App16.Models
{
    public class RandomUserResult
    {
        [JsonProperty("gender")]
        public string Gender { get; set; }
        [JsonProperty("name")]
        public RandomUserName Name { get; set; }
        [JsonProperty("location")]
        public Location Location { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("login")]
        public Login Login { get; set; }
        [JsonProperty("dob")]
        public DateOfBirth Dob { get; set; }
        [JsonProperty("registered")]
        public DateOfBirth Registered { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("cell")]
        public string Cell { get; set; }
        [JsonProperty("id")]
        public RandomUserId Id { get; set; }
        [JsonProperty("picture")]
        public Picture Picture { get; set; }
        [JsonProperty("nat")]
        public string Nat { get; set; }
    }

}