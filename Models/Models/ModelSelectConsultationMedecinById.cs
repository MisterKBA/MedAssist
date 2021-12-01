using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class ModelSelectConsultationMedecinById
    {
        public int IDPlanningMED { get; set; }
        public System.DateTime JourDePressence { get; set; }
        public int IDPatient { get; set; }
        public string patient { get; set; }
        public string Prenom { get; set; }
        public int IDConsultation { get; set; }
        public Nullable<System.TimeSpan> DebutConsulation { get; set; }
        public Nullable<System.TimeSpan> FinConsultation { get; set; }
        public int IDSPecialite { get; set; }
        public string specialite { get; set; }
        public int IDMaisonM { get; set; }
        public string Nom { get; set; }
    }
}
