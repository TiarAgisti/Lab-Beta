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
    
    public partial class Sender
    {
        public int ID { get; set; }
        public string SenderName { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public int Location_ID { get; set; }
        public string TelpHome { get; set; }
        public string TelpWork { get; set; }
        public string Email { get; set; }
        public Nullable<double> Discount { get; set; }
        public int AccountBankID { get; set; }
        public int MethodPaymentID { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public Nullable<int> UserCreate { get; set; }
        public Nullable<System.DateTime> DateCreate { get; set; }
        public Nullable<int> UserModify { get; set; }
        public Nullable<System.DateTime> DateModify { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}
