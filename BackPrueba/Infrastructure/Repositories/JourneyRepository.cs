using BackPrueba.Infrastructure.Data;
using BackPrueba.Infrastructure.Dtos;
using BackPrueba.Infrastructure.Repositories.Interfaces;

namespace BackPrueba.Infrastructure.Repositories
{
    public class JourneyRepository : IJourneyRepository
    {
        private readonly DataJourney _dataJourney;

        public JourneyRepository(DataJourney dataJourney) 
        {
            _dataJourney = dataJourney;
        }

        public async Task<List<JourneyDto>> FindFlights(string Origin, string Destination)
        {
            var flights = await _dataJourney.GetData();

            var graph = BuildGraph(flights);
            var visited = new HashSet<string>();
            var flightsPath = new List<JourneyDto>();
            var found = DFS(Origin, Destination, visited, graph, flightsPath);

            if (!found) return null;

            return flightsPath;
        }

        private bool DFS(string current, string Destination, HashSet<string> visited, Dictionary<string, List<JourneyDto>> graph, List<JourneyDto> flightsPath)
        {
            visited.Add(current);

            if (current == Destination) return true;

            if (!graph.ContainsKey(current))  return false;

            foreach (var flight in graph[current])
            {
                if (!visited.Contains(flight.ArrivalStation))
                {
                    flightsPath.Add(flight);

                    if (DFS(flight.ArrivalStation, Destination, visited, graph, flightsPath)) return true;

                    flightsPath.RemoveAt(flightsPath.Count - 1);
                }
            }

            return false;
        }

        private Dictionary<string, List<JourneyDto>> BuildGraph(List<JourneyDto> flights)
        {
            var graph = new Dictionary<string, List<JourneyDto>>();

            foreach (var flight in flights)
            {
                if (!graph.ContainsKey(flight.DepartureStation))
                {
                    graph[flight.DepartureStation] = new List<JourneyDto>();
                }

                graph[flight.DepartureStation].Add(flight);
            }

            return graph;
        }

    }
}
