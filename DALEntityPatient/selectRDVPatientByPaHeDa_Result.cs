//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DALEntityPatient
{
    using System;
    
    public partial class selectRDVPatientByPaHeDa_Result
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
