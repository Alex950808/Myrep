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
    
    public partial class T_InterceptApprove
    {
        public int ID { get; set; }
        public int Pid { get; set; }
        public string ApproveName { get; set; }
        public string ApproveUser { get; set; }
        public int ApproveStatus { get; set; }
        public Nullable<System.DateTime> ApproveTime { get; set; }
        public string Memo { get; set; }
    }
}
