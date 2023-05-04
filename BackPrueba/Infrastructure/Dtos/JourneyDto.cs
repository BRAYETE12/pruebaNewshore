namespace BackPrueba.Infrastructure.Dtos
{
    public class JourneyDto
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public decimal Price { get; set; }
        public List<FlightDto> Flights { get; set; }
    }
}
