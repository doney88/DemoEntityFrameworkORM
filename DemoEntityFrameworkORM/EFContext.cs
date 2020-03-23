namespace DemoEntityFrameworkORM
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EFContext : DbContext
    {
        public EFContext()
            : base("name=EFContext")
        {
        }

        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tblAccount> tblAccounts { get; set; }
        public virtual DbSet<tblAccountMonth> tblAccountMonths { get; set; }
        public virtual DbSet<tblAcetate> tblAcetates { get; set; }
        public virtual DbSet<tblAcetateCat> tblAcetateCats { get; set; }
        public virtual DbSet<tblAcetateDensity> tblAcetateDensities { get; set; }
        public virtual DbSet<tblAcetateSize> tblAcetateSizes { get; set; }
        public virtual DbSet<tblAcetateSub> tblAcetateSubs { get; set; }
        public virtual DbSet<tblAkSpl> tblAkSpls { get; set; }
        public virtual DbSet<tblAKTClientPayment> tblAKTClientPayments { get; set; }
        public virtual DbSet<tblAktClientShipment> tblAktClientShipments { get; set; }
        public virtual DbSet<tblBank> tblBanks { get; set; }
        public virtual DbSet<tblBankLocal> tblBankLocals { get; set; }
        public virtual DbSet<tblBOM> tblBOMs { get; set; }
        public virtual DbSet<tblCat1> tblCat1 { get; set; }
        public virtual DbSet<tblCat2> tblCat2 { get; set; }
        public virtual DbSet<tblCat3> tblCat3 { get; set; }
        public virtual DbSet<tblCat3Process> tblCat3Process { get; set; }
        public virtual DbSet<tblClaim> tblClaims { get; set; }
        public virtual DbSet<tblClaimSub> tblClaimSubs { get; set; }
        public virtual DbSet<tblClient> tblClients { get; set; }
        public virtual DbSet<tblClientAddress> tblClientAddresses { get; set; }
        public virtual DbSet<tblClientAR> tblClientARs { get; set; }
        public virtual DbSet<tblClientARDetail> tblClientARDetails { get; set; }
        public virtual DbSet<tblClientARDetailSub> tblClientARDetailSubs { get; set; }
        public virtual DbSet<tblClientContact> tblClientContacts { get; set; }
        public virtual DbSet<tblClientQuality> tblClientQualities { get; set; }
        public virtual DbSet<tblCompany> tblCompanies { get; set; }
        public virtual DbSet<tblComponent> tblComponents { get; set; }
        public virtual DbSet<tblComponentBag> tblComponentBags { get; set; }
        public virtual DbSet<tblComponentBagSub> tblComponentBagSubs { get; set; }
        public virtual DbSet<tblComponentBGSub> tblComponentBGSubs { get; set; }
        public virtual DbSet<tblComponentBOM> tblComponentBOMs { get; set; }
        public virtual DbSet<tblComponentBox> tblComponentBoxes { get; set; }
        public virtual DbSet<tblComponentCarton> tblComponentCartons { get; set; }
        public virtual DbSet<tblComponentCartonSub> tblComponentCartonSubs { get; set; }
        public virtual DbSet<tblComponentCore> tblComponentCores { get; set; }
        public virtual DbSet<tblComponentCoreSP> tblComponentCoreSPs { get; set; }
        public virtual DbSet<tblComponentCoreSub> tblComponentCoreSubs { get; set; }
        public virtual DbSet<tblComponentDMST> tblComponentDMSTs { get; set; }
        public virtual DbSet<tblComponentDWD> tblComponentDWDs { get; set; }
        public virtual DbSet<tblComponentEyebrowSub> tblComponentEyebrowSubs { get; set; }
        public virtual DbSet<tblComponentFrontSub> tblComponentFrontSubs { get; set; }
        public virtual DbSet<tblComponentHinge> tblComponentHinges { get; set; }
        public virtual DbSet<tblComponentHingeF> tblComponentHingeFS { get; set; }
        public virtual DbSet<tblComponentHingeSub> tblComponentHingeSubs { get; set; }
        public virtual DbSet<tblComponentJB> tblComponentJBs { get; set; }
        public virtual DbSet<tblComponentJBRaw> tblComponentJBRaws { get; set; }
        public virtual DbSet<tblComponentJBSub> tblComponentJBSubs { get; set; }
        public virtual DbSet<tblComponentLen> tblComponentLens { get; set; }
        public virtual DbSet<tblComponentLenLR> tblComponentLenLRs { get; set; }
        public virtual DbSet<tblComponentLenRaw> tblComponentLenRaws { get; set; }
        public virtual DbSet<tblComponentLenRawSub> tblComponentLenRawSubs { get; set; }
        public virtual DbSet<tblComponentMetalFrontSub> tblComponentMetalFrontSubs { get; set; }
        public virtual DbSet<tblComponentMetalStickerSub> tblComponentMetalStickerSubs { get; set; }
        public virtual DbSet<tblComponentMillWQD> tblComponentMillWQDs { get; set; }
        public virtual DbSet<tblComponentMould> tblComponentMoulds { get; set; }
        public virtual DbSet<tblComponentPin> tblComponentPins { get; set; }
        public virtual DbSet<tblComponentPinSub> tblComponentPinSubs { get; set; }
        public virtual DbSet<tblComponentPlate> tblComponentPlates { get; set; }
        public virtual DbSet<tblComponentPlateSub> tblComponentPlateSubs { get; set; }
        public virtual DbSet<tblComponentPPN> tblComponentPPNs { get; set; }
        public virtual DbSet<tblComponentQuality> tblComponentQualities { get; set; }
        public virtual DbSet<tblComponentScrew> tblComponentScrews { get; set; }
        public virtual DbSet<tblComponentScrewSub> tblComponentScrewSubs { get; set; }
        public virtual DbSet<tblComponentSelfSealingBag> tblComponentSelfSealingBags { get; set; }
        public virtual DbSet<tblComponentSelfSealingBagSub> tblComponentSelfSealingBagSubs { get; set; }
        public virtual DbSet<tblComponentSpringBox> tblComponentSpringBoxes { get; set; }
        public virtual DbSet<tblComponentSTN> tblComponentSTNs { get; set; }
        public virtual DbSet<tblComponentSub> tblComponentSubs { get; set; }
        public virtual DbSet<tblComponentSubBOM> tblComponentSubBOMs { get; set; }
        public virtual DbSet<tblComponentSubLR> tblComponentSubLRs { get; set; }
        public virtual DbSet<tblComponentTrim> tblComponentTrims { get; set; }
        public virtual DbSet<tblComponentTrimRaw> tblComponentTrimRaws { get; set; }
        public virtual DbSet<tblComponentTrimSub> tblComponentTrimSubs { get; set; }
        public virtual DbSet<tblComponentTT> tblComponentTTs { get; set; }
        public virtual DbSet<tblComponentYZ> tblComponentYZs { get; set; }
        public virtual DbSet<tblCurrencyType> tblCurrencyTypes { get; set; }
        public virtual DbSet<tblCust> tblCusts { get; set; }
        public virtual DbSet<tblCustPrintingInfo> tblCustPrintingInfoes { get; set; }
        public virtual DbSet<tblCustPrintingInfoSub> tblCustPrintingInfoSubs { get; set; }
        public virtual DbSet<tblCustQuality> tblCustQualities { get; set; }
        public virtual DbSet<tblDepartment> tblDepartments { get; set; }
        public virtual DbSet<tblDesignFront> tblDesignFronts { get; set; }
        public virtual DbSet<tblEmployee> tblEmployees { get; set; }
        public virtual DbSet<tblEngineerLenCategory> tblEngineerLenCategories { get; set; }
        public virtual DbSet<tblEntryResignRecord> tblEntryResignRecords { get; set; }
        public virtual DbSet<tblHoliday> tblHolidays { get; set; }
        public virtual DbSet<tblHomeTown> tblHomeTowns { get; set; }
        public virtual DbSet<tblLenColor> tblLenColors { get; set; }
        public virtual DbSet<tblMaterial> tblMaterials { get; set; }
        public virtual DbSet<tblMaterialType> tblMaterialTypes { get; set; }
        public virtual DbSet<tblMaterialWorkShop> tblMaterialWorkShops { get; set; }
        public virtual DbSet<tblMillNQY> tblMillNQies { get; set; }
        public virtual DbSet<tblMillNQYK> tblMillNQYKs { get; set; }
        public virtual DbSet<tblMillTTD> tblMillTTDs { get; set; }
        public virtual DbSet<tblMillXD> tblMillXDs { get; set; }
        public virtual DbSet<tblMouldTemplePunch> tblMouldTemplePunches { get; set; }
        public virtual DbSet<tblMouldTemplePunchMould> tblMouldTemplePunchMoulds { get; set; }
        public virtual DbSet<tblMWHIn> tblMWHIns { get; set; }
        public virtual DbSet<tblMWHInBill> tblMWHInBills { get; set; }
        public virtual DbSet<tblMWHInBillType> tblMWHInBillTypes { get; set; }
        public virtual DbSet<tblMWHIni> tblMWHInis { get; set; }
        public virtual DbSet<tblMWHInP> tblMWHInPs { get; set; }
        public virtual DbSet<tblMWHInPBill> tblMWHInPBills { get; set; }
        public virtual DbSet<tblMWHInPTemp> tblMWHInPTemps { get; set; }
        public virtual DbSet<tblMWHInTemp> tblMWHInTemps { get; set; }
        public virtual DbSet<tblMWHOut> tblMWHOuts { get; set; }
        public virtual DbSet<tblMWHOutBill> tblMWHOutBills { get; set; }
        public virtual DbSet<tblMWHOutTemp> tblMWHOutTemps { get; set; }
        public virtual DbSet<tblOrder> tblOrders { get; set; }
        public virtual DbSet<tblOrderAnalyze> tblOrderAnalyzes { get; set; }
        public virtual DbSet<tblOrderComponent> tblOrderComponents { get; set; }
        public virtual DbSet<tblOrderMould> tblOrderMoulds { get; set; }
        public virtual DbSet<tblOrderPrintingInfo> tblOrderPrintingInfoes { get; set; }
        public virtual DbSet<tblOrderPrintingInfoSpl> tblOrderPrintingInfoSpls { get; set; }
        public virtual DbSet<tblOrderPrintingInfoSub> tblOrderPrintingInfoSubs { get; set; }
        public virtual DbSet<tblOrderPrintingMould> tblOrderPrintingMoulds { get; set; }
        public virtual DbSet<tblOrderProcessBOM> tblOrderProcessBOMs { get; set; }
        public virtual DbSet<tblOrderShipBatch> tblOrderShipBatches { get; set; }
        public virtual DbSet<tblOrderShipBatchSub> tblOrderShipBatchSubs { get; set; }
        public virtual DbSet<tblOrderSub> tblOrderSubs { get; set; }
        public virtual DbSet<tblOrderSubBOM> tblOrderSubBOMs { get; set; }
        public virtual DbSet<tblOrderSubBOMPacking> tblOrderSubBOMPackings { get; set; }
        public virtual DbSet<tblPackingBackCard> tblPackingBackCards { get; set; }
        public virtual DbSet<tblPackingMixType> tblPackingMixTypes { get; set; }
        public virtual DbSet<tblPackingTemplate> tblPackingTemplates { get; set; }
        public virtual DbSet<tblPackingTemplateSub> tblPackingTemplateSubs { get; set; }
        public virtual DbSet<tblPara_GetFile> tblPara_GetFile { get; set; }
        public virtual DbSet<tblPara_Letter> tblPara_Letter { get; set; }
        public virtual DbSet<tblPartsTemple> tblPartsTemples { get; set; }
        public virtual DbSet<tblPartsTempleSub> tblPartsTempleSubs { get; set; }
        public virtual DbSet<tblPaymentTerm> tblPaymentTerms { get; set; }
        public virtual DbSet<tblPDTWH> tblPDTWHs { get; set; }
        public virtual DbSet<tblPDTWHBill> tblPDTWHBills { get; set; }
        public virtual DbSet<tblPDTWHBillType> tblPDTWHBillTypes { get; set; }
        public virtual DbSet<tblPDTWHFreight> tblPDTWHFreights { get; set; }
        public virtual DbSet<tblPDTWHIn> tblPDTWHIns { get; set; }
        public virtual DbSet<tblPDTWHInBill> tblPDTWHInBills { get; set; }
        public virtual DbSet<tblPDTWHInTemp> tblPDTWHInTemps { get; set; }
        public virtual DbSet<tblPDTWHTemp> tblPDTWHTemps { get; set; }
        public virtual DbSet<tblPDTWHTempFreight> tblPDTWHTempFreights { get; set; }
        public virtual DbSet<tblPlateColor> tblPlateColors { get; set; }
        public virtual DbSet<tblPrintingInfo> tblPrintingInfoes { get; set; }
        public virtual DbSet<tblPrintingPart> tblPrintingParts { get; set; }
        public virtual DbSet<tblProcess> tblProcesses { get; set; }
        public virtual DbSet<tblProcessBOM> tblProcessBOMs { get; set; }
        public virtual DbSet<tblProcessBomSub> tblProcessBomSubs { get; set; }
        public virtual DbSet<tblProcessPlate> tblProcessPlates { get; set; }
        public virtual DbSet<tblProcessSub> tblProcessSubs { get; set; }
        public virtual DbSet<tblProcessTemplate> tblProcessTemplates { get; set; }
        public virtual DbSet<tblProcessTemplateSub> tblProcessTemplateSubs { get; set; }
        public virtual DbSet<tblProcurement> tblProcurements { get; set; }
        public virtual DbSet<tblProcurementChoose> tblProcurementChooses { get; set; }
        public virtual DbSet<tblProcurementConfirmDate> tblProcurementConfirmDates { get; set; }
        public virtual DbSet<tblProcurementSub> tblProcurementSubs { get; set; }
        public virtual DbSet<tblProcurementSubBOM> tblProcurementSubBOMs { get; set; }
        public virtual DbSet<tblProcurementTemp> tblProcurementTemps { get; set; }
        public virtual DbSet<tblProduct> tblProducts { get; set; }
        public virtual DbSet<tblProduction> tblProductions { get; set; }
        public virtual DbSet<tblProductionMonth> tblProductionMonths { get; set; }
        public virtual DbSet<tblProductionPlan> tblProductionPlans { get; set; }
        public virtual DbSet<tblProductionPlanHeader> tblProductionPlanHeaders { get; set; }
        public virtual DbSet<tblProductionSample> tblProductionSamples { get; set; }
        public virtual DbSet<tblProductionSampleSub> tblProductionSampleSubs { get; set; }
        public virtual DbSet<tblProductionSampleSubSub> tblProductionSampleSubSubs { get; set; }
        public virtual DbSet<tblProductSampleBox> tblProductSampleBoxes { get; set; }
        public virtual DbSet<tblProductSKU> tblProductSKUs { get; set; }
        public virtual DbSet<tblProductSKUAcetate> tblProductSKUAcetates { get; set; }
        public virtual DbSet<tblProductStyle> tblProductStyles { get; set; }
        public virtual DbSet<tblProformaInvoice> tblProformaInvoices { get; set; }
        public virtual DbSet<tblQuotation> tblQuotations { get; set; }
        public virtual DbSet<tblQuotationBase> tblQuotationBases { get; set; }
        public virtual DbSet<tblQuotationBOM> tblQuotationBOMs { get; set; }
        public virtual DbSet<tblQuotationList> tblQuotationLists { get; set; }
        public virtual DbSet<tblQuotationProcess> tblQuotationProcesses { get; set; }
        public virtual DbSet<tblRightItem> tblRightItems { get; set; }
        public virtual DbSet<tblRightValue> tblRightValues { get; set; }
        public virtual DbSet<tblRptProductionCardComponent> tblRptProductionCardComponents { get; set; }
        public virtual DbSet<tblRptProductionCardComponentSub> tblRptProductionCardComponentSubs { get; set; }
        public virtual DbSet<tblRptProductionCardMaterial> tblRptProductionCardMaterials { get; set; }
        public virtual DbSet<tblRptProductionCardMould> tblRptProductionCardMoulds { get; set; }
        public virtual DbSet<tblRptProductionCardQuality> tblRptProductionCardQualities { get; set; }
        public virtual DbSet<tblRptProductionComponent> tblRptProductionComponents { get; set; }
        public virtual DbSet<tblRptProductionComponentSub> tblRptProductionComponentSubs { get; set; }
        public virtual DbSet<tblRptProductionHead> tblRptProductionHeads { get; set; }
        public virtual DbSet<tblRptProductionMaterial> tblRptProductionMaterials { get; set; }
        public virtual DbSet<tblRptProductionProcedure> tblRptProductionProcedures { get; set; }
        public virtual DbSet<tblRptProductionProcess> tblRptProductionProcesses { get; set; }
        public virtual DbSet<tblRptProductionQuality> tblRptProductionQualities { get; set; }
        public virtual DbSet<tblRptProductionSection> tblRptProductionSections { get; set; }
        public virtual DbSet<tblRptProductionSemi> tblRptProductionSemis { get; set; }
        public virtual DbSet<tblSalary> tblSalaries { get; set; }
        public virtual DbSet<tblSalarySum> tblSalarySums { get; set; }
        public virtual DbSet<tblScrap> tblScraps { get; set; }
        public virtual DbSet<tblScrappage> tblScrappages { get; set; }
        public virtual DbSet<tblSection> tblSections { get; set; }
        public virtual DbSet<tblSectionCost> tblSectionCosts { get; set; }
        public virtual DbSet<tblSupplier> tblSuppliers { get; set; }
        public virtual DbSet<tblSupplierContact> tblSupplierContacts { get; set; }
        public virtual DbSet<tblSurface> tblSurfaces { get; set; }
        public virtual DbSet<tblSysAttachment> tblSysAttachments { get; set; }
        public virtual DbSet<tblSysAttachmentType> tblSysAttachmentTypes { get; set; }
        public virtual DbSet<tblSysLorR> tblSysLorRs { get; set; }
        public virtual DbSet<tblSysLorRCode> tblSysLorRCodes { get; set; }
        public virtual DbSet<tblSysMenu> tblSysMenus { get; set; }
        public virtual DbSet<tblSysMenuCommand> tblSysMenuCommands { get; set; }
        public virtual DbSet<TblSysParameter> TblSysParameters { get; set; }
        public virtual DbSet<tblSysRole> tblSysRoles { get; set; }
        public virtual DbSet<tblSysRoleRight> tblSysRoleRights { get; set; }
        public virtual DbSet<tblSysWindowType> tblSysWindowTypes { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
        public virtual DbSet<tblUserRole> tblUserRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblAccount>()
                .HasMany(e => e.tblAccount1)
                .WithOptional(e => e.tblAccount2)
                .HasForeignKey(e => e.FAccountMainID);

            modelBuilder.Entity<tblAccount>()
                .HasMany(e => e.tblAccountMonths)
                .WithRequired(e => e.tblAccount)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblAccountMonth>()
                .Property(e => e.FAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblAcetate>()
                .HasMany(e => e.tblAcetateSubs)
                .WithRequired(e => e.tblAcetate)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblAcetateCat>()
                .Property(e => e.FPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblAcetateCat>()
                .HasMany(e => e.tblAcetates)
                .WithRequired(e => e.tblAcetateCat)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblAcetateDensity>()
                .Property(e => e.FThick)
                .HasPrecision(2, 1);

            modelBuilder.Entity<tblAcetateDensity>()
                .Property(e => e.FWeight)
                .HasPrecision(2, 1);

            modelBuilder.Entity<tblAcetateSize>()
                .HasMany(e => e.tblAcetateCats)
                .WithRequired(e => e.tblAcetateSize)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblAcetateSize>()
                .HasMany(e => e.tblAcetateSubs)
                .WithRequired(e => e.tblAcetateSize)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblAcetateSub>()
                .Property(e => e.FThick)
                .HasPrecision(2, 1);

            modelBuilder.Entity<tblAkSpl>()
                .Property(e => e.FPurchase)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblAkSpl>()
                .Property(e => e.FDiscount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblAkSpl>()
                .Property(e => e.FChange)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblAkSpl>()
                .Property(e => e.FAkDue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblAkSpl>()
                .Property(e => e.FAktDue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblAKTClientPayment>()
                .Property(e => e.FPayment)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblAktClientShipment>()
                .Property(e => e.FAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblAktClientShipment>()
                .Property(e => e.FReceived)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblAktClientShipment>()
                .Property(e => e.FCommition)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblAktClientShipment>()
                .Property(e => e.FCommitionPayed)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblAktClientShipment>()
                .Property(e => e.FOtherAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblAktClientShipment>()
                .Property(e => e.FAmountTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblBOM>()
                .Property(e => e.FQty)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tblCat1>()
                .Property(e => e.FCat1Code)
                .IsFixedLength();

            modelBuilder.Entity<tblCat1>()
                .HasMany(e => e.tblCat2)
                .WithOptional(e => e.tblCat1)
                .WillCascadeOnDelete();

            modelBuilder.Entity<tblCat2>()
                .Property(e => e.FCat2Code)
                .IsFixedLength();

            modelBuilder.Entity<tblCat2>()
                .HasMany(e => e.tblCat3)
                .WithRequired(e => e.tblCat2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCat2>()
                .HasMany(e => e.tblSuppliers)
                .WithRequired(e => e.tblCat2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCat3>()
                .HasMany(e => e.tblComponentMoulds)
                .WithRequired(e => e.tblCat3)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCat3>()
                .HasMany(e => e.tblMouldTemplePunchMoulds)
                .WithRequired(e => e.tblCat3)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCat3>()
                .HasMany(e => e.tblProductSampleBoxes)
                .WithRequired(e => e.tblCat3)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCat3>()
                .HasMany(e => e.tblProcessTemplates)
                .WithRequired(e => e.tblCat3)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCat3>()
                .HasMany(e => e.tblProducts)
                .WithRequired(e => e.tblCat3)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCat3>()
                .HasMany(e => e.tblComponents)
                .WithRequired(e => e.tblCat3)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCat3>()
                .HasMany(e => e.tblMaterials)
                .WithRequired(e => e.tblCat3)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblClaim>()
                .Property(e => e.FClaimNum)
                .IsFixedLength();

            modelBuilder.Entity<tblClaimSub>()
                .Property(e => e.FAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblClient>()
                .Property(e => e.FAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblClient>()
                .HasMany(e => e.tblAKTClientPayments)
                .WithRequired(e => e.tblClient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblClient>()
                .HasMany(e => e.tblAktClientShipments)
                .WithRequired(e => e.tblClient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblClient>()
                .HasMany(e => e.tblClientARs)
                .WithRequired(e => e.tblClient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblClient>()
                .HasMany(e => e.tblCusts)
                .WithRequired(e => e.tblClient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblClient>()
                .HasMany(e => e.tblPDTWHBills)
                .WithRequired(e => e.tblClient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblClient>()
                .HasMany(e => e.tblQuotations)
                .WithRequired(e => e.tblClient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblClient>()
                .HasMany(e => e.tblOrders)
                .WithRequired(e => e.tblClient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblClient>()
                .HasMany(e => e.tblClientAddresses)
                .WithOptional(e => e.tblClient)
                .WillCascadeOnDelete();

            modelBuilder.Entity<tblClient>()
                .HasMany(e => e.tblClientContacts)
                .WithOptional(e => e.tblClient)
                .WillCascadeOnDelete();

            modelBuilder.Entity<tblClient>()
                .HasMany(e => e.tblProducts)
                .WithRequired(e => e.tblClient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblClientAR>()
                .Property(e => e.FAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblClientAR>()
                .Property(e => e.FDiscount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblClientAR>()
                .Property(e => e.FDepositUSE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblClientAR>()
                .Property(e => e.FAmountAR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblClientAR>()
                .HasMany(e => e.tblClientARDetails)
                .WithRequired(e => e.tblClientAR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblClientARDetail>()
                .Property(e => e.FPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblClientARDetail>()
                .Property(e => e.FAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblClientARDetail>()
                .HasMany(e => e.tblClientARDetailSubs)
                .WithRequired(e => e.tblClientARDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblClientARDetailSub>()
                .Property(e => e.FPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblClientARDetailSub>()
                .Property(e => e.FAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblComponent>()
                .Property(e => e.FPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblComponent>()
                .Property(e => e.FStock)
                .HasPrecision(25, 6);

            modelBuilder.Entity<tblComponent>()
                .HasMany(e => e.tblComponentMoulds)
                .WithRequired(e => e.tblComponent)
                .HasForeignKey(e => e.FComponentID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblComponent>()
                .HasMany(e => e.tblComponentMoulds1)
                .WithRequired(e => e.tblComponent1)
                .HasForeignKey(e => e.FMouldID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblComponent>()
                .HasMany(e => e.tblOrderComponents)
                .WithRequired(e => e.tblComponent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblComponent>()
                .HasMany(e => e.tblProducts)
                .WithOptional(e => e.tblComponent)
                .HasForeignKey(e => e.FFrontID);

            modelBuilder.Entity<tblComponent>()
                .HasMany(e => e.tblProducts1)
                .WithOptional(e => e.tblComponent1)
                .HasForeignKey(e => e.FLenID);

            modelBuilder.Entity<tblComponent>()
                .HasMany(e => e.tblRptProductionCardComponents)
                .WithOptional(e => e.tblComponent)
                .HasForeignKey(e => e.FChildComponentID);

            modelBuilder.Entity<tblComponent>()
                .HasMany(e => e.tblRptProductionComponents)
                .WithRequired(e => e.tblComponent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblComponent>()
                .HasMany(e => e.tblRptProductionCardComponents1)
                .WithOptional(e => e.tblComponent1)
                .HasForeignKey(e => e.FComponentID);

            modelBuilder.Entity<tblComponent>()
                .HasMany(e => e.tblRptProductionCardMoulds)
                .WithRequired(e => e.tblComponent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblComponent>()
                .HasMany(e => e.tblComponentSelfSealingBags)
                .WithRequired(e => e.tblComponent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblComponent>()
                .HasMany(e => e.tblComponentTrims)
                .WithOptional(e => e.tblComponent)
                .WillCascadeOnDelete();

            modelBuilder.Entity<tblComponent>()
                .HasMany(e => e.tblComponentTrimRaws)
                .WithOptional(e => e.tblComponent)
                .WillCascadeOnDelete();

            modelBuilder.Entity<tblComponent>()
                .HasMany(e => e.tblMillXDs)
                .WithRequired(e => e.tblComponent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblComponent>()
                .HasMany(e => e.tblPackingBackCards)
                .WithRequired(e => e.tblComponent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblComponent>()
                .HasMany(e => e.tblComponentBags)
                .WithRequired(e => e.tblComponent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblComponent>()
                .HasMany(e => e.tblComponentCartons)
                .WithOptional(e => e.tblComponent)
                .WillCascadeOnDelete();

            modelBuilder.Entity<tblComponent>()
                .HasMany(e => e.tblComponentDMSTs)
                .WithRequired(e => e.tblComponent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblComponent>()
                .HasMany(e => e.tblComponentLenRaws)
                .WithOptional(e => e.tblComponent)
                .WillCascadeOnDelete();

            modelBuilder.Entity<tblComponent>()
                .HasMany(e => e.tblComponentMillWQDs)
                .WithRequired(e => e.tblComponent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblComponent>()
                .HasMany(e => e.tblComponentPins)
                .WithRequired(e => e.tblComponent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblComponent>()
                .HasMany(e => e.tblComponentSubs)
                .WithRequired(e => e.tblComponent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblComponent>()
                .HasMany(e => e.tblComponentTTs)
                .WithRequired(e => e.tblComponent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblComponent>()
                .HasMany(e => e.tblProducts2)
                .WithRequired(e => e.tblComponent2)
                .HasForeignKey(e => e.FComponentID);

            modelBuilder.Entity<tblComponentBag>()
                .Property(e => e.FLength)
                .HasPrecision(4, 1);

            modelBuilder.Entity<tblComponentBag>()
                .Property(e => e.FWidth)
                .HasPrecision(4, 1);

            modelBuilder.Entity<tblComponentBOM>()
                .Property(e => e.FQty)
                .HasPrecision(7, 6);

            modelBuilder.Entity<tblComponentBox>()
                .Property(e => e.FLength)
                .HasPrecision(3, 1);

            modelBuilder.Entity<tblComponentBox>()
                .Property(e => e.FWidth)
                .HasPrecision(3, 1);

            modelBuilder.Entity<tblComponentBox>()
                .Property(e => e.FHeight)
                .HasPrecision(3, 1);

            modelBuilder.Entity<tblComponentCarton>()
                .Property(e => e.FLength)
                .HasPrecision(3, 1);

            modelBuilder.Entity<tblComponentCarton>()
                .Property(e => e.FWidth)
                .HasPrecision(3, 1);

            modelBuilder.Entity<tblComponentCarton>()
                .Property(e => e.FHeight)
                .HasPrecision(3, 1);

            modelBuilder.Entity<tblComponentCore>()
                .Property(e => e.FHingeWidth)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentCore>()
                .Property(e => e.FHingeWidthTotal)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentCore>()
                .Property(e => e.FCoreDiameter)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentCore>()
                .Property(e => e.FBottomWidth)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentCoreSP>()
                .Property(e => e.FHingeWidth)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentCoreSP>()
                .Property(e => e.FBoxWidth)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentCoreSP>()
                .Property(e => e.FCoreDiameter)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentCoreSP>()
                .Property(e => e.FBottomWidth)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentCoreSub>()
                .Property(e => e.FLengthCore)
                .HasPrecision(4, 1);

            modelBuilder.Entity<tblComponentCoreSub>()
                .Property(e => e.FLength)
                .HasPrecision(4, 1);

            modelBuilder.Entity<tblComponentCoreSub>()
                .Property(e => e.FLengthCut)
                .HasPrecision(2, 1);

            modelBuilder.Entity<tblComponentDMST>()
                .Property(e => e.FHeadDiameter)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentDMST>()
                .Property(e => e.FPinDiameter)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentDMST>()
                .Property(e => e.FThreadDiameter)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentDMST>()
                .Property(e => e.FLength)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentDWD>()
                .Property(e => e.FLength)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentDWD>()
                .Property(e => e.FDiameter)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentHinge>()
                .Property(e => e.FPadWidth)
                .HasPrecision(2, 1);

            modelBuilder.Entity<tblComponentHinge>()
                .Property(e => e.FPadLength)
                .HasPrecision(2, 1);

            modelBuilder.Entity<tblComponentHinge>()
                .Property(e => e.FHingeWidth)
                .HasPrecision(2, 1);

            modelBuilder.Entity<tblComponentHinge>()
                .Property(e => e.FCoreHeight)
                .HasPrecision(2, 1);

            modelBuilder.Entity<tblComponentHingeF>()
                .Property(e => e.FPadWidth)
                .HasPrecision(2, 1);

            modelBuilder.Entity<tblComponentHingeF>()
                .Property(e => e.FPadLength)
                .HasPrecision(2, 1);

            modelBuilder.Entity<tblComponentHingeF>()
                .Property(e => e.FHingeWidth)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentHingeF>()
                .Property(e => e.FHeight)
                .HasPrecision(2, 1);

            modelBuilder.Entity<tblComponentHingeF>()
                .Property(e => e.FHoleDiameter)
                .HasPrecision(2, 1);

            modelBuilder.Entity<tblComponentJB>()
                .Property(e => e.FWidthMax)
                .HasPrecision(4, 2);

            modelBuilder.Entity<tblComponentJB>()
                .Property(e => e.FThickMax)
                .HasPrecision(4, 2);

            modelBuilder.Entity<tblComponentJB>()
                .Property(e => e.FTailWidth)
                .HasPrecision(4, 2);

            modelBuilder.Entity<tblComponentJB>()
                .Property(e => e.FHingeWidth)
                .HasPrecision(4, 2);

            modelBuilder.Entity<tblComponentJBSub>()
                .Property(e => e.FLengthCore)
                .HasPrecision(4, 1);

            modelBuilder.Entity<tblComponentJBSub>()
                .Property(e => e.FLength)
                .HasPrecision(4, 1);

            modelBuilder.Entity<tblComponentLen>()
                .Property(e => e.FThick)
                .HasPrecision(2, 1);

            modelBuilder.Entity<tblComponentLen>()
                .Property(e => e.FASize)
                .HasPrecision(3, 1);

            modelBuilder.Entity<tblComponentLen>()
                .Property(e => e.FBSize)
                .HasPrecision(3, 1);

            modelBuilder.Entity<tblComponentLen>()
                .Property(e => e.FCSize)
                .HasPrecision(4, 1);

            modelBuilder.Entity<tblComponentLen>()
                .Property(e => e.FEDSize)
                .HasPrecision(3, 1);

            modelBuilder.Entity<tblComponentLen>()
                .Property(e => e.FPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblComponentLenRaw>()
                .Property(e => e.FRefractive)
                .HasPrecision(4, 3);

            modelBuilder.Entity<tblComponentLenRawSub>()
                .Property(e => e.FThick)
                .HasPrecision(2, 1);

            modelBuilder.Entity<tblComponentMillWQD>()
                .Property(e => e.FBellyLength)
                .HasPrecision(3, 1);

            modelBuilder.Entity<tblComponentMillWQD>()
                .Property(e => e.FBellyDiameter)
                .HasPrecision(4, 2);

            modelBuilder.Entity<tblComponentPin>()
                .Property(e => e.FHeadThick)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentPin>()
                .Property(e => e.FThreadDiameter)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentPin>()
                .Property(e => e.FTotalLength)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentPlate>()
                .Property(e => e.FLength)
                .HasPrecision(4, 2);

            modelBuilder.Entity<tblComponentPlate>()
                .Property(e => e.FWidth)
                .HasPrecision(4, 2);

            modelBuilder.Entity<tblComponentPlate>()
                .Property(e => e.FThick)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentPPN>()
                .Property(e => e.FHeadDiameter)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentPPN>()
                .Property(e => e.FThreadDiameter)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentPPN>()
                .Property(e => e.FTotalLength)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentPPN>()
                .Property(e => e.FHeadThick)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentScrew>()
                .Property(e => e.FDiameterCup)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentScrew>()
                .Property(e => e.FDiameterThread)
                .HasPrecision(2, 1);

            modelBuilder.Entity<tblComponentScrew>()
                .Property(e => e.FLength)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentScrewSub>()
                .Property(e => e.FThickCup)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentSelfSealingBag>()
                .Property(e => e.FLength)
                .HasPrecision(3, 1);

            modelBuilder.Entity<tblComponentSelfSealingBag>()
                .Property(e => e.FLengthHead)
                .HasPrecision(2, 1);

            modelBuilder.Entity<tblComponentSelfSealingBag>()
                .Property(e => e.FWidth)
                .HasPrecision(3, 1);

            modelBuilder.Entity<tblComponentSpringBox>()
                .Property(e => e.FLength)
                .HasPrecision(4, 2);

            modelBuilder.Entity<tblComponentSpringBox>()
                .Property(e => e.FWidth)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentSpringBox>()
                .Property(e => e.FHeight)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentSTN>()
                .Property(e => e.FLength)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentSTN>()
                .Property(e => e.FDiameterEX)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentSTN>()
                .Property(e => e.FDiameterIN)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentSub>()
                .Property(e => e.FPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblComponentSub>()
                .Property(e => e.FStock)
                .HasPrecision(19, 6);

            modelBuilder.Entity<tblComponentSub>()
                .HasMany(e => e.tblComponentBOMs)
                .WithRequired(e => e.tblComponentSub)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblComponentSub>()
                .HasMany(e => e.tblComponentJBSubs)
                .WithOptional(e => e.tblComponentSub)
                .WillCascadeOnDelete();

            modelBuilder.Entity<tblComponentSub>()
                .HasMany(e => e.tblComponentSubBOMs)
                .WithRequired(e => e.tblComponentSub)
                .HasForeignKey(e => e.FMainID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblComponentSub>()
                .HasMany(e => e.tblComponentSubBOMs1)
                .WithRequired(e => e.tblComponentSub1)
                .HasForeignKey(e => e.FChildID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblComponentSub>()
                .HasMany(e => e.tblComponentSubLRs)
                .WithRequired(e => e.tblComponentSub)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblComponentSubBOM>()
                .Property(e => e.FQty)
                .HasPrecision(7, 6);

            modelBuilder.Entity<tblComponentTrim>()
                .Property(e => e.FThick)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentTrimRaw>()
                .Property(e => e.FThick)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentTT>()
                .Property(e => e.FDiameterOuter)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentTT>()
                .Property(e => e.FDiameterInside)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentTT>()
                .Property(e => e.FLength)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentYZ>()
                .Property(e => e.FDiameter)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblComponentYZ>()
                .Property(e => e.FLength)
                .HasPrecision(4, 1);

            modelBuilder.Entity<tblCurrencyType>()
                .Property(e => e.FRaleToRMB)
                .HasPrecision(7, 6);

            modelBuilder.Entity<tblCurrencyType>()
                .HasMany(e => e.tblQuotations)
                .WithRequired(e => e.tblCurrencyType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCust>()
                .HasMany(e => e.tblPrintingInfoes)
                .WithRequired(e => e.tblCust)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCust>()
                .HasMany(e => e.tblCustQualities)
                .WithRequired(e => e.tblCust)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCustPrintingInfo>()
                .HasMany(e => e.tblPrintingInfoes)
                .WithRequired(e => e.tblCustPrintingInfo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCustPrintingInfo>()
                .HasMany(e => e.tblCustPrintingInfoSubs)
                .WithRequired(e => e.tblCustPrintingInfo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblDepartment>()
                .HasMany(e => e.tblSections)
                .WithRequired(e => e.tblDepartment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblDesignFront>()
                .Property(e => e.FSizeA)
                .HasPrecision(3, 1);

            modelBuilder.Entity<tblDesignFront>()
                .Property(e => e.FSizeB)
                .HasPrecision(4, 2);

            modelBuilder.Entity<tblDesignFront>()
                .Property(e => e.FSizeC)
                .HasPrecision(5, 2);

            modelBuilder.Entity<tblDesignFront>()
                .Property(e => e.FSizeDBL)
                .HasPrecision(3, 1);

            modelBuilder.Entity<tblDesignFront>()
                .Property(e => e.FSizeED)
                .HasPrecision(4, 2);

            modelBuilder.Entity<tblDesignFront>()
                .Property(e => e.FBase)
                .HasPrecision(2, 1);

            modelBuilder.Entity<tblDesignFront>()
                .Property(e => e.FLength)
                .HasPrecision(4, 1);

            modelBuilder.Entity<tblDesignFront>()
                .Property(e => e.FLengthMargin)
                .HasPrecision(3, 1);

            modelBuilder.Entity<tblDesignFront>()
                .Property(e => e.FWidth)
                .HasPrecision(3, 1);

            modelBuilder.Entity<tblDesignFront>()
                .Property(e => e.FWidthMargin)
                .HasPrecision(2, 1);

            modelBuilder.Entity<tblDesignFront>()
                .Property(e => e.FCutThick)
                .HasPrecision(2, 1);

            modelBuilder.Entity<tblEmployee>()
                .Property(e => e.FSalary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblEmployee>()
                .Property(e => e.FIdentity)
                .IsFixedLength();

            modelBuilder.Entity<tblEmployee>()
                .Property(e => e.FStatus)
                .IsFixedLength();

            modelBuilder.Entity<tblEngineerLenCategory>()
                .Property(e => e.FTransmittanceMin)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblEngineerLenCategory>()
                .Property(e => e.FTransmittanceMax)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblEntryResignRecord>()
                .Property(e => e.FStatus)
                .IsFixedLength();

            modelBuilder.Entity<tblLenColor>()
                .Property(e => e.FTransmittanceMin)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblLenColor>()
                .Property(e => e.FTransmittanceMax)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblLenColor>()
                .HasMany(e => e.tblComponentLenRaws)
                .WithRequired(e => e.tblLenColor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblMaterial>()
                .Property(e => e.FPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblMaterial>()
                .Property(e => e.FPriceNet)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblMaterial>()
                .Property(e => e.FMOQ)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tblMaterial>()
                .Property(e => e.FBatchQty)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tblMaterial>()
                .Property(e => e.FStock)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tblMaterial>()
                .Property(e => e.FStockOccupied)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tblMaterial>()
                .Property(e => e.FStockPurchased)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tblMaterial>()
                .Property(e => e.FStockWeight)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tblMaterial>()
                .Property(e => e.FStockAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblMaterial>()
                .Property(e => e.FStockPrice)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tblMaterial>()
                .HasMany(e => e.tblBOMs)
                .WithRequired(e => e.tblMaterial)
                .HasForeignKey(e => e.FChildID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblMaterial>()
                .HasMany(e => e.tblBOMs1)
                .WithRequired(e => e.tblMaterial1)
                .HasForeignKey(e => e.FMainID);

            modelBuilder.Entity<tblMaterial>()
                .HasMany(e => e.tblComponentFrontSubs)
                .WithRequired(e => e.tblMaterial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblMaterial>()
                .HasMany(e => e.tblMaterialWorkShops)
                .WithRequired(e => e.tblMaterial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblMaterial>()
                .HasMany(e => e.tblOrderAnalyzes)
                .WithRequired(e => e.tblMaterial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblMaterial>()
                .HasMany(e => e.tblOrderMoulds)
                .WithRequired(e => e.tblMaterial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblMaterial>()
                .HasMany(e => e.tblOrderPrintingMoulds)
                .WithRequired(e => e.tblMaterial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblMaterial>()
                .HasMany(e => e.tblOrderSubBOMPackings)
                .WithRequired(e => e.tblMaterial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblMaterial>()
                .HasMany(e => e.tblPackingTemplateSubs)
                .WithRequired(e => e.tblMaterial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblMaterial>()
                .HasMany(e => e.tblPDTWHInTemps)
                .WithRequired(e => e.tblMaterial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblMaterial>()
                .HasMany(e => e.tblPDTWHIns)
                .WithRequired(e => e.tblMaterial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblMaterial>()
                .HasMany(e => e.tblPDTWHTemps)
                .WithRequired(e => e.tblMaterial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblMaterial>()
                .HasMany(e => e.tblProcurementTemps)
                .WithRequired(e => e.tblMaterial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblMaterial>()
                .HasMany(e => e.tblMWHIns)
                .WithRequired(e => e.tblMaterial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblMaterial>()
                .HasMany(e => e.tblMWHInPs)
                .WithRequired(e => e.tblMaterial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblMaterial>()
                .HasMany(e => e.tblMWHOuts)
                .WithRequired(e => e.tblMaterial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblMaterial>()
                .HasMany(e => e.tblOrderSubBOMs)
                .WithRequired(e => e.tblMaterial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblMaterial>()
                .HasMany(e => e.tblProcurementSubBOMs)
                .WithRequired(e => e.tblMaterial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblMaterial>()
                .HasMany(e => e.tblProcurementSubs)
                .WithRequired(e => e.tblMaterial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblMaterial>()
                .HasMany(e => e.tblPDTWHs)
                .WithRequired(e => e.tblMaterial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblMaterial>()
                .HasMany(e => e.tblOrderSubs)
                .WithRequired(e => e.tblMaterial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblMaterialType>()
                .HasMany(e => e.tblComponentPins)
                .WithRequired(e => e.tblMaterialType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblMaterialType>()
                .HasMany(e => e.tblMillNQYKs)
                .WithRequired(e => e.tblMaterialType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblMaterialType>()
                .HasMany(e => e.tblMillXDs)
                .WithRequired(e => e.tblMaterialType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblMaterialWorkShop>()
                .Property(e => e.FStock)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tblMillNQY>()
                .Property(e => e.FShankDiameter)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblMillNQY>()
                .Property(e => e.FGrooveWidth)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblMillNQY>()
                .Property(e => e.FGrooveDepth)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblMillNQY>()
                .Property(e => e.FNoseHeight)
                .HasPrecision(3, 1);

            modelBuilder.Entity<tblMillNQY>()
                .Property(e => e.FGrooveRadius)
                .HasPrecision(3, 1);

            modelBuilder.Entity<tblMillNQYK>()
                .Property(e => e.FShankDiameter)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblMillNQYK>()
                .Property(e => e.FGrooveWidth)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblMillNQYK>()
                .Property(e => e.FGrooveDepth)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblMillNQYK>()
                .Property(e => e.FNoseHeight)
                .HasPrecision(3, 1);

            modelBuilder.Entity<tblMillNQYK>()
                .Property(e => e.FGrooveRadius)
                .HasPrecision(3, 1);

            modelBuilder.Entity<tblMillNQYK>()
                .Property(e => e.FHoleDiameter)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblMillTTD>()
                .Property(e => e.FShankDiameter)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblMillTTD>()
                .Property(e => e.FGrooveWidth)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblMillTTD>()
                .Property(e => e.FGrooveDepth)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblMillTTD>()
                .Property(e => e.FGrooveRadius)
                .HasPrecision(3, 1);

            modelBuilder.Entity<tblMillXD>()
                .Property(e => e.FEdgeDiameter)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblMillXD>()
                .Property(e => e.FEdgeLength)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblMillXD>()
                .Property(e => e.FShankDiameter)
                .HasPrecision(3, 2);

            modelBuilder.Entity<tblMillXD>()
                .Property(e => e.FTotalLength)
                .HasPrecision(4, 2);

            modelBuilder.Entity<tblMouldTemplePunch>()
                .Property(e => e.FWidthTop)
                .HasPrecision(3, 1);

            modelBuilder.Entity<tblMouldTemplePunch>()
                .Property(e => e.FWidthMid)
                .HasPrecision(3, 1);

            modelBuilder.Entity<tblMouldTemplePunch>()
                .Property(e => e.FWidthTip)
                .HasPrecision(3, 1);

            modelBuilder.Entity<tblMouldTemplePunch>()
                .Property(e => e.FCutWidth)
                .HasPrecision(3, 1);

            modelBuilder.Entity<tblMWHIn>()
                .Property(e => e.FPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblMWHIn>()
                .Property(e => e.FQty)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tblMWHIn>()
                .Property(e => e.FWeight)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tblMWHIn>()
                .Property(e => e.FAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblMWHInBill>()
                .Property(e => e.FPmtTerm)
                .IsFixedLength();

            modelBuilder.Entity<tblMWHInBill>()
                .Property(e => e.FAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblMWHInBillType>()
                .HasMany(e => e.tblMWHInBills)
                .WithRequired(e => e.tblMWHInBillType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblMWHInBillType>()
                .HasMany(e => e.tblMWHInPBills)
                .WithRequired(e => e.tblMWHInBillType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblMWHIni>()
                .Property(e => e.FPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblMWHIni>()
                .Property(e => e.FQty)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tblMWHIni>()
                .Property(e => e.FWeight)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tblMWHIni>()
                .Property(e => e.FAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblMWHInP>()
                .Property(e => e.FPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblMWHInP>()
                .Property(e => e.FQty)
                .HasPrecision(10, 3);

            modelBuilder.Entity<tblMWHInP>()
                .Property(e => e.FWeight)
                .HasPrecision(10, 3);

            modelBuilder.Entity<tblMWHInP>()
                .Property(e => e.FAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblMWHInPBill>()
                .Property(e => e.FAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblMWHInPTemp>()
                .Property(e => e.FQty)
                .HasPrecision(10, 3);

            modelBuilder.Entity<tblMWHInPTemp>()
                .Property(e => e.FWeight)
                .HasPrecision(10, 3);

            modelBuilder.Entity<tblMWHInPTemp>()
                .Property(e => e.FPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblMWHInPTemp>()
                .Property(e => e.FAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblMWHInTemp>()
                .Property(e => e.FQty)
                .HasPrecision(10, 3);

            modelBuilder.Entity<tblMWHInTemp>()
                .Property(e => e.FWeight)
                .HasPrecision(10, 3);

            modelBuilder.Entity<tblMWHInTemp>()
                .Property(e => e.FPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblMWHInTemp>()
                .Property(e => e.FAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblMWHOut>()
                .Property(e => e.FPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblMWHOut>()
                .Property(e => e.FQty)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tblMWHOut>()
                .Property(e => e.FWeight)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tblMWHOut>()
                .Property(e => e.FAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblMWHOutBill>()
                .Property(e => e.FBillType)
                .IsFixedLength();

            modelBuilder.Entity<tblMWHOutBill>()
                .Property(e => e.FAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblMWHOutTemp>()
                .Property(e => e.FQty)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tblMWHOutTemp>()
                .Property(e => e.FWeight)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tblMWHOutTemp>()
                .Property(e => e.FPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblMWHOutTemp>()
                .Property(e => e.FAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblOrder>()
                .Property(e => e.FShipAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblOrder>()
                .Property(e => e.FCostAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblOrder>()
                .Property(e => e.FAmountBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblOrder>()
                .HasMany(e => e.tblOrderAnalyzes)
                .WithRequired(e => e.tblOrder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblOrder>()
                .HasMany(e => e.tblOrderMoulds)
                .WithRequired(e => e.tblOrder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblOrder>()
                .HasMany(e => e.tblOrderShipBatches)
                .WithRequired(e => e.tblOrder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblOrder>()
                .HasMany(e => e.tblOrderSubBOMPackings)
                .WithRequired(e => e.tblOrder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblOrder>()
                .HasMany(e => e.tblPrintingInfoes)
                .WithRequired(e => e.tblOrder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblOrder>()
                .HasMany(e => e.tblProcurementChooses)
                .WithOptional(e => e.tblOrder)
                .WillCascadeOnDelete();

            modelBuilder.Entity<tblOrder>()
                .HasMany(e => e.tblProformaInvoices)
                .WithOptional(e => e.tblOrder)
                .WillCascadeOnDelete();

            modelBuilder.Entity<tblOrderAnalyze>()
                .Property(e => e.FPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblOrderAnalyze>()
                .Property(e => e.FQty)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tblOrderAnalyze>()
                .Property(e => e.FWeight)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tblOrderAnalyze>()
                .Property(e => e.FAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblOrderPrintingInfo>()
                .HasMany(e => e.tblOrderPrintingInfoSpls)
                .WithRequired(e => e.tblOrderPrintingInfo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblOrderProcessBOM>()
                .HasMany(e => e.tblOrderProcessBOM1)
                .WithOptional(e => e.tblOrderProcessBOM2)
                .HasForeignKey(e => e.FOrderProcessBOMIDPrev);

            modelBuilder.Entity<tblOrderShipBatch>()
                .HasMany(e => e.tblOrderShipBatchSubs)
                .WithRequired(e => e.tblOrderShipBatch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblOrderSub>()
                .Property(e => e.FPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblOrderSub>()
                .Property(e => e.FAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblOrderSub>()
                .Property(e => e.FMaterialAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblOrderSub>()
                .HasMany(e => e.tblOrderShipBatchSubs)
                .WithRequired(e => e.tblOrderSub)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblOrderSub>()
                .HasMany(e => e.tblProductionPlans)
                .WithRequired(e => e.tblOrderSub)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblOrderSub>()
                .HasMany(e => e.tblOrderSubBOMs)
                .WithRequired(e => e.tblOrderSub)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblOrderSub>()
                .HasMany(e => e.tblProductions)
                .WithRequired(e => e.tblOrderSub)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblOrderSubBOM>()
                .Property(e => e.FQty)
                .HasPrecision(8, 3);

            modelBuilder.Entity<tblOrderSubBOM>()
                .Property(e => e.FStockUSE)
                .HasPrecision(8, 3);

            modelBuilder.Entity<tblOrderSubBOM>()
                .Property(e => e.FPurchaseUSE)
                .HasPrecision(8, 3);

            modelBuilder.Entity<tblOrderSubBOM>()
                .Property(e => e.FQtyUsed)
                .HasPrecision(8, 3);

            modelBuilder.Entity<tblOrderSubBOM>()
                .Property(e => e.FQtyArrive)
                .HasPrecision(8, 3);

            modelBuilder.Entity<tblOrderSubBOM>()
                .Property(e => e.FMaterialAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblOrderSubBOM>()
                .Property(e => e.FQtySpend)
                .HasPrecision(8, 3);

            modelBuilder.Entity<tblOrderSubBOM>()
                .Property(e => e.FQtyScrap)
                .HasPrecision(8, 3);

            modelBuilder.Entity<tblOrderSubBOM>()
                .Property(e => e.FQtyBalance)
                .HasPrecision(10, 3);

            modelBuilder.Entity<tblOrderSubBOMPacking>()
                .Property(e => e.FQty)
                .HasPrecision(10, 3);

            modelBuilder.Entity<tblOrderSubBOMPacking>()
                .Property(e => e.FStockUSE)
                .HasPrecision(10, 3);

            modelBuilder.Entity<tblOrderSubBOMPacking>()
                .Property(e => e.FPurchaseUSE)
                .HasPrecision(10, 3);

            modelBuilder.Entity<tblOrderSubBOMPacking>()
                .Property(e => e.FQtyArrive)
                .HasPrecision(10, 3);

            modelBuilder.Entity<tblOrderSubBOMPacking>()
                .Property(e => e.FQtyUSE)
                .HasPrecision(10, 3);

            modelBuilder.Entity<tblPackingBackCard>()
                .Property(e => e.FLength)
                .HasPrecision(4, 1);

            modelBuilder.Entity<tblPackingTemplate>()
                .HasMany(e => e.tblPackingTemplateSubs)
                .WithRequired(e => e.tblPackingTemplate)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblPackingTemplateSub>()
                .Property(e => e.FQtyPer)
                .HasPrecision(10, 3);

            modelBuilder.Entity<tblPackingTemplateSub>()
                .HasMany(e => e.tblPackingTemplateSub1)
                .WithOptional(e => e.tblPackingTemplateSub2)
                .HasForeignKey(e => e.FPackingTempalteSubIDLink);

            modelBuilder.Entity<tblPara_GetFile>()
                .HasMany(e => e.tblCat3)
                .WithOptional(e => e.tblPara_GetFile)
                .HasForeignKey(e => e.FDWGParaID);

            modelBuilder.Entity<tblPara_GetFile>()
                .HasMany(e => e.tblCat31)
                .WithOptional(e => e.tblPara_GetFile1)
                .HasForeignKey(e => e.FFileParaID);

            modelBuilder.Entity<tblPara_GetFile>()
                .HasMany(e => e.tblCat32)
                .WithOptional(e => e.tblPara_GetFile2)
                .HasForeignKey(e => e.FPicParaID);

            modelBuilder.Entity<tblPartsTemple>()
                .Property(e => e.FLength)
                .HasPrecision(4, 1);

            modelBuilder.Entity<tblPartsTemple>()
                .Property(e => e.FThick)
                .HasPrecision(2, 1);

            modelBuilder.Entity<tblPartsTemple>()
                .HasMany(e => e.tblPartsTempleSubs)
                .WithRequired(e => e.tblPartsTemple)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblPartsTempleSub>()
                .Property(e => e.FQtyPerT)
                .HasPrecision(4, 1);

            modelBuilder.Entity<tblPartsTempleSub>()
                .Property(e => e.FAcetateQtyT)
                .HasPrecision(5, 1);

            modelBuilder.Entity<tblPaymentTerm>()
                .Property(e => e.FTimeUnit_CN)
                .IsFixedLength();

            modelBuilder.Entity<tblPaymentTerm>()
                .HasMany(e => e.tblClientARs)
                .WithRequired(e => e.tblPaymentTerm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblPDTWH>()
                .Property(e => e.FPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblPDTWH>()
                .Property(e => e.FAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblPDTWH>()
                .HasMany(e => e.tblClientARDetailSubs)
                .WithRequired(e => e.tblPDTWH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblPDTWHBill>()
                .Property(e => e.FAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblPDTWHBill>()
                .Property(e => e.FAmountMinus)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblPDTWHBill>()
                .Property(e => e.FFreight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblPDTWHBill>()
                .Property(e => e.FAmountActual)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblPDTWHBillType>()
                .HasMany(e => e.tblPDTWHBills)
                .WithRequired(e => e.tblPDTWHBillType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblPDTWHFreight>()
                .Property(e => e.FAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblPDTWHIn>()
                .Property(e => e.FPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblPDTWHIn>()
                .Property(e => e.FAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblPDTWHInBill>()
                .Property(e => e.FAMount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblPDTWHInTemp>()
                .Property(e => e.FPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblPDTWHInTemp>()
                .Property(e => e.FAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblPDTWHTemp>()
                .Property(e => e.FPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblPDTWHTemp>()
                .Property(e => e.FAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblPDTWHTempFreight>()
                .Property(e => e.FAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblPlateColor>()
                .Property(e => e.FPlateColorNum)
                .IsFixedLength();

            modelBuilder.Entity<tblPlateColor>()
                .HasMany(e => e.tblComponentMetalFrontSubs)
                .WithRequired(e => e.tblPlateColor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblPlateColor>()
                .HasMany(e => e.tblComponentMetalStickerSubs)
                .WithRequired(e => e.tblPlateColor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblPlateColor>()
                .HasMany(e => e.tblComponentPlateSubs)
                .WithRequired(e => e.tblPlateColor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblPlateColor>()
                .HasMany(e => e.tblComponentTrimSubs)
                .WithRequired(e => e.tblPlateColor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblPlateColor>()
                .HasMany(e => e.tblProcessPlates)
                .WithRequired(e => e.tblPlateColor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblPrintingPart>()
                .HasMany(e => e.tblCustPrintingInfoSubs)
                .WithRequired(e => e.tblPrintingPart)
                .HasForeignKey(e => e.FPrintPartID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblPrintingPart>()
                .HasMany(e => e.tblOrderPrintingInfoes)
                .WithRequired(e => e.tblPrintingPart)
                .HasForeignKey(e => e.FPrintPartID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblProcess>()
                .HasMany(e => e.tblOrderProcessBOMs)
                .WithRequired(e => e.tblProcess)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblProcess>()
                .HasMany(e => e.tblProductionSampleSubSubs)
                .WithRequired(e => e.tblProcess)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblProcess>()
                .HasMany(e => e.tblProductionMonths)
                .WithRequired(e => e.tblProcess)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblProcess>()
                .HasMany(e => e.tblProductionPlans)
                .WithRequired(e => e.tblProcess)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblProcess>()
                .HasMany(e => e.tblRptProductionMaterials)
                .WithRequired(e => e.tblProcess)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblProcess>()
                .HasMany(e => e.tblRptProductionCardMaterials)
                .WithRequired(e => e.tblProcess)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblProcess>()
                .HasMany(e => e.tblProcessTemplateSubs)
                .WithRequired(e => e.tblProcess)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblProcess>()
                .HasMany(e => e.tblProcessBOMs)
                .WithRequired(e => e.tblProcess)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblProcess>()
                .HasMany(e => e.tblProcessBomSubs)
                .WithRequired(e => e.tblProcess)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblProcess>()
                .HasMany(e => e.tblProcessSubs)
                .WithRequired(e => e.tblProcess)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblProcess>()
                .HasMany(e => e.tblProductions)
                .WithRequired(e => e.tblProcess)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblProcessBOM>()
                .HasMany(e => e.tblProcessBOM1)
                .WithOptional(e => e.tblProcessBOM2)
                .HasForeignKey(e => e.FProcessBOMIDPrev);

            modelBuilder.Entity<tblProcessBomSub>()
                .HasMany(e => e.tblOrderProcessBOMs)
                .WithRequired(e => e.tblProcessBomSub)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblProcessBomSub>()
                .HasMany(e => e.tblProcessBomSub1)
                .WithOptional(e => e.tblProcessBomSub2)
                .HasForeignKey(e => e.FProcessBomSubIDPrev);

            modelBuilder.Entity<tblProcessPlate>()
                .Property(e => e.FTech)
                .IsFixedLength();

            modelBuilder.Entity<tblProcessSub>()
                .Property(e => e.FPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblProcessSub>()
                .HasMany(e => e.tblProcessPlates)
                .WithRequired(e => e.tblProcessSub)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblProcessTemplateSub>()
                .HasMany(e => e.tblProcessTemplateSub1)
                .WithOptional(e => e.tblProcessTemplateSub2)
                .HasForeignKey(e => e.FProcessTemplateSubIDPrev);

            modelBuilder.Entity<tblProcurement>()
                .HasMany(e => e.tblProcurementSubs)
                .WithRequired(e => e.tblProcurement)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblProcurementChoose>()
                .Property(e => e.FQty)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tblProcurementChoose>()
                .Property(e => e.FPurchaseUSE)
                .HasPrecision(7, 1);

            modelBuilder.Entity<tblProcurementChoose>()
                .Property(e => e.FStockUSE)
                .HasPrecision(7, 1);

            modelBuilder.Entity<tblProcurementSub>()
                .Property(e => e.FStock)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tblProcurementSub>()
                .Property(e => e.FQtyRequire)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tblProcurementSub>()
                .Property(e => e.FQty)
                .HasPrecision(10, 3);

            modelBuilder.Entity<tblProcurementSub>()
                .Property(e => e.FMWHInPQty)
                .HasPrecision(10, 3);

            modelBuilder.Entity<tblProcurementSub>()
                .Property(e => e.FPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblProcurementSub>()
                .HasMany(e => e.tblMWHInPTemps)
                .WithOptional(e => e.tblProcurementSub)
                .WillCascadeOnDelete();

            modelBuilder.Entity<tblProcurementSub>()
                .HasMany(e => e.tblProcurementSubBOMs)
                .WithRequired(e => e.tblProcurementSub)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblProcurementTemp>()
                .Property(e => e.FQtyRequire)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tblProcurementTemp>()
                .Property(e => e.FQty)
                .HasPrecision(10, 3);

            modelBuilder.Entity<tblProcurementTemp>()
                .Property(e => e.FStockUse)
                .HasPrecision(8, 3);

            modelBuilder.Entity<tblProduct>()
                .HasMany(e => e.tblProductSKUs)
                .WithRequired(e => e.tblProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblProductionMonth>()
                .Property(e => e.FMonth)
                .IsFixedLength();

            modelBuilder.Entity<tblProductionPlanHeader>()
                .HasMany(e => e.tblProductionPlans)
                .WithRequired(e => e.tblProductionPlanHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblProductionSample>()
                .HasMany(e => e.tblProductionSampleSubs)
                .WithRequired(e => e.tblProductionSample)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblProductionSampleSub>()
                .HasMany(e => e.tblProductionSampleSubSubs)
                .WithOptional(e => e.tblProductionSampleSub)
                .WillCascadeOnDelete();

            modelBuilder.Entity<tblProductSKU>()
                .Property(e => e.FPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblProductStyle>()
                .HasMany(e => e.tblProductSampleBoxes)
                .WithRequired(e => e.tblProductStyle)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblQuotationBase>()
                .Property(e => e.FPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblQuotationBOM>()
                .Property(e => e.FQty)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tblQuotationBOM>()
                .Property(e => e.FWeight)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tblQuotationBOM>()
                .Property(e => e.FPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblQuotationList>()
                .Property(e => e.FMaterialCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblQuotationList>()
                .Property(e => e.FMaterialCostVAT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblQuotationList>()
                .Property(e => e.FProcessCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblQuotationList>()
                .Property(e => e.FOverHeadCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblQuotationList>()
                .Property(e => e.FMargin)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblQuotationList>()
                .Property(e => e.FPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblQuotationList>()
                .Property(e => e.FPriceConfirm)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblQuotationList>()
                .Property(e => e.FCostSum)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblQuotationList>()
                .Property(e => e.FPriceRef)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblQuotationList>()
                .Property(e => e.FTax)
                .HasPrecision(33, 11);

            modelBuilder.Entity<tblQuotationList>()
                .Property(e => e.FPriceVATRef)
                .HasPrecision(34, 11);

            modelBuilder.Entity<tblQuotationList>()
                .HasMany(e => e.tblQuotationBOMs)
                .WithOptional(e => e.tblQuotationList)
                .WillCascadeOnDelete();

            modelBuilder.Entity<tblQuotationList>()
                .HasMany(e => e.tblQuotationProcesses)
                .WithOptional(e => e.tblQuotationList)
                .WillCascadeOnDelete();

            modelBuilder.Entity<tblQuotationProcess>()
                .Property(e => e.FPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblRptProductionCardMaterial>()
                .Property(e => e.FQty)
                .HasPrecision(9, 2);

            modelBuilder.Entity<tblRptProductionMaterial>()
                .Property(e => e.FQty)
                .HasPrecision(9, 2);

            modelBuilder.Entity<tblSalary>()
                .Property(e => e.FSalaryBase)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblSalary>()
                .Property(e => e.FSalary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblSalary>()
                .Property(e => e.FBorrow)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblSalary>()
                .Property(e => e.FFine)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblSalary>()
                .Property(e => e.FInsurance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblSalarySum>()
                .Property(e => e.FSalarySum)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblSalarySum>()
                .HasMany(e => e.tblSalaries)
                .WithOptional(e => e.tblSalarySum)
                .WillCascadeOnDelete();

            modelBuilder.Entity<tblScrappage>()
                .Property(e => e.FScrappage)
                .HasPrecision(5, 3);

            modelBuilder.Entity<tblScrappage>()
                .Property(e => e.FScrappageQuote)
                .HasPrecision(5, 3);

            modelBuilder.Entity<tblScrappage>()
                .Property(e => e.FScrappageMetal)
                .HasPrecision(5, 3);

            modelBuilder.Entity<tblSection>()
                .HasMany(e => e.tblEmployees)
                .WithRequired(e => e.tblSection)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSection>()
                .HasMany(e => e.tblMWHOutBills)
                .WithRequired(e => e.tblSection)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSection>()
                .HasMany(e => e.tblOrderProcessBOMs)
                .WithRequired(e => e.tblSection)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSection>()
                .HasMany(e => e.tblProcesses)
                .WithRequired(e => e.tblSection)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSection>()
                .HasMany(e => e.tblProcessBOMs)
                .WithRequired(e => e.tblSection)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSection>()
                .HasMany(e => e.tblProcessBomSubs)
                .WithRequired(e => e.tblSection)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSection>()
                .HasMany(e => e.tblRptProductionCardComponents)
                .WithRequired(e => e.tblSection)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSection>()
                .HasMany(e => e.tblRptProductionSections)
                .WithRequired(e => e.tblSection)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSection>()
                .HasMany(e => e.tblSectionCosts)
                .WithRequired(e => e.tblSection)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSectionCost>()
                .Property(e => e.FYearMonth)
                .IsFixedLength();

            modelBuilder.Entity<tblSectionCost>()
                .Property(e => e.FSectionSalary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblSectionCost>()
                .Property(e => e.FAuxiliaryCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblSectionCost>()
                .Property(e => e.FMouldCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblSupplier>()
                .Property(e => e.FVATPercent)
                .HasPrecision(5, 4);

            modelBuilder.Entity<tblSupplier>()
                .HasMany(e => e.tblBOMs)
                .WithRequired(e => e.tblSupplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSupplier>()
                .HasMany(e => e.tblClaims)
                .WithRequired(e => e.tblSupplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSupplier>()
                .HasMany(e => e.tblComponents)
                .WithRequired(e => e.tblSupplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSupplier>()
                .HasMany(e => e.tblComponentBOMs)
                .WithRequired(e => e.tblSupplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSupplier>()
                .HasMany(e => e.tblComponentSubs)
                .WithRequired(e => e.tblSupplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSupplier>()
                .HasMany(e => e.tblMaterials)
                .WithRequired(e => e.tblSupplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSupplier>()
                .HasMany(e => e.tblMWHInBills)
                .WithRequired(e => e.tblSupplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSupplier>()
                .HasMany(e => e.tblMWHInPBills)
                .WithRequired(e => e.tblSupplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSupplier>()
                .HasMany(e => e.tblOrderMoulds)
                .WithRequired(e => e.tblSupplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSupplier>()
                .HasMany(e => e.tblOrderPrintingMoulds)
                .WithRequired(e => e.tblSupplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSupplier>()
                .HasMany(e => e.tblOrderSubBOMs)
                .WithRequired(e => e.tblSupplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSupplier>()
                .HasMany(e => e.tblOrderSubBOMPackings)
                .WithRequired(e => e.tblSupplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSupplier>()
                .HasMany(e => e.tblPDTWHFreights)
                .WithRequired(e => e.tblSupplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSupplier>()
                .HasMany(e => e.tblProcessSubs)
                .WithRequired(e => e.tblSupplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSupplier>()
                .HasMany(e => e.tblProductions)
                .WithRequired(e => e.tblSupplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSysLorRCode>()
                .HasMany(e => e.tblComponents)
                .WithRequired(e => e.tblSysLorRCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSysMenu>()
                .HasMany(e => e.tblSysMenu1)
                .WithOptional(e => e.tblSysMenu2)
                .HasForeignKey(e => e.FSysMenuParentID);

            modelBuilder.Entity<tblSysRole>()
                .HasMany(e => e.tblUserRoles)
                .WithOptional(e => e.tblSysRole)
                .WillCascadeOnDelete();

            modelBuilder.Entity<tblUser>()
                .HasMany(e => e.tblUserRoles)
                .WithOptional(e => e.tblUser)
                .WillCascadeOnDelete();
        }
    }
}
