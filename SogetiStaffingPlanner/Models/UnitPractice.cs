//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SogetiStaffingPlanner.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UnitPractice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UnitPractice()
        {
            this.Positions = new HashSet<Position>();
        }
    
        public int UnitPracticeId { get; set; }
        public int PracticeId { get; set; }
        public int UnitId { get; set; }
        public bool Active { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Position> Positions { get; set; }
        public virtual Practice Practice { get; set; }
        public virtual Unit Unit { get; set; }
    }
}
