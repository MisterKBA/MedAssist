using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class ModelSelectPatient
    {
        public int IDPatient { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public Nullable<System.DateTime> DateDeNaissance { get; set; }
    }
}
