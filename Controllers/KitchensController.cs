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
    public class KitchensController : ControllerBase
    {
        private readonly CloudKitchenContext _context;

        public KitchensController(CloudKitchenContext context)
        {
            _context = context;
        }

        // GET: api/Kitchens
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Kitchen>>> GetKitchens()
        {
            return await _context.Kitchens.ToListAsync();
        }

        // GET: api/Kitchens/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Kitchen>> GetKitchen(int id)
        {
            var kitchen = await _context.Kitchens.FindAsync(id);

            if (kitchen == null)
            {
                return NotFound();
            }

            return kitchen;
        }

        // PUT: api/Kitchens/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKitchen(int id, Kitchen kitchen)
        {
            if (id != kitchen.KitchenId)
            {
                return BadRequest();
            }

            _context.Entry(kitchen).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KitchenExists(id))
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

        // POST: api/Kitchens
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Kitchen>> PostKitchen(Kitchen kitchen)
        {
            _context.Kitchens.Add(kitchen);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKitchen", new { id = kitchen.KitchenId }, kitchen);
        }

        // DELETE: api/Kitchens/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKitchen(int id)
        {
            var kitchen = await _context.Kitchens.FindAsync(id);
            if (kitchen == null)
            {
                return NotFound();
            }

            _context.Kitchens.Remove(kitchen);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool KitchenExists(int id)
        {
            return _context.Kitchens.Any(e => e.KitchenId == id);
        }
    }
}
