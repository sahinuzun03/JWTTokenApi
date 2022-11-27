using ApıJwt.Context;
using ApıJwt.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApıJwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateController : ControllerBase
    {
        private readonly JwtTestDbContext _context;
        public CreateController(JwtTestDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] User user)
        {
            if(user!= null)
            {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                return Ok(user);
            }

            return NotFound();
            
        }
    }
}