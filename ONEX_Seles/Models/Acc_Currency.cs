//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ONEX_Seles.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Acc_Currency
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string NmAr { get; set; }
        public string NmEn { get; set; }
        public string Symbol { get; set; }
        public string BrokenAr { get; set; }
        public string BrokenEn { get; set; }
        public bool IsLocal { get; set; }
        public bool IsForeign { get; set; }
        public bool IsStoreCur { get; set; }
        public Nullable<float> TransPrice { get; set; }
        public Nullable<float> MaxTransPrice { get; set; }
        public Nullable<float> MinTransPrice { get; set; }
        public string adUser { get; set; }
        public string adDate { get; set; }
        public string EditUser { get; set; }
        public string EditDate { get; set; }
    }
}
