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
    
    public partial class BeliefModifier
    {
        public string BeliefType { get; set; }
        public string ModifierID { get; set; }
    
        public virtual Belief Belief { get; set; }
    }
}
