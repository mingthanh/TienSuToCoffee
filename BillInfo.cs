//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TienSuToCoffee
{
    using System;
    using System.Collections.Generic;
    
    public partial class BillInfo
    {
        public int id { get; set; }
        public Nullable<int> idBill { get; set; }
        public Nullable<int> idFood { get; set; }
        public Nullable<int> count { get; set; }
    
        public virtual BILL BILL { get; set; }
        public virtual Food Food { get; set; }
    }
}
