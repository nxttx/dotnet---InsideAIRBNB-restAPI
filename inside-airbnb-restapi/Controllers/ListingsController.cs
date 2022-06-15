using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.Models.DTO;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    [Route("listings")]
    [ApiController]
    public class ListingsController : ControllerBase
    {
        private readonly IListingsRepository _listingsRepository;

        public ListingsController(IListingsRepository listingsRepository)
        {
            _listingsRepository = listingsRepository;
        }

        // GET: Listings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ListingDTO>>> GetListings()
        {

            var listings = await _listingsRepository.getListings();
            return Ok(listings);
        }
        

        // GET: Listings
        [HttpGet("geodata")]
        public async Task<ActionResult<IEnumerable<ShortListing>>> GetListingGeodata()
        {
            
            var listings = await _listingsRepository.GetListingGeodata();
            return Ok(listings);

        }
        
    }
}
