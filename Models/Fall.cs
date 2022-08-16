using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace RestAPI_SaatmannTest2.Models
{

    public partial class Fall
    {
        public string? IK { get; set; }
        public string? Entlassender_Standort { get; set; }
        public string? Entgeltbereich { get; set; }
        [Key]
        public string KH_internes_Kennzeichen { get; set; } = null!;                  // Schluessel
        public string? Versicherten_ID { get; set; }
        public string? Vertragskennzeichen_64b_Modellvorhaben { get; set; }
        public string? IK_der_Krankenkasse { get; set; }
        public string? Geburtsjahr { get; set; }
        public string? Geburtsmonat { get; set; }
        public string? Geschlecht { get; set; }
        public string? PLZ { get; set; }
        public string? Wohnort { get; set; }
        public DateTime? Aufnahmedatum { get; set; }                           // Suchkriterium : Datum [von bis]
        //public string? Aufnahmedatum { get; set; }
        public string? Aufnahmeanlass { get; set; }
        public string? Aufnahmegrund { get; set; }
        public string? Fallzusammenfuehrung { get; set; }
        public string? Fallzusammenfuehrungsgrund { get; set; }
        public string? Aufnahmegewicht { get; set; }
        public string? Entlassungsdatum { get; set; }
        public string? Entlassungsgrund { get; set; }
        public string? Alter_in_Tagen_am_Aufnahmetag { get; set; }
        public string? Alter_in_Jahren_am_Aufnahmetag { get; set; }
        public string? Patientennummer { get; set; }
        public string? Interkurrente_Dialysen { get; set; }
        public string? Beatmungsstunden { get; set; }
        public string? Behandlungsbeginn_vorstationaer { get; set; }
        public string? Behandlungstage_vorstationaer { get; set; }
        public string? Behandlungsende_nachstationaer { get; set; }
        public string? Behandlungstage_nachstationaer { get; set; }
        public string? IK_Verlegungs_KH { get; set; }
        public string? Belegungstage_in_anderem_Entgeltbereich { get; set; }
        public string? Beurlaubungstage_PSY { get; set; }
        public string? Kennung_Besonderer_Fall_Modellvorhaben { get; set; }

    }
}
