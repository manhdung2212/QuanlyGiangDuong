//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolManager.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RoomManagement
    {
        public int ID { get; set; }
        public Nullable<bool> LecturerToClass { get; set; }
        public Nullable<bool> ClassToLearn { get; set; }
        public Nullable<System.DateTime> TimeCheck { get; set; }
        public string NodeResource { get; set; }
        public string Node { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<int> Status { get; set; }
    }
}