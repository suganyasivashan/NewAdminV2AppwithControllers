using NewAdminV2App.Shared;
using NewAdminV2App.Shared.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace NewAdminV2App.Client.HttpRepo
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient _client;

        public HttpService(HttpClient client)
        {
            _client = client;
        }
        public async Task<int> Count(string search)
        {
            return await _client.GetFromJsonAsync<int>("search");
        }
        public async Task<IEnumerable<School>> GetSchoolENV1(int skip, int take, string orderBy, string direction, string search)
        {
            return await _client.GetFromJsonAsync<IEnumerable<School>>("SchoolENV1");
        }
       
        public async Task<IEnumerable<School>> GetSchoolENV2(int skip, int take, string orderBy, string direction, string search)
        {
            return await _client.GetFromJsonAsync<IEnumerable<School>>("SchoolENV2");
        }
    }
}