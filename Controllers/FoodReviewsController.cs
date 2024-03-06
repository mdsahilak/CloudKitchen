using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CloudKitchen.Models;

namespace CloudKitchen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodReviewsController : ControllerBase
    {
        private readonly CloudKitchenContext _context;

        public FoodReviewsController(CloudKitchenContext context)
        {
            _context = context;
        }

        // GET: api/FoodReviews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FoodReview>>> GetFoodReviews()
        {
            return await _context.FoodReviews.ToListAsync();
        }

        // GET: api/FoodReviews/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FoodReview>> GetFoodReview(int id)
        {
            var foodReview = await _context.FoodReviews.FindAsync(id);

            if (foodReview == null)
            {
                return NotFound();
            }

            return foodReview;
        }

        // PUT: api/FoodReviews/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFoodReview(int id, FoodReview foodReview)
        {
            if (id != foodReview.FoodReviewId)
            {
                return BadRequest();
            }

            _context.Entry(foodReview).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FoodReviewExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/FoodReviews
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FoodReview>> PostFoodReview(FoodReview foodReview)
        {
            _context.FoodReviews.Add(foodReview);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFoodReview", new { id = foodReview.FoodReviewId }, foodReview);
        }

        // DELETE: api/FoodReviews/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFoodReview(int id)
        {
            var foodReview = await _context.FoodReviews.FindAsync(id);
            if (foodReview == null)
            {
                return NotFound();
            }

            _context.FoodReviews.Remove(foodReview);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FoodReviewExists(int id)
        {
            return _context.FoodReviews.Any(e => e.FoodReviewId == id);
        }
    }
}
