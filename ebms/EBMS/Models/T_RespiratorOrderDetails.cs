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
    
    public partial class T_RespiratorOrderDetails
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string Company { get; set; }
        public Nullable<int> Number { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<double> Subtotal { get; set; }
        public Nullable<int> OrderID { get; set; }
        public Nullable<int> Ismain { get; set; }
        public Nullable<int> IsGuaranteed { get; set; }
    }
}
