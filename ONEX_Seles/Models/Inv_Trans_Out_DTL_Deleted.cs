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
    
    public partial class Inv_Trans_Out_DTL_Deleted
    {
        public long ID { get; set; }
        public string DTL_Code { get; set; }
        public Nullable<long> Serial { get; set; }
        public Nullable<long> Bill_Code { get; set; }
        public string Itm_Code { get; set; }
        public string Unt_Code { get; set; }
        public Nullable<float> Unt_Size { get; set; }
        public string Batch_Num { get; set; }
        public Nullable<int> Stor_Code { get; set; }
        public string CC_Code { get; set; }
        public string Proj_Code { get; set; }
        public Nullable<float> Qty { get; set; }
        public string ExpireDT { get; set; }
        public Nullable<float> Itm_Price { get; set; }
        public Nullable<float> Amount_inStore { get; set; }
        public Nullable<bool> isTaxed { get; set; }
        public Nullable<float> Tax_Percent { get; set; }
        public Nullable<float> Tax_Value { get; set; }
        public Nullable<float> Itm_Total { get; set; }
        public string Notes { get; set; }
        public Nullable<int> State { get; set; }
        public string AdUser { get; set; }
        public string AdDate { get; set; }
    }
}
