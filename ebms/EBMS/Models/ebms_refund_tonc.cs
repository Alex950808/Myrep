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
    
    public partial class ebms_refund_tonc
    {
        public int ID { get; set; }
        public Nullable<int> oid { get; set; }
        public Nullable<System.DateTime> refundabledate { get; set; }
        public string shop_no { get; set; }
        public string ordernumber { get; set; }
        public string goods_name { get; set; }
        public string goods_no { get; set; }
        public Nullable<int> qty { get; set; }
        public Nullable<decimal> share_amount { get; set; }
        public string refundablehouse { get; set; }
        public string retreat_isrefund { get; set; }
        public string retreat_Isreturn { get; set; }
        public string retreat_deliverstatus { get; set; }
        public Nullable<int> IsInsertToNC { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<int> typ { get; set; }
        public string Reason { get; set; }
        public Nullable<System.DateTime> CreatTime { get; set; }
        public Nullable<System.DateTime> times { get; set; }
    }
}
