using BackPrueba.Infrastructure.Dtos;

namespace BackPrueba.Infrastructure.Services.Interfaces
{
    public interface IJourneyService
    {
        public Task<List<JourneyDto>> GetData(string apiUrl);

    }
}
