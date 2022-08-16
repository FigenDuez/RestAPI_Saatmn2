using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace RestAPI_SaatmannTest2.Models
{
    [Keyless]
    public partial class Ops
    {
        public string? IK { get; set; }
        public string? Entlassender_Standort{ get; set; }
        public string? Entgeltbereich { get; set; }
        public string? KH_internes_Kennzeichen{ get; set; }
        public string? OPS_Version{ get; set; }
        public string? OPS_Kode{ get; set; }
        public string? Lokalisation { get; set; }
        public string? OPS_Datum{ get; set; }
        public string? Belegoperateur { get; set; }
        public string? Beleganaesthesist { get; set; }
        public string? Beleghebamme { get; set; }
    }
    
}
