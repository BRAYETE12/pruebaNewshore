﻿using BackPrueba.Infrastructure.Data;
using BackPrueba.Infrastructure.Dtos;
using BackPrueba.Infrastructure.Managers.Interfaces;
using BackPrueba.Infrastructure.Repositories.Interfaces;

namespace BackPrueba.Infrastructure.Managers
{
    public class JourneyManager : IJourneyManager
    {
        private readonly IJourneyRepository _journeyRepositoty;
        private readonly int NumberMaxJourney;

        public JourneyManager(IJourneyRepository journeyRepositoty, IConfiguration configuration) 
        {
            _journeyRepositoty = journeyRepositoty;
            NumberMaxJourney = configuration.GetValue<int>("MAX_JOURNEY");
        }

        public async Task<Response> Search(JourneySearchDto journeyDto) 
        {
            Response response = new Response();

            List<JourneyModel> flights = await _journeyRepositoty.FindFlights(journeyDto.Origin, journeyDto.Destination);

            if (flights == null)  return notFound(response); 

            if (flights.Count > NumberMaxJourney) return notFound(response, true);

            JourneyDto journey = new JourneyDto() { Origin = journeyDto.Origin, Destination = journeyDto.Destination };
            journey.Flights = flights.Select(x => new FlightDto(x) ).ToList();
            journey.Price = journey.Flights.Sum(x => x.Price);

            response.Object = journey;

            return response;
        }


        public static Response notFound(Response response, bool exceeded = false) 
        {
            response.StatusCode = StatusCodes.Status404NotFound;
            response.Message = !exceeded ? "The inquiry cannot be processed" : "The number of flights exceeded";
        
            return response;
        }
    }
}
