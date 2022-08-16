using RestAPI_SaatmannTest2.Data;
using RestAPI_SaatmannTest2.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace RestAPI_SaatmannTest2.Queries
{
    public class GetOpsByIDQuery
    {
        private readonly ITAssessmentContext _context;
        private readonly string _id;
        public List<Ops> Ops = new();

        public GetOpsByIDQuery(ITAssessmentContext context, string id)
        {
            _context = context;
            _id = id;
            Processing();
        }
        private void Processing()
        {
           Ops = _context.Ops
                            .FromSqlRaw<Ops>("SELECT O.* FROM OPS O INNER JOIN Falls F ON O.KH_internes_Kennzeichen = F.KH_internes_Kennzeichen WHERE F.KH_internes_Kennzeichen = @searchTerm", new SqlParameter("@searchTerm", _id))
                           .ToList();
        }
    }
}
