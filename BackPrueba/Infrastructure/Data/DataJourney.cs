using BackPrueba.Infrastructure.Dtos;
using BackPrueba.Infrastructure.Services.Interfaces;
using System;

namespace BackPrueba.Infrastructure.Data
{
    public class DataJourney
    {
        private readonly IJourneyService _journeyService;
        private readonly string URL_Api;
        private List<JourneyDto> Flights;

        public DataJourney(IJourneyService journeyService, IConfiguration configuration) 
        {
            _journeyService = journeyService;
            URL_Api = configuration.GetValue<string>("API_URL");
        }

        public async Task<List<JourneyDto>> GetData() 
        {
            if (Flights == null) 
                Flights = await _journeyService.GetData(URL_Api);

            return Flights;
        }
    }
}
