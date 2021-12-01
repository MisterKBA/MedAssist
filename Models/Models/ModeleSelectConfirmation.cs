using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class ModeleSelectConfirmation
    {
        public int IDPlanningRDV { get; set; }
        public System.DateTime DateRDV { get; set; }
        public Nullable<System.TimeSpan> HeureRDV { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
    }
}
