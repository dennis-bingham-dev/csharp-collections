using System;

namespace collection_practice.Models
{
    public class FindingArrayDataBusRouteRepository
    {
        public static FindingArrayDataBusRoute[] InitializeRoute() {
            return new FindingArrayDataBusRoute[] {
                new FindingArrayDataBusRoute(40, new string[] {"Morecambe", "Lancaster", "Garstang", "Preston"}),
                new FindingArrayDataBusRoute(42, new string[] {"Lancaster", "Garstang", "Blackpool"}),
                new FindingArrayDataBusRoute(100, new string[] {"University", "Lancaster", "Morecambe"}),
                new FindingArrayDataBusRoute(555, new string[] {"Lancaster", "Carnforth", "Kendal", "Windermere", "Keswick"})
            };
        }

        public static FindingArrayDataBusRoute[] FindBusesTo(FindingArrayDataBusRoute[] routes, string location) => Array.FindAll(routes, route => route.Serves(location));
    }
}
