using WebApplication1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Repository;
public class NeighbourhoodsRepository: INeighbourhoodsRepository
{
    private readonly AIRBNBContext _context;
    public NeighbourhoodsRepository(AIRBNBContext context)
    {
        _context = context;
    }
    
    public async Task<ActionResult<IEnumerable<String>>> GetAllNeighbourhoods()
    {
        return await _context.Neighbourhoods.Select(x=>x.Neighbourhood1).ToListAsync();
        
    }
    
}