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
    
    public partial class District_GreatPersonPoints
    {
        public string DistrictType { get; set; }
        public string GreatPersonClassType { get; set; }
        public long PointsPerTurn { get; set; }
    
        public virtual GreatPersonClass GreatPersonClass { get; set; }
        public virtual District District { get; set; }
    }
}
