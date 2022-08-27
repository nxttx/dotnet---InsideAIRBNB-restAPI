namespace WebApplication1.Models.DTO;

public class ShortListing
{
    public double? latitude { get; set; }
    public double? longitude { get; set; }
    public string? price { get; set; }
    public string? listingUrl { get; set; }
    public string? neighbourhoodCleansed { get; set; }
    public double? reviewScoresRating{ get; }

    public ShortListing(double? latitude, double? longitude, string? price, String? listingUrl, string? NeighbourhoodCleansed, double? review_scores_rating)
    {
        this.latitude = latitude;
        this.longitude = longitude;
        this.price = price;
        this.listingUrl = listingUrl;
        this.neighbourhoodCleansed = NeighbourhoodCleansed;
        this.reviewScoresRating = review_scores_rating;
    }
}