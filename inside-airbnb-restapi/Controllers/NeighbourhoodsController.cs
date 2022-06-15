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
        public async Task<ActionResult<IEnumerable<String>>> GetNeighbourhoods()
        {

            return await _neighbourhoodsRepository.GetAllNeighbourhoods();
        }
        
        
    }
}
