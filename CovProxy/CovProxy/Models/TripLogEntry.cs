using System;

namespace CovProxy.Models
{
    public class TripLogEntry
    {
        public Location Location { get; set; }

        public DateTime VisitedOn { get; set; }

        public string Notes { get; set; }
    }
}
