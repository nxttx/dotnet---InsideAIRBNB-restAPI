using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Calendar
    {
        public int ListingId { get; set; }
        public DateTime Date { get; set; }
        public string Available { get; set; } = null!;
        public string? Price { get; set; }

        public virtual Listings2019 Listing { get; set; } = null!;
    }
}
