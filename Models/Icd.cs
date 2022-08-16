using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace RestAPI_SaatmannTest2.Models
{
    [Keyless]
    public partial class Icd
    {
        public string? IK { get; set; }
        public string? Entlassender_Standort { get; set; }
        public string? Entgeltbereich { get; set; }
        public string? KH_internes_Kennzeichen { get; set; }
        public string? Diagnoseart { get; set; }
        public string? ICD_Version { get; set; }
        public string? ICD_Kode { get; set; }
        public string? Lokalisation { get; set; }
        public string? Diagnosensicherheit { get; set; }
        public string? Sekundaer_Kode { get; set; }
   

    }
    
}
