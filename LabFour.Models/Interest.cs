using System;
using System.Collections.Generic;
using System.Text;

namespace LabFour.Models
{
    public class Interest
    {
        public int InterestId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<PersonInterest> Persons { get; set; }
        public ICollection<WebSite> WebSites { get; set; }

    }
}
