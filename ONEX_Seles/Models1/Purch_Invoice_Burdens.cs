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
    
    public partial class Purch_Invoice_Burdens
    {
        public int ID { get; set; }
        public long Serial { get; set; }
        public long Bill_Code { get; set; }
        public string Brdn_Code { get; set; }
        public string Brdn_Acc_Code { get; set; }
        public string Brdn_Cur_Code { get; set; }
        public Nullable<float> Brdn_Percent { get; set; }
        public Nullable<float> Brdn_Amount { get; set; }
        public Nullable<float> Brdn_Amount_Bill { get; set; }
        public string AdUser { get; set; }
        public string AdDate { get; set; }
    }
}
