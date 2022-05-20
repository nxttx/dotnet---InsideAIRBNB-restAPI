using WebApplication1.Domain;

namespace WebApplication1.Repository;

public interface IListingRepository
{
    Task<IEnumerable<Listing>> GetListings();
    Task<Listing> GetListing(int listingId);
    Task<Listing> AddListing(Listing listing);
    Task<Listing> UpdateListing(Listing listing);
    void DeleteListing(int listingId);
}