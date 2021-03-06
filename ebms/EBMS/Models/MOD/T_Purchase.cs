﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EBMS.Models
{
    [MetadataType(typeof(MOD))]
    public partial class T_Purchase
    {
        class MOD
        {
            [Display(Name = "主键")]
            public int ID { get; set; }
             [Display(Name = "申请人")]
            public string ApplyName { get; set; }
                  [Display(Name = "申请部门")]
            public string ApplyDepartment { get; set; }
                [Display(Name = "申请备注")]
            public string ApplyReason { get; set; }
              [Display(Name = "采购批号")]
            public string PurchaseOddNum { get; set; }
             [Display(Name = "支付帐号")]
            public string Payment { get; set; }
             [Display(Name = "收货仓库")]
            public string Warehouse { get; set; }
                 [Display(Name = "应付金额")]
            public Nullable<decimal> CopelPay { get; set; }
                [Display(Name = "申请时间")]
            public System.DateTime ApplyDate { get; set; }
            [Display(Name = "支付方式")]
            public string paymentMode { get; set; }
               [Display(Name = "审批状态")]
            public int Status { get; set; }
              [Display(Name = "审批步奏")]
            public int Step { get; set; }
              [Display(Name = "是否删除")]
            public int IsDelete { get; set; }
                   [Display(Name = "是否完成付款")]
            public Nullable<int> Ispayment { get; set; }
                    [Display(Name = "是否完成收货")]
            public Nullable<int> IsReceived { get; set; }
                   [Display(Name = "实付金额")]
            public Nullable<decimal> ActualPay { get; set; }
                   [Display(Name = "审核人")]
                   public Nullable<decimal> ApproveFirst { get; set; }
        }
    }
}











