using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RestAPI_SaatmannTest2.Data;
using RestAPI_SaatmannTest2.Models;
using System.Data;

namespace RestAPI_SaatmannTest2.Queries
{
    public class GetOpsByDateBetweenQuery
    {
       
        public List<Ops> Ops = new();

        private DateTime _startdate;
        private DateTime _enddate;
        private readonly ITAssessmentContext _context;
        public GetOpsByDateBetweenQuery(ITAssessmentContext context, DateTime startDate, DateTime endDate)
        {
            _context = context;
            _startdate = startDate;
            _enddate = endDate;
            Processing();
        }
        private void Processing()
        {
            SqlParameter param1 = new SqlParameter("@startDate", _startdate);
            SqlParameter param2 = new SqlParameter("@endDate", _enddate);

            Ops = _context.Ops
                             .FromSqlRaw<Ops>("SELECT O.* FROM OPS O INNER JOIN Falls F ON O.KH_internes_Kennzeichen = F.KH_internes_Kennzeichen WHERE F.Aufnahmedatum >= @startDate and F.Aufnahmedatum <= @endDate", param1,param2)
                            .ToList();
        }
    }
}
