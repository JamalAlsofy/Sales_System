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
    
    public partial class Sys_UserLog
    {
        public long ID { get; set; }
        public string Domain { get; set; }
        public string DocType { get; set; }
        public string DocDate { get; set; }
        public Nullable<short> C_DocDate { get; set; }
        public string DocDesc { get; set; }
        public string Ref { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> MachineID { get; set; }
    }
}
