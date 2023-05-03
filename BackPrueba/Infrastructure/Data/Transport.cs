namespace BackPrueba.Infrastructure.Data
{
    public class Transport
    {
        public string FlightCarrier { get; set; }
        public string FlightNumber { get; set; }

        public Transport(string flightCarrier, string flightNumber)
        {
            FlightCarrier = flightCarrier;
            FlightNumber = flightNumber;
        }
    }
}
