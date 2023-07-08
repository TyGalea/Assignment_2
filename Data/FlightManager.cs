using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2.Data
{
    internal class FlightManager
    {
        private const string FILE_PATH = @"C:\Users\tygal\Documents\SAIT\Spring 2023\CPRG 211D\Assignment_2\Resources\Files\flights.csv";
        public static List<Flight> flights = new List<Flight>();
        public FlightManager()
        {
            flights = new List<Flight>();
            populateFlights();
        }

        /// <summary>
        /// Populates a list of flights from
        /// the flights.csv file
        /// </summary>
        private void populateFlights()
        {
            Flight flight;

            foreach (string line in System.IO.File.ReadLines(FILE_PATH))
            {
                string[] parts = line.Split(",");

                string flightCode = parts[0];
                string airline = parts[1];
                string dept = parts[2];
                string dest = parts[3];
                string day = parts[4];
                string time = parts[5];
                int seats = int.Parse(parts[6]);
                double cost = double.Parse(parts[7]);

                flight = new Flight(flightCode, airline, dept, dest, day, time, seats, cost);
                flights.Add(flight);
            }
        }

        /// <summary>
        /// Returns the flight list
        /// </summary>
        public static List<Flight> GetFlights()
        {
            return flights;
        }
    }
}
