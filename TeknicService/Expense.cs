//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeknicService
{
    using System;
    using System.Collections.Generic;
    
    public partial class Expense
    {
        public System.Guid ExpenseID { get; set; }
        public System.DateTime ExpenseDate { get; set; }
        public string ExpenseCategory { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string Payee { get; set; }
        public string ReceiptNumber { get; set; }
        public string Notes { get; set; }
    }
}
