namespace InfinityWorks.TechTest.Client
{
    using System.Net.Http;
    using System.Threading.Tasks;
    using InfinityWorks.TechTest.Client.Model;
    using System.Text.Json;

    public class FsaClient : IFsaClient
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public FsaClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<FsaAuthorityList> GetAuthorities()
        {
            return await GetFsaResource<FsaAuthorityList>("Authorities");
        }

        public async Task<FsaEstablishmentList> GetEstablishmentByAuthority(int localAuthorityId, int pageSize = 10000)
        {
            return await GetFsaResource<FsaEstablishmentList>($"Establishments?localAuthorityId={localAuthorityId}&pageSize={pageSize}");
        }

        private async Task<T> GetFsaResource<T>(string path)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("x-api-version", "2");

            var stream = await client.GetStreamAsync($"https://api.ratings.food.gov.uk/{path}");
            return await JsonSerializer.DeserializeAsync<T>(stream);
        }
    }
}
