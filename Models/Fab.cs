using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace RestAPI_SaatmannTest2.Models
{
    [Keyless]
    public partial class Fab
    {
        public string? IK { get; set; }
        public string? Entlassender_Standort { get; set; }
        public string? Entgeltbereich { get; set; }
        public string? KH_internes_Kennzeichen { get; set; }
        public string? FAB { get; set; }
        public string? FAB_Aufnahmedatum { get; set; }
        public string? FAB_Entlassungsdatum { get; set; }
        public string? Standort { get; set; }
        public string? Station { get; set; }
        public string? typ { get; set; }
    }
    
}
