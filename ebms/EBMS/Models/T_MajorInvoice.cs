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
    
    public partial class T_MajorInvoice
    {
        public int ID { get; set; }
        public string ShopName { get; set; }
        public string OrderNumber { get; set; }
        public Nullable<decimal> TheInvoiceAmount { get; set; }
        public string InvoiceContent { get; set; }
        public Nullable<double> Number { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public string Address { get; set; }
        public string CorporateName { get; set; }
        public string TaxNumber { get; set; }
        public string InvoiceAddress { get; set; }
        public string Telephone { get; set; }
        public string BankAccount { get; set; }
        public string BankAddress { get; set; }
        public int Status { get; set; }
        public int Step { get; set; }
        public string Isdelete { get; set; }
        public string PostUser { get; set; }
        public Nullable<System.DateTime> PostDate { get; set; }
        public string GoodsAddress { get; set; }
        public string Remarks { get; set; }
        public string OrderSCode { get; set; }
        public string Invoicetype { get; set; }
    }
}
