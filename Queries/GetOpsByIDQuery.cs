using RestAPI_SaatmannTest2.Data;
using RestAPI_SaatmannTest2.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace RestAPI_SaatmannTest2.Queries
{
    public class GetOpsByIDQuery
    {
        private readonly ITAssessmentContext _context;
        private readonly string _id;
        private List<Ops> Ops;
       
        public GetOpsByIDQuery(ITAssessmentContext context, string id)
        {
            _context = context;
            _id = id;
            Ops = new();
        }

        public async Task<IEnumerable<Ops>> Processing()
        {
            await Task.Yield();
            Ops = _context.Ops
                            .FromSqlRaw<Ops>("SELECT O.* FROM OPS O INNER JOIN Falls F ON O.KH_internes_Kennzeichen = F.KH_internes_Kennzeichen WHERE F.KH_internes_Kennzeichen = @searchTerm", new SqlParameter("@searchTerm", _id))
                           .ToList();
            return Ops;
        }
    }
}
