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
    
    public partial class Stock
    {
        public int Id { get; set; }
        public string CodeStock { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }
        public string Unit { get; set; }
        public int TypeStockId { get; set; }
        public int GroupStockId { get; set; }
        public System.DateTime ExpDate { get; set; }
        public System.DateTime WarningDate { get; set; }
        public int WarningQty { get; set; }
        public int UserCreate { get; set; }
        public System.DateTime DateCreate { get; set; }
        public Nullable<int> UserModify { get; set; }
        public Nullable<System.DateTime> DateModify { get; set; }
        public Nullable<int> Status { get; set; }
    }
}