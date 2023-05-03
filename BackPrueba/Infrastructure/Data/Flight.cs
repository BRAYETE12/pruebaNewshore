using BackPrueba.Infrastructure.Dtos;

namespace BackPrueba.Infrastructure.Data
{
    public class Flight
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public Decimal Price { get; set; }
        public Transport Transport { get; set; }

        public Flight(JourneyDto journeyDto)
        {
            Origin = journeyDto.DepartureStation;
            Destination = journeyDto.ArrivalStation;
            Price = journeyDto.Price;

            Transport = new Transport(journeyDto.FlightCarrier, journeyDto.FlightNumber);
        }

    }
}
