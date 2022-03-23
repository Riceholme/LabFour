using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LabFour.Models
{
    public class WebSite
    {
        [Key]
        public int WebSiteId { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public int InterestId { get; set; }
        public Interest Interest { get; set; }
    }
}
