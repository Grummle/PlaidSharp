namespace Plaid
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    public class Plaid
    {
        public const string Adduser = "";
        private readonly string _clientId;
        private readonly string _key;
        private readonly HttpClient _client;
        public ConnectApi Connect { get; private set; }

        public Plaid(string clientId, string key, HttpClient client = null)
        {
            _client = client ?? new HttpClient();
            _clientId = clientId;
            _key = key;
            _client.BaseAddress = new Uri("https://tartan.plaid.com/");
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            Connect = new ConnectApi(_clientId, _key, _client);
        }

        public async Task<List<Institution>> GetInstitutionsTask()
        {
            var response = await _client.GetAsync("institutions");
            var result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Institution>>(result);
        }
        public async Task<List<Category>> GetCategoriesTask()
        {
            var response = await _client.GetAsync("categories");
            var result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Category>>(result);
        }
    }
}