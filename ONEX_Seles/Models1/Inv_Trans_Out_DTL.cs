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
    
    public partial class Inv_Trans_Out_DTL
    {
        public long ID { get; set; }
        public long Serial { get; set; }
        public long Bill_Code { get; set; }
        public string Itm_Code { get; set; }
        public string MnGrp_Code { get; set; }
        public string Unt_Code { get; set; }
        public float Unt_Size { get; set; }
        public Nullable<int> Stor_Code { get; set; }
        public string Batch_Num { get; set; }
        public string ExpireDT { get; set; }
        public float Qty { get; set; }
        public Nullable<float> AVG_Cost { get; set; }
        public float Itm_Price { get; set; }
        public Nullable<float> Itm_Total { get; set; }
        public string CC_Code { get; set; }
        public string Proj_Code { get; set; }
        public Nullable<float> Amount_inStore { get; set; }
        public string Note { get; set; }
        public string AdUser { get; set; }
        public string AdDate { get; set; }
        public Nullable<int> Rec_Seq { get; set; }
        public Nullable<float> Final_Total { get; set; }
    
        public virtual Inv_Trans_Out_MST Inv_Trans_Out_MST { get; set; }
    }
}
