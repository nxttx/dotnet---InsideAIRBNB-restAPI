using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.DTO;

namespace WebApplication1.Repository;

public interface IListingsRepository
{
    Task<ActionResult<IEnumerable<ListingDTO>>> getListings();
    Task<ActionResult<IEnumerable<ShortListing>>> GetListingGeodata();
}