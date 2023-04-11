using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.DataAccess; 

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthorsController : ControllerBase
{
    private readonly AppDbContext _dbContext;
    public AuthorsController(AppDbContext dbContext) => _dbContext = dbContext;

    [HttpGet(nameof(LazyLoadingGetAllAuthors))]
    public async Task<IActionResult> LazyLoadingGetAllAuthors()
    { 
        // 1 Query for the whole list
        // 1 Query for EACH author => N queries for N Authors 
        // N + 1 Queries Total
        var authors = await _dbContext.Authors.ToListAsync(); 
        return Ok(authors);
    }

    [HttpGet(nameof(EagerLoadingGetAllAuthors))]
    public async Task<IActionResult> EagerLoadingGetAllAuthors()
    { 
        // Only 1 Query in total
        var authors = await _dbContext.Authors
            .Include(a => a.Books)
            .ToListAsync();
        return Ok(authors);
    }
}