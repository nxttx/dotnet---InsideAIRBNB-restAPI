using WebApplication1.Domain;

namespace WebApplication1.Repository;

public class ListingRepository:IListingRepository
{
    
    // private readonly AppDbContext appDbContext;
    //
    // public ListingRepository(AppDbContext appDbContext)
    // {
    //     this.appDbContext = appDbContext;
    // }
    
    

    public Task<IEnumerable<Listing>> GetListings()
    {
        throw new NotImplementedException();
    }

    public Task<Listing> GetListing(int listingId)
    {
        throw new NotImplementedException();
    }

    public Task<Listing> AddListing(Listing listing)
    {
        throw new NotImplementedException();
    }

    public Task<Listing> UpdateListing(Listing listing)
    {
        throw new NotImplementedException();
    }

    public void DeleteListing(int listingId)
    {
        throw new NotImplementedException();
    }
}