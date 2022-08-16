using RestAPI_SaatmannTest2.Data;
using RestAPI_SaatmannTest2.Models;
using RestAPI_SaatmannTest2.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public IEnumerable<Ops> Get()
        {
            return new GetAllOpsQuery(_context).Ops;
        }


        [HttpGet("{id}")]
        //api/ops/3260423194
        public IEnumerable<Ops> Get(string id)
        {
            return new GetOpsByIDQuery(_context, id).Ops;
        }

        [HttpGet("{startdate}/{enddate}")]
        //api/ops/2019-01-14/2019-01-15
        public IEnumerable<Ops> Get(DateTime startdate, DateTime enddate)
        {
            return new GetOpsByDateBetweenQuery(_context, startdate, enddate).Ops;
        }
      
    }
}
