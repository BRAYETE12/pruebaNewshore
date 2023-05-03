using BackPrueba.Infrastructure.Dtos;
using BackPrueba.Infrastructure.Services.Interfaces;
using Newtonsoft.Json;

namespace BackPrueba.Infrastructure.Services
{
    public class JourneyService : IJourneyService
    {

        private readonly HttpClient httpClient;

        public JourneyService() 
        {
            httpClient = new HttpClient();
        }


        public async Task<List<JourneyDto>> GetData(string apiUrl)
        {
            HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
            response.EnsureSuccessStatusCode();

            string responseContent = await response.Content.ReadAsStringAsync();

            List<JourneyDto> list = JsonConvert.DeserializeObject<List<JourneyDto>>(responseContent);

            return list;
        }

    }
}
