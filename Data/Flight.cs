using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2.Data
{
    internal class Flight
    {
        public string flightCode { get; set; }
        public string airline { get; set; }
        public string dept { get; set; }
        public string dest { get; set; }
        public string day { get; set; }
        public string time { get; set; }
        public int seats { get; set; }
        public double cost { get; set; }

        public Flight() { }

        public Flight(string flightCode, string airline, string dept, string dest, string day, string time, int seats, double cost)
        {
            this.flightCode = flightCode;
            this.airline = airline;
            this.dept = dept;
            this.dest = dest;
            this.day = day;
            this.time = time;
            this.seats = seats;
            this.cost = cost;
        }

        /// <summary>
        /// Displays Flight as a string
        /// </summary>
        public override string ToString()
        {
            return flightCode + ", " + airline + ", " + dept + ", " + dest + ", " + day + ", " + time + ", " + seats + ", " + cost;
        }
    }
}
