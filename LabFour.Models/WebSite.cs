using System;
using System.Collections.Generic;
using System.Text;

namespace LabFour.Models
{
    public class WebSite
    {
        public int WebSiteId { get; set; }
        public int Link { get; set; }
        public int Description { get; set; }
        public int InterestId { get; set; }
        public Interest Interest { get; set; }
    }
}
