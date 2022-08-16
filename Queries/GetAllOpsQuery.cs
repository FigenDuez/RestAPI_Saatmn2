using RestAPI_SaatmannTest2.Data;
using RestAPI_SaatmannTest2.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace RestAPI_SaatmannTest2.Queries
{
    public class GetAllOpsQuery
    {
        private readonly ITAssessmentContext _context;
        private List<Ops> Ops;
        
        public GetAllOpsQuery(ITAssessmentContext context)
        {
            _context = context;
            Ops = new();

        }
        public async Task<IEnumerable<Ops>> Processing()
        {
            await Task.Yield();
            Ops = _context.Ops
                            .FromSqlRaw<Ops>("SELECT O.* FROM OPS as O INNER JOIN Falls as F ON O.KH_internes_Kennzeichen = F.KH_internes_Kennzeichen")
                            .ToList();
            return Ops;
        }

      
    }
}
