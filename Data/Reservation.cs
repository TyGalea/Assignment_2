using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2.Data
{
    internal class Reservation
    {
        public string reservationCode { get; set; }
        public string flightCode { get; set; }
        public string airline { get; set; }
        public string day { get; set; }
        public string time { get; set; }
        public double cost { get; set; }
        public string name { get; set; }
        public string citizenship { get; set; }
        public string status { get; set; } = "Inactive";

        public Reservation() { }

        public Reservation(string reservationCode, string flightCode, string airline, string day, string time, double cost, string name, string citizenship)
        {
            this.reservationCode = reservationCode;
            this.flightCode = flightCode;
            this.airline = airline;
            this.day = day;
            this.time = time;
            this.cost = cost;
            this.name = name;
            this.citizenship = citizenship;
        }

        /// <summary>
        /// Displays Reservation as a string
        /// </summary>
        public override string ToString()
        {
            return reservationCode + ", " + flightCode + ", " + airline + ", " + day + ", " + time + ", " + cost + ", " + name + ", " + citizenship + ", " + status;
        }
    }
}