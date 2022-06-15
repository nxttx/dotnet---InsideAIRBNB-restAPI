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
using WebApplication1.Cache;

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
        [Cached(600)]
        public async Task<ActionResult<IEnumerable<ListingDTO>>> GetListings()
        {

            return await _listingsRepository.getListings();
        }
        

        // GET: Listings
        [HttpGet("geodata")]
        [Cached(600)]
        public async Task<ActionResult<IEnumerable<ShortListing>>> GetListingGeodata()
        {
            
            return await _listingsRepository.GetListingGeodata();

        }
    }
}
