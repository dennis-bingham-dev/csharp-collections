using System;

namespace collection_practice.Models
{
    public class FindingArrayDataBusRoute
    {
        public int Route { get; set; }

        public string[] Stops { get; set;}
        public string Departure => Stops[0];
        public string Arrival => Stops[^1]; // ^1 same as Stops.Length - 1

        public FindingArrayDataBusRoute(int route, string[] stops) {
            this.Route = route;
            this.Stops = stops;
        }

        public override string ToString() => $"{Route}: {Departure} -> {Arrival}";

        public bool Serves(string destination) => Array.Exists(Stops, place => place == destination);
    }
}
