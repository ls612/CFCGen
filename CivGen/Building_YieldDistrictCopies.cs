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
    
    public partial class Building_YieldDistrictCopies
    {
        public string BuildingType { get; set; }
        public string OldYieldType { get; set; }
        public string NewYieldType { get; set; }
    
        public virtual Yield Yield { get; set; }
        public virtual Yield Yield1 { get; set; }
        public virtual Building Building { get; set; }
    }
}
