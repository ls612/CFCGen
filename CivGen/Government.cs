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
    
    public partial class Government
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Government()
        {
            this.Government_SlotCounts = new HashSet<Government_SlotCounts>();
            this.GovernmentModifiers = new HashSet<GovernmentModifier>();
            this.StartingGovernments = new HashSet<StartingGovernment>();
        }
    
        public string GovernmentType { get; set; }
        public string Name { get; set; }
        public string PrereqCivic { get; set; }
        public string InherentBonusDesc { get; set; }
        public string AccumulatedBonusShortDesc { get; set; }
        public string AccumulatedBonusDesc { get; set; }
        public long OtherGovernmentIntolerance { get; set; }
        public long InfluencePointsPerTurn { get; set; }
        public long InfluencePointsThreshold { get; set; }
        public long InfluenceTokensPerThreshold { get; set; }
        public string BonusType { get; set; }
    
        public virtual Civic Civic { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Government_SlotCounts> Government_SlotCounts { get; set; }
        public virtual GovernmentBonusName GovernmentBonusName { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GovernmentModifier> GovernmentModifiers { get; set; }
        public virtual Type Type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StartingGovernment> StartingGovernments { get; set; }
    }
}
