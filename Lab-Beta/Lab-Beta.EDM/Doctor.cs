//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab_Beta.EDM
{
    using System;
    using System.Collections.Generic;
    
    public partial class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string Address { get; set; }
        public int Location_ID { get; set; }
        public int BloodGroup_ID { get; set; }
        public int Specialist_Id { get; set; }
        public string TelpHome { get; set; }
        public string TelpWork { get; set; }
        public string Email { get; set; }
        public Nullable<double> Fee { get; set; }
        public int AccountBank_ID { get; set; }
        public int MethodPayment_ID { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public Nullable<int> UserCreate { get; set; }
        public Nullable<System.DateTime> DateCreate { get; set; }
        public Nullable<int> UserModify { get; set; }
        public Nullable<System.DateTime> DateModify { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}
