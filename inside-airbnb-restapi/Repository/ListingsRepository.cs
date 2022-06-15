using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.Models.DTO;

namespace WebApplication1.Repository;

public class ListingRepository : IListingsRepository
{
    private readonly AIRBNBContext _context;

    public ListingRepository(AIRBNBContext context)
    {
        _context = context;
    }

    public async Task<ActionResult<IEnumerable<ListingDTO>>> getListings()
    {
        return await _context.Listings.Take(20).Select(x => new ListingDTO(
            x.Id,
            x.Name,
            x.PictureUrl,
            x.HostIsSuperhost,
            x.Neighbourhood,
            x.Latitude,
            x.Longitude,
            x.PropertyType,
            x.RoomType,
            x.Accommodates,
            x.BathroomsText,
            x.Bedrooms,
            x.Beds,
            x.Price,
            x.NumberOfReviews,
            x.ReviewScoresRating

        )).AsNoTracking().ToListAsync();
    }

    public async Task<ActionResult<IEnumerable<ShortListing>>> GetListingGeodata()
    {
        return await _context.Listings.Select(x => new ShortListing(x.Latitude, x.Longitude, x.Price, x.ListingUrl,
            x.NeighbourhoodCleansed, x.ReviewScoresRating)).ToListAsync();
    }

}
    