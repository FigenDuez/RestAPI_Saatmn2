using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAPI_SaatmannTest2.Data;
using RestAPI_SaatmannTest2.Models;

namespace RestAPI_SaatmannTest2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FallsController : ControllerBase
    {
       
        private readonly ITAssessmentContext _context;
      
        public FallsController(ITAssessmentContext context)
        {
            _context = context;
        }

        // GET: api/Falls
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fall>>> GetFalls()
        {
            if (_context.Falls == null)
            {
                return NotFound();
            }
            return await _context.Falls.ToListAsync();
        }

        // GET: api/Falls/3260423194
        [HttpGet("{id}")]
        public async Task<ActionResult<Fall>> GetFall(string id)
        {
            if (_context.Falls == null || (!FallExists(id)))
            {
                return NotFound();
            }
            var fall = await _context.Falls.FindAsync(id);

            if (fall == null)
            {
                return NotFound();
            }
            return fall;
        }

        [HttpGet("{startDate}/{endDate}")]
        //api/Falls/2019-01-14/2019-01-17
        public async Task<ActionResult<IEnumerable<Fall>>> GetFallDateBetween([FromRoute] DateTime startDate, [FromRoute] DateTime endDate)
        {
            if (_context.Falls == null)
            {
                return NotFound();
            }
            var falls = await _context.Falls.Where(w => w.Aufnahmedatum >= startDate
                                                    && w.Aufnahmedatum <= endDate).ToListAsync();
            if (falls == null)
            {
                return NotFound();
            }
            return falls;
        }

        private bool FallExists(string id)
        {
            return (_context.Falls?.Any(e => e.KH_internes_Kennzeichen == id)).GetValueOrDefault();
        }
    }
}
