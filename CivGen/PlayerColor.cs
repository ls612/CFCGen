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
    
    public partial class PlayerColor
    {
        public string Type { get; set; }
        public string Usage { get; set; }
        public string PrimaryColor { get; set; }
        public string SecondaryColor { get; set; }
        public string TextColor { get; set; }
    
        public virtual Color Color { get; set; }
        public virtual Color Color1 { get; set; }
        public virtual Color Color2 { get; set; }
    }
}
