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
    
    public partial class T_Assets
    {
        public string Code { get; set; }
        public string Pic { get; set; }
        public string Name { get; set; }
        public string Spec { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public string Buyer { get; set; }
        public string BuyFrom { get; set; }
        public string Guarantee { get; set; }
        public Nullable<System.DateTime> BuyDate { get; set; }
        public string Department { get; set; }
        public string Owner { get; set; }
        public string Place { get; set; }
        public string Responsible { get; set; }
        public string Memo { get; set; }
        public string Barcode { get; set; }
        public string isDelete { get; set; }
        public string isScrap { get; set; }
        public Nullable<System.DateTime> ScrapDate { get; set; }
        public string TypeCode { get; set; }
    }
}
