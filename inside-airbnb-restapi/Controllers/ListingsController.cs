using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.Models.DTO;

namespace WebApplication1.Controllers
{
    [Route("listings")]
    [ApiController]
    public class ListingsController : ControllerBase
    {
        private readonly AIRBNBContext _context;

        public ListingsController(AIRBNBContext context)
        {
            _context = context;
        }

        // GET: Listings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ListingDTO>>> getListings()
        {
            if (_context.Listings == null)
            {
                return NotFound();
            }

            return await _context.Listings.Take(20).Select(x=>new ListingDTO(x)).ToListAsync();
        }
        
        
        // GET: Listings
        // [HttpGet]
        // public async Task<ActionResult<IEnumerable<Listing>>> GetListings()
        // {
        //   if (_context.Listings == null)
        //   {
        //       return NotFound();
        //   }
        //     return await _context.Listings.ToListAsync();
        // }

        // GET: Listings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Listing>> GetListing(int id)
        {
          if (_context.Listings == null)
          {
              return NotFound();
          }
            var listing = await _context.Listings.FindAsync(id);

            if (listing == null)
            {
                return NotFound();
            }

            return listing;
        }

        // GET: Listings
        [HttpGet("geodata")]
        public async Task<ActionResult<IEnumerable<ShortListing>>> GetListingGeodata()
        {
            if (_context.Listings == null)
            {
                return NotFound();
            }

            return await _context.Listings.Select(x=>new ShortListing(x.Latitude, x.Longitude, x.Price, x.ListingUrl, x.NeighbourhoodCleansed, x.ReviewScoresRating)).ToListAsync();
        }
        
    }
}
