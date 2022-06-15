using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Repository;

public interface INeighbourhoodsRepository
{
    Task<ActionResult<IEnumerable<String>>> GetAllNeighbourhoods();
    
}