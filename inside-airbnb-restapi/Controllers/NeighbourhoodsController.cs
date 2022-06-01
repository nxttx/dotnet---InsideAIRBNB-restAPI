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
    [Route("neighbourhoods")]
    [ApiController]
    public class NeighbourhoodsController : ControllerBase
    {
        private readonly AIRBNBContext _context;

        public NeighbourhoodsController(AIRBNBContext context)
        {
            _context = context;
        }

        // GET: Neighbourhoods
        [HttpGet]
        public async Task<ActionResult<IEnumerable<String>>> GetNeighbourhoods()
        {
            if (_context.Neighbourhoods == null)
            {
                return NotFound();
            }

            return await _context.Neighbourhoods.Select(x=>x.Neighbourhood1).ToListAsync();
        }
        
        
    }
}
