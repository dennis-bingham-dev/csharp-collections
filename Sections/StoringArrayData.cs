using System;

namespace collection_practice.Sections
{
    public static class StoringArrayData
    {
        public static void SettingArrayElements() {
            BusRoute route40 = new BusRoute(40, "Morecambe", "Preston");
            BusRoute route42 = new BusRoute(42, "Lancaster", "Blackpool");
            BusRoute[] routes = new BusRoute[4];

            routes[0] = route40;
            routes[1] = route42;
            routes[2] = new BusRoute(100, "University", "Morecambe");
            routes[3] = new BusRoute(555, "Lancaster", "Keswick");

            for (int i = 0; i < routes.Length; i++)
                Console.WriteLine($"{i}: {routes[i].Arrival}");

            foreach (var route in routes)
                Console.WriteLine(route.Arrival);
        }
    }

    public class BusRoute {
        public int Route { get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }

        public BusRoute(int route, string departure, string arrival) {
            this.Route = route;
            this.Departure = departure;
            this.Arrival = arrival;
        }
    }
}
