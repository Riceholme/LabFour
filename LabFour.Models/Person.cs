using System;
using System.Collections.Generic;

namespace LabFour.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<PersonInterest> Interests { get; set; }
    }
}
