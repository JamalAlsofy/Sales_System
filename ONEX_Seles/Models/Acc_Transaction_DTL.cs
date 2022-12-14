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
    
    public partial class Acc_Transaction_DTL
    {
        public int ID { get; set; }
        public Nullable<int> DocType { get; set; }
        public Nullable<long> Serial { get; set; }
        public Nullable<int> Rec_Code { get; set; }
        public string Acc_Code { get; set; }
        public Nullable<bool> IsSub { get; set; }
        public Nullable<short> SubType { get; set; }
        public Nullable<int> Sub_Code { get; set; }
        public string Cur_Code { get; set; }
        public Nullable<float> Cur_Rate { get; set; }
        public Nullable<int> C_Code { get; set; }
        public Nullable<int> Cash_No { get; set; }
        public Nullable<int> Bnk_No { get; set; }
        public Nullable<int> Emp_Code { get; set; }
        public Nullable<int> S_Code { get; set; }
        public Nullable<float> D_Amount { get; set; }
        public Nullable<float> C_Amount { get; set; }
        public Nullable<float> FD_Amount { get; set; }
        public Nullable<float> FC_Amount { get; set; }
        public string T_Desc { get; set; }
        public Nullable<long> Ref { get; set; }
        public string Tagged { get; set; }
        public string CC_Code { get; set; }
        public string Proj_Code { get; set; }
        public Nullable<int> Verify_Code { get; set; }
        public Nullable<int> Mnth { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<int> BRN_No { get; set; }
        public string AdUser { get; set; }
        public string AdDate { get; set; }
        public string Machine_NM { get; set; }
        public string Bnk_CheckNo { get; set; }
        public Nullable<int> WorthType { get; set; }
        public string WorthDate { get; set; }
    
        public virtual Acc_Accounts Acc_Accounts { get; set; }
        public virtual Acc_Transaction_MST Acc_Transaction_MST { get; set; }
    }
}
