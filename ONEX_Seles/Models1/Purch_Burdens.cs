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
    
    public partial class Purch_Burdens
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string NmAr { get; set; }
        public string NmEn { get; set; }
        public string Acc_Code { get; set; }
        public Nullable<int> Brdn_Type { get; set; }
        public Nullable<int> Effect_Type { get; set; }
        public string Cur_Code { get; set; }
        public Nullable<int> Brdn_Cls { get; set; }
        public Nullable<float> Brdn_Value { get; set; }
        public Nullable<bool> Allow_Return { get; set; }
        public string Note { get; set; }
        public string AdUser { get; set; }
        public string AdDate { get; set; }
        public string EditUser { get; set; }
        public string EditDate { get; set; }
    }
}