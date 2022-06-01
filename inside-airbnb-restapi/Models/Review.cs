﻿using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Review
    {
        public int ListingId { get; set; }
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int ReviewerId { get; set; }
        public string ReviewerName { get; set; } = null!;
        public string Comments { get; set; } = null!;

        public virtual Listings2019 Listing { get; set; } = null!;
    }
}
