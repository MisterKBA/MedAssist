using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class ModelSelectHeureRDVMPlan
    {
        public int IDPlanningMED { get; set; }
        public System.DateTime JourDePressence { get; set; }
        public System.TimeSpan HeureDebutJournee { get; set; }
        public System.TimeSpan HeureDebutAprem { get; set; }
    }
}
