using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Assignment_2.Data
{
    internal class ReservationManager
    {
        private const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static List<Reservation> reservations = new List<Reservation>();
        public ReservationManager()
        {
            reservations = new List<Reservation>();
            populateReservations();
        }

        /// <summary>
        /// Populates a list of reservations from
        /// the reservation.json file. Removes 
        /// active reservations.
        /// </summary>
        private void populateReservations()
        {
            var path = Path.Combine(FileSystem.AppDataDirectory, "reservation.json");
            if (!File.Exists(path))
                return;
            var contents = File.ReadAllText(path);
            var savedItems = JsonSerializer.Deserialize<List<Reservation>>(contents);
            reservations.AddRange(savedItems);
            for (int i = 0; i < reservations.Count; i++)
            {
                if (reservations[i].status == "active")
                {
                    reservations.RemoveAt(i);
                }
            }
        }

        /// <summary>
        /// Returns the reservation list
        /// </summary>
        public static List<Reservation> GetReservation()
        {
            return reservations;
        }

        /// <summary>
        /// Returns a string that starts with 
        /// one number followed by four letters
        /// </summary>
        public string generateCode()
        {
            Random rnd = new Random();
            string code = "";
            code += letters[rnd.Next(0, letters.Length)];
            for(int i = 0; i < 4; i++)
            {
                code += rnd.Next(0, 10);
            }
            return code;
        }
    }
}
