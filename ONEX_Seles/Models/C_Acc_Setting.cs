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
    
    public partial class C_Acc_Setting
    {
        public int ID { get; set; }
        public Nullable<int> Indexing_Voucher { get; set; }
        public Nullable<int> CCType_Voucher { get; set; }
        public Nullable<bool> CCMust_Voucher { get; set; }
        public Nullable<int> ProjType_Voucher { get; set; }
        public Nullable<bool> ProjMust_Voucher { get; set; }
        public Nullable<int> Indexing_Cashing { get; set; }
        public Nullable<int> CCType_Cashing { get; set; }
        public Nullable<bool> CCMust_Cashing { get; set; }
        public Nullable<int> ProjType_Cashing { get; set; }
        public Nullable<bool> ProjMust_Cashing { get; set; }
        public Nullable<int> Indexing_Jorunal { get; set; }
        public Nullable<bool> AccMultiCash { get; set; }
        public Nullable<bool> AccMultiBnk { get; set; }
    }
}
