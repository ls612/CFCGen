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
    
    public partial class CivilizationLeader
    {
        public string LeaderType { get; set; }
        public string CivilizationType { get; set; }
        public string CapitalName { get; set; }
    
        public virtual Civilization Civilization { get; set; }
        public virtual Leader Leader { get; set; }
    }
}
