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
    
    public partial class T_AR
    {
        public int ID { get; set; }
        public string BillCode { get; set; }
        public string BillCompany { get; set; }
        public string BillType { get; set; }
        public string BillFromCode { get; set; }
        public double BillMoney { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string CreatUser { get; set; }
        public double ReceivedMony { get; set; }
    }
}
