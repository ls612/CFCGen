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
    
    public partial class Building_GreatWorks
    {
        public string BuildingType { get; set; }
        public string GreatWorkSlotType { get; set; }
        public long NumSlots { get; set; }
        public bool ThemingUniquePerson { get; set; }
        public bool ThemingSameObjectType { get; set; }
        public bool ThemingUniqueCivs { get; set; }
        public bool ThemingSameEras { get; set; }
        public long ThemingYieldMultiplier { get; set; }
        public long ThemingTourismMultiplier { get; set; }
        public long NonUniquePersonYield { get; set; }
        public long NonUniquePersonTourism { get; set; }
        public string ThemingBonusDescription { get; set; }
    
        public virtual GreatWorkSlotType GreatWorkSlotType1 { get; set; }
        public virtual Building Building { get; set; }
    }
}
