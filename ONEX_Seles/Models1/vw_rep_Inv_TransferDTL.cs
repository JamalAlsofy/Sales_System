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
    
    public partial class vw_rep_Inv_TransferDTL
    {
        public long ID { get; set; }
        public long Serial { get; set; }
        public long Bill_Code { get; set; }
        public string Itm_Code { get; set; }
        public string Itm_NmAr { get; set; }
        public string Unt_NmAr { get; set; }
        public string Batch_Num { get; set; }
        public float Qty { get; set; }
        public string ExpireDT { get; set; }
        public float Itm_Price { get; set; }
        public Nullable<float> Amount_inStore { get; set; }
        public Nullable<float> Itm_Total { get; set; }
        public string Note { get; set; }
        public Nullable<int> Rec_Seq { get; set; }
        public Nullable<int> Stor_Code { get; set; }
        public string Stor_NmAr { get; set; }
        public string Stor_Code_To { get; set; }
        public string Stor_To_NmAr { get; set; }
        public string Unt_Code { get; set; }
        public float Unt_Size { get; set; }
        public string MnGrp_NmAr { get; set; }
        public string MnGrp_Code { get; set; }
        public string CC_Code { get; set; }
        public string CC_NmAr { get; set; }
        public string Proj_Code { get; set; }
        public string Proj_NmAr { get; set; }
        public string BRN_Code { get; set; }
        public Nullable<int> TransferType { get; set; }
        public string BRN_NmAr { get; set; }
        public string Cur_Code { get; set; }
        public Nullable<float> Cur_Rate { get; set; }
        public string Process_Date { get; set; }
        public Nullable<int> InvoiceMonth { get; set; }
        public Nullable<int> InvoiceYear { get; set; }
        public string Ref { get; set; }
        public string Cur_NmAr { get; set; }
        public string Symbol { get; set; }
        public string Col_Code { get; set; }
        public string Col_Name { get; set; }
        public Nullable<float> Bill_Total { get; set; }
        public string description { get; set; }
        public string ItmTyp_Code { get; set; }
        public string Cls_Code { get; set; }
        public string FavGrp_Code { get; set; }
        public Nullable<float> AVG_Cost { get; set; }
        public Nullable<float> Qty_Available_From { get; set; }
        public Nullable<float> Qty_Available_To { get; set; }
        public string AdUser { get; set; }
        public string AdDate { get; set; }
        public Nullable<float> Final_Total { get; set; }
        public string TransferType_NmAr { get; set; }
        public string Itm_Prps { get; set; }
        public Nullable<float> Qty_Received { get; set; }
        public string Stor_Code_From { get; set; }
        public string Reason { get; set; }
        public Nullable<bool> isUsed { get; set; }
        public Nullable<bool> isPending { get; set; }
        public Nullable<bool> isPosted { get; set; }
        public Nullable<bool> isReceived { get; set; }
        public Nullable<int> Doc_Type { get; set; }
        public string Broker_Acc_Code { get; set; }
    }
}
