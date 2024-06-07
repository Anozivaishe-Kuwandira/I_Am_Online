using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api.data;
using api.Models;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HostelController : ControllerBase
    {
        private readonly DataContext _context;

        public HostelController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Hostel
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hostel>>> GetHostel()
        {
            return await _context.Hostel.ToListAsync();
        }

        // GET: api/Hostel/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hostel>> GetHostel(int id)
        {
            var hostel = await _context.Hostel.FindAsync(id);

            if (hostel == null)
            {
                return NotFound();
            }

            return hostel;
        }

        // PUT: api/Hostel/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHostel(int id, Hostel hostel)
        {
            if (id != hostel.HostelId)
            {
                return BadRequest();
            }

            _context.Entry(hostel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HostelExists(id))
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

        // POST: api/Hostel
        [HttpPost]
        public async Task<ActionResult<Hostel>> PostHostel(Hostel hostel)
        {
            _context.Hostel.Add(hostel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHostel", new { id = hostel.HostelId }, hostel);
        }

        // DELETE: api/Hostel/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHostel(int id)
        {
            var hostel = await _context.Hostel.FindAsync(id);
            if (hostel == null)
            {
                return NotFound();
            }

            _context.Hostel.Remove(hostel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HostelExists(int id)
        {
            return _context.Hostel.Any(e => e.HostelId == id);
        }
    }
}
