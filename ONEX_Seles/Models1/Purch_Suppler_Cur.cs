//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ONEX_Seles.Models1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Purch_Suppler_Cur
    {
        public int ID { get; set; }
        public string S_Code { get; set; }
        public string Cur_Code { get; set; }
        public Nullable<bool> Used { get; set; }
        public Nullable<float> Limit_DAmount { get; set; }
        public Nullable<float> Limit_CAmount { get; set; }
    
        public virtual Purch_Supplers Purch_Supplers { get; set; }
    }
}
