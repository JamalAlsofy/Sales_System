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
    
    public partial class Sys_Users
    {
        public int ID { get; set; }
        public string User_id { get; set; }
        public string NmAr { get; set; }
        public string NmEn { get; set; }
        public string UserName { get; set; }
        public string Pass { get; set; }
        public Nullable<bool> UseLoginLimit { get; set; }
        public string Start_Login { get; set; }
        public Nullable<int> C_Start_Login { get; set; }
        public string End_Login { get; set; }
        public Nullable<int> C_End_Login { get; set; }
        public Nullable<int> User_group { get; set; }
        public Nullable<int> REP_Form { get; set; }
        public Nullable<int> Perm_N { get; set; }
        public Nullable<bool> State { get; set; }
        public string Note { get; set; }
        public string AdUser { get; set; }
        public string AdDate { get; set; }
        public string EditUser { get; set; }
        public string EditDate { get; set; }
    
        public virtual Sys_Users Sys_Users1 { get; set; }
        public virtual Sys_Users Sys_Users2 { get; set; }
    }
}
