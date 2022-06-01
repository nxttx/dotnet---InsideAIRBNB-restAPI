using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Listing
    {
        public long Id { get; set; }
        public string? ListingUrl { get; set; }
        public DateTime? LastScraped { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? NeighborhoodOverview { get; set; }
        public string? PictureUrl { get; set; }
        public string? HostId { get; set; }
        public string? HostUrl { get; set; }
        public string? HostName { get; set; }
        public DateTime? HostSince { get; set; }
        public string? HostLocation { get; set; }
        public string? HostAbout { get; set; }
        public string? HostResponseTime { get; set; }
        public string? HostResponseRate { get; set; }
        public string? HostAcceptanceRate { get; set; }
        public string? HostIsSuperhost { get; set; }
        public string? HostThumbnailUrl { get; set; }
        public string? HostPictureUrl { get; set; }
        public string? HostNeighbourhood { get; set; }
        public string? HostListingsCount { get; set; }
        public string? HostTotalListingsCount { get; set; }
        public string? HostVerifications { get; set; }
        public string? HostHasProfilePic { get; set; }
        public string? HostIdentityVerified { get; set; }
        public string? Neighbourhood { get; set; }
        public string? NeighbourhoodCleansed { get; set; }
        public string? NeighbourhoodGroupCleansed { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string? PropertyType { get; set; }
        public string? RoomType { get; set; }
        public string? Accommodates { get; set; }
        public string? Bathrooms { get; set; }
        public string? BathroomsText { get; set; }
        public string? Bedrooms { get; set; }
        public string? Beds { get; set; }
        public string? Amenities { get; set; }
        public string? Price { get; set; }
        public string? MinimumNights { get; set; }
        public string? MaximumNights { get; set; }
        public string? MinimumMinimumNights { get; set; }
        public string? MaximumMinimumNights { get; set; }
        public string? MinimumMaximumNights { get; set; }
        public string? MaximumMaximumNights { get; set; }
        public double? MinimumNightsAvgNtm { get; set; }
        public double? MaximumNightsAvgNtm { get; set; }
        public string? CalendarUpdated { get; set; }
        public string? HasAvailability { get; set; }
        public string? Availability30 { get; set; }
        public string? Availability60 { get; set; }
        public string? Availability90 { get; set; }
        public string? Availability365 { get; set; }
        public DateTime? CalendarLastScraped { get; set; }
        public string? NumberOfReviews { get; set; }
        public string? NumberOfReviewsLtm { get; set; }
        public string? NumberOfReviewsL30d { get; set; }
        public DateTime? FirstReview { get; set; }
        public DateTime? LastReview { get; set; }
        public double? ReviewScoresRating { get; set; }
        public double? ReviewScoresAccuracy { get; set; }
        public double? ReviewScoresCleanliness { get; set; }
        public double? ReviewScoresCheckin { get; set; }
        public double? ReviewScoresCommunication { get; set; }
        public double? ReviewScoresLocation { get; set; }
        public double? ReviewScoresValue { get; set; }
        public string? License { get; set; }
        public string? InstantBookable { get; set; }
        public string? CalculatedHostListingsCount { get; set; }
        public string? CalculatedHostListingsCountEntireHomes { get; set; }
        public string? CalculatedHostListingsCountPrivateRooms { get; set; }
        public string? CalculatedHostListingsCountSharedRooms { get; set; }
        public double? ReviewsPerMonth { get; set; }
    }
}
