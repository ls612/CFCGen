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
    
    public partial class AiFavoredItem
    {
        public string ListType { get; set; }
        public string Item { get; set; }
        public bool Favored { get; set; }
        public long Value { get; set; }
        public string StringVal { get; set; }
        public string MinDifficulty { get; set; }
        public string MaxDifficulty { get; set; }
    
        public virtual AiListType AiListType { get; set; }
        public virtual Difficulty Difficulty { get; set; }
        public virtual Difficulty Difficulty1 { get; set; }
    }
}
