using System;
using System.Collections.Generic;
using collection_practice.Models;

namespace collection_practice.Sections
{
    public static class DataWithLists
    {
        public static void SearchList() {
            List<ListBusRoute> allRoutes = ListBusRouteRepository.InitializeRoute();
            allRoutes.RemoveAll(route => route.Departure.StartsWith("Test "));

            Console.WriteLine("Where would you like to go?");
            string location = Console.ReadLine();

            List<ListBusRoute> routes = ListBusRouteRepository.FindBusesTo(allRoutes, location);

            if (routes.Count > 0)
                foreach (var route in routes)
                    Console.WriteLine($"You can use route {route}");
            else
                Console.WriteLine($"No routes go to {location}");
        }
    }
}
