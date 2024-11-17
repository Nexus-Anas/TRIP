using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRIP_APP.Models
{
    internal class Debtors
    {
        public Person Debtor { get; set; }
        public decimal Amount { get; set; }
        public string DebtorName => Debtor?.Name;
    }
}
