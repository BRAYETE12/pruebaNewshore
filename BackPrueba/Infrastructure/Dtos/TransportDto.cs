namespace BackPrueba.Infrastructure.Dtos
{
    public class TransportDto
    {
        public string FlightCarrier { get; set; }
        public string FlightNumber { get; set; }

        public TransportDto(string flightCarrier, string flightNumber)
        {
            FlightCarrier = flightCarrier;
            FlightNumber = flightNumber;
        }
    }
}
