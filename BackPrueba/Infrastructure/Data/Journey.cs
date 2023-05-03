namespace BackPrueba.Infrastructure.Data
{
    public class Journey
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public Decimal Price { get; set; }
        public List<Flight> Flights { get; set; }
    }
}
