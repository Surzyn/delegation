using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.DTO
{
    public class BaseDelegationData
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime From { get; set; }
        public DateTime? To { get; set; }
    }
}
