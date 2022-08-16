using RestAPI_SaatmannTest2.Data;
using RestAPI_SaatmannTest2.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace RestAPI_SaatmannTest2.Queries
{
    public class GetAllOpsQuery
    {
       
        public List<Ops> Ops = new();
        private readonly ITAssessmentContext _context;
        public GetAllOpsQuery(ITAssessmentContext context)
        {
            _context = context;
            Processing();
        }
        private void Processing()
        {
            Ops = _context.Ops
                            .FromSqlRaw<Ops>("SELECT O.* FROM OPS as O INNER JOIN Falls as F ON O.KH_internes_Kennzeichen = F.KH_internes_Kennzeichen")
                            .ToList();
        }

      
    }
}
