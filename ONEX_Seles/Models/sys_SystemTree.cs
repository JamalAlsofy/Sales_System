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
    
    public partial class sys_SystemTree
    {
        public decimal NodeNo { get; set; }
        public decimal NodeId { get; set; }
        public string NodeTitle_Ar { get; set; }
        public string NodeTitle_En { get; set; }
        public string TreeType { get; set; }
        public string NodeTag { get; set; }
        public Nullable<int> NodeIndex { get; set; }
        public string NodeType { get; set; }
        public bool isDeleted { get; set; }
        public string EntryUserId { get; set; }
        public Nullable<System.DateTime> EntryDateTime { get; set; }
        public string EditUserId { get; set; }
        public Nullable<System.DateTime> EditDateTime { get; set; }
    }
}