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
    
    public partial class BonusMinorStartingUnit
    {
        public string Unit { get; set; }
        public string Era { get; set; }
        public long Quantity { get; set; }
    
        public virtual Unit Unit1 { get; set; }
        public virtual Era Era1 { get; set; }
    }
}
