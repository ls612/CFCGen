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
    
    public partial class StrategyCondition
    {
        public string StrategyType { get; set; }
        public string ConditionFunction { get; set; }
        public long ThresholdValue { get; set; }
        public bool Disqualifier { get; set; }
        public bool Exclusive { get; set; }
    
        public virtual Strategy Strategy { get; set; }
    }
}
