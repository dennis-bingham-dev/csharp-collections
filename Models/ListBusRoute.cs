using System.Collections.Generic;

namespace collection_practice.Models
{
    public class ListBusRoute
    {
        public int Route { get; set; }

        public List<string> Stops { get; set;}
        public string Departure => Stops[0];
        public string Arrival => Stops[^1]; // ^1 same as Stops.Length - 1

        public ListBusRoute(int route, List<string> stops) {
            this.Route = route;
            this.Stops = stops;
        }

        public override string ToString() => $"{Route}: {Departure} -> {Arrival}";

        public bool Serves(string destination) => Stops.Exists(place => place == destination);
    }
}
