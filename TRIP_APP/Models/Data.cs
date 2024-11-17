using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRIP_APP.Models
{
    internal class Data
    {
        public static Trip Trip { get; set; }


        public void SaveTripsToJson(List<Trip> trips)
        {
            string json = JsonConvert.SerializeObject(trips, Formatting.Indented);
            string filename = "trips.json";
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);
            File.WriteAllText(path, json);
        }


        public List<Trip> LoadTripsFromJson()
        {
            string filename = "trips.json";
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                var trips = JsonConvert.DeserializeObject<List<Trip>>(json);
                return trips;
            }
            return new List<Trip>();
        }



        public void UpdateTripInJson(int tripId, Trip updatedTrip)
        {
            string filename = "trips.json";
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);

                var trips = JsonConvert.DeserializeObject<List<Trip>>(json);

                var existingTrip = trips.FirstOrDefault(t => t.Id == tripId);

                if (existingTrip != null)
                {
                    // Update the trip's properties
                    existingTrip.Activities = updatedTrip.Activities;

                    string updatedJson = JsonConvert.SerializeObject(trips, Formatting.Indented);
                    File.WriteAllText(path, updatedJson);
                }
            }
        }

        public void UpdateTripInJson(Trip updatedTrip)
        {
            string filename = "trips.json";
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);

                var trips = JsonConvert.DeserializeObject<List<Trip>>(json);

                var existingTrip = trips.FirstOrDefault(t => t.Id == updatedTrip.Id);

                if (existingTrip != null)
                {
                    existingTrip.IsEnded = updatedTrip.IsEnded;

                    string updatedJson = JsonConvert.SerializeObject(trips, Formatting.Indented);
                    File.WriteAllText(path, updatedJson);
                }
            }
        }
    }
}
