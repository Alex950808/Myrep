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
    
    public partial class T_LossReportDetail
    {
        public int ID { get; set; }
        public Nullable<int> Oid { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string WangWang { get; set; }
        public string OderNumber { get; set; }
        public string Reason { get; set; }
        public string Unit { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public decimal Amount { get; set; }
        public string Note { get; set; }
        public int Qty { get; set; }
        public string PZ_Department { get; set; }
        public string PZ_Subject { get; set; }
        public Nullable<int> PZ_Direction { get; set; }
    }
}
