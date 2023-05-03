using BackPrueba.Infrastructure.Data;

namespace BackPrueba.Infrastructure.Dtos
{
    public class FlightDto
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public decimal Price { get; set; }
        public TransportDto Transport { get; set; }

        public FlightDto(JourneyModel journeyModel)
        {
            Origin = journeyModel.DepartureStation;
            Destination = journeyModel.ArrivalStation;
            Price = journeyModel.Price;

            Transport = new TransportDto(journeyModel.FlightCarrier, journeyModel.FlightNumber);
        }

    }
}
