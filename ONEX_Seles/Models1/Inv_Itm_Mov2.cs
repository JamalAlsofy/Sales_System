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
    
    public partial class Inv_Itm_Mov2
    {
        public long ID { get; set; }
        public string Trns_Type { get; set; }
        public string Trns_CodeNo { get; set; }
        public string Trns_Serial { get; set; }
        public string Trns_DT { get; set; }
        public Nullable<int> C_Date { get; set; }
        public Nullable<int> C_Time { get; set; }
        public string DM_Serial { get; set; }
        public string DM_Code { get; set; }
        public Nullable<int> DM_Rec_Seq { get; set; }
        public string Cur_Code { get; set; }
        public Nullable<float> Cur_Rate { get; set; }
        public string Itm_Code { get; set; }
        public string Unt_Code { get; set; }
        public Nullable<float> Unt_Size { get; set; }
        public string Stor_Code { get; set; }
        public string Batch_Num { get; set; }
        public string ExpireDT { get; set; }
        public Nullable<float> SizeQty_in { get; set; }
        public Nullable<float> SizeQty_out { get; set; }
        public Nullable<float> Qnty_In { get; set; }
        public Nullable<float> Qnty_Out { get; set; }
        public Nullable<float> QtyFree_in { get; set; }
        public Nullable<float> QtyFree_out { get; set; }
        public Nullable<decimal> Itm_Cost { get; set; }
        public Nullable<decimal> AVG_Cost { get; set; }
        public Nullable<decimal> Total_Cost { get; set; }
        public Nullable<decimal> Total_Discount_In { get; set; }
        public Nullable<decimal> Expenses_In { get; set; }
        public string CC_Code { get; set; }
        public string Proj_Code { get; set; }
        public Nullable<bool> isItm_EffectStore { get; set; }
        public Nullable<bool> EffectedOnStore { get; set; }
        public string Ref { get; set; }
        public string T_Desc { get; set; }
        public string Machine_Code { get; set; }
        public string Machine_Nm { get; set; }
        public Nullable<int> Brn_Code { get; set; }
        public string AdUser { get; set; }
        public string AdDate { get; set; }
        public string EditUser { get; set; }
        public string EditDate { get; set; }
        public Nullable<decimal> Stor_AVG_Cost { get; set; }
        public Nullable<float> Stor_QntyByBatch { get; set; }
        public Nullable<float> Stor_QntyByExpireDT { get; set; }
        public Nullable<float> Stor_Qnty { get; set; }
        public Nullable<float> Stor_Qnty_OfStor { get; set; }
        public Nullable<float> Stor_Qnty_All_ByBatch { get; set; }
        public Nullable<float> Stor_Qnty_All_ByExpireDT { get; set; }
        public Nullable<float> Stor_Qnty_All_ByBatchExpire { get; set; }
        public Nullable<float> Stor_Qnty_All { get; set; }
        public Nullable<decimal> Final_Total { get; set; }
    }
}
