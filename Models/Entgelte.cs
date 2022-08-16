using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace RestAPI_SaatmannTest2.Models
{
    [Keyless]
    public partial class Entgelte
    {
        public string? IK { get; set; }
        public string? Entlassender_Standort { get; set; }
        public string? Entgeltbereich { get; set; }
        public string? KH_internes_Kennzeichen { get; set; }
        public string? IK_Krankenkasse { get; set; }
        public string? Entgeltart { get; set; }
        public string? Entgeltbetrag { get; set; }
        public string? Abrechnung_von { get; set; }
        public string? Abrechnung_bis { get; set; }
        public string? Entgeltanzahl { get; set; }
        public string? Tage_ohne_Berechnung_Behandlung { get; set; }
        public string? Tag_der_Behandlung { get; set; }
    }
  
}
