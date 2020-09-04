using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class DelegationItem
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Destination { get; set; }
        public DateTime Date { get; set; }
        public DateTime? ReturningData { get; set; }
        public double? Cost { get; set; }
    }
}
