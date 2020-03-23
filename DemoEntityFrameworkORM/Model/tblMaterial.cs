namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblMaterial")]
    public partial class tblMaterial
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblMaterial()
        {
            tblAcetateSubs = new HashSet<tblAcetateSub>();
            tblBOMs = new HashSet<tblBOM>();
            tblBOMs1 = new HashSet<tblBOM>();
            tblComponentFrontSubs = new HashSet<tblComponentFrontSub>();
            tblComponentSubLRs = new HashSet<tblComponentSubLR>();
            tblMaterialWorkShops = new HashSet<tblMaterialWorkShop>();
            tblMWHInPTemps = new HashSet<tblMWHInPTemp>();
            tblMWHInTemps = new HashSet<tblMWHInTemp>();
            tblMWHOutTemps = new HashSet<tblMWHOutTemp>();
            tblOrderAnalyzes = new HashSet<tblOrderAnalyze>();
            tblOrderMoulds = new HashSet<tblOrderMould>();
            tblOrderPrintingMoulds = new HashSet<tblOrderPrintingMould>();
            tblOrderPrintingInfoSpls = new HashSet<tblOrderPrintingInfoSpl>();
            tblOrderSubBOMPackings = new HashSet<tblOrderSubBOMPacking>();
            tblPackingTemplateSubs = new HashSet<tblPackingTemplateSub>();
            tblPDTWHInTemps = new HashSet<tblPDTWHInTemp>();
            tblPDTWHIns = new HashSet<tblPDTWHIn>();
            tblPDTWHTemps = new HashSet<tblPDTWHTemp>();
            tblProcurementChooses = new HashSet<tblProcurementChoose>();
            tblProcurementTemps = new HashSet<tblProcurementTemp>();
            tblMWHIns = new HashSet<tblMWHIn>();
            tblMWHInPs = new HashSet<tblMWHInP>();
            tblMWHOuts = new HashSet<tblMWHOut>();
            tblOrderSubBOMs = new HashSet<tblOrderSubBOM>();
            tblProcessBomSubs = new HashSet<tblProcessBomSub>();
            tblProcurementSubBOMs = new HashSet<tblProcurementSubBOM>();
            tblProcurementSubs = new HashSet<tblProcurementSub>();
            tblProductSKUs = new HashSet<tblProductSKU>();
            tblQuotationBOMs = new HashSet<tblQuotationBOM>();
            tblPDTWHs = new HashSet<tblPDTWH>();
            tblPartsTempleSubs = new HashSet<tblPartsTempleSub>();
            tblOrderSubs = new HashSet<tblOrderSub>();
        }

        [Key]
        public int FMaterialID { get; set; }

        [StringLength(20)]
        public string FMaterialCode { get; set; }

        public int FCat3ID { get; set; }

        public int FSupplierID { get; set; }

        [Required]
        [StringLength(255)]
        public string FItem { get; set; }

        [Required]
        [StringLength(255)]
        public string FSpec { get; set; }

        [Required]
        [StringLength(5)]
        public string FUnit { get; set; }

        [Column(TypeName = "money")]
        public decimal FPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? FPriceNet { get; set; }

        public bool FVAT { get; set; }

        [StringLength(5)]
        public string FPosition { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FMOQ { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FBatchQty { get; set; }

        [StringLength(50)]
        public string FNote { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FModifyDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FCreateTime { get; set; }

        public bool FCancel { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FStock { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FStockOccupied { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FStockPurchased { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FStockWeight { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FStockCheckDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? FStockAmount { get; set; }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? FStockPrice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAcetateSub> tblAcetateSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBOM> tblBOMs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBOM> tblBOMs1 { get; set; }

        public virtual tblCat3 tblCat3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentFrontSub> tblComponentFrontSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentSubLR> tblComponentSubLRs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMaterialWorkShop> tblMaterialWorkShops { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMWHInPTemp> tblMWHInPTemps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMWHInTemp> tblMWHInTemps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMWHOutTemp> tblMWHOutTemps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderAnalyze> tblOrderAnalyzes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderMould> tblOrderMoulds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderPrintingMould> tblOrderPrintingMoulds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderPrintingInfoSpl> tblOrderPrintingInfoSpls { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderSubBOMPacking> tblOrderSubBOMPackings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPackingTemplateSub> tblPackingTemplateSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPDTWHInTemp> tblPDTWHInTemps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPDTWHIn> tblPDTWHIns { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPDTWHTemp> tblPDTWHTemps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProcurementChoose> tblProcurementChooses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProcurementTemp> tblProcurementTemps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMWHIn> tblMWHIns { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMWHInP> tblMWHInPs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMWHOut> tblMWHOuts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderSubBOM> tblOrderSubBOMs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProcessBomSub> tblProcessBomSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProcurementSubBOM> tblProcurementSubBOMs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProcurementSub> tblProcurementSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProductSKU> tblProductSKUs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblQuotationBOM> tblQuotationBOMs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPDTWH> tblPDTWHs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPartsTempleSub> tblPartsTempleSubs { get; set; }

        public virtual tblSupplier tblSupplier { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderSub> tblOrderSubs { get; set; }
    }
}
