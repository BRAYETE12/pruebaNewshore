using BackPrueba.Infrastructure.Data;

namespace BackPrueba.Infrastructure.Repositories.Interfaces
{
    public interface IJourneyRepository
    {
        public Task<List<JourneyModel>> FindFlights(string Origin, string Destination);
    }
}
