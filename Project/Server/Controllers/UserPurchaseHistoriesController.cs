using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Server.Data;
using Project.Shared.Domain;

namespace Project.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserPurchaseHistoriesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UserPurchaseHistoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/UserPurchaseHistories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cart>>> GetUserPurchaseHistories()
        {
            var completedPurchases = await _context.Carts.Where(c => c.IsCompleted).ToListAsync();
            return Ok(completedPurchases);
        }

        // POST: api/UserPurchaseHistories/CompletePurchase
        [HttpPost("CompletePurchase")]
        public async Task<ActionResult<Cart>> CompletePurchase(Cart cart)
        {
            // Set IsCompleted to true to indicate that the purchase is completed
            cart.IsCompleted = true;

            _context.Carts.Add(cart);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserPurchaseHistory", new { id = cart.Id }, cart);
        }

        // Other actions and methods...

        // For example, you can add an endpoint to get details of a specific completed purchase
        [HttpGet("CompletedPurchase/{id}")]
        public async Task<ActionResult<Cart>> GetCompletedPurchase(int id)
        {
            var completedPurchase = await _context.Carts.FirstOrDefaultAsync(c => c.Id == id && c.IsCompleted);

            if (completedPurchase == null)
            {
                return NotFound();
            }

            return completedPurchase;
        }
    }
}