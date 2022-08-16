using RestAPI_SaatmannTest2.Data;
using RestAPI_SaatmannTest2.Models;
using RestAPI_SaatmannTest2.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;
using System.Linq;

namespace RestAPI_SaatmannTest2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpsController : ControllerBase
    {
        private readonly ITAssessmentContext _context;
        public OpsController(ITAssessmentContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ops>>> Get()
        {
            var Ops = await new GetAllOpsQuery(_context).Processing();
            if (Ops.Count() == 0)
            {
                return NotFound();
            }
            return Ok(Ops);
        }


        [HttpGet("{id}")]
        //api/ops/3260423194
        public async Task<ActionResult<IEnumerable<Ops>>> Get(string id)
        {
            var Ops = await new GetOpsByIDQuery(_context, id).Processing();
            if (Ops.Count() == 0)
            {
                //return NotFound();
                return Problem("Entity Ops does not return any result!");
            }
            return Ok(Ops);
        }

        [HttpGet("{startdate}/{enddate}")]
        //api/ops/2019-01-14/2019-01-15
        public async Task<ActionResult<IEnumerable<Ops>>> Get(DateTime startdate, DateTime enddate)
        {
            var Ops = await new GetOpsByDateBetweenQuery(_context, startdate, enddate).Processing();
            if (Ops.Count() == 0)
            {
                return Problem("Entity Ops does not return any result!");
            }
            return Ok(Ops);
        }
      
    }
}
