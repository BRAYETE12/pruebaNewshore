using BackPrueba.Infrastructure.Dtos;

namespace BackPrueba.Infrastructure.Repositories.Interfaces
{
    public interface IJourneyRepository
    {
        public Task<List<JourneyDto>> FindFlights(string Origin, string Destination);
    }
}
