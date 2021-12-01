using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class ModelSelectPatientRDV
    {
        public int IDPlanningRDV { get; set; }
        public System.DateTime date { get; set; }
        public Nullable<System.TimeSpan> heure { get; set; }
        public int IDSPecialite { get; set; }
        public int IDLocal { get; set; }
        public int IDMaisonM { get; set; }
        public string Specialite { get; set; }
        public string local { get; set; }
        public string Maison { get; set; }
        public string Medecin { get; set; }
        public int IDMedecin { get; set; }
        public int IDConsultation { get; set; }
        
    }
}
