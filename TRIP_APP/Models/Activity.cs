using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRIP_APP.Models
{
    internal class Activity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Person PersonInCharge { get; set; }
        public List<Debtors> Debtors { get; set; }
    }
}
