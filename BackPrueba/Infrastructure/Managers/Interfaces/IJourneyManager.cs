using BackPrueba.Infrastructure.Dtos;

namespace BackPrueba.Infrastructure.Managers.Interfaces
{
    public interface IJourneyManager
    {
        public Task<Response> Search(JourneySearchDto journeyDto);
    }
}
