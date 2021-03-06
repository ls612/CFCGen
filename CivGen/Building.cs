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
    
    public partial class Building
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Building()
        {
            this.Boosts = new HashSet<Boost>();
            this.Building_GreatPersonPoints = new HashSet<Building_GreatPersonPoints>();
            this.Building_GreatWorks = new HashSet<Building_GreatWorks>();
            this.Building_YieldChanges = new HashSet<Building_YieldChanges>();
            this.Building_YieldDistrictCopies = new HashSet<Building_YieldDistrictCopies>();
            this.BuildingModifiers = new HashSet<BuildingModifier>();
            this.GreatPersonIndividuals = new HashSet<GreatPersonIndividual>();
            this.Projects = new HashSet<Project>();
            this.StartingBuildings = new HashSet<StartingBuilding>();
            this.Unit_BuildingPrereqs = new HashSet<Unit_BuildingPrereqs>();
            this.Features = new HashSet<Feature>();
            this.Features1 = new HashSet<Feature>();
            this.Terrains = new HashSet<Terrain>();
            this.Buildings1 = new HashSet<Building>();
            this.Buildings = new HashSet<Building>();
            this.Buildings11 = new HashSet<Building>();
            this.Buildings12 = new HashSet<Building>();
            this.Buildings2 = new HashSet<Building>();
        }
    
        public string BuildingType { get; set; }
        public string Name { get; set; }
        public string PrereqTech { get; set; }
        public string PrereqCivic { get; set; }
        public long Cost { get; set; }
        public long MaxPlayerInstances { get; set; }
        public long MaxWorldInstances { get; set; }
        public bool Capital { get; set; }
        public string PrereqDistrict { get; set; }
        public string AdjacentDistrict { get; set; }
        public string Description { get; set; }
        public bool RequiresPlacement { get; set; }
        public bool RequiresRiver { get; set; }
        public Nullable<long> OuterDefenseHitPoints { get; set; }
        public long Housing { get; set; }
        public long Entertainment { get; set; }
        public string AdjacentResource { get; set; }
        public Nullable<bool> Coast { get; set; }
        public bool EnabledByReligion { get; set; }
        public bool AllowsHolyCity { get; set; }
        public string PurchaseYield { get; set; }
        public bool MustPurchase { get; set; }
        public long Maintenance { get; set; }
        public bool IsWonder { get; set; }
        public string TraitType { get; set; }
        public long OuterDefenseStrength { get; set; }
        public Nullable<long> CitizenSlots { get; set; }
        public bool MustBeLake { get; set; }
        public bool MustNotBeLake { get; set; }
        public long RegionalRange { get; set; }
        public bool AdjacentToMountain { get; set; }
        public string ObsoleteEra { get; set; }
        public bool RequiresReligion { get; set; }
        public long GrantFortification { get; set; }
        public long DefenseModifier { get; set; }
        public bool InternalOnly { get; set; }
        public bool RequiresAdjacentRiver { get; set; }
        public string Quote { get; set; }
        public string QuoteAudio { get; set; }
        public bool MustBeAdjacentLand { get; set; }
        public string AdvisorType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Boost> Boosts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Building_GreatPersonPoints> Building_GreatPersonPoints { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Building_GreatWorks> Building_GreatWorks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Building_YieldChanges> Building_YieldChanges { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Building_YieldDistrictCopies> Building_YieldDistrictCopies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuildingModifier> BuildingModifiers { get; set; }
        public virtual Type Type { get; set; }
        public virtual Trait Trait { get; set; }
        public virtual Yield Yield { get; set; }
        public virtual Civic Civic { get; set; }
        public virtual Resource Resource { get; set; }
        public virtual Technology Technology { get; set; }
        public virtual District District { get; set; }
        public virtual District District1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GreatPersonIndividual> GreatPersonIndividuals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Project> Projects { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StartingBuilding> StartingBuildings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Unit_BuildingPrereqs> Unit_BuildingPrereqs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feature> Features { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feature> Features1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Terrain> Terrains { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Building> Buildings1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Building> Buildings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Building> Buildings11 { get; set; }
        public virtual Building Building1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Building> Buildings12 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Building> Buildings2 { get; set; }
    }
}
