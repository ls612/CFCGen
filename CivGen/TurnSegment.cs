//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CivGen
{
    using System;
    using System.Collections.Generic;
    
    public partial class TurnSegment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TurnSegment()
        {
            this.TurnPhases = new HashSet<TurnPhas>();
            this.TurnPhases1 = new HashSet<TurnPhas>();
        }
    
        public string TurnSegmentType { get; set; }
        public string DisplayName { get; set; }
        public string Sound { get; set; }
        public bool AllowStrategicCommands { get; set; }
        public bool AllowTacticalCommands { get; set; }
        public long TimeLimit_Base { get; set; }
        public long TimeLimit_PerCity { get; set; }
        public long TimeLimit_PerUnit { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TurnPhas> TurnPhases { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TurnPhas> TurnPhases1 { get; set; }
    }
}
