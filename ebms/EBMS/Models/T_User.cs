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
    
    public partial class T_User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public string Power { get; set; }
        public string Tel { get; set; }
        public string PassWord { get; set; }
        public string DepartmentId { get; set; }
        public string IsManagers { get; set; }
        public Nullable<bool> OffOn { get; set; }
        public string dingID { get; set; }
    }
}