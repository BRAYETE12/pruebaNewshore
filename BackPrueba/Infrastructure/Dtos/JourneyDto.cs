namespace BackPrueba.Infrastructure.Dtos
{
    public class JourneyDto
    {
        public string DepartureStation { get; set; }
        public string ArrivalStation { get; set; }
        public string FlightCarrier { get; set; }
        public string FlightNumber { get; set; }
        public Decimal Price { get; set; }
    }
}
