namespace WebApplication1.Domain;

public class Listing
{
    private int id { get; }
    private String name { get; }
    private String thumbnail_url{ get; }
    private Boolean host_is_superhost{ get; }
    private String neighbourhood{ get; }
    private float latitude{ get; }
    private float longitude{ get; }
    private String property_type{ get; }
    private String room_type{ get; }
    private int accommodates{ get; }
    private float bathrooms{ get; }
    private float bedrooms{ get; }
    private float beds{ get; }
    private String price{ get; }
    private int number_of_reviews{ get; }
    private int review_scores_rating{ get; }
    
    
    public Listing(int id, string name, string thumbnailUrl, bool hostIsSuperhost, string neighbourhood, float latitude, float longitude, string propertyType, string roomType, int accommodates, float bathrooms, float bedrooms, float beds, string price, int numberOfReviews, int reviewScoresRating)
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
}