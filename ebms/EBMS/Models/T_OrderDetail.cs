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
    
    public partial class T_OrderDetail
    {
        public int id { get; set; }
        public string oid { get; set; }
        public Nullable<int> refund { get; set; }
        public string item_code { get; set; }
        public string item_name { get; set; }
        public string item_simple_name { get; set; }
        public string sku_code { get; set; }
        public string sku_name { get; set; }
        public Nullable<int> qty { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<decimal> amount { get; set; }
        public Nullable<decimal> discount_fee { get; set; }
        public Nullable<decimal> amount_after { get; set; }
        public Nullable<decimal> post_fee { get; set; }
        public string platform_item_name { get; set; }
        public string platform_sku_name { get; set; }
        public string note { get; set; }
        public Nullable<int> ExchangeStatus { get; set; }
        public Nullable<int> ExchangeQty { get; set; }
        public Nullable<int> ReissueStatus { get; set; }
        public Nullable<int> ReissueQty { get; set; }
        public Nullable<int> RetreatStatus { get; set; }
        public Nullable<int> RetreatQty { get; set; }
    }
}
