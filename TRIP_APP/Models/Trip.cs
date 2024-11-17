using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRIP_APP.Models
{
    internal class Trip
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsEnded { get; set; } = false;
        public List<Person> Participants { get; set; }
        public List<Activity> Activities { get; set; }
    }
}
