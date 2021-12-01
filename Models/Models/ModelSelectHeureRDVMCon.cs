using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class ModelSelectHeureRDVMCon
    {
        public int IDPlanningMED { get; set; }
        public Nullable<System.TimeSpan> DebutConsulation { get; set; }
        public Nullable<System.TimeSpan> FinConsultation { get; set; }
        public int IDConsultation { get; set; }
        public System.TimeSpan HeureDebutAprem { get; set; }
        public System.TimeSpan HeureDebutJournee { get; set; }
    }
}
