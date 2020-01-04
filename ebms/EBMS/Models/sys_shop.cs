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
    
    public partial class sys_shop
    {
        public short shop_id { get; set; }
        public short platform_id { get; set; }
        public short sub_platform_id { get; set; }
        public string shop_no { get; set; }
        public string shop_name { get; set; }
        public string pay_account_id { get; set; }
        public short auth_state { get; set; }
        public short push_rds_id { get; set; }
        public short pay_auth_state { get; set; }
        public string account_id { get; set; }
        public string account_nick { get; set; }
        public string app_key { get; set; }
        public string refresh_token { get; set; }
        public string sh_secret { get; set; }
        public System.DateTime auth_time { get; set; }
        public System.DateTime expire_time { get; set; }
        public System.DateTime re_expire_time { get; set; }
        public int freeze_auth_to { get; set; }
        public short wms_check { get; set; }
        public int logistics_id { get; set; }
        public int cod_logistics_id { get; set; }
        public string contact { get; set; }
        public short country { get; set; }
        public int province { get; set; }
        public int city { get; set; }
        public int district { get; set; }
        public string address { get; set; }
        public int address_id { get; set; }
        public string telno { get; set; }
        public string mobile { get; set; }
        public string zip { get; set; }
        public string email { get; set; }
        public string remark { get; set; }
        public string website { get; set; }
        public string prop1 { get; set; }
        public string prop2 { get; set; }
        public short is_hold_enabled { get; set; }
        public short is_nomerge { get; set; }
        public short is_nosplit { get; set; }
        public short is_forbidden_setwarebygoods { get; set; }
        public short is_setwarebygoods { get; set; }
        public short is_undownload_trade { get; set; }
        public string cust_data { get; set; }
        public int group_id { get; set; }
        public short is_topreorder { get; set; }
        public short is_disabled { get; set; }
        public int taobao_shop_id { get; set; }
        public int invoice_payee_id { get; set; }
        public int invoice_provider_id { get; set; }
        public short logistics_sync_delay { get; set; }
        public System.DateTime modified { get; set; }
        public System.DateTime created { get; set; }
        public string forbidden_logistics_list { get; set; }
        public int shop_priority { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> typ { get; set; }
        public Nullable<int> InUse { get; set; }
    
        public virtual dict_platform dict_platform { get; set; }
    }
}
