namespace Plaid
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    public class ConnectApi
    {
        private readonly string _clientId;
        private readonly string _key;
        private readonly HttpClient _client;

        public ConnectApi(string clientId, string key, HttpClient client)
        {
            this._clientId = clientId;
            this._key = key;
            this._client = client;
        }

        public async Task<AddUserResponse> AddUser(string username, string password, string institution)
        {
            var request = new AddUserRequest { client_id = this._clientId, secret = this._key, username = username, password = password, type=institution};
            request.options.Add("list",true);
            HttpResponseMessage response = await this._client.PostAsync("connect", new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json"));
            var result = await response.Content.ReadAsStringAsync();
            Console.Write(result);
            var value = JsonConvert.DeserializeObject<AddUserResponse>(result);
            value.MfaRequired = response.StatusCode == HttpStatusCode.Created;
            return value;
        }
    }
}