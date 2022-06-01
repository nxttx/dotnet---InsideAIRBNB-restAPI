namespace WebApplication1.Models.DTO;

public class ShortListing
{
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
    public string? Price { get; set; }
    public string? ListingUrl { get; set; }
    public string? NeighbourhoodCleansed { get; set; }
    public double? ReviewScoresRating{ get; }

    public ShortListing(double? latitude, double? longitude, string? price, String? listingUrl, string? NeighbourhoodCleansed, double? review_scores_rating)
    {
        Latitude = latitude;
        Longitude = longitude;
        Price = price;
        ListingUrl = listingUrl;
        this.NeighbourhoodCleansed = NeighbourhoodCleansed;
        this.ReviewScoresRating = review_scores_rating;
    }
}