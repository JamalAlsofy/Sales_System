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
    
    public partial class Purch_Invoice_DTL_Deleted
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
        public Nullable<float> Qty_Free { get; set; }
        public string ExpireDT { get; set; }
        public Nullable<float> Itm_Price { get; set; }
        public Nullable<float> Amount_inStore { get; set; }
        public Nullable<float> ProfRate { get; set; }
        public Nullable<float> SalePrice { get; set; }
        public Nullable<float> Discount { get; set; }
        public Nullable<float> Discount_Percent { get; set; }
        public Nullable<float> Discount2 { get; set; }
        public Nullable<float> Discount2_Percent { get; set; }
        public Nullable<float> Discount3 { get; set; }
        public Nullable<float> Discount3_Percent { get; set; }
        public Nullable<float> Total_Discount { get; set; }
        public Nullable<float> Expenses { get; set; }
        public Nullable<float> Expenses_Percent { get; set; }
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