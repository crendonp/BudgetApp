using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EntriesController : ControllerBase
    {
        private readonly DataContext _context;
        public EntriesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Entry>>> GetEntries()
        {
            var entries = await _context.Entries.ToListAsync();
            return Ok(entries);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Entry>> GetEntry(string id)
        {
            var entry = await _context.Entries.FindAsync(id);
            return Ok(entry);
        }
    }
}