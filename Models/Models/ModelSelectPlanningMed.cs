using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class ModelSelectPlanningMed
    {
        public System.DateTime JourDePressence { get; set; }
        public System.TimeSpan HeureDebutJournee { get; set; }
        public System.TimeSpan HeureFinMatinee { get; set; }
        public System.TimeSpan HeureDebutAprem { get; set; }
        public System.TimeSpan HeureFinAprem { get; set; }
        public string Nom { get; set; }
        public int IDPlanningMED { get; set; }
    }
}
