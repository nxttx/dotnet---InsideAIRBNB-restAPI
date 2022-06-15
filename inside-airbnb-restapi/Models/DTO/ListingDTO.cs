namespace WebApplication1.Models.DTO;

public class ListingDTO
{
    public long? id { get; }
    public string? name { get; }
    public string? thumbnail_url{ get; }
    public string? host_is_superhost{ get; }
    public string? neighbourhood{ get; }
    public double? latitude{ get; }
    public double? longitude{ get; }
    public string? property_type{ get; }
    public string? room_type{ get; }
    public string? accommodates{ get; }
    public string? bathrooms{ get; }
    public string? bedrooms{ get; }
    public string? beds{ get; }
    public string? price{ get; }
    public string? number_of_reviews{ get; }
    public double? review_scores_rating{ get; }
    
    
    public ListingDTO(long id, string name, string thumbnailUrl, string hostIsSuperhost, string neighbourhood, double? latitude, double? longitude, string propertyType, string roomType, string accommodates, string bathrooms, string bedrooms, string beds, string price, string numberOfReviews, double? reviewScoresRating)
    {
        this.id = id;
        this.name = name;
        thumbnail_url = thumbnailUrl;
        host_is_superhost = hostIsSuperhost;
        this.neighbourhood = neighbourhood;
        this.latitude = latitude;
        this.longitude = longitude;
        property_type = propertyType;
        room_type = roomType;
        this.accommodates = accommodates;
        this.bathrooms = bathrooms;
        this.bedrooms = bedrooms;
        this.beds = beds;
        this.price = price;
        number_of_reviews = numberOfReviews;
        review_scores_rating = reviewScoresRating;
    }
    
    public ListingDTO(Models.Listing listing)
    {
        this.id = listing.Id;
        this.name = listing.Name;
        thumbnail_url = listing.PictureUrl;
        host_is_superhost = listing.HostIsSuperhost;
        this.neighbourhood = listing.Neighbourhood;
        this.latitude = listing.Latitude;
        this.longitude = listing.Longitude;
        property_type = listing.PropertyType;
        room_type = listing.RoomType;
        this.accommodates = listing.Accommodates;
        // this.bathrooms = listing.Bathrooms;
        this.bathrooms = listing.BathroomsText;
        this.bedrooms = listing.Bedrooms;
        this.beds = listing.Beds;
        this.price = listing.Price;
        number_of_reviews = listing.NumberOfReviews;
        review_scores_rating = listing.ReviewScoresRating;
    }
}