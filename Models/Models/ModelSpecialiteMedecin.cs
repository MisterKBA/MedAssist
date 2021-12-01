using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class ModelSpecialiteMedecin
    {
        public int IDMedecin { get; set; }
        public string Nom { get; set; }
        public int IDSPecialite { get; set; }
        public Nullable<int> ExamenDurée { get; set; }
        public int IDMaisonM { get; set; }
        public string NomSpecialite { get; set; }
        public string NomMaison { get; set; }
    }
}
