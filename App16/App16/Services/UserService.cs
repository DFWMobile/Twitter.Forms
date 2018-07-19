using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using App16.Models;
using Newtonsoft.Json;

namespace App16.Services
{
    public class UserService
    {
        public async Task<List<RandomUserResult>> GetUsersAsync(int count)
        {
            var httpClient = new HttpClient();

            var response = await httpClient.GetAsync($"https://randomuser.me/api/?results={count}&seed=dfwmobilenet");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();

                var results = JsonConvert.DeserializeObject<RandomUserResults>(json);

                return results.Results;
            }

            throw new Exception("You failed!");
        }
    }
}