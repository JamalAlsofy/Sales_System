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
    
    public partial class vw_rep_Sal_InvoiceMST
    {
        public long ID { get; set; }
        public string BRN_NmAr { get; set; }
        public long Serial { get; set; }
        public long Bill_Code { get; set; }
        public string ProcessType { get; set; }
        public string InvoiceDate { get; set; }
        public string WorthDate { get; set; }
        public string Cur_NmAr { get; set; }
        public string Cash_Bank_S_NmAr { get; set; }
        public string Ref { get; set; }
        public float Bill_Amount { get; set; }
        public float Bill_Disc { get; set; }
        public float Bill_Taxs { get; set; }
        public float Bill_Total { get; set; }
        public string Description { get; set; }
        public int Brn_Code { get; set; }
        public int ProcType { get; set; }
        public Nullable<int> Cash_Bnk_No { get; set; }
        public string Acc_Code { get; set; }
        public Nullable<int> Cur_Code { get; set; }
        public Nullable<int> C_Code { get; set; }
        public string C_Acc_Code { get; set; }
        public string Symbol { get; set; }
        public float NetAmount { get; set; }
        public string AdUser { get; set; }
        public string AdDate { get; set; }
        public float Bill_Itm_Disc { get; set; }
        public Nullable<float> TransPrice { get; set; }
        public string C_NmAr { get; set; }
        public Nullable<int> G_Code { get; set; }
        public Nullable<int> Type_Code { get; set; }
        public Nullable<int> Dgree_Code { get; set; }
        public Nullable<bool> isTaxed { get; set; }
        public Nullable<int> TaxType { get; set; }
        public string Tax_Num { get; set; }
        public Nullable<int> Country { get; set; }
        public Nullable<int> City { get; set; }
        public Nullable<int> Area { get; set; }
        public string adrs { get; set; }
        public string Phone { get; set; }
    }
}
