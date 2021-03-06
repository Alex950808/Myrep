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
    
    public partial class goods_spec
    {
        public int spec_id { get; set; }
        public int goods_id { get; set; }
        public int tax_code_id { get; set; }
        public string spec_no { get; set; }
        public string spec_code { get; set; }
        public string barcode { get; set; }
        public string spec_name { get; set; }
        public short is_allow_neg_stock { get; set; }
        public short is_not_need_examine { get; set; }
        public short is_not_use_air { get; set; }
        public short is_sn_enable { get; set; }
        public short is_single_batch { get; set; }
        public decimal lowest_price { get; set; }
        public decimal retail_price { get; set; }
        public decimal wholesale_price { get; set; }
        public decimal member_price { get; set; }
        public decimal market_price { get; set; }
        public decimal custom_price1 { get; set; }
        public decimal custom_price2 { get; set; }
        public int sale_score { get; set; }
        public int pack_score { get; set; }
        public int pick_score { get; set; }
        public int validity_days { get; set; }
        public int sales_days { get; set; }
        public int receive_days { get; set; }
        public decimal weight { get; set; }
        public decimal length { get; set; }
        public decimal width { get; set; }
        public decimal height { get; set; }
        public string washing_label { get; set; }
        public decimal tax_rate { get; set; }
        public short large_type { get; set; }
        public int unit { get; set; }
        public int aux_unit { get; set; }
        public string prop1 { get; set; }
        public string prop2 { get; set; }
        public string prop3 { get; set; }
        public string prop4 { get; set; }
        public string prop5 { get; set; }
        public string prop6 { get; set; }
        public int flag_id { get; set; }
        public short is_zero_cost { get; set; }
        public short is_lower_cost { get; set; }
        public string img_url { get; set; }
        public string img_key { get; set; }
        public short barcode_count { get; set; }
        public short plat_spec_count { get; set; }
        public string remark { get; set; }
        public int deleted { get; set; }
        public System.DateTime modified { get; set; }
        public System.DateTime created { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    }
}
