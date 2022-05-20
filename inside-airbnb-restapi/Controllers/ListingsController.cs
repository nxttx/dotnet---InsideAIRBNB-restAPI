using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("listings")]
    public class ListingsController : ControllerBase
    {

        [HttpGet]
        [Route("")]
        public String GetListings()
        {
            return "[{\"id\":2818,\"name\":\"Quiet garden view room\",\"thumbnail_url\":\"https://a0.muscache.com/im/pictures/10272854/8dcca016_original.jpg?aki_policy=small\",\"host_is_superhost\":true,\"neighbourhood\":\"Indische Buurt\",\"latitude\":52.365754513876180,\"longitude\":4.941419235184398,\"property_type\":\"Apartment\",\"room_type\":\"Private room\",\"accommodates\":2,\"bathrooms\":15,\"bedrooms\":1,\"beds\":2,\"price\":\"$69.00\",\"number_of_reviews\":218,\"review_scores_rating\":97},{\"id\":3209,\"name\":\"Quiet apt near center, great view\",\"thumbnail_url\":\"https://a0.muscache.com/im/pictures/88955424/496ae7bb_original.jpg?aki_policy=small\",\"host_is_superhost\":true,\"neighbourhood\":\"Spaarndammer en Zeeheldenbuurt\",\"latitude\":52.39022505041117,\"longitude\":4.873924094742859,\"property_type\":\"Condominium\",\"room_type\":\"Entire home/apt\",\"accommodates\":4,\"bathrooms\":10,\"bedrooms\":2,\"beds\":2,\"price\":\"$139.00\",\"number_of_reviews\":33,\"review_scores_rating\":95},{\"id\":20168,\"name\":\"100% Centre - Private Bathroom - Lockable Studio\",\"thumbnail_url\":\"https://a0.muscache.com/im/pictures/69979664/3652fedc_original.jpg?aki_policy=small\",\"host_is_superhost\":false,\"neighbourhood\":\"Grachtengordel\",\"latitude\":52.365087026809170,\"longitude\":4.8935410078410100,\"property_type\":\"Townhouse\",\"room_type\":\"Private room\",\"accommodates\":2,\"bathrooms\":10,\"bedrooms\":1,\"beds\":1,\"price\":\"$80.00\",\"number_of_reviews\":182,\"review_scores_rating\":87}]";
        }

        [HttpGet]
        [Route("{id}")]
        public String GetListing(int id)
        {
            return "{\"id\":"+id+",\"name\":\"Quiet garden view room\",\"thumbnail_url\":\"https://a0.muscache.com/im/pictures/10272854/8dcca016_original.jpg?aki_policy=small\",\"host_is_superhost\":true,\"neighbourhood\":\"Indische Buurt\",\"latitude\":52.365754513876180,\"longitude\":4.941419235184398,\"property_type\":\"Apartment\",\"room_type\":\"Private room\",\"accommodates\":2,\"bathrooms\":15,\"bedrooms\":1,\"beds\":2,\"price\":\"$69.00\",\"number_of_reviews\":218,\"review_scores_rating\":97}";
        }

    }
}