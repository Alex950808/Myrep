//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EBMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class sale_zoAmount_trade_order
    {
        public int ID { get; set; }
        public string Shop_no { get; set; }
        public string Goods_no { get; set; }
        public Nullable<int> num { get; set; }
        public Nullable<decimal> amount { get; set; }
        public Nullable<System.DateTime> startTime { get; set; }
        public Nullable<System.DateTime> endTime { get; set; }
        public string Reason { get; set; }
        public Nullable<int> IsRetrun { get; set; }
        public Nullable<int> IsImport { get; set; }
    }
}
