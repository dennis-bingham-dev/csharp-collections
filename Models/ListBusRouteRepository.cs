using System.Collections.Generic;

namespace collection_practice.Models
{
    public class ListBusRouteRepository
    {
        public static List<ListBusRoute> InitializeRoute() => new List<ListBusRoute> {
                new ListBusRoute(40, new List<string>() {"Morecambe", "Lancaster", "Garstang", "Preston"}),
                new ListBusRoute(42, new List<string>() {"Lancaster", "Garstang", "Blackpool"}),
                new ListBusRoute(1_000, new List<string>() {"Test origin", "Test destination"}),
                new ListBusRoute(100, new List<string>() {"University", "Lancaster", "Morecambe"}),
                new ListBusRoute(555, new List<string>() {"Lancaster", "Carnforth", "Kendal", "Windermere", "Keswick"})
            };

        public static List<ListBusRoute> FindBusesTo(List<ListBusRoute> routes, string location) => routes.FindAll(route => route.Serves(location));
    }
}
