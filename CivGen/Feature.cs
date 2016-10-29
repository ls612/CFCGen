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
    
    public partial class Feature
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Feature()
        {
            this.Adjacency_YieldChanges = new HashSet<Adjacency_YieldChanges>();
            this.Feature_AdjacentYields = new HashSet<Feature_AdjacentYields>();
            this.Feature_Removes = new HashSet<Feature_Removes>();
            this.Feature_YieldChanges = new HashSet<Feature_YieldChanges>();
            this.GreatPersonIndividuals = new HashSet<GreatPersonIndividual>();
            this.StartBiasFeatures = new HashSet<StartBiasFeature>();
            this.Buildings = new HashSet<Building>();
            this.Buildings1 = new HashSet<Building>();
            this.Districts = new HashSet<District>();
            this.Features1 = new HashSet<Feature>();
            this.Features = new HashSet<Feature>();
            this.Terrains = new HashSet<Terrain>();
            this.Terrains1 = new HashSet<Terrain>();
            this.Features11 = new HashSet<Feature>();
            this.Features2 = new HashSet<Feature>();
            this.Terrains2 = new HashSet<Terrain>();
            this.Improvements = new HashSet<Improvement>();
            this.Resources = new HashSet<Resource>();
        }
    
        public string FeatureType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Quote { get; set; }
        public bool Coast { get; set; }
        public bool NoCoast { get; set; }
        public bool NoRiver { get; set; }
        public bool NoAdjacentFeatures { get; set; }
        public bool RequiresRiver { get; set; }
        public long MovementChange { get; set; }
        public long SightThroughModifier { get; set; }
        public bool Impassable { get; set; }
        public bool NaturalWonder { get; set; }
        public string RemoveTech { get; set; }
        public bool Removable { get; set; }
        public string AddCivic { get; set; }
        public long DefenseModifier { get; set; }
        public bool AddsFreshWater { get; set; }
        public long Appeal { get; set; }
        public long MinDistanceLand { get; set; }
        public long MaxDistanceLand { get; set; }
        public bool NotNearFeature { get; set; }
        public bool Lake { get; set; }
        public long Tiles { get; set; }
        public bool Adjacent { get; set; }
        public bool NoResource { get; set; }
        public bool DoubleAdjacentTerrainYield { get; set; }
        public bool NotCliff { get; set; }
        public long MinDistanceNW { get; set; }
        public string CustomPlacement { get; set; }
        public bool Forest { get; set; }
        public long AntiquityPriority { get; set; }
        public string QuoteAudio { get; set; }
        public bool Settlement { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adjacency_YieldChanges> Adjacency_YieldChanges { get; set; }
        public virtual Civic Civic { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feature_AdjacentYields> Feature_AdjacentYields { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feature_Removes> Feature_Removes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feature_YieldChanges> Feature_YieldChanges { get; set; }
        public virtual Technology Technology { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GreatPersonIndividual> GreatPersonIndividuals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StartBiasFeature> StartBiasFeatures { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Building> Buildings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Building> Buildings1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<District> Districts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feature> Features1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feature> Features { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Terrain> Terrains { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Terrain> Terrains1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feature> Features11 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feature> Features2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Terrain> Terrains2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Improvement> Improvements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resource> Resources { get; set; }
    }
}
