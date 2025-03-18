using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Flight> flgts = new List<Flight>();
            flgts.Add(new Flight
            {
                FlightNumber = "1",
                DepartureCity = "Kolkata",
                ArrivalCity = "Kochi",
                DepartureTime = DateTime.Parse("2024-1-17 08:00"),
                ArrivalTime = DateTime.Parse("2024-1-17 12:00")
            });
            flgts.Add(new Flight
            {
                FlightNumber = "2",
                DepartureCity = "Hyderabad",
                ArrivalCity = "Kolkata",
                DepartureTime = DateTime.Parse("2024-1-19 10:00"),
                ArrivalTime = DateTime.Parse("2024-1-19 12:00")
            });
            flgts.Add(new Flight
            {
                FlightNumber = "4",
                DepartureCity = "Chennai",
                ArrivalCity = "Kolkata",
                DepartureTime = DateTime.Parse("2024-1-20 09:00"),
                ArrivalTime = DateTime.Parse("2024-1-20 13:00")
            });

            Console.WriteLine("Flight information system");
            while (true)
            {
                Console.WriteLine("\n1. List all flights");
                Console.WriteLine("\n2. Search for flights");
                Console.WriteLine("\n3. Exit");
                Console.Write("\nEnter your choice");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            ListAllFLights(flgts); break;
                        case 2:
                            SearchFlights(flgts); break;
                        case 3:
                            Console.WriteLine("Thanks for using our app");
                            return;
                        default:
                            Console.WriteLine("Choose correct options");
                            break;
                    }
                }
            }
        }
        static void ListAllFLights(List<Flight> flights) 
        {
            Console.WriteLine("\nAll flights: ");
            flights.ForEach(flight => Console.WriteLine(flight));
        }
        static void SearchFlights(List<Flight> flights) {
            Console.Write("Enter the departure city: ");
            string departureCity=Console.ReadLine();
            Console.Write("Enter the arrival city: ");
            string arrivalCity = Console.ReadLine();

            var matchingFlights=flights.Where(flight => (flight.DepartureCity.ToLower()==departureCity.ToLower() && 
            flight.ArrivalCity.ToLower() == arrivalCity.ToLower())).ToList();

            Console.WriteLine(matchingFlights.Any() ?
                "\nMatching flights:\n" + string.Join("\n", matchingFlights) :
                "No matching flights found");


        }
    }
}
