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
    
    public partial class Sales_Refund_Invoice_DTL
    {
        public long ID { get; set; }
        public long Serial { get; set; }
        public long Bill_Code { get; set; }
        public string Itm_Code { get; set; }
        public string MnGrp_Code { get; set; }
        public string Unt_Code { get; set; }
        public float Unt_Size { get; set; }
        public Nullable<long> Refund_Bill_Serial { get; set; }
        public long Refund_Bill_Code { get; set; }
        public int Stor_Code { get; set; }
        public string ExpireDT { get; set; }
        public string Batch_Num { get; set; }
        public float Qty { get; set; }
        public float Qty_free { get; set; }
        public float Qty_Total { get; set; }
        public float Qty_Refunded { get; set; }
        public float Itm_Price { get; set; }
        public Nullable<float> Itm_Total { get; set; }
        public float Tax_Percent { get; set; }
        public float Tax_Value { get; set; }
        public Nullable<float> Total_Discount { get; set; }
        public Nullable<float> Discount_addational { get; set; }
        public float TheTotal { get; set; }
        public Nullable<float> Amount_InStore { get; set; }
        public float AVG_Cost { get; set; }
        public Nullable<int> CC_Code { get; set; }
        public Nullable<int> Proj_Code { get; set; }
        public string Note { get; set; }
        public float Discount { get; set; }
        public float Discount_Percent { get; set; }
        public float Discount2 { get; set; }
        public float Discount2_Percent { get; set; }
        public float Discount3 { get; set; }
        public float Discount3_Percent { get; set; }
        public float Prof_Value { get; set; }
        public float Prof_Percent { get; set; }
        public string AdUser { get; set; }
        public string AdDate { get; set; }
        public Nullable<int> Rec_Seq { get; set; }
        public Nullable<float> Final_Total { get; set; }
    
        public virtual Sales_Refund_Invoice_MST Sales_Refund_Invoice_MST { get; set; }
    }
}
