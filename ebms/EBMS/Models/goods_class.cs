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
    
    public partial class goods_class
    {
        public int class_id { get; set; }
        public int parent_id { get; set; }
        public short is_leaf { get; set; }
        public string class_name { get; set; }
        public string path { get; set; }
        public System.DateTime modified { get; set; }
        public System.DateTime created { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    }
}
