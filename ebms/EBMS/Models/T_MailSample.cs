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
    
    public partial class T_MailSample
    {
        public int ID { get; set; }
        public string ApplyName { get; set; }
        public Nullable<System.DateTime> ApplyDate { get; set; }
        public string ShopName { get; set; }
        public string DeliverGoodsWarehouse { get; set; }
        public string OrderNumber { get; set; }
        public string GoodsReceiptName { get; set; }
        public string DeliverGoodsReason { get; set; }
        public string GoodsReceiptPhone { get; set; }
        public string GoodsReceiptAddress { get; set; }
        public string ApplyRemarks { get; set; }
        public Nullable<System.DateTime> GoodsReceiptDate { get; set; }
        public string IsReturn { get; set; }
        public string ExpressCode { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> Step { get; set; }
        public Nullable<int> Isdelete { get; set; }
        public string GoodsAddress { get; set; }
    }
}
