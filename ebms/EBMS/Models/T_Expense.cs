//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EBMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_Expense
    {
        public int ID { get; set; }
        public string Department { get; set; }
        public string Reun_Reason { get; set; }
        public int ExpenseNextApprove { get; set; }
        public decimal Reun_Cost { get; set; }
        public string PostUser { get; set; }
        public System.DateTime CrateDate { get; set; }
        public string Reun_Code { get; set; }
        public string AccountType { get; set; }
        public string Reun_Bank { get; set; }
        public string Shop { get; set; }
        public string Reun_Name { get; set; }
        public string Car_Number { get; set; }
        public int Status { get; set; }
        public int Step { get; set; }
        public bool IsExpenseMatch { get; set; }
        public int IsExpenseEnclosure { get; set; }
        public Nullable<int> IsDelete { get; set; }
        public Nullable<int> Pz_BXStatus { get; set; }
        public string MatchBorrowNumber { get; set; }
        public string SpendingNumber { get; set; }
        public string SpendingCompany { get; set; }
        public Nullable<int> IsBlending { get; set; }
        public Nullable<int> PrintCount { get; set; }
        public string Pz_BxMemo { get; set; }
        public string Memo { get; set; }
        public string Cashier { get; set; }
        public string ExpStatus { get; set; }
        public string Company { get; set; }
    }
}
