//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DalEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Locaux
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Locaux()
        {
            this.DispoLocal = new HashSet<DispoLocal>();
            this.PlanningRDV = new HashSet<PlanningRDV>();
        }
    
        public int IDLocal { get; set; }
        public string Nom { get; set; }
        public int IDMaisonM { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DispoLocal> DispoLocal { get; set; }
        public virtual MaisonMedical MaisonMedical { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanningRDV> PlanningRDV { get; set; }
    }
}
