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
    [Route("neighbourhoods")]
    [ApiController]
    public class NeighbourhoodsController : ControllerBase
    {
        private readonly INeighbourhoodsRepository _neighbourhoodsRepository;

        public NeighbourhoodsController(INeighbourhoodsRepository neighbourhoodsRepository)
        {
            _neighbourhoodsRepository = neighbourhoodsRepository;
        }

        // GET: Neighbourhoods
        [HttpGet]
        [Cached(600)]
        public async Task<ActionResult<IEnumerable<String>>> GetNeighbourhoods()
        {

            return Ok(await _neighbourhoodsRepository.GetAllNeighbourhoods());
        }
        
        
    }
}
