﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EBMSEntities : DbContext
    {
        public EBMSEntities()
            : base("name=EBMSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DEMO_REGION> DEMO_REGION { get; set; }
        public virtual DbSet<Lm_Expresstest> Lm_Expresstest { get; set; }
        public virtual DbSet<R_Basics> R_Basics { get; set; }
        public virtual DbSet<R_Basics_Education> R_Basics_Education { get; set; }
        public virtual DbSet<R_Basics_Family> R_Basics_Family { get; set; }
        public virtual DbSet<R_Basics_Relative> R_Basics_Relative { get; set; }
        public virtual DbSet<R_Basics_Reward> R_Basics_Reward { get; set; }
        public virtual DbSet<R_Basics_Title> R_Basics_Title { get; set; }
        public virtual DbSet<R_Basics_WorkExperience> R_Basics_WorkExperience { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<T_AccountantProject> T_AccountantProject { get; set; }
        public virtual DbSet<T_AliExpressOrder> T_AliExpressOrder { get; set; }
        public virtual DbSet<T_AliSumai> T_AliSumai { get; set; }
        public virtual DbSet<T_AliSumaiConfig> T_AliSumaiConfig { get; set; }
        public virtual DbSet<T_AliSumaiGoods> T_AliSumaiGoods { get; set; }
        public virtual DbSet<T_AliSumaiShip> T_AliSumaiShip { get; set; }
        public virtual DbSet<T_AP> T_AP { get; set; }
        public virtual DbSet<T_AR> T_AR { get; set; }
        public virtual DbSet<T_AreaSubsidyCost> T_AreaSubsidyCost { get; set; }
        public virtual DbSet<T_Assets> T_Assets { get; set; }
        public virtual DbSet<T_Assets1> T_Assets1 { get; set; }
        public virtual DbSet<T_AssetsApprove> T_AssetsApprove { get; set; }
        public virtual DbSet<T_AssetsChange> T_AssetsChange { get; set; }
        public virtual DbSet<T_AssetsConfig> T_AssetsConfig { get; set; }
        public virtual DbSet<T_AssetsReason> T_AssetsReason { get; set; }
        public virtual DbSet<T_AssetsTransferApply> T_AssetsTransferApply { get; set; }
        public virtual DbSet<T_AssetsTransferRecord> T_AssetsTransferRecord { get; set; }
        public virtual DbSet<T_AssetsType> T_AssetsType { get; set; }
        public virtual DbSet<T_BalanceCost> T_BalanceCost { get; set; }
        public virtual DbSet<T_Borrow> T_Borrow { get; set; }
        public virtual DbSet<T_BorrowApprove> T_BorrowApprove { get; set; }
        public virtual DbSet<T_BorrowApproveConfig> T_BorrowApproveConfig { get; set; }
        public virtual DbSet<T_BorrowGoods> T_BorrowGoods { get; set; }
        public virtual DbSet<T_BorrowGoodsApprove> T_BorrowGoodsApprove { get; set; }
        public virtual DbSet<T_BorrowGoodsConfig> T_BorrowGoodsConfig { get; set; }
        public virtual DbSet<T_BorrowGoodsDetail> T_BorrowGoodsDetail { get; set; }
        public virtual DbSet<T_BorrowSettementRecord> T_BorrowSettementRecord { get; set; }
        public virtual DbSet<T_BusinessTravel> T_BusinessTravel { get; set; }
        public virtual DbSet<T_BusinessTravelApprove> T_BusinessTravelApprove { get; set; }
        public virtual DbSet<T_BusinessTravelConfig> T_BusinessTravelConfig { get; set; }
        public virtual DbSet<T_CashBack> T_CashBack { get; set; }
        public virtual DbSet<T_CashBackApprove> T_CashBackApprove { get; set; }
        public virtual DbSet<T_CashbackApproveConfig> T_CashbackApproveConfig { get; set; }
        public virtual DbSet<T_CashBackDetail> T_CashBackDetail { get; set; }
        public virtual DbSet<T_CashBackFrom> T_CashBackFrom { get; set; }
        public virtual DbSet<T_CashbackMethod> T_CashbackMethod { get; set; }
        public virtual DbSet<T_CashBackReason> T_CashBackReason { get; set; }
        public virtual DbSet<T_CB> T_CB { get; set; }
        public virtual DbSet<T_CeshiCbs> T_CeshiCbs { get; set; }
        public virtual DbSet<T_CeshiOrderList> T_CeshiOrderList { get; set; }
        public virtual DbSet<T_CeshiRetreat> T_CeshiRetreat { get; set; }
        public virtual DbSet<T_CheckAttendace> T_CheckAttendace { get; set; }
        public virtual DbSet<T_CheckAttendaceConfig> T_CheckAttendaceConfig { get; set; }
        public virtual DbSet<T_CheckAttendanceApprove> T_CheckAttendanceApprove { get; set; }
        public virtual DbSet<T_CollectCost> T_CollectCost { get; set; }
        public virtual DbSet<T_CollectionQuidcoStatus> T_CollectionQuidcoStatus { get; set; }
        public virtual DbSet<T_CollectionServiceCost> T_CollectionServiceCost { get; set; }
        public virtual DbSet<T_Company> T_Company { get; set; }
        public virtual DbSet<T_CompensationCost> T_CompensationCost { get; set; }
        public virtual DbSet<T_Deliver> T_Deliver { get; set; }
        public virtual DbSet<T_DeliverDetail> T_DeliverDetail { get; set; }
        public virtual DbSet<T_Department> T_Department { get; set; }
        public virtual DbSet<T_DepartmentActivity> T_DepartmentActivity { get; set; }
        public virtual DbSet<T_DepartmentActivityApprove> T_DepartmentActivityApprove { get; set; }
        public virtual DbSet<T_DepartmentActivityConfig> T_DepartmentActivityConfig { get; set; }
        public virtual DbSet<T_DingConfig> T_DingConfig { get; set; }
        public virtual DbSet<T_Directory> T_Directory { get; set; }
        public virtual DbSet<T_ElectronicInvoice> T_ElectronicInvoice { get; set; }
        public virtual DbSet<T_ElectronicInvoiceAppRove> T_ElectronicInvoiceAppRove { get; set; }
        public virtual DbSet<T_ElectronicInvoiceConfig> T_ElectronicInvoiceConfig { get; set; }
        public virtual DbSet<T_ElectronicInvoiceDetails> T_ElectronicInvoiceDetails { get; set; }
        public virtual DbSet<T_ElectronicInvoiceEnclosure> T_ElectronicInvoiceEnclosure { get; set; }
        public virtual DbSet<T_ElectronicInvoiceGroup> T_ElectronicInvoiceGroup { get; set; }
        public virtual DbSet<T_ElectronicInvoiceReason> T_ElectronicInvoiceReason { get; set; }
        public virtual DbSet<T_EmployDemand> T_EmployDemand { get; set; }
        public virtual DbSet<T_EmployDemandApprove> T_EmployDemandApprove { get; set; }
        public virtual DbSet<T_EmployDemandConfig> T_EmployDemandConfig { get; set; }
        public virtual DbSet<T_ExchangeCenter> T_ExchangeCenter { get; set; }
        public virtual DbSet<T_ExchangeCenterApprove> T_ExchangeCenterApprove { get; set; }
        public virtual DbSet<T_ExchangeCenterConfig> T_ExchangeCenterConfig { get; set; }
        public virtual DbSet<T_ExchangeDetail> T_ExchangeDetail { get; set; }
        public virtual DbSet<T_ExchangeGroup> T_ExchangeGroup { get; set; }
        public virtual DbSet<T_ExchangePic> T_ExchangePic { get; set; }
        public virtual DbSet<T_ExchangeReson> T_ExchangeReson { get; set; }
        public virtual DbSet<T_Expense> T_Expense { get; set; }
        public virtual DbSet<T_ExpenseAcount> T_ExpenseAcount { get; set; }
        public virtual DbSet<T_ExpenseApprove> T_ExpenseApprove { get; set; }
        public virtual DbSet<T_ExpenseApproveConfig> T_ExpenseApproveConfig { get; set; }
        public virtual DbSet<T_ExpenseEnclosure> T_ExpenseEnclosure { get; set; }
        public virtual DbSet<T_ExpenseProduct> T_ExpenseProduct { get; set; }
        public virtual DbSet<T_ExpenseState> T_ExpenseState { get; set; }
        public virtual DbSet<T_Express> T_Express { get; set; }
        public virtual DbSet<T_ExpressCost> T_ExpressCost { get; set; }
        public virtual DbSet<T_ExpressIndemnity> T_ExpressIndemnity { get; set; }
        public virtual DbSet<T_ExpressIndemnityApprove> T_ExpressIndemnityApprove { get; set; }
        public virtual DbSet<T_ExpressIndemnityConfig> T_ExpressIndemnityConfig { get; set; }
        public virtual DbSet<T_ExpressIndemnityPic> T_ExpressIndemnityPic { get; set; }
        public virtual DbSet<T_ExpressIndemnityRecord> T_ExpressIndemnityRecord { get; set; }
        public virtual DbSet<T_ExpressMoney_Query> T_ExpressMoney_Query { get; set; }
        public virtual DbSet<T_Freeze> T_Freeze { get; set; }
        public virtual DbSet<T_FreezeApprove> T_FreezeApprove { get; set; }
        public virtual DbSet<T_FreezeConfig> T_FreezeConfig { get; set; }
        public virtual DbSet<T_FundAcount> T_FundAcount { get; set; }
        public virtual DbSet<T_FundAllot> T_FundAllot { get; set; }
        public virtual DbSet<T_FundApprove> T_FundApprove { get; set; }
        public virtual DbSet<T_FundConfig> T_FundConfig { get; set; }
        public virtual DbSet<T_FundOutAllot> T_FundOutAllot { get; set; }
        public virtual DbSet<T_FundRecord> T_FundRecord { get; set; }
        public virtual DbSet<T_Generalize> T_Generalize { get; set; }
        public virtual DbSet<T_GeneralizeApprove> T_GeneralizeApprove { get; set; }
        public virtual DbSet<T_GeneralizeApproveConfig> T_GeneralizeApproveConfig { get; set; }
        public virtual DbSet<T_GH_Dept> T_GH_Dept { get; set; }
        public virtual DbSet<T_GH_Doctor> T_GH_Doctor { get; set; }
        public virtual DbSet<T_GH_Doctor_Record> T_GH_Doctor_Record { get; set; }
        public virtual DbSet<T_GH_Hospital> T_GH_Hospital { get; set; }
        public virtual DbSet<T_GH_List> T_GH_List { get; set; }
        public virtual DbSet<T_goodsGY> T_goodsGY { get; set; }
        public virtual DbSet<T_GoodsGyParts> T_GoodsGyParts { get; set; }
        public virtual DbSet<T_HandwrittenExpress> T_HandwrittenExpress { get; set; }
        public virtual DbSet<T_HandwrittenExpressAppRove> T_HandwrittenExpressAppRove { get; set; }
        public virtual DbSet<T_HandwrittenExpressConfig> T_HandwrittenExpressConfig { get; set; }
        public virtual DbSet<T_HandwrittenExpressCopy> T_HandwrittenExpressCopy { get; set; }
        public virtual DbSet<T_HandwrittenExpressGroup> T_HandwrittenExpressGroup { get; set; }
        public virtual DbSet<T_HtEbey> T_HtEbey { get; set; }
        public virtual DbSet<T_HtEbeyItem> T_HtEbeyItem { get; set; }
        public virtual DbSet<T_HtEbeyOrderConfig> T_HtEbeyOrderConfig { get; set; }
        public virtual DbSet<T_HTExchangeRate> T_HTExchangeRate { get; set; }
        public virtual DbSet<T_HtShopee> T_HtShopee { get; set; }
        public virtual DbSet<T_HtShopeeItem> T_HtShopeeItem { get; set; }
        public virtual DbSet<T_HtShopeeOrderConfig> T_HtShopeeOrderConfig { get; set; }
        public virtual DbSet<T_HtSuNing> T_HtSuNing { get; set; }
        public virtual DbSet<T_HtSuNingItem> T_HtSuNingItem { get; set; }
        public virtual DbSet<T_Intercept> T_Intercept { get; set; }
        public virtual DbSet<T_InterceptApprove> T_InterceptApprove { get; set; }
        public virtual DbSet<T_InterceptApproveConfig> T_InterceptApproveConfig { get; set; }
        public virtual DbSet<T_InterceptDetail> T_InterceptDetail { get; set; }
        public virtual DbSet<T_InterceptExpressRecord> T_InterceptExpressRecord { get; set; }
        public virtual DbSet<T_InterceptGroup> T_InterceptGroup { get; set; }
        public virtual DbSet<T_InterceptLogistics> T_InterceptLogistics { get; set; }
        public virtual DbSet<T_InterceptLogisticsRole> T_InterceptLogisticsRole { get; set; }
        public virtual DbSet<T_InterceptReson> T_InterceptReson { get; set; }
        public virtual DbSet<T_InvoiceApply> T_InvoiceApply { get; set; }
        public virtual DbSet<T_InvoiceApplyAppRove> T_InvoiceApplyAppRove { get; set; }
        public virtual DbSet<T_InvoiceApplyConfig> T_InvoiceApplyConfig { get; set; }
        public virtual DbSet<T_InvoiceApplyGroup> T_InvoiceApplyGroup { get; set; }
        public virtual DbSet<T_Joined> T_Joined { get; set; }
        public virtual DbSet<T_JoinedApprove> T_JoinedApprove { get; set; }
        public virtual DbSet<T_JoinedApproveConfig> T_JoinedApproveConfig { get; set; }
        public virtual DbSet<T_JoinedOptions> T_JoinedOptions { get; set; }
        public virtual DbSet<T_LazadaGyCode> T_LazadaGyCode { get; set; }
        public virtual DbSet<T_LazadaOrder> T_LazadaOrder { get; set; }
        public virtual DbSet<T_LazadaOrderConfig> T_LazadaOrderConfig { get; set; }
        public virtual DbSet<T_LazadaOrderItem> T_LazadaOrderItem { get; set; }
        public virtual DbSet<T_LineDepatment> T_LineDepatment { get; set; }
        public virtual DbSet<T_LineExpense> T_LineExpense { get; set; }
        public virtual DbSet<T_LineExpenseAcount> T_LineExpenseAcount { get; set; }
        public virtual DbSet<T_LineExpenseApprove> T_LineExpenseApprove { get; set; }
        public virtual DbSet<T_LineExpenseApproveConfig> T_LineExpenseApproveConfig { get; set; }
        public virtual DbSet<T_LineExpenseEnclosure> T_LineExpenseEnclosure { get; set; }
        public virtual DbSet<T_LineExpenseGroup> T_LineExpenseGroup { get; set; }
        public virtual DbSet<T_LineExpenseProduct> T_LineExpenseProduct { get; set; }
        public virtual DbSet<T_LossReport> T_LossReport { get; set; }
        public virtual DbSet<T_LossReportApprove> T_LossReportApprove { get; set; }
        public virtual DbSet<T_LossReportApproveConfig> T_LossReportApproveConfig { get; set; }
        public virtual DbSet<T_LossReportDetail> T_LossReportDetail { get; set; }
        public virtual DbSet<T_MailSample> T_MailSample { get; set; }
        public virtual DbSet<T_MailSampleAppRove> T_MailSampleAppRove { get; set; }
        public virtual DbSet<T_MailSampleConfig> T_MailSampleConfig { get; set; }
        public virtual DbSet<T_MailSampleDetails> T_MailSampleDetails { get; set; }
        public virtual DbSet<T_MailSampleGroup> T_MailSampleGroup { get; set; }
        public virtual DbSet<T_MajorInvoice> T_MajorInvoice { get; set; }
        public virtual DbSet<T_MajorInvoiceAppRove> T_MajorInvoiceAppRove { get; set; }
        public virtual DbSet<T_MajorInvoiceConfig> T_MajorInvoiceConfig { get; set; }
        public virtual DbSet<T_MajorInvoiceDetails> T_MajorInvoiceDetails { get; set; }
        public virtual DbSet<T_MajorInvoiceEnclosure> T_MajorInvoiceEnclosure { get; set; }
        public virtual DbSet<T_MajorInvoiceGroup> T_MajorInvoiceGroup { get; set; }
        public virtual DbSet<T_MajorInvoiceReason> T_MajorInvoiceReason { get; set; }
        public virtual DbSet<T_ManualBilling> T_ManualBilling { get; set; }
        public virtual DbSet<T_ManualBillingAppRove> T_ManualBillingAppRove { get; set; }
        public virtual DbSet<T_ManualBillingConfig> T_ManualBillingConfig { get; set; }
        public virtual DbSet<T_ManualBillingDetails> T_ManualBillingDetails { get; set; }
        public virtual DbSet<T_ManualBillingGroup> T_ManualBillingGroup { get; set; }
        public virtual DbSet<T_ManualExpress> T_ManualExpress { get; set; }
        public virtual DbSet<T_ManualExpressAppRove> T_ManualExpressAppRove { get; set; }
        public virtual DbSet<T_ManualExpressConfig> T_ManualExpressConfig { get; set; }
        public virtual DbSet<T_ManualExpressDetail> T_ManualExpressDetail { get; set; }
        public virtual DbSet<T_ManualExpressGroup> T_ManualExpressGroup { get; set; }
        public virtual DbSet<T_ManualExpressType> T_ManualExpressType { get; set; }
        public virtual DbSet<T_ManualOrder> T_ManualOrder { get; set; }
        public virtual DbSet<T_ManualorderDetail> T_ManualorderDetail { get; set; }
        public virtual DbSet<T_MeetingRoom> T_MeetingRoom { get; set; }
        public virtual DbSet<T_MeetingRoomApprove> T_MeetingRoomApprove { get; set; }
        public virtual DbSet<T_MeetingRoomConfig> T_MeetingRoomConfig { get; set; }
        public virtual DbSet<T_MeetShare> T_MeetShare { get; set; }
        public virtual DbSet<T_MeetShareRecord> T_MeetShareRecord { get; set; }
        public virtual DbSet<T_MeetShareSeason> T_MeetShareSeason { get; set; }
        public virtual DbSet<T_ModularNotaudited> T_ModularNotaudited { get; set; }
        public virtual DbSet<T_MutuallyCost> T_MutuallyCost { get; set; }
        public virtual DbSet<T_NoTicketExpense> T_NoTicketExpense { get; set; }
        public virtual DbSet<T_NoTicketExpenseAccount> T_NoTicketExpenseAccount { get; set; }
        public virtual DbSet<T_offer> T_offer { get; set; }
        public virtual DbSet<T_offerApprove> T_offerApprove { get; set; }
        public virtual DbSet<T_offerDetails> T_offerDetails { get; set; }
        public virtual DbSet<T_OperaterLog> T_OperaterLog { get; set; }
        public virtual DbSet<T_OrderDetail> T_OrderDetail { get; set; }
        public virtual DbSet<T_OrderDetail2> T_OrderDetail2 { get; set; }
        public virtual DbSet<T_OrderList> T_OrderList { get; set; }
        public virtual DbSet<T_OrderList2> T_OrderList2 { get; set; }
        public virtual DbSet<T_OrderType> T_OrderType { get; set; }
        public virtual DbSet<T_Payment> T_Payment { get; set; }
        public virtual DbSet<T_PaymentAcount> T_PaymentAcount { get; set; }
        public virtual DbSet<T_PaymentApprove> T_PaymentApprove { get; set; }
        public virtual DbSet<T_PaymentApproveConfig> T_PaymentApproveConfig { get; set; }
        public virtual DbSet<T_PaymentEnclosure> T_PaymentEnclosure { get; set; }
        public virtual DbSet<T_PaymentProduct> T_PaymentProduct { get; set; }
        public virtual DbSet<T_PaymentState> T_PaymentState { get; set; }
        public virtual DbSet<T_PaymentType> T_PaymentType { get; set; }
        public virtual DbSet<T_PersonnelEduBackgroud> T_PersonnelEduBackgroud { get; set; }
        public virtual DbSet<T_PersonnelFamily> T_PersonnelFamily { get; set; }
        public virtual DbSet<T_PersonnelFile> T_PersonnelFile { get; set; }
        public virtual DbSet<T_PersonnelFile1> T_PersonnelFile1 { get; set; }
        public virtual DbSet<T_PersonnelFile2> T_PersonnelFile2 { get; set; }
        public virtual DbSet<T_PersonnelInterviewConfig> T_PersonnelInterviewConfig { get; set; }
        public virtual DbSet<T_PersonnelInterviewRecord> T_PersonnelInterviewRecord { get; set; }
        public virtual DbSet<T_PersonnelPayRaise> T_PersonnelPayRaise { get; set; }
        public virtual DbSet<T_PersonnelPayRaiseApprove> T_PersonnelPayRaiseApprove { get; set; }
        public virtual DbSet<T_PersonnelPayRaiseConfig> T_PersonnelPayRaiseConfig { get; set; }
        public virtual DbSet<T_PersonnelPerformance> T_PersonnelPerformance { get; set; }
        public virtual DbSet<T_PersonnelQuit> T_PersonnelQuit { get; set; }
        public virtual DbSet<T_PersonnelReward> T_PersonnelReward { get; set; }
        public virtual DbSet<T_PersonnelTransfer> T_PersonnelTransfer { get; set; }
        public virtual DbSet<T_PersonnelTransferApprove> T_PersonnelTransferApprove { get; set; }
        public virtual DbSet<T_PersonnelTransferConfig> T_PersonnelTransferConfig { get; set; }
        public virtual DbSet<T_PersonnelWorkExperience> T_PersonnelWorkExperience { get; set; }
        public virtual DbSet<T_PhotoApprove> T_PhotoApprove { get; set; }
        public virtual DbSet<T_PhotoConfig> T_PhotoConfig { get; set; }
        public virtual DbSet<T_PhotoDetail> T_PhotoDetail { get; set; }
        public virtual DbSet<T_Photograph> T_Photograph { get; set; }
        public virtual DbSet<T_PP> T_PP { get; set; }
        public virtual DbSet<T_PR> T_PR { get; set; }
        public virtual DbSet<T_ProductClass> T_ProductClass { get; set; }
        public virtual DbSet<T_ProductCodeGenerate> T_ProductCodeGenerate { get; set; }
        public virtual DbSet<T_ProductCodeGenerateDetails> T_ProductCodeGenerateDetails { get; set; }
        public virtual DbSet<T_ProductManufactor> T_ProductManufactor { get; set; }
        public virtual DbSet<T_Purchase> T_Purchase { get; set; }
        public virtual DbSet<T_PurchaseApprove> T_PurchaseApprove { get; set; }
        public virtual DbSet<T_PurchaseCollect> T_PurchaseCollect { get; set; }
        public virtual DbSet<T_PurchaseConfig> T_PurchaseConfig { get; set; }
        public virtual DbSet<T_PurchaseDetails> T_PurchaseDetails { get; set; }
        public virtual DbSet<T_PurchaseExecutive> T_PurchaseExecutive { get; set; }
        public virtual DbSet<T_PurchaseExecutiveApprove> T_PurchaseExecutiveApprove { get; set; }
        public virtual DbSet<T_PurchaseExecutiveCollect> T_PurchaseExecutiveCollect { get; set; }
        public virtual DbSet<T_PurchaseExecutiveConfig> T_PurchaseExecutiveConfig { get; set; }
        public virtual DbSet<T_PurchaseExecutiveDetails> T_PurchaseExecutiveDetails { get; set; }
        public virtual DbSet<T_PurchaseFinance> T_PurchaseFinance { get; set; }
        public virtual DbSet<T_PZ_BS> T_PZ_BS { get; set; }
        public virtual DbSet<T_PZ_BX> T_PZ_BX { get; set; }
        public virtual DbSet<T_PZ_DePartMent> T_PZ_DePartMent { get; set; }
        public virtual DbSet<T_PZ_FundAllot> T_PZ_FundAllot { get; set; }
        public virtual DbSet<T_PZ_JZ> T_PZ_JZ { get; set; }
        public virtual DbSet<T_PZ_ProductPurchase> T_PZ_ProductPurchase { get; set; }
        public virtual DbSet<T_PZ_PurchaseExecutive> T_PZ_PurchaseExecutive { get; set; }
        public virtual DbSet<T_Quit> T_Quit { get; set; }
        public virtual DbSet<T_QuitApprove> T_QuitApprove { get; set; }
        public virtual DbSet<T_QuitApproveConfig> T_QuitApproveConfig { get; set; }
        public virtual DbSet<T_QuitOptions> T_QuitOptions { get; set; }
        public virtual DbSet<T_Receipt> T_Receipt { get; set; }
        public virtual DbSet<T_ReceiptDetails> T_ReceiptDetails { get; set; }
        public virtual DbSet<T_ReceivedAfter> T_ReceivedAfter { get; set; }
        public virtual DbSet<T_Reissue> T_Reissue { get; set; }
        public virtual DbSet<T_ReissueApprove> T_ReissueApprove { get; set; }
        public virtual DbSet<T_ReissueConfig> T_ReissueConfig { get; set; }
        public virtual DbSet<T_ReissueDetail> T_ReissueDetail { get; set; }
        public virtual DbSet<T_ReissueGroup> T_ReissueGroup { get; set; }
        public virtual DbSet<T_ReissuePic> T_ReissuePic { get; set; }
        public virtual DbSet<T_ReissueReson> T_ReissueReson { get; set; }
        public virtual DbSet<T_RespiratorOrder> T_RespiratorOrder { get; set; }
        public virtual DbSet<T_RespiratorOrderDetails> T_RespiratorOrderDetails { get; set; }
        public virtual DbSet<T_RespiratorOrderRecord> T_RespiratorOrderRecord { get; set; }
        public virtual DbSet<T_Retreat> T_Retreat { get; set; }
        public virtual DbSet<T_RetreatAppRove> T_RetreatAppRove { get; set; }
        public virtual DbSet<T_RetreatConfig> T_RetreatConfig { get; set; }
        public virtual DbSet<T_RetreatDetails> T_RetreatDetails { get; set; }
        public virtual DbSet<T_RetreatExpressRecord> T_RetreatExpressRecord { get; set; }
        public virtual DbSet<T_RetreatGroup> T_RetreatGroup { get; set; }
        public virtual DbSet<T_RetreatPayment> T_RetreatPayment { get; set; }
        public virtual DbSet<T_RetreatReason> T_RetreatReason { get; set; }
        public virtual DbSet<T_RetreatSorting> T_RetreatSorting { get; set; }
        public virtual DbSet<T_RetreatSortingDelivering> T_RetreatSortingDelivering { get; set; }
        public virtual DbSet<T_ReturnNoWithinRange> T_ReturnNoWithinRange { get; set; }
        public virtual DbSet<T_ReturnPrint> T_ReturnPrint { get; set; }
        public virtual DbSet<T_ReturnPrintDetail> T_ReturnPrintDetail { get; set; }
        public virtual DbSet<T_ReTurnStorageImg> T_ReTurnStorageImg { get; set; }
        public virtual DbSet<T_ReturnToStorage> T_ReturnToStorage { get; set; }
        public virtual DbSet<T_ReturnToStorageBlending> T_ReturnToStorageBlending { get; set; }
        public virtual DbSet<T_ReturnToStorageBlendingDetails> T_ReturnToStorageBlendingDetails { get; set; }
        public virtual DbSet<T_ReturnToStorageBlendingType> T_ReturnToStorageBlendingType { get; set; }
        public virtual DbSet<T_ReturnToStorageDetails> T_ReturnToStorageDetails { get; set; }
        public virtual DbSet<T_ReturnToStoragelet> T_ReturnToStoragelet { get; set; }
        public virtual DbSet<T_Role> T_Role { get; set; }
        public virtual DbSet<T_RuleReader> T_RuleReader { get; set; }
        public virtual DbSet<T_RulesNotice> T_RulesNotice { get; set; }
        public virtual DbSet<T_SecurityCode> T_SecurityCode { get; set; }
        public virtual DbSet<T_SecurityCodeAppRove> T_SecurityCodeAppRove { get; set; }
        public virtual DbSet<T_SecurityCodeConfig> T_SecurityCodeConfig { get; set; }
        public virtual DbSet<T_SecurityCodeGroup> T_SecurityCodeGroup { get; set; }
        public virtual DbSet<T_ShopFromGY> T_ShopFromGY { get; set; }
        public virtual DbSet<T_Stock> T_Stock { get; set; }
        public virtual DbSet<T_StockDetail> T_StockDetail { get; set; }
        public virtual DbSet<T_StockOutstorage> T_StockOutstorage { get; set; }
        public virtual DbSet<T_StockStorage> T_StockStorage { get; set; }
        public virtual DbSet<T_StoreReceived> T_StoreReceived { get; set; }
        public virtual DbSet<T_SupplierGY> T_SupplierGY { get; set; }
        public virtual DbSet<T_Suppliers> T_Suppliers { get; set; }
        public virtual DbSet<T_SYCM_Data> T_SYCM_Data { get; set; }
        public virtual DbSet<T_Syslog> T_Syslog { get; set; }
        public virtual DbSet<T_SysModule> T_SysModule { get; set; }
        public virtual DbSet<T_ToRegularApprove> T_ToRegularApprove { get; set; }
        public virtual DbSet<T_ToRegularConfig> T_ToRegularConfig { get; set; }
        public virtual DbSet<T_ToRegularWorker> T_ToRegularWorker { get; set; }
        public virtual DbSet<T_TransFerAdjustCost> T_TransFerAdjustCost { get; set; }
        public virtual DbSet<T_User> T_User { get; set; }
        public virtual DbSet<T_Userinformation> T_Userinformation { get; set; }
        public virtual DbSet<T_Warehouses> T_Warehouses { get; set; }
        public virtual DbSet<T_WDTExpress> T_WDTExpress { get; set; }
        public virtual DbSet<T_WDTGoods> T_WDTGoods { get; set; }
        public virtual DbSet<T_WDTshop> T_WDTshop { get; set; }
        public virtual DbSet<T_WeChat> T_WeChat { get; set; }
        public virtual DbSet<T_WeChatAccounts> T_WeChatAccounts { get; set; }
        public virtual DbSet<T_WeChatAppRove> T_WeChatAppRove { get; set; }
        public virtual DbSet<T_WeChatConfig> T_WeChatConfig { get; set; }
        public virtual DbSet<T_WeChatDetail> T_WeChatDetail { get; set; }
        public virtual DbSet<T_WeChatGroup> T_WeChatGroup { get; set; }
        public virtual DbSet<T_ZD_Cost> T_ZD_Cost { get; set; }
        public virtual DbSet<T_CashBackApprove2> T_CashBackApprove2 { get; set; }
        public virtual DbSet<T_cashbackmethod1> T_cashbackmethod1 { get; set; }
        public virtual DbSet<T_Data_DayShopSales> T_Data_DayShopSales { get; set; }
        public virtual DbSet<T_Warehouses_Backups> T_Warehouses_Backups { get; set; }
        public virtual DbSet<T_ReturnPrintAdjust> T_ReturnPrintAdjust { get; set; }
    
        public virtual ObjectResult<ReturnPrintData_Result> ReturnPrintData(string sortingname, string outWarehouse)
        {
            var sortingnameParameter = sortingname != null ?
                new ObjectParameter("Sortingname", sortingname) :
                new ObjectParameter("Sortingname", typeof(string));
    
            var outWarehouseParameter = outWarehouse != null ?
                new ObjectParameter("OutWarehouse", outWarehouse) :
                new ObjectParameter("OutWarehouse", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ReturnPrintData_Result>("ReturnPrintData", sortingnameParameter, outWarehouseParameter);
        }
    
        public virtual ObjectResult<ReturnPrintQualifiedData_Result> ReturnPrintQualifiedData(string sortingname)
        {
            var sortingnameParameter = sortingname != null ?
                new ObjectParameter("Sortingname", sortingname) :
                new ObjectParameter("Sortingname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ReturnPrintQualifiedData_Result>("ReturnPrintQualifiedData", sortingnameParameter);
        }
    
        public virtual ObjectResult<ReturnPrintUnqualifiedData_Result> ReturnPrintUnqualifiedData(string sortingname)
        {
            var sortingnameParameter = sortingname != null ?
                new ObjectParameter("Sortingname", sortingname) :
                new ObjectParameter("Sortingname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ReturnPrintUnqualifiedData_Result>("ReturnPrintUnqualifiedData", sortingnameParameter);
        }
    }
}
