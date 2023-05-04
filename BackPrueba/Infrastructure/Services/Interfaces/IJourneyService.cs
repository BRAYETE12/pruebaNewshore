using BackPrueba.Infrastructure.Data;

namespace BackPrueba.Infrastructure.Services.Interfaces
{
    public interface IJourneyService
    {
        public Task<List<JourneyModel>> GetData(string apiUrl);

    }
}
