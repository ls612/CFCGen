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
    
    public partial class UnitCommand
    {
        public string CommandType { get; set; }
        public string Description { get; set; }
        public string Help { get; set; }
        public string DisabledHelp { get; set; }
        public string Icon { get; set; }
        public string Sound { get; set; }
        public bool VisibleInUI { get; set; }
        public bool HoldCycling { get; set; }
        public string CategoryInUI { get; set; }
        public string InterfaceMode { get; set; }
        public string PrereqTech { get; set; }
        public string PrereqCivic { get; set; }
        public long MaxEra { get; set; }
        public string HotkeyId { get; set; }
    
        public virtual Civic Civic { get; set; }
        public virtual Technology Technology { get; set; }
    }
}
