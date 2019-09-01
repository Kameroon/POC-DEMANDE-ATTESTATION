using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POC_DEMANDE_ATTESTATION.Models
{
    public class DemandeAttestation
    {
        public string Date { get; set; }
        public string NomPrenom { get; set; }

        public string Objet { get; set; }

        public string Statut { get; set; }

        public string Controller { get; set; }
        public string Action { get; set; }
    }
}