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
    
    public partial class T_MeetingRoom
    {
        public int ID { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public string MeetingTheme { get; set; }
        public string Host { get; set; }
        public string MeetingRoom { get; set; }
        public int PeopleNum { get; set; }
        public string Memo { get; set; }
        public string PostName { get; set; }
        public System.DateTime PostTime { get; set; }
        public int Status { get; set; }
        public int Step { get; set; }
        public string CurrentApprove { get; set; }
        public int IsDelete { get; set; }
    }
}
