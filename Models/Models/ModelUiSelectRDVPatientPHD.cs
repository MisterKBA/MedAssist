using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class ModelUiSelectRDVPatientPHD
    {
        public int IDPlanningRDV { get; set; }
        public System.DateTime DateRDV { get; set; }
        public Nullable<System.TimeSpan> HeureRDV { get; set; }
        public int IDLocal { get; set; }
        public string Nom { get; set; }
        public int IDMedecin { get; set; }
        public int IDMaisonM { get; set; }
        public string Local { get; set; }
        public string Prenom_Medecin { get; set; }
        public string Maison { get; set; }
    }
}
