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
    
    public partial class C_Purch_Setting
    {
        public int ID { get; set; }
        public Nullable<short> SupplerWithAcc { get; set; }
        public Nullable<int> Indexing_PurchInvoice { get; set; }
        public Nullable<short> Discount_Type { get; set; }
        public Nullable<short> Discount_Calc_Method { get; set; }
        public Nullable<short> Discounts_No { get; set; }
        public Nullable<short> Digit_Num { get; set; }
        public Nullable<int> CCType_PurchInvoice { get; set; }
        public Nullable<bool> CC_Must_PurchInvoice { get; set; }
        public Nullable<int> ProjType_PurchInvoice { get; set; }
        public Nullable<bool> ProjMust_PurchInvoice { get; set; }
        public Nullable<bool> Multi_Stor { get; set; }
        public Nullable<bool> Pricing_By_Purch { get; set; }
        public Nullable<bool> Dsply_Itm_Desc { get; set; }
        public Nullable<bool> Dsply_Itm_Notes { get; set; }
        public Nullable<bool> Use_Batch_Num { get; set; }
        public Nullable<bool> Use_ExpireDT { get; set; }
        public Nullable<bool> Use_Qty_Free { get; set; }
        public Nullable<short> QtyFree_Calc_Method { get; set; }
        public Nullable<bool> UseBillDiscount { get; set; }
        public Nullable<bool> Use_Discount_By_Itm { get; set; }
        public Nullable<bool> UseDiscount1 { get; set; }
        public Nullable<bool> UseDiscount2 { get; set; }
        public Nullable<bool> UseDiscount3 { get; set; }
        public Nullable<bool> Use_Added_Value_Tax { get; set; }
        public Nullable<bool> Get_Dflt_SalePrice { get; set; }
        public Nullable<bool> Get_Dflt_Unt { get; set; }
    }
}
