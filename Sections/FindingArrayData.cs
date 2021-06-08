using System;
using collection_practice.Models;

namespace collection_practice.Sections
{
    public static class FindingArrayData
    {
        public static void SearchArray() {
            Models.FindingArrayDataBusRoute[] allRoutes = FindingArrayDataBusRouteRepository.InitializeRoute();

            Console.WriteLine("Where would you like to go?");
            string location = Console.ReadLine();

            Models.FindingArrayDataBusRoute[] routes = FindingArrayDataBusRouteRepository.FindBusesTo(allRoutes, location);

            if (routes.Length > 0)
                foreach (var route in routes)
                    Console.WriteLine($"You can use route {route}");
            else
                Console.WriteLine($"No routes go to {location}");
        }
    }
}
